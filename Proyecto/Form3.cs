using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cURSOS.Curso' Puede moverla o quitarla según sea necesario.
            this.cursoTableAdapter.Fill(this.cURSOS.Curso);
            // TODO: esta línea de código carga datos en la tabla 'mATERIAS.Materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.mATERIAS.Materias);

        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                string rut = txtRut.Text;
                string nombre = txtNombreIngPro.Text;
                string apellido = txtApellidoPro.Text;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Iniciar una transacción SQL
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Insertar en Profesor
                            string queryProfesor = "INSERT INTO Profesor (rut, nombre, apellido) VALUES (@rut, @nombre, @apellido)";
                            using (SqlCommand cmdProfesor = new SqlCommand(queryProfesor, con, transaction))
                            {
                                cmdProfesor.Parameters.AddWithValue("@rut", rut);
                                cmdProfesor.Parameters.AddWithValue("@nombre", nombre);
                                cmdProfesor.Parameters.AddWithValue("@apellido", apellido);

                                cmdProfesor.ExecuteNonQuery();
                            }

                            // Insertar en ProfesorMateria
                            foreach (string materia in listMateria.SelectedItems)
                            {
                                string queryProfesorMateria = "INSERT INTO ProfesorMateria (rut, idMateria) VALUES (@rut, @idMateria)";
                                using (SqlCommand cmdProfesorMateria = new SqlCommand(queryProfesorMateria, con, transaction))
                                {
                                    cmdProfesorMateria.Parameters.AddWithValue("@rut", rut);
                                    cmdProfesorMateria.Parameters.AddWithValue("@nombreMateria", materia); // Directamente el nombre de la materia

                                    cmdProfesorMateria.ExecuteNonQuery();
                                }
                            }

                            // Insertar en ProfesorCurso
                            foreach (string curso in listCurso.SelectedItems)
                            {
                                string queryProfesorCurso = "INSERT INTO ProfesorCurso (rut, idCurso) VALUES (@rut, @idCurso)";
                                using (SqlCommand cmdProfesorCurso = new SqlCommand(queryProfesorCurso, con, transaction))
                                {
                                    cmdProfesorCurso.Parameters.AddWithValue("@rut", rut);
                                    cmdProfesorCurso.Parameters.AddWithValue("@idCurso", curso); // Directamente el nombre del curso

                                    cmdProfesorCurso.ExecuteNonQuery();
                                }
                            }

                            // Si todo va bien, commit de la transacción
                            transaction.Commit();
                            MessageBox.Show("Profesor y sus materias y cursos agregados correctamente");
                        }
                        catch (Exception ex)
                        {
                            // Si algo sale mal, rollback de la transacción
                            transaction.Rollback();
                            MessageBox.Show("Error al agregar el registro: " + ex.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
