using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form9 : Form
    {
        private int valorNumerico = 45; // Valor numérico que deseas asignar
        private int maxSumaPorDia = 450; // Valor máximo de suma por día
        private int maxSumaSemanal = 2400; // Valor máximo de suma semanal
        private List<List<bool>> valoresCheckbox; // Lista para almacenar los valores de las casillas de verificación

        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "PERIODO";
            dataGridView1.Columns[1].Name = "HORA";

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "Lunes";
            dataGridView1.Columns.Add(chk);

            DataGridViewCheckBoxColumn chk1 = new DataGridViewCheckBoxColumn();
            chk1.Name = "Martes";
            dataGridView1.Columns.Add(chk1);

            DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();
            chk2.Name = "Miércoles";
            dataGridView1.Columns.Add(chk2);

            DataGridViewCheckBoxColumn chk3 = new DataGridViewCheckBoxColumn();
            chk3.Name = "Jueves";
            dataGridView1.Columns.Add(chk3);

            DataGridViewCheckBoxColumn chk4 = new DataGridViewCheckBoxColumn();
            chk4.Name = "Viernes";
            dataGridView1.Columns.Add(chk4);

            string[] row = new string[] { "1", "08:30 - 9:15" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "2", "09:15 - 10:00" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "3", "10:20 - 11:05" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "4", "11:05 - 11:50" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "5", "12:05 - 12:50" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "6", "12:50 - 13:35" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "7", "14:30 - 15:05" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "8", "15:05 - 15:50" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "9", "15:50 - 16:35" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "10", "16:35 - 17:20" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "11", "17:20 - 18:05" };
            dataGridView1.Rows.Add(row);
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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2) // Verificar si se hizo clic en una celda de las columnas de verificación
            {
                dataGridView1.EndEdit(); // Forzar la validación de la celda

                int columnaInicial = 2; // Índice de la primera columna de verificación
                int diaSeleccionado = e.ColumnIndex - columnaInicial; // Obtener el índice del día seleccionado

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
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2) // Verificar si se cambió el valor de una celda de las columnas de verificación
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
                valoresCheckbox[e.RowIndex][e.ColumnIndex - 2] = isChecked;

                // Actualizar el contador de horas
                int contadorHoras = CalcularHorasSeleccionadas();

                labelContadorHoras.Text = "Horas seleccionadas: " + contadorHoras;
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
    }
}
