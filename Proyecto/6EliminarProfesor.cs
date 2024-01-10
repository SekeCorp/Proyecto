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
            LoadProfesorData();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'profesores._Profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this.profesores._Profesores);
            CargarDatosComboBoxRut();



        }
        private void LoadProfesorData()
        {
            string connectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            string query = @"
        SELECT * FROM Profesores";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt; // Asegúrate de que tu DataGridView se llame dataGridView1.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string path, query, rut;
                DataTable dt = new DataTable();

                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                rut = comboBoxRut.Text;

                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    // Eliminar referencias en MateriaCurso
                    string queryDeleteMateriaCurso = "DELETE FROM MateriaCurso WHERE rutProfesor = @rut";
                    using (SqlCommand cmdDeleteMateriaCurso = new SqlCommand(queryDeleteMateriaCurso, con))
                    {
                        cmdDeleteMateriaCurso.Parameters.AddWithValue("@rut", rut);
                        cmdDeleteMateriaCurso.ExecuteNonQuery();
                    }
                    // Eliminar referencias en ProfesorMateria
                    string queryDeleteProfesorMateria = "DELETE FROM ProfesorMateria WHERE rutProfesor = @rut";
                    using (SqlCommand cmdDeleteProfesorMateria = new SqlCommand(queryDeleteProfesorMateria, con))
                    {
                        cmdDeleteProfesorMateria.Parameters.AddWithValue("@rut", rut);
                        cmdDeleteProfesorMateria.ExecuteNonQuery();
                    }
                    // Eliminar referencias en ProfesorCurso
                    string queryDeleteProfesorCurso = "DELETE FROM ProfesorCurso WHERE rutProfesor = @rut";
                    using (SqlCommand cmdDeleteProfesorCurso = new SqlCommand(queryDeleteProfesorCurso, con))
                    {
                        cmdDeleteProfesorCurso.Parameters.AddWithValue("@rut", rut);
                        cmdDeleteProfesorCurso.ExecuteNonQuery();
                    }
                    // Eliminar referencias en Disponibilidad
                    string queryDeleteDisponibilidad = "DELETE FROM Disponibilidad WHERE profesor_rut = @rut";
                    using (SqlCommand cmdDeleteDisponibilidad = new SqlCommand(queryDeleteDisponibilidad, con))
                    {
                        cmdDeleteDisponibilidad.Parameters.AddWithValue("@rut", rut);
                        cmdDeleteDisponibilidad.ExecuteNonQuery();
                    }
                    // Eliminar referencias en Devoluciones
                    string queryDeleteDevoluciones = "DELETE FROM Devoluciones WHERE rutProfesores = @rut";
                    using (SqlCommand cmdDeleteDevoluciones = new SqlCommand(queryDeleteDevoluciones, con))
                    {
                        cmdDeleteDevoluciones.Parameters.AddWithValue("@rut", rut);
                        cmdDeleteDevoluciones.ExecuteNonQuery();
                    }
                    // Eliminar referencias en HorarioClases
                    string queryDeleteHorarioClases = "DELETE FROM HorarioClases WHERE RUT = @rut";
                    using (SqlCommand cmdDeleteHorarioClases = new SqlCommand(queryDeleteHorarioClases, con))
                    {
                        cmdDeleteHorarioClases.Parameters.AddWithValue("@rut", rut);
                        cmdDeleteHorarioClases.ExecuteNonQuery();
                    }

                    // Eliminar al profesor
                    query = "DELETE FROM Profesores WHERE rut = @rut";
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message);
            }
        }

        private void btnConfirmarElim_Click(object sender, EventArgs e)
        {
            LoadProfesorData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
