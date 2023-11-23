using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Proyecto
{
    public partial class ModificarProfesor : Form
    {
        public ModificarProfesor()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet23.Profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this.proyectoDataSet23.Profesores);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet13.Materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.proyectoDataSet13.Materias);
            // Agregar un mensaje de instrucción en el ComboBox

            // Limpiar la selección actual del ComboBox
            comboBoxRut.SelectedIndex = -1;
            CargarDatosComboBoxRut();
        }

        private void CargarDatosComboBoxRut()
        {

            try
            {
                string path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                string query = "SELECT rut FROM Profesores";

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
            dt.Columns.Add("apellido");
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataRow row = dt.NewRow();
                row["rut"] = dr["rut"];
                row["nombre"] = dr["nombre"];
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
                apellido = txtApellidoProMod.Text;

                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    query = "UPDATE Profesor SET nombre = @nombre, materia = @materia, horas = @horas, apellido = @apellido WHERE rut = @rut";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
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

        private void comboBoxRut_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Obtener el "rut" seleccionado
                string selectedRut = comboBoxRut.SelectedItem?.ToString();

                // Verificar que se ha seleccionado un "rut" válido
                if (!string.IsNullOrEmpty(selectedRut))
                {
                    CargarDatosProfesor(selectedRut);
                }
                else
                {
                    // Si no hay un "rut" válido seleccionado, limpiar los campos
                    txtNombreModPro.Clear();
                    txtApellidoProMod.Clear();
                }
            }
        private void CargarDatosProfesor(string rut)
        {
            try
            {
                string path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    string query = "SELECT nombre, apellido FROM Profesor WHERE rut = @rut";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@rut", rut);

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            txtNombreModPro.Text = dr["nombre"].ToString();
                            txtApellidoProMod.Text = dr["apellido"].ToString();
                        }
                        else
                        {
                            // Si el "rut" no existe, limpiar los campos
                            txtNombreModPro.Clear();
                            txtApellidoProMod.Clear();
                        }
                        dr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del profesor: " + ex.Message);
            }
        }




    }

    }
