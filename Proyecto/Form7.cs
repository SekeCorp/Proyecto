using DGV2Printer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

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
            CargarIdsEquipos();

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
                dt.Rows.Add(row);

            }
            dataGridView1.DataSource = dt;
            con.Close();
            nomEquipo_txt.Clear();
            numSerie_txt.Clear();

            // Actualizar el ComboBox cbx_id con los nuevos ids
            CargarIdsEquipos();
        }


        private void btnGuardarQr_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG|*.jpeg";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string varing = saveFileDialog1.FileName;
                Bitmap varbmp = new Bitmap(imgBarra.Image);
                varbmp.Save(varing, ImageFormat.Jpeg);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                try
                {
                    string path, query, id, nombre, serie;
                    DataTable dt = new DataTable();
                    path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                    // path = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";
                    nombre = nomEquipo_txt.Text;
                    serie = numSerie_txt.Text;

                    using (SqlConnection con = new SqlConnection(path))
                    {
                        con.Open();

                        query = "INSERT INTO Equipos (nombre, numero_serie) VALUES (@nombre, @numero_serie)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@nombre", nombre);
                            cmd.Parameters.AddWithValue("@numero_serie", serie);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Agregado correctamente");
                        }
                    }


                }
                catch (Exception a)
                {
                    MessageBox.Show("Error al agregar el registro: " + a.Message);
                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(imgBarra.Image, 100, 600, imgBarra.Width, imgBarra.Height);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cbx_id.SelectedItem != null)
            {
                int id = Convert.ToInt32(cbx_id.SelectedItem);
                // Generar código de barras
                Code128BarcodeDraw codigodebarra = BarcodeDrawFactory.Code128WithChecksum;
                imgBarra.Image = codigodebarra.Draw(id.ToString(), 40);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un id de equipo para generar el código de barras.");
            }
        }
        private void CargarIdsEquipos()
        {
            try
            {
                string cadenaConexion = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                // Consulta SQL para obtener los ids de Equipos desde la tabla Equipos
                string consultaSql = "SELECT id FROM Equipos";

                // Crear la conexión y el comando
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                {
                    // Abrir la conexión
                    conexion.Open();

                    // Ejecutar la consulta y obtener un lector de datos
                    SqlDataReader lector = comando.ExecuteReader();

                    // Limpiar los items actuales del ComboBox
                    cbx_id.Items.Clear();

                    // Agregar los ids de Equipos al ComboBox
                    while (lector.Read())
                    {
                        int idEquipo = Convert.ToInt32(lector["id"]);
                        cbx_id.Items.Add(idEquipo);
                    }

                    // Cerrar el lector de datos
                    lector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los ids de Equipos: " + ex.Message);
            }
        }
    }
}

