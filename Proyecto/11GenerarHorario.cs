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
using System.Security.Cryptography;

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

            // BPD - 2023-12-01 - Limpiar el datagridview antes de cargar la informacion
            dataDatos.Rows.Clear();
            dataDatos.Columns.Clear();
            SetupDataGridView();

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

            // BPD - 2023-12-01 - Agregar campos de acuerdo a la consulta de materias por profesor
            public string NombreCurso { get; set; }
            public string NombreSala { get; set; }
            public string Dia { get; set; }
        }

        class Disponibilidad
        {
            public string Dia { get; set; }
            public List<string> Periodos { get; set; }

            // BPD - 2023-11-29 - Agregar campos de acuerdo a la tabla Disponibilidad de la BD
            public string Periodo { get; set; }
            public int Id_Disponibilidad { get; set; }
            public string Profesor_Rut { get; set; }
        }

        private void SetupDataGridView()
        {

            dataDatos.Columns.Add("rutProfesor", "RUT Profesor");
            dataDatos.Columns.Add("periodo", "Período");
            dataDatos.Columns.Add("nombreCurso", "Nombre Curso");
            dataDatos.Columns.Add("nombresalas", "Nombre Sala");
            dataDatos.Columns.Add("dias", "Lunes");
            dataDatos.Columns.Add("dias", "Martes");
            dataDatos.Columns.Add("dias", "Miércoles");
            dataDatos.Columns.Add("dias", "Jueves");
            dataDatos.Columns.Add("dias", "Viernes");

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

                int bloquesAsignadoPorDia = 1;
                string diaAnterior = "";

                foreach (var periodo in dia.Periodos)
                {
                    //int bloquesAsignadoPorDia = 1;
                    // Verifica si el período ya está ocupado para ese día
                    if (periodosOcupados[dia.Dia].Contains(periodo))
                    {
                        //continue; // El período ya está ocupado, así que continúa con el siguiente
                    }

                    if (bloquesAsignadosHoy >= 2 || (ultimoPeriodoAsignado != null && GetNextPeriodo(ultimoPeriodoAsignado) != periodo))
                    {
                        // Si ya se asignaron 2 bloques hoy o el periodo actual no es consecutivo, pasar al siguiente día
                        //break;                        
                    }


                    var materiaParaAsignar = materias.FirstOrDefault(m => !m.Asignada); // Obtén la primera materia no asignada

                    if (materiaParaAsignar != null)
                    {
                        // BPD - 2023-12-04 - Consulta para asignar valor del dia a variable y sumar al contador para su validacion
                        if (diaAnterior != materiaParaAsignar.Dia)
                        {
                            diaAnterior = materiaParaAsignar.Dia;
                            bloquesAsignadoPorDia = 1;
                        }
                        else
                        {
                            bloquesAsignadoPorDia++;
                        }

                        //BPD - 2023 - 12 - 04 - Validacion de bloques por dia
                        if (bloquesAsignadoPorDia == 3)
                        {
                            MessageBox.Show("Este profesor ya tiene 2 bloques asignados por día ", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            bloquesAsignadoPorDia = 1;
                            break;
                            return;
                        }

                        int rowIndex = dataDatos.Rows.Add();


                        // Marca la materia como asignada para este bloque de tiempo
                        materiaParaAsignar.Asignada = true;
                        //bloquesAsignadosHoy++;
                        ultimoPeriodoAsignado = periodo;

                        // Marca el período como ocupado
                        periodosOcupados[dia.Dia].Add(periodo);

                        // BPD - 2023-12-03 - Validacion de horarios y grabacion en la BD
                        if (ExisteHorarioAsignado(materiaParaAsignar.NombreCurso, materiaParaAsignar.Nombre, materiaParaAsignar.Dia, periodo))
                        {
                            MessageBox.Show("Ya existe un horario asignado para el curso: " + materiaParaAsignar.NombreCurso + " Materia: " + materiaParaAsignar.Nombre
                                + " Dia: " + materiaParaAsignar.Dia + " Periodo: " + periodo, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //if (bloquesAsignadoPorDia > 1)
                            //{
                            //    bloquesAsignadoPorDia--;
                            //}
                            bloquesAsignadoPorDia = 0;

                            continue;
                        }

                        GuardarHorarioClases(rutProfesor, materiaParaAsignar.Nombre, periodo, materiaParaAsignar.Dia, materiaParaAsignar.NombreCurso);

                        dataDatos.Rows[rowIndex].SetValues(rutProfesor, periodo, materiaParaAsignar.NombreCurso, materiaParaAsignar.NombreSala, materiaParaAsignar.Dia == "Lunes" ? materiaParaAsignar.Nombre : "", materiaParaAsignar.Dia == "Martes" ? materiaParaAsignar.Nombre : "",
                            materiaParaAsignar.Dia == "Miércoles" ? materiaParaAsignar.Nombre : "", materiaParaAsignar.Dia == "Jueves" ? materiaParaAsignar.Nombre : "", materiaParaAsignar.Dia == "Viernes" ? materiaParaAsignar.Nombre : "");

                        bloquesAsignadosHoy++;


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
            List<Disponibilidad> lstDisp = new List<Disponibilidad>();
            Disponibilidad disponibilidad;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT dias, periodo, profesor_rut FROM Disponibilidad WHERE profesor_rut = @rutProfesor ORDER BY dias;";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rutProfesor", rutProfesor);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    disponibilidad = new Disponibilidad();
                    disponibilidad.Dia = reader["dias"].ToString();
                    disponibilidad.Periodo = reader["periodo"].ToString();
                    disponibilidad.Profesor_Rut = reader["profesor_rut"].ToString();
                    disponibilidad.Periodos = new List<string> {
                        "08:30 - 9:15", "09:15 - 10:00", "10:20 - 11:05", "11:05 - 11:50",
                        "12:00 - 12:45", "12:45 - 13:30", "13:40 - 14:25", "14:25 - 15:10",
                        "15:20 - 16:05", "16:05 - 16:50", "17:00 - 17:45", "17:45 - 18:30",
                        "18:40 - 19:25"
                    };

                    lstDisp.Add(disponibilidad);
                }

                reader.Close();
            }

            return lstDisp;
        }
        private List<Materia> ObtenerAsignacionesMaterias(string rutProfesor)
        {
            List<Materia> materiasAsignadas = new List<Materia>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // BPD - 2023-12-01 - Se modifica la consulta para obtener los campos que faltan en el datagridview
                //string query = @"
                //SELECT m.nombreMateria
                //FROM Materias m
                //INNER JOIN AsignacionesHorarios ah ON m.idMateria = CAST(ah.idMateria AS int)
                //WHERE ah.rutProfesor = @rutProfesor";

                string query = @"
                                    SELECT
                    pc.rutProfesor,
                    c.nombreCurso,
                    m.nombreMateria, 
                    d.dias,
                    d.periodo,
                    s.nombresalas AS idSala
                FROM
                    ProfesorCurso pc
                JOIN Profesores pfs ON pc.rutProfesor = pfs.rut
                JOIN ProfesorMateria pm ON pfs.rut = pm.rutProfesor
                JOIN Materias m ON pm.idMateria = m.idMateria
                JOIN Cursos c ON pc.idCurso = c.idCurso
                JOIN Disponibilidad d ON pc.rutProfesor = d.profesor_rut
                JOIN Salas s ON m.idsala = s.idsalas
                WHERE
                    pc.rutProfesor = @rutProfesor
                    ORDER BY dias;";
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
                            Asignada = false, // Inicialmente, ninguna materia está asignada

                            // BPD - 2023-12-01 - Agregar campos de acuerdo a la consulta de materias por profesor
                            NombreCurso = reader["nombreCurso"].ToString(),
                            NombreSala = reader["idSala"].ToString(),
                            Dia = reader["dias"].ToString()
                        });
                    }
                }
            }
            return materiasAsignadas;
        }
        // BPD - 2023-12-03 - Método para consultar si existe el horario ingresado para un curso, dia y periodo cargado en el Datagridview
        private bool ExisteHorarioAsignado(string Curso, string Materia, string Dias, string Periodo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                SELECT idHorario 
                FROM HorarioClases
                WHERE Curso = @Curso                
                AND Dias = @Dias
                AND Materia = @Materia
                AND Periodo = @Periodo";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Curso", Curso);
                command.Parameters.AddWithValue("@Dias", Dias);
                command.Parameters.AddWithValue("@Materia", Materia);
                command.Parameters.AddWithValue("@Periodo", Periodo);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return true;
                    else
                        return false;
                }
            }
        }

        // BPD - 2023-12-03 - Método para guardar el horario de clases
        private void GuardarHorarioClases(string rutProfesor, string Materia, string Periodo, string Dias, string Curso)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO HorarioClases (RUT, Materia, Periodo, Dias, Curso)" +
                    " VALUES (@rutProfesor, @Materia, @Periodo, @Dias, @Curso)", con))
                {
                    command.Parameters.AddWithValue("@rutProfesor", rutProfesor);
                    command.Parameters.AddWithValue("@Materia", Materia);
                    command.Parameters.AddWithValue("@Periodo", Periodo);
                    command.Parameters.AddWithValue("@Dias", Dias);
                    command.Parameters.AddWithValue("@Curso", Curso);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}



