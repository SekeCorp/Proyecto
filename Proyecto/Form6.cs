using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Buscar_btn_Click(object sender, EventArgs e)
        {

            string path, query, id;
            DataTable dt = new DataTable();
            path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            path = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";
            id = id_txt.Text;
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();

                query = "SELECT * FROM Equipos WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string nombre = reader.GetString(1);
                        string numeroSerie = reader.GetString(2);
                        bool enPrestamo = reader.GetBoolean(3);
                        String _enprestamo;

                        if (enPrestamo == true)
                        {
                            _enprestamo = "Prestado";
                        }
                        else
                        {
                            _enprestamo = "Disponible";
                        }

                        MessageBox.Show($"Item encontrado: Nombre: {nombre}, Número de serie: {numeroSerie}, Estado: {_enprestamo}");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún item con el ID especificado.");
                    }
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet3.Equipos' Puede moverla o quitarla según sea necesario.
            this.equiposTableAdapter.Fill(this.proyectoDataSet3.Equipos);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet4.Equipos' Puede moverla o quitarla según sea necesario.
            //this.equiposTableAdapter.Fill(this.proyectoDataSet4.Equipos);
        }
    }
}
