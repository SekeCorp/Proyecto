using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto
{
    public partial class Form9 : Form
    {
        private const int VALOR_NUMERICO = 45;
        private const int MAX_SUMA_POR_DIA = 450;
        private const int MAX_SUMA_SEMANAL = 2400;
        private List<List<bool>> valoresCheckbox;
        private string connectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

        public Form9()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
            }
        }

        private void SaveDisponibilidadHoras(System.Windows.Forms.ComboBox comboBox)
        {
            string[] nombresDias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string rut = comboBox.SelectedValue.ToString();

                using (SqlCommand command = new SqlCommand("DELETE FROM Disponible WHERE profesor_rut = @rut", con))
                {
                    command.Parameters.AddWithValue("@rut", rut);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("INSERT INTO Disponible (profesor_rut, periodo, dias) VALUES (@rut, @periodo, @dias)", con))
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 2; j < dataGridView1.Columns.Count; j++)
                        {
                            bool isChecked = (bool)dataGridView1.Rows[i].Cells[j].Value;

                            if (isChecked)
                            {
                                string periodo = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                string dia = nombresDias[j - 2];

                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@rut", rut);
                                command.Parameters.AddWithValue("@periodo", periodo);
                                command.Parameters.AddWithValue("@dias", dia);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: Código que carga datos en la tabla
            this.profesorTableAdapter1.Fill(this.proyectoDataSet8.Profesor);
            InitializeDataGridView();
            InitializeValoresCheckbox();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "PERIODO";
            dataGridView1.Columns[1].Name = "HORA";
            dataGridView1.Columns[2].Name = "Lunes";
            dataGridView1.Columns[3].Name = "Martes";
            dataGridView1.Columns[4].Name = "Miércoles";
            dataGridView1.Columns[5].Name = "Jueves";
            dataGridView1.Columns[6].Name = "Viernes";

            string[][] rows = {
                new[] { "1", "08:30 - 9:15", "False", "False", "False", "False", "False" },
                new[] { "2", "09:15 - 10:00", "False", "False", "False", "False", "False" },
                new[] { "3", "10:20 - 11:05", "False", "False", "False", "False", "False" },
                new[] { "4", "11:05 - 11:50", "False", "False", "False", "False", "False" },
                new[] { "5", "12:00 - 12:45", "False", "False", "False", "False", "False" },
                new[] { "6", "12:45 - 13:30", "False", "False", "False", "False", "False" },
                new[] { "7", "13:40 - 14:25", "False", "False", "False", "False", "False" },
                new[] { "8", "14:25 - 15:10", "False", "False", "False", "False", "False" },
                new[] { "9", "15:20 - 16:05", "False", "False", "False", "False", "False" },
                new[] { "10", "16:05 - 16:50", "False", "False", "False", "False", "False" },
                new[] { "11", "17:00 - 17:45", "False", "False", "False", "False", "False" },
                new[] { "12", "17:45 - 18:30", "False", "False", "False", "False", "False" },
                new[] { "13", "18:40 - 19:25", "False", "False", "False", "False", "False" }

            };

            foreach (var row in rows)
            {
                dataGridView1.Rows.Add(row);
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 2; j < dataGridView1.Columns.Count; j++)
                {
                    DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                    checkBoxCell.Value = false;
                    dataGridView1.Rows[i].Cells[j] = checkBoxCell;
                }
            }
        }

        private void InitializeValoresCheckbox()
        {
            valoresCheckbox = new List<List<bool>>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                List<bool> filaValores = new List<bool>();

                for (int j = 2; j < dataGridView1.Columns.Count; j++)
                {
                    filaValores.Add(false);
                }

                valoresCheckbox.Add(filaValores);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCheckboxChanges(e);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            HandleCheckboxChanges(e);
        }

        private void HandleCheckboxChanges(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2 && e.ColumnIndex < dataGridView1.Columns.Count)
            {
                dataGridView1.EndEdit();

                int columnaInicial = 2;
                int diaSeleccionado = e.ColumnIndex - columnaInicial;

                if (diaSeleccionado >= 0)
                {
                    bool isChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (isChecked && VerificarLimiteSemanal())
                    {
                        MessageBox.Show($"Se ha alcanzado el límite máximo de horas por semana. No puede marcar más casillas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                        valoresCheckbox[e.RowIndex][diaSeleccionado] = false;
                    }
                    else
                    {
                        valoresCheckbox[e.RowIndex][diaSeleccionado] = isChecked;
                        CalcularHorasSeleccionadas();
                    }
                }
            }
        }

        private int CalcularHorasSeleccionadas()
        {
            int sumaSemanal = 0;

            for (int i = 0; i < valoresCheckbox.Count; i++)
            {
                int sumaPorDia = valoresCheckbox[i].Count(isChecked => isChecked) * VALOR_NUMERICO;

                if (sumaPorDia > MAX_SUMA_POR_DIA)
                {
                    for (int j = 2; j < dataGridView1.Columns.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = false;
                        valoresCheckbox[i][j - 2] = false;
                    }

                    MessageBox.Show($"La suma ha superado los {MAX_SUMA_POR_DIA} para el día seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sumaSemanal += sumaPorDia;
                }
            }

            if (sumaSemanal > MAX_SUMA_SEMANAL)
            {
                MessageBox.Show($"La suma semanal ha superado los {MAX_SUMA_SEMANAL}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            labelContadorHoras.Text = "Horas seleccionadas: " + sumaSemanal;
            return sumaSemanal;
        }

        private bool VerificarLimiteSemanal()
        {
            return CalcularHorasSeleccionadas() > MAX_SUMA_SEMANAL;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveDisponibilidadHoras(comboBox2);
            MessageBox.Show("La información ha sido guardada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerarHorario_Click(object sender, EventArgs e)
        {
            FormHorario formHorario = new FormHorario(); // Creas una instancia del FormHorario
            formHorario.Show(); // Muestras el FormHorario
            this.Hide();
        }

        // ... [Cualquier otra función que estuviera en tu código original] ...
    }

}