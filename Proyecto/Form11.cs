
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
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT DISTINCT materia FROM Profesor WHERE rut = @rut";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rut", rut);

                SqlDataReader reader = command.ExecuteReader();

                comboBoxMateria.Items.Clear(); // Limpiar ComboBoxMateria antes de agregar nuevos elementos

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
        private void LoadSalas(string materia)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT s.nombresalas FROM Materias m INNER JOIN Salas s ON m.sala_id = s.idsalas WHERE m.nombre = @materia";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@materia", materia);

                SqlDataReader reader = command.ExecuteReader();

                comboBoxSala.Items.Clear(); // Limpiar ComboBoxSala antes de agregar nuevos elementos

                while (reader.Read())
                {
                    string sala = reader["nombresalas"].ToString();
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

        private void comboBoxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMateria = comboBoxMateria.SelectedItem.ToString();
            LoadSalas(selectedMateria);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
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

            // Obtener los valores seleccionados de los ComboBox
            selectedRut = comboBoxRut.SelectedItem?.ToString() ?? "";
            string materia = comboBoxMateria.SelectedItem?.ToString() ?? "";
            string sala = comboBoxSala.SelectedItem?.ToString() ?? "";
            string periodo = comboBoxPeriodo.SelectedItem?.ToString() ?? "";
            string curso = comboBoxCurso.SelectedItem?.ToString() ?? "";

            // Obtener el día seleccionado en el comboBoxDia
            string dia = comboBoxDia.SelectedItem?.ToString() ?? "";

            // Obtener el Nombre y Apellido asociados al RUT seleccionado
            selectedNombreApellido = GetNombreApellido(selectedRut);

            // Agregar una nueva fila al DataGridView con los valores seleccionados
            dataGridView2.Rows.Add(selectedRut, materia, sala, periodo, dia, curso);
        }

        private List<string> GetDiasDisponibles(string rut)
        {
            List<string> diasDisponibles = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT dias FROM Disponible WHERE profesor_rut = @rut";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rut", rut);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string dias = reader["dias"].ToString();
                    diasDisponibles.Add(dias);
                }

                reader.Close();
            }

            return diasDisponibles;
        }

        private void comboBoxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDia = comboBoxDia.SelectedItem?.ToString();
            string selectedRut = comboBoxRut.SelectedItem?.ToString();
            LoadPeriodos(selectedDia, selectedRut);
        }
        private void LoadPeriodos(string dia, string rut)
        {
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
            LoadDisponibilidad(selectedRut);
            LoadMaterias(selectedRut);
            string selectedMateria = GetSelectedMateria();
            LoadDiasDisponibles(selectedRut); 
        }
        private void LoadDiasDisponibles(string rut)
        {
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
        private string selectedRut;
        private string selectedNombreApellido;
    }

}
