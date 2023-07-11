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
    public partial class Form11 : Form
    {
        //private string connectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True"; el webas
        private string connectionString = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";

        public Form11()
        {
            InitializeComponent();
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            LoadRuts();
        }
        private void LoadRuts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT profesor_rut FROM Disponibilidad GROUP BY profesor_rut";
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string rut = reader["profesor_rut"].ToString();
                    comboBoxRut.Items.Add(rut);
                }

                reader.Close();
            }
        }

        private void comboBoxRut_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRut = comboBoxRut.SelectedItem.ToString();
            LoadDisponibilidad(selectedRut);
        }

        private void LoadDisponibilidad(string rut)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT periodo, dias FROM Disponibilidad WHERE profesor_rut = @rut";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@rut", rut);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string selectedRut = comboBoxRut.SelectedItem.ToString();
            LoadDisponibilidad(selectedRut);
        }

    }
}
