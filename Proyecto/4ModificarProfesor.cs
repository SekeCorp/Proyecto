using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

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
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet24.Materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter2.Fill(this.proyectoDataSet24.Materias);

            // TODO: esta línea de código carga datos en la tabla 'cursos._Cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.cursos._Cursos);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet23.Profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this.proyectoDataSet23.Profesores);

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
            LoadProfesorData();
        }
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string rut, nombre, apellido;
                List<string> selectedMaterias = listMateria.SelectedItems.Cast<DataRowView>()
                                           .Select(item => item["nombreMateria"].ToString())
                                           .ToList();

                // Capturar los elementos seleccionados de listCurso
                List<string> selectedCursos = listCurso.SelectedItems.Cast<DataRowView>()
                                          .Select(item => item["nombreCurso"].ToString())
                                          .ToList();
                rut = comboBoxRut.Text;
                nombre = txtNombreModPro.Text;
                apellido = txtApellidoProMod.Text;

                // Eliminar registros antiguos en ProfesorMateria y ProfesorCurso
                DeleteProfesorData(rut);

                // Crear y mostrar Form17 pasando los elementos seleccionados de materias y cursos
                Form17 f17 = new Form17(selectedMaterias, selectedCursos, rut, nombre, apellido);
                f17.Show();

                // Insertar nuevos registros en ProfesorMateria y ProfesorCurso
                //InsertProfesorData(rut, selectedMaterias, selectedCursos);

                // Refrescar la vista de los datos
                LoadProfesorData();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al modificar los registros: " + ex.Message);
            }

        }
        private void DeleteProfesorData(string rut)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Eliminar registros en ProfesorMateria
                    string queryDeleteProfesorMateria = "DELETE FROM ProfesorMateria WHERE rutProfesor = @rut";
                    using (SqlCommand cmdDeleteProfesorMateria = new SqlCommand(queryDeleteProfesorMateria, con))
                    {
                        cmdDeleteProfesorMateria.Parameters.AddWithValue("@rut", rut);
                        cmdDeleteProfesorMateria.ExecuteNonQuery();
                    }

                    string queryDeleteMateriaCurso = "DELETE FROM MateriaCurso WHERE rutProfesor = @rut";
                    // Elimina las filas relacionadas en MateriaCurso
                    using (SqlCommand commandDeleteMateriaCurso = new SqlCommand(queryDeleteMateriaCurso, con))
                    {
                        commandDeleteMateriaCurso.Parameters.AddWithValue("@rut", rut);
                        commandDeleteMateriaCurso.ExecuteNonQuery();
                    }

                    // Eliminar registros en ProfesorCurso
                    string queryDeleteProfesorCurso = "DELETE FROM ProfesorCurso WHERE rutProfesor = @rut";
                    using (SqlCommand cmdDeleteProfesorCurso = new SqlCommand(queryDeleteProfesorCurso, con))
                    {
                        cmdDeleteProfesorCurso.Parameters.AddWithValue("@rut", rut);
                        cmdDeleteProfesorCurso.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los registros antiguos: " + ex.Message);
            }
        }

        //// Método para insertar nuevos registros
        //private void InsertProfesorData(string rut, List<string> materias, List<string> cursos)
        //{

        //    try
        //    {
        //        string connectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            con.Open();

        //            // Insertar registros en ProfesorMateria
        //            string queryInsertProfesorMateria = @"
        //        INSERT INTO ProfesorMateria (rutProfesor, idMateria)
        //        VALUES (@rut, (SELECT idMateria FROM Materias WHERE nombreMateria = @materia))";
        //            foreach (string materia in materias)
        //            {
        //                using (SqlCommand cmdInsertProfesorMateria = new SqlCommand(queryInsertProfesorMateria, con))
        //                {
        //                    cmdInsertProfesorMateria.Parameters.AddWithValue("@rut", rut);
        //                    cmdInsertProfesorMateria.Parameters.AddWithValue("@materia", materia);
        //                    cmdInsertProfesorMateria.ExecuteNonQuery();
        //                }
        //            }

        //            // Insertar registros en ProfesorCurso
        //            string queryInsertProfesorCurso = @"
        //        INSERT INTO ProfesorCurso (rutProfesor, idCurso)
        //        VALUES (@rut, (SELECT idCurso FROM Cursos WHERE nombreCurso = @curso))";
        //            foreach (string curso in cursos)
        //            {
        //                using (SqlCommand cmdInsertProfesorCurso = new SqlCommand(queryInsertProfesorCurso, con))
        //                {
        //                    cmdInsertProfesorCurso.Parameters.AddWithValue("@rut", rut);
        //                    cmdInsertProfesorCurso.Parameters.AddWithValue("@curso", curso);
        //                    cmdInsertProfesorCurso.ExecuteNonQuery();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al insertar los nuevos registros: " + ex.Message);
        //    }
        //}


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

                    string query = "SELECT nombre, apellido FROM Profesores WHERE rut = @rut";
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            LoadProfesorData();
        }
        private void LoadProfesorData()
        {
            string connectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            string query = @"
        SELECT 
            Profesores.rut, 
            Profesores.nombre + ' ' + Profesores.apellido AS 'NombreCompleto', 
            Materias.nombreMateria, 
            Cursos.nombreCurso 
        FROM 
            Profesores 
        INNER JOIN 
            ProfesorMateria ON Profesores.rut = ProfesorMateria.rutProfesor 
        INNER JOIN 
            Materias ON ProfesorMateria.idMateria = Materias.idMateria 
        INNER JOIN 
            ProfesorCurso ON Profesores.rut = ProfesorCurso.rutProfesor 
        INNER JOIN 
            Cursos ON ProfesorCurso.idCurso = Cursos.idCurso";

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
    }

    }
