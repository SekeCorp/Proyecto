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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {


        }

        private void Agregar_btn_Click(object sender, EventArgs e)
        {
            //Data Source = LAPTOP - HP6EH3TV\SQLEXPRESS01; Initial Catalog = Proyecto; Integrated Security = True
            try
            {
                string path, query, id, nombre, serie;
                DataTable dt = new DataTable();
                //path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                path = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";
                id = id_txt.Text;
                nombre = nomEquipo_txt.Text;
                serie = numSerie_txt.Text;

                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    query = "INSERT INTO Equipos (id, nombre, numero_serie) VALUES (@id, @nombre, @numero_serie)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@numero_serie", serie);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Agregado correctamente");
                    }
                }   
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al agregar el registro: "+a.Message);
            }

        }

        private void Actualizar_btn_Click(object sender, EventArgs e)
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
            dt.Columns.Add("en_prestamo");
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                DataRow row = dt.NewRow();
                row["id"] = dr["id"];
                row["nombre"] = dr["nombre"];
                row["numero_serie"] = dr["numero_serie"];
                row["en_prestamo"] = dr["en_prestamo"];
                dt.Rows.Add(row);
                //String fila;
                //fila = dr.GetString(1).ToString();
                //MessageBox.Show(fila);
            }
            dataGridView1.DataSource = dt;
            con.Close();
            id_txt.Clear();
            nomEquipo_txt.Clear();
            numSerie_txt.Clear();
        }
    }
}

