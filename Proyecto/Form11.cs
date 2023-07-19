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
        //private string connectionString = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            LoadRuts();
            LoadCursos();
        }

        private void LoadRuts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT profesor_rut FROM Disponible GROUP BY profesor_rut";
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string rut = reader["profesor_rut"].ToString();
                    comboBoxRut.Items.Add(rut);
                }

                reader.Close();
            }
        }

        private void comboBoxRut_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRut = comboBoxRut.SelectedItem?.ToString();
            LoadDisponibilidad(selectedRut);
            LoadMaterias(selectedRut);
        }

        private void LoadDisponibilidad(string rut)
        {
            if (string.IsNullOrEmpty(rut))
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Obtener la materia asociada al RUT
                string queryMateria = "SELECT m.nombre FROM Profesor p INNER JOIN Materias m ON p.materia = m.nombre WHERE p.rut = @rut";
                SqlCommand commandMateria = new SqlCommand(queryMateria, con);
                commandMateria.Parameters.AddWithValue("@rut", rut);

                string materia = commandMateria.ExecuteScalar()?.ToString();

                // Cargar la materia en el ComboBoxMateria
                comboBoxMateria.Items.Clear();
                if (!string.IsNullOrEmpty(materia))
                {
                    comboBoxMateria.Items.Add(materia);
                    comboBoxMateria.SelectedIndex = 0;
                }

                // Obtener los períodos y días de disponibilidad
                string queryDisponibilidad = "SELECT periodo, dias FROM Disponible WHERE profesor_rut = @rut";
                SqlCommand commandDisponibilidad = new SqlCommand(queryDisponibilidad, con);
                commandDisponibilidad.Parameters.AddWithValue("@rut", rut);

                SqlDataAdapter adapter = new SqlDataAdapter(commandDisponibilidad);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void LoadMaterias(string rut)
        {
            if (string.IsNullOrEmpty(rut))
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT DISTINCT materia FROM Profesor WHERE rut = @rut";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rut", rut);

                SqlDataReader reader = command.ExecuteReader();

                comboBoxMateria.Items.Clear(); // Limpiar ComboBoxMateria antes de agregar nuevos elementos
                comboBoxMateria.DropDownStyle = ComboBoxStyle.DropDownList; // Establecer el estilo DropDownList

                while (reader.Read())
                {
                    string materia = reader["materia"].ToString();
                    comboBoxMateria.Items.Add(materia);
                }

                reader.Close();
            }
        }

        private void LoadPeriodos(string rut)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT DISTINCT periodo FROM Disponible WHERE profesor_rut = @rut";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rut", rut);

                SqlDataReader reader = command.ExecuteReader();

                comboBoxPeriodo.Items.Clear(); // Limpiar ComboBoxPeriodo antes de agregar nuevos elementos

                while (reader.Read())
                {
                    string periodo = reader["periodo"].ToString();
                    comboBoxPeriodo.Items.Add(periodo);
                }

                reader.Close();
            }
        }
        public class Sala
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
        private void LoadSalas(string materia)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT s.nombresalas AS Sala FROM Materias m INNER JOIN Salas s ON m.sala_id = s.idsalas WHERE m.nombre = @materia";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@materia", materia);

                SqlDataReader reader = command.ExecuteReader();

                comboBoxSala.Items.Clear(); // Limpiar ComboBoxSala antes de agregar nuevos elementos

                while (reader.Read())
                {
                    string sala = reader["Sala"].ToString();
                    comboBoxSala.Items.Add(sala);
                }

                reader.Close();
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string selectedRut = comboBoxRut.SelectedItem?.ToString();
            LoadDisponibilidad(selectedRut);
            LoadPeriodos(selectedRut);
        }

        private void LoadCursos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT curso FROM Curso";
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();

                comboBoxCurso.Items.Clear(); // Limpiar ComboBoxCurso antes de agregar nuevos elementos

                while (reader.Read())
                {
                    string curso = reader["curso"].ToString();
                    comboBoxCurso.Items.Add(curso);
                }

                reader.Close();
            }
        }


        private Dictionary<string, List<PeriodoUtilizado>> cursosPeriodosUtilizados = new Dictionary<string, List<PeriodoUtilizado>>();

        private class PeriodoUtilizado
        {
            public string Periodo { get; set; }
            public string Dia { get; set; }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados de los ComboBox
            string selectedRut = comboBoxRut.SelectedItem?.ToString() ?? "";
            string materia = comboBoxMateria.SelectedItem?.ToString() ?? "";
            string sala = comboBoxSala.SelectedItem?.ToString() ?? "";
            string periodo = comboBoxPeriodo.SelectedItem?.ToString() ?? "";
            string dia = comboBoxDia.SelectedItem?.ToString() ?? "";
            string curso = comboBoxCurso.SelectedItem?.ToString() ?? "";

            // Verificar si los valores son válidos
            if (string.IsNullOrEmpty(selectedRut) || string.IsNullOrEmpty(materia) || string.IsNullOrEmpty(sala) || string.IsNullOrEmpty(periodo) || string.IsNullOrEmpty(dia) || string.IsNullOrEmpty(curso))
            {
                MessageBox.Show("Por favor, seleccione todos los campos antes de añadir los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el período ya se utilizó para algún curso
            foreach (var cursosPeriodos in cursosPeriodosUtilizados)
            {
                string cursoExistente = cursosPeriodos.Key;
                List<PeriodoUtilizado> periodosUtilizados = cursosPeriodos.Value;

                foreach (var periodoUtilizado in periodosUtilizados)
                {
                    if (periodoUtilizado.Periodo == periodo && periodoUtilizado.Dia == dia)
                    {
                        MessageBox.Show($"El período {periodo} del día {dia} ya se ha utilizado para el curso {cursoExistente}. Por favor, seleccione otro período.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Agregar el período utilizado al curso actual
            if (cursosPeriodosUtilizados.ContainsKey(curso))
            {
                List<PeriodoUtilizado> periodosUtilizados = cursosPeriodosUtilizados[curso];
                periodosUtilizados.Add(new PeriodoUtilizado { Periodo = periodo, Dia = dia });
            }
            else
            {
                cursosPeriodosUtilizados[curso] = new List<PeriodoUtilizado> { new PeriodoUtilizado { Periodo = periodo, Dia = dia } };
            }

            // Verificar si las columnas ya existen en el DataGridView
            if (dataGridView2.Columns.Count == 0)
            {
                // Agregar las columnas necesarias al DataGridView
                dataGridView2.Columns.Add("RUT", "RUT");
                dataGridView2.Columns.Add("Materia", "Materia");
                dataGridView2.Columns.Add("Sala", "Sala");
                dataGridView2.Columns.Add("Periodo", "Periodo");
                dataGridView2.Columns.Add("Días", "Días");
                dataGridView2.Columns.Add("Curso", "Curso");
            }
            // Insertar los datos en la base de datos
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string insertQuery = "INSERT INTO HorarioClases (RUT, Materia, Sala, Periodo, Dias, Curso) VALUES (@rut, @materia, @sala, @periodo, @dia, @curso)";
                SqlCommand command = new SqlCommand(insertQuery, con);
                command.Parameters.AddWithValue("@rut", selectedRut);
                command.Parameters.AddWithValue("@materia", materia);
                command.Parameters.AddWithValue("@sala", sala);
                command.Parameters.AddWithValue("@periodo", periodo);
                command.Parameters.AddWithValue("@dia", dia);
                command.Parameters.AddWithValue("@curso", curso);

                command.ExecuteNonQuery();
            }
            // Limpiar los campos seleccionados
            comboBoxPeriodo.SelectedIndex = -1;
            comboBoxDia.SelectedIndex = -1;
            comboBoxCurso.SelectedIndex = -1;

            // Mostrar un mensaje de éxito
            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Agregar una nueva fila al DataGridView con los valores seleccionados
            dataGridView2.Rows.Add(selectedRut, materia, sala, periodo, dia, curso);
        }

        private void comboBoxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDia = comboBoxDia.SelectedItem?.ToString();
            string selectedRut = comboBoxRut.SelectedItem?.ToString();
            LoadPeriodos(selectedDia, selectedRut);
        }

        private void LoadPeriodos(string dia, string rut)
        {
            if (string.IsNullOrEmpty(dia) || string.IsNullOrEmpty(rut))
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT DISTINCT periodo FROM Disponible WHERE profesor_rut = @rut AND dias = @dia";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rut", rut);
                command.Parameters.AddWithValue("@dia", dia);

                SqlDataReader reader = command.ExecuteReader();

                comboBoxPeriodo.Items.Clear(); // Limpiar ComboBoxPeriodo antes de agregar nuevos elementos

                while (reader.Read())
                {
                    string periodo = reader["periodo"].ToString();
                    comboBoxPeriodo.Items.Add(periodo);
                }

                reader.Close();
            }
        }


        private void comboBoxRut_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedRut = comboBoxRut.SelectedItem?.ToString();
            selectedNombreApellido = GetNombreApellido(selectedRut); // Aquí se obtendrá el valor del nombre y apellido
            LoadDisponibilidad(selectedRut);
            LoadMaterias(selectedRut);
            string selectedMateria = GetSelectedMateria();
            LoadDiasDisponibles(selectedRut);
        }

        private void LoadDiasDisponibles(string rut)
        {
            if (string.IsNullOrEmpty(rut))
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT DISTINCT dias FROM Disponible WHERE profesor_rut = @rut";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rut", rut);

                SqlDataReader reader = command.ExecuteReader();

                comboBoxDia.Items.Clear(); // Limpiar ComboBoxDia antes de agregar nuevos elementos

                while (reader.Read())
                {
                    string dias = reader["dias"].ToString();
                    comboBoxDia.Items.Add(dias);
                }

                reader.Close();
            }
        }

        private string GetSelectedMateria()
        {
            if (comboBoxMateria.SelectedItem != null)
            {
                return comboBoxMateria.SelectedItem.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        //----------------------------------------------------------------------------------------------

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            PrintDataGridView print = new PrintDataGridView(dataGridView2);
            print.isRightToLeft = false;
            print.ReportHeader = "Horario de Clases";
            print.ReportFooter = "Docente: " + selectedNombreApellido;
            print.Print();
        }

        private string GetNombreApellido(string rut)
        {
            if (string.IsNullOrEmpty(rut))
            {
                return string.Empty;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT nombre, apellido FROM Profesor WHERE rut = @rut";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rut", rut);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string nombre = reader["nombre"].ToString();
                    string apellido = reader["apellido"].ToString();
                    reader.Close();
                    return $"{nombre} {apellido}";
                }
                else
                {
                    reader.Close();
                    return string.Empty;
                }
            }
        }

        private string selectedNombreApellido;

        private void comboBoxMateria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxMateria.SelectedItem != null)
            {
                string selectedMateria = comboBoxMateria.SelectedItem.ToString();
                LoadSalas(selectedMateria);
            }
        }

    }
}
