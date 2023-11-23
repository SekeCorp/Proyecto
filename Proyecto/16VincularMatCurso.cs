using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form16 : Form
    {
        private List<string> materias;
        private List<string> cursos;
        private string rutProfesor;
        private string nombreProfesor;
        private string apellidoProfesor;

        public Form16(List<string> selectedMaterias, List<string> selectedCursos, string rut, string nombre, string apellido)
        {
            InitializeComponent();
            materias = selectedMaterias;
            cursos = selectedCursos;
            rutProfesor = rut;
            nombreProfesor = nombre;
            apellidoProfesor = apellido;
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            LoadMaterias(materias);
            LoadCursos(cursos);
        }

        public void LoadMaterias(List<string> materias)
        {
            foreach (string materia in materias)
            {
                materiacbx.Items.Add(materia);
            }
            if (materiacbx.Items.Count > 0)
            {
                materiacbx.SelectedIndex = 0;
            }
        }

        public void LoadCursos(List<string> cursos)
        {
            foreach (string curso in cursos)
            {
                cursocbx.Items.Add(curso);
            }
            if (cursocbx.Items.Count > 0)
            {
                cursocbx.SelectedIndex = 0;
            }
        }

        private void insertarbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                string queryProfesor = @"
                    IF NOT EXISTS (SELECT 1 FROM Profesores WHERE rut = @rut)
                    BEGIN
                        INSERT INTO Profesores (rut, nombre, apellido)
                        VALUES (@rut, @nombre, @apellido)
                    END";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Inserta el profesor si no existe.
                    using (SqlCommand command = new SqlCommand(queryProfesor, conn))
                    {
                        command.Parameters.AddWithValue("@rut", rutProfesor);
                        command.Parameters.AddWithValue("@nombre", nombreProfesor);
                        command.Parameters.AddWithValue("@apellido", apellidoProfesor);
                        command.ExecuteNonQuery();
                    }

                    // Obtén la materia y el curso seleccionados de los comboboxes.
                    string selectedMateria = materiacbx.SelectedItem.ToString();
                    string selectedCurso = cursocbx.SelectedItem.ToString();

                    // Inserta en ProfesorMateria si no existe.
                    string queryMateria = @"
                        IF NOT EXISTS (SELECT 1 FROM ProfesorMateria WHERE rutProfesor = @rut AND idMateria = (SELECT idMateria FROM Materias WHERE nombreMateria = @materia))
                        BEGIN
                            INSERT INTO ProfesorMateria (rutProfesor, idMateria)
                            VALUES (@rut, (SELECT idMateria FROM Materias WHERE nombreMateria = @materia))
                        END";

                    using (SqlCommand commandMateria = new SqlCommand(queryMateria, conn))
                    {
                        commandMateria.Parameters.AddWithValue("@rut", rutProfesor);
                        commandMateria.Parameters.AddWithValue("@materia", selectedMateria);
                        commandMateria.ExecuteNonQuery();
                    }

                    // Inserta en ProfesorCurso si no existe.
                    string queryCurso = @"
                        IF NOT EXISTS (SELECT 1 FROM ProfesorCurso WHERE rutProfesor = @rut AND idCurso = (SELECT idCurso FROM Cursos WHERE nombreCurso = @curso))
                        BEGIN
                            INSERT INTO ProfesorCurso (rutProfesor, idCurso)
                            VALUES (@rut, (SELECT idCurso FROM Cursos WHERE nombreCurso = @curso))
                        END";

                    using (SqlCommand commandCurso = new SqlCommand(queryCurso, conn))
                    {
                        commandCurso.Parameters.AddWithValue("@rut", rutProfesor);
                        commandCurso.Parameters.AddWithValue("@curso", selectedCurso);
                        commandCurso.ExecuteNonQuery();
                    }

                    // Inserta en MateriaCurso si no existe la combinación de materia y curso.
                    string queryMateriaCurso = @"
                        IF NOT EXISTS (SELECT 1 FROM MateriaCurso WHERE idMateria = (SELECT idMateria FROM Materias WHERE nombreMateria = @materia) AND idCurso = (SELECT idCurso FROM Cursos WHERE nombreCurso = @curso) AND rutProfesor = @rut)
                        BEGIN
                            INSERT INTO MateriaCurso (idMateria, idCurso, rutProfesor)
                            VALUES ((SELECT idMateria FROM Materias WHERE nombreMateria = @materia), (SELECT idCurso FROM Cursos WHERE nombreCurso = @curso), @rut)
                        END";

                    using (SqlCommand commandMateriaCurso = new SqlCommand(queryMateriaCurso, conn))
                    {
                        commandMateriaCurso.Parameters.AddWithValue("@materia", selectedMateria);
                        commandMateriaCurso.Parameters.AddWithValue("@curso", selectedCurso);
                        commandMateriaCurso.Parameters.AddWithValue("@rut", rutProfesor);
                        commandMateriaCurso.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos insertados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
