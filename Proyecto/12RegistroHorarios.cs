using DGV2Printer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form12 : Form
    {
        private DataTable dataTable;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet25.HorarioClases' Puede moverla o quitarla según sea necesario.
            this.horarioClasesTableAdapter.Fill(this.proyectoDataSet25.HorarioClases);

            // Obtener el DataTable asociado al BindingSource
            dataTable = ((DataView)horarioClasesBindingSource.List).Table;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDataGridView print = new PrintDataGridView(dataGridView1);
            print.isRightToLeft = false;
            print.ReportHeader = "Horario de Clases";
            print.Print();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ordenar por PERIODO y DIAS
            dataTable.DefaultView.Sort = "RUT, Periodo, Dias";

            // Actualizar el DataGridView
            dataGridView1.DataSource = dataTable.DefaultView.ToTable();
        }
    }
}
