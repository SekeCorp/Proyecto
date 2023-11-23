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
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet22.AsignacionesHorarios' Puede moverla o quitarla según sea necesario.
            this.asignacionesHorariosTableAdapter.Fill(this.proyectoDataSet22.AsignacionesHorarios);


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDataGridView print = new PrintDataGridView(dataGridView1);
            print.isRightToLeft = false;
            print.ReportHeader = "Horario de Clases";
            print.Print();
        }
        private string selectedNombreApellido;

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
