using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormHorario : Form
    {
        private const string ConnectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

        private readonly Dictionary<string, int> diaAColumna = new Dictionary<string, int>
    {
        {"Lunes", 5},
        {"Martes", 6},
        {"Miércoles", 7},
        {"Jueves", 8},
        {"Viernes", 9}
    };
        public FormHorario()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadProfesores();
            this.comboBoxProfesores.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfesores_SelectedIndexChanged_1);
        }

        private void InitializeDataGridView()
        {
            // Limpiar las columnas existentes para configurar las nuevas
            dataGridViewHorario.Columns.Clear();

            // Añadir las nuevas columnas necesarias
            dataGridViewHorario.Columns.Add("ID", "ID");
            dataGridViewHorario.Columns.Add("RUT", "RUT");
            dataGridViewHorario.Columns.Add("Sala", "Sala");
            dataGridViewHorario.Columns.Add("Periodo", "Periodo");
            dataGridViewHorario.Columns.Add("Curso", "Curso");
            dataGridViewHorario.Columns.Add("Lunes", "Lunes");
            dataGridViewHorario.Columns.Add("Martes", "Martes");
            dataGridViewHorario.Columns.Add("Miércoles", "Miércoles");
            dataGridViewHorario.Columns.Add("Jueves", "Jueves");
            dataGridViewHorario.Columns.Add("Viernes", "Viernes");

            // Suponiendo 7 periodos al día
            for (int i = 0; i < 7; i++)
            {
                dataGridViewHorario.Rows.Add();
            }
        }

        private void LoadProfesores()
        {
            comboBoxProfesores.Items.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT rut FROM Profesor";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string rut = reader["rut"].ToString();
                        comboBoxProfesores.Items.Add(rut);
                    }
                }
            }
        }

        private void comboBoxProfesores_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxProfesores.SelectedItem != null)
            {
                string rutSeleccionado = comboBoxProfesores.SelectedItem.ToString();

                // Limpiar el DataGridView antes de asignar nuevos valores.
                ClearDataGridView();

                var disponibilidad = GetDisponibilidadDeProfesores(rutSeleccionado);
                AssignToDataGridView(disponibilidad);
            }
        }

        private Dictionary<string, List<(string dia, int periodo, string materia)>> GetDisponibilidadDeProfesores(string rutSeleccionado)
        {
            var disponibilidad = new Dictionary<string, List<(string dia, int periodo, string materia)>>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT dias, periodo, idmateria FROM Disponible WHERE profesor_rut = @Rut";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Rut", rutSeleccionado);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string dia = reader["dias"].ToString();
                        int periodo = int.Parse(reader["periodo"].ToString());
                        string materia = reader["idmateria"].ToString();

                        if (!disponibilidad.ContainsKey(dia))
                        {
                            disponibilidad[dia] = new List<(string dia, int periodo, string materia)>();
                        }

                        disponibilidad[dia].Add((dia, periodo, materia));
                    }
                }
            }

            return disponibilidad;
        }

        private void AssignToDataGridView(Dictionary<string, List<(string dia, int periodo, string materia)>> disponibilidad)
        {

            foreach (var dia in disponibilidad.Keys)
            {
                foreach (var horario in disponibilidad[dia])
                {
                    if (diaAColumna.ContainsKey(horario.dia))
                    {
                        int columnIndex = diaAColumna[horario.dia] + 5; // Asumiendo que las columnas de días empiezan en la posición 5
                        int rowIndex = horario.periodo - 1;

                        if (rowIndex >= 0 && rowIndex < dataGridViewHorario.Rows.Count && columnIndex >= 0 && columnIndex < dataGridViewHorario.Columns.Count)
                        {
                            dataGridViewHorario.Rows[rowIndex].Cells[columnIndex].Value = horario.materia;
                        }
                    }
                }
            }
        }

        private void ClearDataGridView()
        {
            foreach (DataGridViewRow row in dataGridViewHorario.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = "";  // O puedes usar null, dependiendo de cómo quieras manejar las celdas vacías.
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxProfesores.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un profesor.");
                return;
            }


            string rutProfesor = comboBoxProfesores.SelectedItem.ToString();

            // Aquí necesitarás agregar la lógica para obtener la Sala y el Curso de alguna parte,
            // ya que no están incluidos en el DataGridView actualmente. Esto es solo un ejemplo.
            string sala = "Sala por defecto";
            string curso = "Curso por defecto";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Eliminar la disponibilidad existente del profesor en HorarioClases
                string deleteQuery = "DELETE FROM HorarioClases WHERE RUT = @Rut";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@Rut", rutProfesor);
                deleteCommand.ExecuteNonQuery();

                // Insertar la nueva disponibilidad en HorarioClases
                for (int row = 0; row < dataGridViewHorario.Rows.Count; row++)
                {
                    for (int col = 5; col < dataGridViewHorario.Columns.Count; col++) // Empieza en 5 porque las columnas Lunes a Viernes empiezan ahí
                    {
                        if (dataGridViewHorario.Rows[row].Cells[col].Value != null)
                        {
                            string materia = dataGridViewHorario.Rows[row].Cells[col].Value.ToString();
                            string dia = dataGridViewHorario.Columns[col].Name;
                            int columnIndex = diaAColumna[dia]; // Obtener el índice de columna basado en el día
                            string periodo = (row + 1).ToString();

                            string insertQuery = "INSERT INTO HorarioClases(RUT, Materia, Sala, Periodo, Dias, Curso) VALUES(@Rut, @Materia, @Sala, @Periodo, @Dias, @Curso)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                            insertCommand.Parameters.AddWithValue("@Rut", rutProfesor);
                            insertCommand.Parameters.AddWithValue("@Materia", materia);
                            insertCommand.Parameters.AddWithValue("@Sala", sala);
                            insertCommand.Parameters.AddWithValue("@Periodo", periodo);
                            insertCommand.Parameters.AddWithValue("@Dias", dia);
                            insertCommand.Parameters.AddWithValue("@Curso", curso);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Horario guardado exitosamente en HorarioClases.");
            }
        }
    }
}
