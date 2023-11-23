using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using DGV2Printer;

namespace Proyecto
{
    public partial class Form11 : Form
    {

        private string connectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

        public Form11()
        {
            InitializeComponent();
            SetupDataGridView();
            InicializarPeriodosOcupados(); // Inicializa los periodos ocupados aquí
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            LoadRuts();
        }

        // Estructura para llevar un seguimiento de los periodos ocupados
        Dictionary<string, HashSet<string>> periodosOcupados = new Dictionary<string, HashSet<string>>();



        private void LoadRuts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT profesor_rut FROM Disponibilidad GROUP BY profesor_rut";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();

                comboBoxRut.Items.Clear();

                while (reader.Read())
                {
                    string rut = reader["profesor_rut"].ToString();
                    comboBoxRut.Items.Add(rut);
                }

                reader.Close();
            }
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (comboBoxRut.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un RUT.");
                return;
            }

            string selectedRut = comboBoxRut.SelectedItem.ToString();
            LlenarPeriodosOcupados(selectedRut); // Asegúrate de que esta función rellena el diccionario con todos los días que se usarán
            DistribuirMaterias(selectedRut);
        }
        private void LlenarPeriodosOcupados(string rutProfesor)
        {
            InicializarPeriodosOcupados(); // Asegúrate de que se inicializa cada vez que se llena

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"
            SELECT dias, periodo
            FROM AsignacionesHorarios
            WHERE rutProfesor = @rutProfesor";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rutProfesor", rutProfesor);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string dia = reader["dias"].ToString();
                        string periodo = reader["periodo"].ToString();

                        if (!periodosOcupados.ContainsKey(dia))
                        {
                            periodosOcupados[dia] = new HashSet<string>();
                        }
                        periodosOcupados[dia].Add(periodo);
                    }
                }
            }
        }
        //private void CargarAsignacionesPorProfesor(string rutProfesor)
        //{
        //    string query = @"
        //SELECT idAsignacion, [rutProfesor], Cursos.nombreCurso, Materias.nombreMateria, dias, [periodo], Salas.nombresalas
        //FROM AsignacionesHorarios
        //JOIN Cursos ON AsignacionesHorarios.idCurso = Cursos.idCurso
        //JOIN Materias ON AsignacionesHorarios.idMateria = Materias.idMateria
        //JOIN Salas ON AsignacionesHorarios.idSala = Salas.idsalas
        //WHERE rutProfesor = @rutProfesor
        //ORDER BY rutProfesor, Materias.idMateria, dias, periodo, Salas.idsalas";

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(query, con);
        //        command.Parameters.AddWithValue("@rutProfesor", rutProfesor);

        //        SqlDataAdapter da = new SqlDataAdapter(command);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);

        //        dataDatos.DataSource = dt;
        //    }
        //}


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDataGridView print = new PrintDataGridView(dataDatos);
            print.isRightToLeft = false;
            print.ReportHeader = "Horario de Clases";
            print.Print();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        class Materia
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public bool Asignada { get; set; }
        }

        class Disponibilidad
        {
            public string Dia { get; set; }
            public List<string> Periodos { get; set; }
        }

        private void SetupDataGridView()
        {
            // Asegúrate de que esta configuración se llame en el constructor de tu formulario o en el método Load
            dataDatos.Columns.Add("idAsignacion", "ID Asignación");
            dataDatos.Columns.Add("rutProfesor", "RUT Profesor");
            dataDatos.Columns.Add("nombreCurso", "Nombre Curso");
            dataDatos.Columns.Add("nombreMateria", "Nombre Materia");
            dataDatos.Columns.Add("dias", "Día");
            dataDatos.Columns.Add("periodo", "Período");
            dataDatos.Columns.Add("nombresalas", "Nombre Sala");
        }

        private void InicializarPeriodosOcupados()
        {

                string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
                foreach (var dia in dias)
                {
                    periodosOcupados[dia] = new HashSet<string>();
                }
            
        }

        private void DistribuirMaterias(string rutProfesor)
        {
            List<Disponibilidad> disponibilidad = ObtenerDisponibilidad(rutProfesor);
            List<Materia> materias = ObtenerAsignacionesMaterias(rutProfesor);

            // Asegúrate de que periodosOcupados esté inicializado en algún lugar antes de este método
            // Por ejemplo, podrías llamar a InicializarPeriodosOcupados() en el constructor de tu formulario

            foreach (var dia in disponibilidad)
            {
                int bloquesAsignadosHoy = 0;
                string ultimoPeriodoAsignado = null;

                foreach (var periodo in dia.Periodos)
                {
                    // Verifica si el período ya está ocupado para ese día
                    if (periodosOcupados[dia.Dia].Contains(periodo))
                    {
                        continue; // El período ya está ocupado, así que continúa con el siguiente
                    }

                    if (bloquesAsignadosHoy >= 2 || (ultimoPeriodoAsignado != null && GetNextPeriodo(ultimoPeriodoAsignado) != periodo))
                    {
                        // Si ya se asignaron 2 bloques hoy o el periodo actual no es consecutivo, pasar al siguiente día
                        break;
                    }

                    var materiaParaAsignar = materias.FirstOrDefault(m => !m.Asignada); // Obtén la primera materia no asignada

                    if (materiaParaAsignar != null)
                    {
                        int rowIndex = dataDatos.Rows.Add();
                        dataDatos.Rows[rowIndex].SetValues(null, rutProfesor, "Curso de ejemplo", materiaParaAsignar.Nombre, dia.Dia, periodo, "Sala de ejemplo");

                        // Marca la materia como asignada para este bloque de tiempo
                        materiaParaAsignar.Asignada = true;
                        bloquesAsignadosHoy++;
                        ultimoPeriodoAsignado = periodo;

                        // Marca el período como ocupado
                        periodosOcupados[dia.Dia].Add(periodo);
                    }
                }
            }
        }


        private string GetNextPeriodo(string currentPeriodo)
        {
            // Este método necesita ser ajustado a tu lógica de horario específica.
            // Asumiremos que el formato es "HH:mm - HH:mm"
            string[] periodos = new string[] {
            "08:30 - 9:15", "09:15 - 10:00", "10:20 - 11:05", "11:05 - 11:50",
            "12:00 - 12:45", "12:45 - 13:30", "13:40 - 14:25", "14:25 - 15:10",
            "15:20 - 16:05", "16:05 - 16:50", "17:00 - 17:45", "17:45 - 18:30",
            "18:40 - 19:25"
                     };

            for (int i = 0; i < periodos.Length - 1; i++)
            {
                if (periodos[i] == currentPeriodo)
                    return periodos[i + 1];
            }

            return null; // No hay siguiente período si estamos en el último
        }
        private List<Disponibilidad> ObtenerDisponibilidad(string rutProfesor)
        {
            // Obtén la disponibilidad del profesor de la base de datos
            // Simulamos datos aquí. Debes ajustar la lógica según la disponibilidad real del profesor.
            return new List<Disponibilidad>
        {
                new Disponibilidad { Dia = "Lunes", Periodos = new List<string> {
                "08:30 - 9:15", "09:15 - 10:00", "10:20 - 11:05", "11:05 - 11:50",
                "12:00 - 12:45", "12:45 - 13:30", "13:40 - 14:25", "14:25 - 15:10",
                "15:20 - 16:05", "16:05 - 16:50", "17:00 - 17:45", "17:45 - 18:30",
                "18:40 - 19:25"
                } },
                new Disponibilidad { Dia = "Martes", Periodos = new List<string> {
                "08:30 - 9:15", "09:15 - 10:00", "10:20 - 11:05", "11:05 - 11:50",
                "12:00 - 12:45", "12:45 - 13:30", "13:40 - 14:25", "14:25 - 15:10",
                "15:20 - 16:05", "16:05 - 16:50", "17:00 - 17:45", "17:45 - 18:30",
                "18:40 - 19:25"
                } },
                new Disponibilidad { Dia = "Miércoles", Periodos = new List<string> {
                "08:30 - 9:15", "09:15 - 10:00", "10:20 - 11:05", "11:05 - 11:50",
                "12:00 - 12:45", "12:45 - 13:30", "13:40 - 14:25", "14:25 - 15:10",
                "15:20 - 16:05", "16:05 - 16:50", "17:00 - 17:45", "17:45 - 18:30",
                "18:40 - 19:25"
                } },
                new Disponibilidad { Dia = "Jueves", Periodos = new List<string> {
                "08:30 - 9:15", "09:15 - 10:00", "10:20 - 11:05", "11:05 - 11:50",
                "12:00 - 12:45", "12:45 - 13:30", "13:40 - 14:25", "14:25 - 15:10",
                "15:20 - 16:05", "16:05 - 16:50", "17:00 - 17:45", "17:45 - 18:30",
                "18:40 - 19:25"
                } },
                new Disponibilidad { Dia = "Viernes", Periodos = new List<string> {
                "08:30 - 9:15", "09:15 - 10:00", "10:20 - 11:05", "11:05 - 11:50",
                "12:00 - 12:45", "12:45 - 13:30", "13:40 - 14:25", "14:25 - 15:10",
                "15:20 - 16:05", "16:05 - 16:50", "17:00 - 17:45", "17:45 - 18:30",
                "18:40 - 19:25"
                } },
        // Repetir para cada día de la semana según sea necesario.
                                    };
        }
        private List<Materia> ObtenerAsignacionesMaterias(string rutProfesor)
        {
            List<Materia> materiasAsignadas = new List<Materia>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"
                SELECT m.nombreMateria
                FROM Materias m
                INNER JOIN AsignacionesHorarios ah ON m.idMateria = CAST(ah.idMateria AS int)
                WHERE ah.rutProfesor = @rutProfesor";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rutProfesor", rutProfesor);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        materiasAsignadas.Add(new Materia
                        {
                            // Asumiendo que tienes un campo Id, aunque no lo usas aquí
                            Nombre = reader["nombreMateria"].ToString(),
                            Asignada = false // Inicialmente, ninguna materia está asignada
                        });
                    }
                }
            }
            return materiasAsignadas;
        }
    }
}



