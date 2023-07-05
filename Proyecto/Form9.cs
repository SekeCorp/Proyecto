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
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet6.Profesor' Puede moverla o quitarla según sea necesario.
            this.profesorTableAdapter.Fill(this.proyectoDataSet6.Profesor);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet6.Materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.proyectoDataSet6.Materias);

        }
    }
}
