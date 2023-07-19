using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

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
            // Agregar un mensaje de instrucción en el ComboBox
            comboBoxRut.Items.Insert(0, "Seleccione un RUT");

            // Limpiar la selección actual del ComboBox
            comboBoxRut.SelectedIndex = -1;
        }

        //private void CargarDatosProfesor(string rut)
        //{
        //    try
        //    {
        //        string path, query;
        //        path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

        //        using (SqlConnection con = new SqlConnection(path))
        //        {
        //            con.Open();

        //            query = "SELECT * FROM Profesor WHERE rut = @rut";
        //            using (SqlCommand cmd = new SqlCommand(query, con))
        //            {
        //                cmd.Parameters.AddWithValue("@rut", rut);

        //                SqlDataReader dr = cmd.ExecuteReader();
        //                if (dr.Read())
        //                {
        //                    txtNombreModPro.Text = dr["nombre"].ToString();
        //                    comboboxmateria.Text = dr["materia"].ToString();
        //                    txtApellidoProMod.Text = dr["apellido"].ToString();
        //                }
        //                else
        //                {
        //                    // Si el rut no existe, limpiar los campos
        //                    txtNombreModPro.Clear();
        //                    comboboxmateria.Text = "";
        //                    txtApellidoProMod.Clear();
        //                }
        //                dr.Close();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar los datos del profesor: " + ex.Message);
        //    }
        //}

        private void btnModConfirmar_Click(object sender, EventArgs e)
        {
            string path, query;
            path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(path);
            query = "Select * from Profesor";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
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
            }
            dataGridView1.DataSource = dt;
            con.Close();
            txtNombreModPro.Clear();
            txtApellidoProMod.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string path, query, nombre, materia, horas, rut, apellido;
                DataTable dt = new DataTable();

                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                rut = comboBoxRut.Text;
                nombre = txtNombreModPro.Text;
                materia = comboboxmateria.Text;
                horas = HorasNup.Text;
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



        private void Form4_Shown(object sender, EventArgs e)
        {

        }



        //private void comboBoxRut_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    // Obtener el rut seleccionado
        //    string selectedRut = comboBoxRut.SelectedItem?.ToString();

        //    MessageBox.Show("RUT seleccionado: " + selectedRut);

        //    // Si se ha seleccionado un RUT válido, cargar los datos del profesor
        //    if (!string.IsNullOrEmpty(selectedRut) && comboBoxRut.SelectedIndex > 0)
        //    {
        //        CargarDatosProfesor(selectedRut);
        //    }
        //    else
        //    {
        //        // Si no hay un RUT válido seleccionado o el formulario está cargando, limpiar los campos
        //        if (this.IsHandleCreated) // Verificar si el formulario está cargado
        //        {
        //            txtNombreModPro.Clear();
        //            comboboxmateria.Text = "";
        //            txtApellidoProMod.Clear();
        //        }
        //    }
        }

    }
}
