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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // AVISOS avance 01/06 23.00


        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this; //This se refiere al Formulario 1 
            f2.mievento += delegate { //adjuntar "+=" un nuevo evento //delegate= Valida la acción 
                this.ingresarToolStripMenuItem.Enabled = true;
            };
            f2.mievento2 += delegate { //adjuntar "+=" un nuevo evento //delegate= Valida la acción 
                this.horarioToolStripMenuItem.Enabled = true;
                this.equiposToolStripMenuItem.Enabled = true;

            };
            f2.mievento3 += delegate { //adjuntar "+=" un nuevo evento //delegate= Valida la acción 
                this.horarioToolStripMenuItem.Enabled = true;
                this.cerrarSesionToolStripMenuItem.Enabled = true;

            };
            f2.mievento4 += delegate { //adjuntar "+=" un nuevo evento //delegate= Valida la acción 
                this.equiposToolStripMenuItem.Enabled = true;
                this.horarioToolStripMenuItem.Enabled = false;
            };
            f2.mievento5 += delegate { //adjuntar "+=" un nuevo evento //delegate= Valida la acción 
                this.cerrarSesionToolStripMenuItem.Enabled = true;
            };

            ingresarToolStripMenuItem.Enabled = false;
            f2.Show();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msj;
            String respuesta; // se declara la respuesta al Dialogo en pantalla
            msj = MessageBox.Show("Seguro que desea salir?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information); // Muestra un Texto preguntando si desea salir del sistema o no
            respuesta = msj.ToString(); //Declara que el "msj" pasa a ser "respuesta" 
            if (respuesta == "No")//Si la respuesta de la pregunta es NO hacer: 
            {
                e.Cancel = true; //Cancelar cerrado de programa y continuar dentro de la app 
            }
        }


        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            ingresarToolStripMenuItem.Enabled = true;
            cerrarSesionToolStripMenuItem.Enabled = false;
            equiposToolStripMenuItem.Enabled = false;
            horarioToolStripMenuItem.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this; //This se refiere al Formulario 1 

            ingresarToolStripMenuItem.Enabled = false;

            f3.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.MdiParent = this; //This se refiere al Formulario 1 

            ingresarToolStripMenuItem.Enabled = false;

            f4.Show();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.MdiParent = this;
            f6.Show();
        }

    }
}
