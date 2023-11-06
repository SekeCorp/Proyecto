using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form6 : Form
    {
        private string path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True"; //SEBA

        public Form6()
        {
            InitializeComponent();
        }

        private void Buscar_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxEquipo.Text))
            {
                comboBoxEquipo.BackColor = Color.LightPink;
                comboBoxEquipo.Focus();
                return;
            }
            else
            {
                comboBoxEquipo.BackColor = Color.White;
                comboBoxEquipo.Focus();

                string id = comboBoxEquipo.Text;
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    string query = "SELECT nombre, numero_serie FROM Equipos WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string nombre = reader.GetString(0);
                            string numeroSerie = reader.GetString(1);

                            // Crear un nuevo DataTable y agregar las columnas necesarias
                            DataTable dt = new DataTable();
                            dt.Columns.Add("Nombre");
                            dt.Columns.Add("Número de Serie");

                            // Agregar una nueva fila con los datos encontrados
                            DataRow row = dt.NewRow();
                            row["Nombre"] = nombre;
                            row["Número de Serie"] = numeroSerie;
                            dt.Rows.Add(row);

                            // Asignar el DataTable al DataGridView
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            // Limpiar el DataGridView si no se encontraron resultados
                            dataGridView1.DataSource = null;
                            MessageBox.Show("No se encontró ningún item con el ID especificado.");
                        }
                    }
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CargarDatosComboBoxEquipos();
        }
        private void CargarDatosComboBoxEquipos()
        {
            try
            {
                string path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                string query = "SELECT id FROM Equipos";

                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        // No es necesario limpiar el ComboBox cuando está vinculado con DataSource
                        // comboBoxEquipo.Items.Clear();

                        while (dr.Read())
                        {
                            comboBoxEquipo.Items.Add(dr["id"].ToString());
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
    }
}
