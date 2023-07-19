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

        private void CargarEquiposPrestados()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    string query = "SELECT Prestamos.equipo_id, Prestamos.profesor_rut, Equipos.nombre, Equipos.numero_serie " +
                                   "FROM Prestamos " +
                                   "INNER JOIN Equipos ON Prestamos.equipo_id = Equipos.id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dtEquiposPrestados = new DataTable();
                    dtEquiposPrestados.Load(reader);

                    comboBoxDevolucion.DisplayMember = "equipo_id";
                    comboBoxDevolucion.ValueMember = "equipo_id";
                    comboBoxDevolucion.DataSource = dtEquiposPrestados;

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
            dataGridView1.Columns.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    string selectQuery = "SELECT Devoluciones.equipo_id, Equipos.nombre, Equipos.numero_serie, Devoluciones.fecha_devuelto " +
                                         "FROM Devoluciones " +
                                         "INNER JOIN Equipos ON Devoluciones.equipo_id = Equipos.id";

                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect);
                        DataTable dtDevoluciones = new DataTable();
                        adapter.Fill(dtDevoluciones);

                        // Actualizar el DataGridView con los nuevos datos
                        dataGridView1.DataSource = dtDevoluciones;
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
                    DataRowView selectedRow = (DataRowView)comboBoxDevolucion.SelectedItem;
                    int equipo_id = Convert.ToInt32(selectedRow["equipo_id"]);
                    string query = "DELETE FROM Prestamos WHERE equipo_id = @equipo_id";

                    using (SqlConnection con = new SqlConnection(path))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@equipo_id", equipo_id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Devolución realizada con éxito.");

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

                            // Obtener la fecha_devolucion del equipo prestado de la tabla "Prestamos"
                            DateTime? fechaPrestamo = GetFechaDevolucionEquipo(equipo_id.ToString(), con);

                            // Insertar los datos en la tabla "Devoluciones" y determinar el estado de devolución
                            DateTime fechaDevuelto = DateTime.Now.Date;
                            DateTime? fechaLimite = fechaPrestamo;


                            // Insertar los datos en la tabla "Devoluciones" con el estado adecuado
                            string insertQuery = "INSERT INTO Devoluciones (equipo_id, nombre, numero_serie, fecha_devuelto) " +
                                                 "VALUES (@equipo_id, @nombre, @numero_serie, @fecha_devuelto)";
                            using (SqlCommand cmdInsert = new SqlCommand(insertQuery, con))
                            {
                                cmdInsert.Parameters.AddWithValue("@equipo_id", equipo_id);
                                cmdInsert.Parameters.AddWithValue("@nombre", equipoNombre);
                                cmdInsert.Parameters.AddWithValue("@numero_serie", equipoNumeroSerie);
                                cmdInsert.Parameters.AddWithValue("@fecha_devuelto", fechaDevuelto);
                                cmdInsert.ExecuteNonQuery();
                            }

                            // Actualizar los datos en el DataGridView
                            CargarDevoluciones();

                            // Actualizar el ComboBox con los equipos prestados después de eliminar el equipo devuelto
                            CargarEquiposPrestados();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún equipo para devolver.");
                }
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

    }
}
