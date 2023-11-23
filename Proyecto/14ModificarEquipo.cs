using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
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
            this.equiposTableAdapter.Fill(this.proyectoDataSet13.Equipos);
            CargarDatosComboBoxEquipos();
            comboBoxEquipo.SelectedIndexChanged += comboBoxEquipo_SelectedIndexChanged;


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



        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path, query, nombre, materia, Equipo;
                DataTable dt = new DataTable();

                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                Equipo = comboBoxEquipo.Text;
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

                        cmd.Parameters.AddWithValue("@id", Equipo);


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

                // Generar código de barras
                Zen.Barcode.Code128BarcodeDraw codigodebarra = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox2.Image = codigodebarra.Draw(Equipo, 40);
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

        private void comboBoxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el "id" seleccionado
            string selectedId = comboBoxEquipo.SelectedItem?.ToString();

            // Verificar que se ha seleccionado un "id" válido
            if (!string.IsNullOrEmpty(selectedId))
            {
                CargarDatosEquipo(selectedId);
            }
            else
            {
                // Si no hay un "id" válido seleccionado, limpiar los campos
                txtNombreModEq.Clear();
                txtApellidoProMod.Clear();
            }
        }

        private void CargarDatosEquipo(string id)
        {
            try
            {
                string path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    string query = "SELECT nombre, numero_serie FROM Equipos WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            txtNombreModEq.Text = dr["nombre"].ToString();
                            txtApellidoProMod.Text = dr["numero_serie"].ToString();
                        }
                        else
                        {
                            // Si el "id" no existe, limpiar los campos
                            txtNombreModEq.Clear();
                            txtApellidoProMod.Clear();
                        }
                        dr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del equipo: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG|*.jpeg";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string varing = saveFileDialog1.FileName;
                Bitmap varbmp = new Bitmap(pictureBox2.Image);
                varbmp.Save(varing, ImageFormat.Jpeg);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox2.Image, 100, 600, pictureBox2.Width, pictureBox2.Height);
        }
    }
}
