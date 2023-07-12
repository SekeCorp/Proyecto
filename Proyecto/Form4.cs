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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }


        private void btnModConfirmar_Click(object sender, EventArgs e)
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
            dt.Columns.Add("materia");
            dt.Columns.Add("horas");
            dt.Columns.Add("apellido");
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                DataRow row = dt.NewRow();
                row["rut"] = dr["rut"];
                row["nombre"] = dr["nombre"];
                row["materia"] = dr["materia"];
                row["horas"] = dr["horas"];
                row["apellido"] = dr["apellido"];
                dt.Rows.Add(row);
                //String fila;
                //fila = dr.GetString(1).ToString();
                //MessageBox.Show(fila);
            }
            dataGridView1.DataSource = dt;
            con.Close();
            txtModRut.Clear();
            txtNombreModPro.Clear();
            txtModMateria.Clear();
            txtModHoras.Clear();
            txtApellidoProMod.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string path, query, nombre, materia, horas, rut, apellido;
                DataTable dt = new DataTable();

                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                rut = txtModRut.Text;
                nombre = txtNombreModPro.Text;
                materia = txtModMateria.Text;
                horas = txtModHoras.Text;
                apellido = txtApellidoProMod.Text;

                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    query = "UPDATE Profesor SET nombre = @nombre, materia = @materia, horas = @horas, apellido = @apellido WHERE rut = @rut";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@materia", materia);
                        cmd.Parameters.AddWithValue("@horas", horas);
                        cmd.Parameters.AddWithValue("@rut", rut);
                        cmd.Parameters.AddWithValue("@apellido", apellido);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Modificado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro para actualizar");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar el registro: ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
