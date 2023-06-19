using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
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

        }
    }
}
