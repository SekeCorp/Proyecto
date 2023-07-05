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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string path, query, equipo_id, profesor_rut;
            //    DateTime fecha_p, fecha_d;
            //    DataTable dt = new DataTable();
            //    path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            //    profesor_rut = comboBox_RUT.Text;
            //    equipo_id = comboID_Equipos.Text;
            //    fecha_p = dtp_Fecha_P.Value;
            //    fecha_d = dtp_Fecha_D.Value;


            //    using (SqlConnection con = new SqlConnection(path))
            //    {
            //        con.Open();

            //        query = "INSERT INTO Prestamos (equipo_id , profesor_rut, fecha_prestamo, fecha_devolucion) VALUES (@equipo_id, @profesor_rut, @fecha_prestamo, @fecha_devolucion)";
            //        using (SqlCommand cmd = new SqlCommand(query, con))
            //        {
            //            cmd.Parameters.AddWithValue("@equipo_id", equipo_id);
            //            cmd.Parameters.AddWithValue("@profesor_rut", profesor_rut);
            //            cmd.Parameters.AddWithValue("@fecha_prestamo", fecha_p);
            //            cmd.Parameters.AddWithValue("@fecha_devolucion", fecha_d);

            //            cmd.ExecuteNonQuery();

            //            MessageBox.Show("Prestamo OK");
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al agregar el registro: " + ex);
            //}
        }
    }
}
