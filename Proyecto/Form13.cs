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

        private void CargarDevoluciones()
        {
            dataGridView1.Columns.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    string selectQuery = "SELECT equipo_id, nombre, numero_serie, fecha_devuelto FROM Devoluciones";

                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect);
                        DataTable dtDevoluciones = new DataTable();
                        adapter.Fill(dtDevoluciones);

                        // Añadir una columna "Estado" al DataTable si no existe
                        if (!dtDevoluciones.Columns.Contains("Estado"))
                            dtDevoluciones.Columns.Add("Estado", typeof(string));

                        // Añadir una columna "profesor_rut" al DataTable si no existe
                        if (!dtDevoluciones.Columns.Contains("profesor_rut"))
                            dtDevoluciones.Columns.Add("profesor_rut", typeof(string));

                        foreach (DataRow row in dtDevoluciones.Rows)
                        {
                            DateTime? fechaDevuelto = row.Field<DateTime?>("fecha_devuelto");
                            int equipo_id = Convert.ToInt32(row["equipo_id"]); // Convertir a int aquí

                            // Verificar si la fecha_devuelto es NULL y establecer "Pendiente" como Estado
                            if (fechaDevuelto == null || fechaDevuelto == DateTime.MinValue)
                            {
                                row["Estado"] = "Pendiente";
                            }
                            else
                            {
                                DateTime fechaLimite = GetFechaDevolucionEquipo(equipo_id.ToString(), con).Value;
                                string estado = (fechaDevuelto <= fechaLimite.Date) ? "Correcto" : "Retrasado";
                                row["Estado"] = estado;
                            }

                            // Obtener el profesor_rut del equipo devuelto de la tabla "Prestamos"
                            string profesor_rut = GetProfesorRutEquipo(equipo_id, con);

                            // Verificar si el profesor_rut obtenido no es nulo o vacío antes de asignarlo
                            if (!string.IsNullOrEmpty(profesor_rut))
                            {
                                row["profesor_rut"] = profesor_rut;
                            }
                        }

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

                        // Antes de eliminar el préstamo, obtener la fecha de devolución del equipo
                        SqlDateTime fechaDevuelto = GetFechaDevolucionEquipo(equipo_id.ToString(), con);

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

                            // Determinar el estado de devolución
                            string estado = "Pendiente";
                            if (fechaDevuelto != SqlDateTime.MinValue)
                            {
                                DateTime fechaLimite = fechaDevuelto.Value;
                                DateTime fechaActual = DateTime.Today;
                                estado = (fechaActual <= fechaLimite) ? "Correcto" : "Retrasado";
                            }

                            // Obtener el RUT del equipo devuelto de la tabla "Prestamos"
                            string profesor_rut = GetProfesorRutEquipo(equipo_id, con);

                            // Verificar si el RUT existe en la tabla "Profesor"
                            string queryProfesor = "SELECT COUNT(*) FROM Profesor WHERE rut = @profesor_rut";
                            using (SqlCommand cmdProfesor = new SqlCommand(queryProfesor, con))
                            {
                                cmdProfesor.Parameters.AddWithValue("@profesor_rut", profesor_rut);
                                int count = Convert.ToInt32(cmdProfesor.ExecuteScalar());

                                if (count == 0)
                                {
                                    // El RUT no existe en la tabla "Profesor", mostrar mensaje de error y no realizar la inserción
                                    MessageBox.Show("El RUT del profesor asociado al equipo no existe en la base de datos.");
                                    return;
                                }
                            }

                            // Insertar los datos en la tabla "Devoluciones" con el estado adecuado
                            string insertQuery = "INSERT INTO Devoluciones (equipo_id, nombre, numero_serie, fecha_devuelto, estado, profesor_rut) " +
                                                 "VALUES (@equipo_id, @nombre, @numero_serie, @fecha_devuelto, @estado, @profesor_rut)";
                            using (SqlCommand cmdInsert = new SqlCommand(insertQuery, con))
                            {
                                cmdInsert.Parameters.AddWithValue("@equipo_id", equipo_id);
                                cmdInsert.Parameters.AddWithValue("@nombre", equipoNombre);
                                cmdInsert.Parameters.AddWithValue("@numero_serie", equipoNumeroSerie);
                                cmdInsert.Parameters.AddWithValue("@fecha_devuelto", fechaDevuelto);
                                cmdInsert.Parameters.AddWithValue("@estado", estado);
                                cmdInsert.Parameters.AddWithValue("@profesor_rut", profesor_rut);

                                cmdInsert.ExecuteNonQuery();
                            }

                            // Actualizar los datos en el DataGridView
                            CargarDevoluciones();
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



        private string GetProfesorRutEquipo(int equipo_id, SqlConnection con)
        {
            string query = "SELECT profesor_rut FROM Prestamos WHERE equipo_id = @equipo_id";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@equipo_id", equipo_id);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    string profesor_rut = result.ToString();
                    // Agregar mensaje de depuración para verificar el valor del RUT obtenido
                    Console.WriteLine($"Equipo ID: {equipo_id}, Profesor RUT: {profesor_rut}");
                    return profesor_rut;
                }
                else
                {
                    // El profesor_rut no se encontró en la tabla "Prestamos" para el equipo dado.
                    return string.Empty;
                }
            }
        }

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

        private SqlDateTime GetFechaDevolucionEquipo(string equipo_id, SqlConnection con)
        {
            string query = "SELECT fecha_devolucion FROM Prestamos WHERE equipo_id = @equipo_id";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@equipo_id", equipo_id);
                object result = cmd.ExecuteScalar();

                if (result is DateTime)
                {
                    DateTime fechaDevuelto = (DateTime)result;
                    return new SqlDateTime(fechaDevuelto);
                }
                else
                {
                    return SqlDateTime.MinValue;
                }
            }
        }
    }
}
