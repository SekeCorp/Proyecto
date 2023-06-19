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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Data Source = LAPTOP - HP6EH3TV\SQLEXPRESS01; Initial Catalog = Proyecto; Integrated Security = True
            try
            {
                string path, query, nombre, materia, horas, rut, apellido;
                DataTable dt = new DataTable();
                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                rut = txtRut.Text;
                nombre = txtNombreIngPro.Text;
                materia = txtMateriaIng.Text;
                horas = numericUpDown1.Text;
                apellido = txtApellidoPro.Text;

                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    query = "INSERT INTO Profesor (rut, nombre, materia, horas, apellido) VALUES (@rut, @nombre, @materia, @horas, @apellido)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@rut", rut);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@materia", materia);
                        cmd.Parameters.AddWithValue("@horas", horas);
                        cmd.Parameters.AddWithValue("@apellido", apellido);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Agregado correctamente");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el registro: ");
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
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
            txtRut.Clear();
            txtNombreIngPro.Clear();
            txtApellidoPro.Clear();
            txtMateriaIng.Clear();

        }
    }
}
