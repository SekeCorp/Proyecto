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
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet12.Profesor' Puede moverla o quitarla según sea necesario.
            this.profesorTableAdapter1.Fill(this.proyectoDataSet12.Profesor);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet12.Profesor' Puede moverla o quitarla según sea necesario.
            this.profesorTableAdapter1.Fill(this.proyectoDataSet12.Profesor);

            CargarDatosComboBoxRut();


        }
        private void CargarDatosComboBoxRut()
        {
            try
            {
                string path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                string query = "SELECT rut FROM Profesor";

                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        // Limpiar el ComboBox antes de cargar los datos
                        comboBoxRut.Items.Clear();

                        // Agregar los "rut" al ComboBox
                        while (dr.Read())
                        {
                            comboBoxRut.Items.Add(dr["rut"].ToString());
                        }

                        dr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del ComboBox: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string path, query, rut;
                DataTable dt = new DataTable();

                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                //path = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";
                rut = comboBoxRut.Text;

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
            dt.Columns.Add("apellido");
            dt.Columns.Add("materia");
            dt.Columns.Add("horas");
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                DataRow row = dt.NewRow();
                row["rut"] = dr["rut"];
                row["nombre"] = dr["nombre"];
                row["apellido"] = dr["apellido"];
                row["materia"] = dr["materia"];
                row["horas"] = dr["horas"];
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
