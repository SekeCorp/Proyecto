using DGV2Printer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form13 : Form
    {
        private string path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
        private DataTable dt = new DataTable();
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            CargarEquiposPrestados();
            CargarDevoluciones();
        }

        private Dictionary<int, string> equiposPrestadosDict = new Dictionary<int, string>();

        private void CargarEquiposPrestados()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    string query = "SELECT Prestamos.equipo_id, Prestamos.rutProfesores " +
                                   "FROM Prestamos " +
                                   "INNER JOIN Equipos ON Prestamos.equipo_id = Equipos.id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    equiposPrestadosDict.Clear(); // Limpiamos el diccionario antes de llenarlo nuevamente

                    while (reader.Read())
                    {
                        int equipoId = Convert.ToInt32(reader["equipo_id"]);
                        string profesorRut = reader["rutProfesores"].ToString();
                        equiposPrestadosDict[equipoId] = profesorRut; // Agregar el equipo_id como clave y el profesor_rut como valor al diccionario
                    }

                    comboBoxDevolucion.DisplayMember = "equipo_id"; // Muestra solo el equipo_id en el ComboBox
                    comboBoxDevolucion.ValueMember = "equipo_id"; // Asigna el equipo_id como valor seleccionado en el ComboBox
                    comboBoxDevolucion.DataSource = equiposPrestadosDict.Keys.ToList();

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los equipos prestados: " + ex.Message);
            }
        }
        private DateTime? GetFechaDevolucionEquipo(string equipo_id, SqlConnection con)
        {
            string query = "SELECT fecha_devolucion FROM Prestamos WHERE equipo_id = @equipo_id";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@equipo_id", equipo_id);
                object result = cmd.ExecuteScalar();

                if (result is DateTime)
                {
                    DateTime fechaDevuelto = (DateTime)result;
                    return fechaDevuelto;
                }
                else
                {
                    return null;
                }
            }
        }

        private void CargarDevoluciones()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    string selectQuery = "SELECT * FROM Devoluciones";

                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect);
                        DataTable dtDevoluciones = new DataTable();
                        adapter.Fill(dtDevoluciones);

                        // Actualizar el DataGridView con los nuevos datos
                        dataGridView1.DataSource = dtDevoluciones;

                        // Asignar la tabla a una variable global para poder actualizarla en el botón de devolución
                        dt = dtDevoluciones;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las devoluciones: " + ex.Message);
            }
        }




        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDevolucion.SelectedItem != null)
                {
                    int equipo_id = Convert.ToInt32(comboBoxDevolucion.SelectedItem);

                    using (SqlConnection con = new SqlConnection(path))
                    {
                        con.Open();

                        // Realizar la devolución del equipo actualizando la tabla "Prestamos"
                        string query = "DELETE FROM Prestamos WHERE equipo_id = @equipo_id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@equipo_id", equipo_id);
                            cmd.ExecuteNonQuery();
                        }

                        // Obtener el profesor_rut del diccionario según el equipo_id seleccionado en el ComboBox
                        string profesorRut;
                        if (equiposPrestadosDict.TryGetValue(equipo_id, out profesorRut))
                        {
                            // Obtener los datos del equipo devuelto de la tabla "Equipos"
                            string queryEquipo = "SELECT nombre, numero_serie FROM Equipos WHERE id = @equipo_id";
                            string equipoNombre = string.Empty;
                            string equipoNumeroSerie = string.Empty;
                            using (SqlCommand cmdEquipo = new SqlCommand(queryEquipo, con))
                            {
                                cmdEquipo.Parameters.AddWithValue("@equipo_id", equipo_id);
                                SqlDataReader readerEquipo = cmdEquipo.ExecuteReader();

                                if (readerEquipo.Read())
                                {
                                    equipoNombre = readerEquipo["nombre"].ToString();
                                    equipoNumeroSerie = readerEquipo["numero_serie"].ToString();
                                }

                                readerEquipo.Close();
                            }

                            // Insertar los datos en la tabla "Devoluciones" y determinar el estado de devolución
                            DateTime fechaDevuelto = DateTime.Now.Date;

                            // Insertar los datos en la tabla "Devoluciones" con el estado adecuado
                            string insertQuery = "INSERT INTO Devoluciones (equipo_id, nombre, numero_serie, fecha_devuelto, rutProfesores) " +
                                                 "VALUES (@equipo_id, @nombre, @numero_serie, @fecha_devuelto, @rutProfesores)";
                            using (SqlCommand cmdInsert = new SqlCommand(insertQuery, con))
                            {
                                cmdInsert.Parameters.AddWithValue("@equipo_id", equipo_id);
                                cmdInsert.Parameters.AddWithValue("@nombre", equipoNombre);
                                cmdInsert.Parameters.AddWithValue("@numero_serie", equipoNumeroSerie);
                                cmdInsert.Parameters.AddWithValue("@fecha_devuelto", fechaDevuelto);
                                cmdInsert.Parameters.AddWithValue("@rutProfesores", profesorRut); // Utilizamos el profesor_rut obtenido del diccionario

                                cmdInsert.ExecuteNonQuery();
                            }

                            // Actualizar los datos en el DataGridView
                            CargarDevoluciones();

                            // Actualizar el ComboBox con los equipos prestados después de eliminar el equipo devuelto
                            CargarEquiposPrestados();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el equipo seleccionado en la base de datos.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún equipo para devolver.");
                }
                if (comboBoxDevolucion.SelectedItem != null)
                {
                    int equipo_id = Convert.ToInt32(comboBoxDevolucion.SelectedItem);

                    // Resto del código para realizar la devolución...
                    // Limpiar el ítem seleccionado en el comboBoxDevolucion
                    comboBoxDevolucion.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún equipo para devolver.");
                }
                textBox_rut.Clear();
                textBox_apellido.Clear();
                textBox_nombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la devolución: " + ex.Message);
            }

        }

        private void ActualizarDataGridView()
        {
            // Guardar la posición del DataGridView actualmente visible
            int rowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;

            // Actualizar los datos del DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;

            // Restaurar la posición del DataGridView
            if (rowIndex >= 0 && rowIndex < dataGridView1.RowCount)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
            }

            // Actualizar la visualización
            dataGridView1.Update();
            dataGridView1.Refresh();
        }


        // Métodos GetProfesorRutEquipo, GetNumeroSerieEquipo y GetFechaDevolucionEquipo no han sido modificados
        // ...



        private string GetNumeroSerieEquipo(string equipo_id, SqlConnection con)
        {
            string query = "SELECT numero_serie FROM Equipos WHERE id = @equipo_id";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@equipo_id", equipo_id);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }

        private void comboBoxDevolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDevolucion.SelectedItem != null)
            {
                int equipo_id = Convert.ToInt32(comboBoxDevolucion.SelectedItem);
                CargarDatosProfesor(equipo_id.ToString());
            }
        }
        private void CargarDatosProfesor(string equipo_id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    string selectQuery = "SELECT Profesores.rut, Profesores.nombre, Profesores.apellido " +
                                         "FROM Prestamos " +
                                         "INNER JOIN Profesores ON Prestamos.rutProfesores = Profesores.rut " +
                                         "WHERE Prestamos.equipo_id = @equipo_id";

                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, con))
                    {
                        cmdSelect.Parameters.AddWithValue("@equipo_id", equipo_id);
                        SqlDataReader reader = cmdSelect.ExecuteReader();

                        if (reader.Read())
                        {
                            textBox_rut.Text = reader["rut"].ToString();
                            textBox_nombre.Text = reader["nombre"].ToString();
                            textBox_apellido.Text = reader["apellido"].ToString();
                        }
                        else
                        {
                            textBox_rut.Text = string.Empty;
                            textBox_nombre.Text = string.Empty;
                            textBox_apellido.Text = string.Empty;
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del profesor: " + ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDataGridView print = new PrintDataGridView(dataGridView1);
            print.isRightToLeft = false;
            print.ReportHeader = "Devoluciones";
            print.Print();
        }
    }
}
