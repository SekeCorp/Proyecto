using DGV2Printer;
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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet9.HorarioClases' Puede moverla o quitarla según sea necesario.
            this.horarioClasesTableAdapter.Fill(this.proyectoDataSet9.HorarioClases);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDataGridView print = new PrintDataGridView(dataGridView1);
            print.isRightToLeft = false;
            print.ReportHeader = "Horario de Clases";
            print.ReportFooter = "Docente: " + selectedNombreApellido;
            print.Print();
        }
        private string selectedNombreApellido;
    }
}
