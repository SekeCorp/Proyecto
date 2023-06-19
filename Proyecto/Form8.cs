using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime fec = DateTime.Now;
            DateTime fecdev = dtp_Fecha_D.Value;
            DateTime fecpre = dtp_Fecha_P.Value;

            if (fecpre > fecdev)
            {
                MessageBox.Show("LA FECHA DE PESTAMO NO DEBE SER MAYOR A LA DE DEVOLUCIÒN O REVERSA");
                dtp_Fecha_P.Value = DateTime.Now;
                dtp_Fecha_D.Value = DateTime.Now;
            }
            else
            {
                TimeSpan x = (fecdev - fecpre);
                int numDias = x.Days + 1;
                txtDias_P.Text = numDias.ToString();  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path, query;
            DataTable dt = new DataTable();
            path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            String Consulta = "select * from Profesor where rut= "+textBox1.Text+"";
            SqlCommand comando = new SqlCommand(Consulta,con);
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                textBox2.Text = leer["nombre"].ToString();
                textBox3.Text = leer["apellido"].ToString();
            }
            con.Close();   


        }
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet6.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.proyectoDataSet6.Prestamos);
            string path, query;
            DataTable dt = new DataTable();
            path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            String Consulta = "select id from Equipos";
            SqlCommand comando = new SqlCommand(Consulta, con);
            SqlDataReader reg;
            reg = comando.ExecuteReader();
            while (reg.Read())
            {
                comboID_Equipos.Items.Add(reg["id"].ToString());
            }
        }

        private void comboID_Equipos_Click(object sender, EventArgs e)
        {
            //String path, query;
            //DataTable dt = new DataTable();
            //path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            ////path = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";
            //SqlConnection con = new SqlConnection(path);
            //query = "Select * from Equipos";
            //dt.Columns.Add("id");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////try
            ////{
            ////    string path, query, equipo_id, profesor_rut;
            ////    DateTime fecha_p, fecha_d;
            ////    DataTable dt = new DataTable();
            ////    path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            ////    profesor_rut = textBox1.Text;
            ////    equipo_id = comboID_Equipos.Text;
            ////    fecha_p = dtp_Fecha_P.Value;
            ////    fecha_d = dtp_Fecha_D.Value;


            ////    using (SqlConnection con = new SqlConnection(path))
            ////    {
            ////        con.Open();

            ////        query = "INSERT INTO Prestamos (equipo_id , profesor_rut, fecha_prestamo, fecha_devolucion) VALUES (@equipo_id, @profesor_rut @fecha_prestamo, @fecha_devolucion)";
            ////        using (SqlCommand cmd = new SqlCommand(query, con))
            ////        {
            ////            cmd.Parameters.AddWithValue("@profesor_rut", profesor_rut);
            ////            cmd.Parameters.AddWithValue("@equipo_id", equipo_id);
            ////            cmd.Parameters.AddWithValue("@fecha_prestamo", fecha_p);
            ////            cmd.Parameters.AddWithValue("@fecha_devolucion", fecha_d);

            ////            cmd.ExecuteNonQuery();

            ////            MessageBox.Show("Prestamo OK");
            ////        }
            ////    }
            ////}
            ////catch (Exception ex)
            ////{
            ////    MessageBox.Show("Error al agregar el registro: "+ ex);
            ////}

        }
    }
}
