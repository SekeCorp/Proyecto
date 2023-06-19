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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string path, query, rut;
                DataTable dt = new DataTable();

                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                rut = txtRutElimin.Text;

                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    query = "DELETE FROM Profesor WHERE rut = @rut";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@rut", rut);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Eliminado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro para eliminar");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el registro: ");
            }
        }

        private void btnConfirmarElim_Click(object sender, EventArgs e)
        {
            String path, query;
            DataTable dt = new DataTable();
            path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(path);
            query = "Select*from Profesor";
            SqlCommand cmd = new SqlCommand(query, con);
            dt.Columns.Add("rut");
            dt.Columns.Add("nombre");
            dt.Columns.Add("materia");
            dt.Columns.Add("horas");
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                DataRow row = dt.NewRow();
                row["rut"] = dr["rut"];
                row["nombre"] = dr["nombre"];
                row["materia"] = dr["materia"];
                row["horas"] = dr["horas"];
                dt.Rows.Add(row);
                //String fila;
                //fila = dr.GetString(1).ToString();
                //MessageBox.Show(fila);
            }
            dataGridView1.DataSource = dt;
            con.Close();
            txtRutElimin.Clear();
        }
    }
}
