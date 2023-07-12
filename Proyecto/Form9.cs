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
        private int valorNumerico = 45; // Valor numérico que deseas asignar
        private int maxSumaPorDia = 450; // Valor máximo de suma por día
        private int maxSumaSemanal = 2400; // Valor máximo de suma semanal
        private List<List<bool>> valoresCheckbox; // Lista para almacenar los valores de las casillas de verificación
        private string connectionString = "Data Source = LAPTOP - HP6EH3TV\\SQLEXPRESS01;Initial Catalog = Proyecto; Integrated Security = True"; // Cadena de conexión a la base de datos SQL Server

        //private string  path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True"; 
        private string  path = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";

        public Form9()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();

            }
        }
        private void SaveDisponibilidadHoras(System.Windows.Forms.ComboBox comboBox)
        {
            string[] nombresDias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();

                // Obtener el valor del RUT desde el ComboBox
                string rut = comboBox.SelectedValue.ToString();

                // Borrar los registros existentes para el RUT
                using (SqlCommand command = new SqlCommand("DELETE FROM Disponible WHERE profesor_rut = @rut", con))
                {
                    command.Parameters.AddWithValue("@rut", rut);
                    command.ExecuteNonQuery();
                }

                // Insertar los nuevos registros
                using (SqlCommand command = new SqlCommand("INSERT INTO Disponible (profesor_rut, periodo, dias) VALUES (@rut, @periodo, @dias)", con))
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 2; j < dataGridView1.Columns.Count; j++)
                        {
                            bool isChecked = (bool)dataGridView1.Rows[i].Cells[j].Value;

                            if (isChecked)
                            {
                                string periodo = dataGridView1.Rows[i].Cells[0].Value.ToString(); // Obtener el número de período
                                string dia = nombresDias[j - 2]; // Obtener el nombre del día

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


            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "PERIODO";
            dataGridView1.Columns[1].Name = "HORA";
            dataGridView1.Columns[2].Name = "Lunes";
            dataGridView1.Columns[3].Name = "Martes";
            dataGridView1.Columns[4].Name = "Miercoles";
            dataGridView1.Columns[5].Name = "Jueves";
            dataGridView1.Columns[6].Name = "Viernes";

            // Agregar filas con celdas de verificación
            string[] row1 = { "1", "08:30 - 9:15", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row1);
            string[] row2 = { "2", "09:15 - 10:00", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row2);
            string[] row3 = { "3", "10:20 - 11:05", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row3);
            string[] row4 = { "4", "11:05 - 11:50", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row4);
            string[] row5 = { "5", "12:05 - 12:50", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row5);
            string[] row6 = { "6", "12:50 - 13:35", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row6);
            string[] row7 = { "7", "14:30 - 15:05", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row7);
            string[] row8 = { "8", "15:05 - 15:50", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row8);
            string[] row9 = { "9", "15:50 - 16:35", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row9);
            string[] row10 = { "10", "16:35 - 17:20", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row10);
            string[] row11 = { "11", "17:20 - 18:05", "False", "False", "False", "False", "False" };
            dataGridView1.Rows.Add(row11);

            // Agregar celdas de verificación en las columnas correspondientes
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 2; j < dataGridView1.Columns.Count; j++)
                {
                    DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                    checkBoxCell.Value = false; // Establecer el valor inicial como falso
                    dataGridView1.Rows[i].Cells[j] = checkBoxCell;
                }
            }


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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2 && e.ColumnIndex < dataGridView1.Columns.Count) // Verificar si se hizo clic en una celda de las columnas de verificación
            {
                dataGridView1.EndEdit(); // Forzar la validación de la celda

                int columnaInicial = 2; // Índice de la primera columna de verificación
                int diaSeleccionado = e.ColumnIndex - columnaInicial; // Obtener el índice del día seleccionado

                if (diaSeleccionado >= 0) // Verificar si el índice del día seleccionado es válido
                {
                    bool isChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    // Verificar límite semanal antes de actualizar el valor de la casilla de verificación
                    if (isChecked && VerificarLimiteSemanal())
                    {
                        MessageBox.Show("Se ha alcanzado el límite semanal de " + maxSumaSemanal + " horas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false; // Desmarcar la casilla de verificación
                        return;
                    }

                    // Actualizar el valor de la casilla de verificación en la lista valoresCheckbox
                    valoresCheckbox[e.RowIndex][diaSeleccionado] = isChecked;

                    // Actualizar el contador de horas
                    int contadorHoras = CalcularHorasSeleccionadas();

                    labelContadorHoras.Text = "Horas seleccionadas: " + contadorHoras;
                }
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2 && e.ColumnIndex < dataGridView1.Columns.Count) // Verificar si se cambió el valor de una celda de las columnas de verificación
            {
                int columnaInicial = 2; // Índice de la primera columna de verificación
                int diaSeleccionado = e.ColumnIndex - columnaInicial; // Obtener el índice del día seleccionado

                if (diaSeleccionado >= 0) // Verificar si el índice del día seleccionado es válido
                {
                    bool isChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    // Verificar límite semanal antes de actualizar el valor de la casilla de verificación
                    if (isChecked && VerificarLimiteSemanal())
                    {
                        MessageBox.Show("Se ha alcanzado el límite semanal de " + maxSumaSemanal + " horas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false; // Desmarcar la casilla de verificación
                        return;
                    }

                    // Actualizar el valor de la casilla de verificación en la lista valoresCheckbox
                    valoresCheckbox[e.RowIndex][diaSeleccionado] = isChecked;

                    // Actualizar el contador de horas
                    int contadorHoras = CalcularHorasSeleccionadas();

                    labelContadorHoras.Text = "Horas seleccionadas: " + contadorHoras;
                }
            }
        }
        private int CalcularHorasSeleccionadas()
        {
            int contadorHoras = 0;
            int sumaSemanal = 0;

            for (int i = 0; i < valoresCheckbox.Count; i++)
            {
                int sumaPorDia = valoresCheckbox[i].Count(isChecked => isChecked) * valorNumerico; // Calcular la suma por día
                sumaSemanal += sumaPorDia; // Acumular la suma por día en la suma semanal

                // Verificar límite por día
                if (sumaPorDia > maxSumaPorDia)
                {
                    // Desmarcar todas las casillas de verificación del día seleccionado
                    for (int j = 2; j < dataGridView1.Columns.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = false;
                        valoresCheckbox[i][j - 2] = false;
                    }

                    // Restar el valor excedido
                    sumaSemanal -= sumaPorDia - maxSumaPorDia;

                    MessageBox.Show("La suma ha superado los " + maxSumaPorDia + " para el día seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Verificar límite semanal
            if (sumaSemanal > maxSumaSemanal)
            {
                // Restar el valor excedido
                contadorHoras -= sumaSemanal - maxSumaSemanal;

                MessageBox.Show("La suma semanal ha superado los " + maxSumaSemanal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            contadorHoras = sumaSemanal;

            return contadorHoras;
        }
        private bool VerificarLimiteSemanal()
        {
            int sumaSemanal = valoresCheckbox.Sum(row => row.Count(isChecked => isChecked) * valorNumerico); // Calcular la suma semanal

            return sumaSemanal >= maxSumaSemanal;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveDisponibilidadHoras(comboBox2);
            MessageBox.Show("La información ha sido guardada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

