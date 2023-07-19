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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet13.Equipos' Puede moverla o quitarla según sea necesario.
            this.equiposTableAdapter1.Fill(this.proyectoDataSet13.Equipos);

        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path, query, nombre, materia, rut;
                DataTable dt = new DataTable();

                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                rut = comboboxRut.Text;
                nombre = txtNombreModEq.Text;
                materia = txtApellidoProMod.Text;


                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    query = "UPDATE Equipos SET nombre = @nombre, numero_serie = @numero_serie WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@numero_serie", materia);

                        cmd.Parameters.AddWithValue("@id", rut);


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

        private void btnModConfirmar_Click_1(object sender, EventArgs e)
        {
            String path, query;
            DataTable dt = new DataTable();
            path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            //path = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(path);
            query = "Select*from Equipos";
            SqlCommand cmd = new SqlCommand(query, con);
            dt.Columns.Add("id");
            dt.Columns.Add("nombre");
            dt.Columns.Add("numero_serie");
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                DataRow row = dt.NewRow();
                row["id"] = dr["id"];
                row["nombre"] = dr["nombre"];
                row["numero_serie"] = dr["numero_serie"];

                dt.Rows.Add(row);

            }
            dataGridView1.DataSource = dt;
            con.Close();
            txtNombreModEq.Clear();
            txtApellidoProMod.Clear();
        }
    }
}
