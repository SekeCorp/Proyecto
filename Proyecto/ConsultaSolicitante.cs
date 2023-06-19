using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class ConsultaSolicitante : Form
    {
        SqlConnection conn;
        public ConsultaSolicitante()
        {
            InitializeComponent();
        }

        void ConsultaSolicitante_Load(object sender, EventArgs e)
        {
            String path, query;
            DataTable dt = new DataTable();
            path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            //path = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(path);
            query = "Select*from Profesor";
            SqlCommand cmd = new SqlCommand(query, con);
            dt.Columns.Add("rut");
            dt.Columns.Add("nombre");
            con.Open();
            dr = cmd.ExecuteReader();

            int renglon = 0;
                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["rut"] = dr["rut"];
                    row["nombre"] = dr["nombre"];
                    dt.Rows.Add(row);
                    renglon = dataGridView1.Rows.Add();
                    dataGridView1.Rows[renglon].Cells["rut"].Value = dr.GetInt32(0);
                    dataGridView1.Rows[renglon].Cells["nombre"].Value = dr.GetString(1);
                    dataGridView1.Rows[renglon].Cells["apellido"].Value = dr.GetString(2);
                    dataGridView1.Rows[renglon].Cells["materia"].Value = dr.GetString(3);

                }

            dataGridView1.DataSource = dt;
            con.Close();



        }
        

}
}
