using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;

namespace Proyecto
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            cbx_Dia.SelectedIndexChanged += cbx_Dia_SelectedIndexChanged;

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // Cargar los RUTs en el ComboBox
            CargarRUTs();
        }

        private void CargarRUTs()
        {
            // Cadena de conexión a la base de datos
            string cadenaConexion = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

            // Consulta SQL para obtener los RUTs desde la tabla HorarioClases
            string consultaSql = "SELECT RUT FROM HorarioClases";

            // Crear la conexión y el comando
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
            {
                try
                {
                    // Abrir la conexión
                    conexion.Open();

                    // Ejecutar la consulta y obtener un lector de datos
                    SqlDataReader lector = comando.ExecuteReader();

                    // Usar un HashSet para almacenar los RUTs sin duplicados
                    HashSet<string> rutsUnicos = new HashSet<string>();

                    // Leer los RUTs y agregarlos al HashSet
                    while (lector.Read())
                    {
                        string rut = lector["RUT"].ToString();
                        rutsUnicos.Add(rut);
                    }

                    // Cerrar el lector de datos
                    lector.Close();

                    // Limpiar los items actuales del ComboBox
                    cbx_rut.Items.Clear();

                    // Agregar los RUTs únicos al ComboBox
                    foreach (string rutUnico in rutsUnicos)
                    {
                        cbx_rut.Items.Add(rutUnico);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los RUTs: " + ex.Message);
                }
            }
        }

        private void cbx_rut_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rutSeleccionado = cbx_rut.SelectedItem as string;

            if (rutSeleccionado != null)
            {
                string cadenaConexion = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                // Consulta SQL para obtener los idHorario según el RUT seleccionado en la tabla HorarioClases
                string consultaSqlIdHorario = "SELECT idHorario FROM HorarioClases WHERE RUT = @rut";

                // Consulta SQL para obtener los datos de periodo y día desde la tabla Disponible según el profesor_rut
                string consultaSqlDisponible = "SELECT DISTINCT Dias FROM Disponible WHERE profesor_rut = @profesor_rut";

                // Consulta SQL para obtener los datos de la tabla Curso
                string consultaSqlCursos = "SELECT DISTINCT curso FROM Curso";

                // Crear la conexión y el comando para obtener los idHorario
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                using (SqlCommand comandoIdHorario = new SqlCommand(consultaSqlIdHorario, conexion))
                using (SqlCommand comandoDisponible = new SqlCommand(consultaSqlDisponible, conexion))
                using (SqlCommand comandoCursos = new SqlCommand(consultaSqlCursos, conexion)) // Nueva consulta para obtener los cursos
                {
                    try
                    {
                        // Agregar el parámetro para el RUT seleccionado en la tabla HorarioClases
                        comandoIdHorario.Parameters.AddWithValue("@rut", rutSeleccionado);

                        // Agregar el parámetro para el profesor_rut en la tabla Disponible
                        comandoDisponible.Parameters.AddWithValue("@profesor_rut", rutSeleccionado);

                        // Abrir la conexión
                        conexion.Open();

                        // Ejecutar la consulta y obtener un lector de datos para los idHorario
                        SqlDataReader lectorIdHorario = comandoIdHorario.ExecuteReader();

                        // Limpiar el ComboBox cbx_idHorario antes de agregar los nuevos datos
                        cbx_idHorario.Items.Clear();

                        // Leer los idHorario y agregarlos al ComboBox
                        while (lectorIdHorario.Read())
                        {
                            int idHorario = Convert.ToInt32(lectorIdHorario["idHorario"]);
                            cbx_idHorario.Items.Add(idHorario);
                        }

                        // Cerrar el lector de datos de los idHorario
                        lectorIdHorario.Close();

                        // Ejecutar la consulta y obtener un lector de datos para los datos de Disponible y Cursos
                        SqlDataReader lectorDatos = comandoDisponible.ExecuteReader();

                        // Limpiar los ComboBox cbx_Periodo y cbx_Dia antes de agregar los nuevos datos
                        cbx_Periodo.Items.Clear();
                        cbx_Dia.Items.Clear();

                        // Limpiar el ComboBox cbx_Curso antes de agregar los nuevos datos
                        cbx_Curso.Items.Clear();

                        // Utilizar conjuntos HashSet para evitar repeticiones en los ComboBox de periodo y día
                        HashSet<string> periodosUnicos = new HashSet<string>();
                        HashSet<string> diasUnicos = new HashSet<string>();
                        // Utilizar un HashSet para evitar repeticiones en el ComboBox de cursos
                        HashSet<string> cursosUnicos = new HashSet<string>();

                        while (lectorDatos.Read())
                        {

                            string dias = lectorDatos["Dias"].ToString();


                            if (!string.IsNullOrEmpty(dias) && diasUnicos.Add(dias))
                            {
                                cbx_Dia.Items.Add(dias);
                            }
                        }

                        // Cerrar el lector de datos de Disponible y Cursos
                        lectorDatos.Close();

                        // Ejecutar la consulta y obtener un lector de datos para los datos de Curso
                        SqlDataReader lectorCursos = comandoCursos.ExecuteReader();

                        while (lectorCursos.Read())
                        {
                            string curso = lectorCursos["curso"].ToString();

                            if (!string.IsNullOrEmpty(curso) && cursosUnicos.Add(curso))
                            {
                                cbx_Curso.Items.Add(curso);
                            }
                        }

                        // Cerrar el lector de datos de Cursos
                        lectorCursos.Close();

                        // Cerrar la conexión
                        conexion.Close();

                        // Una vez que hemos cargado los idHorario y los datos de periodo y día, llamamos a la función para cargar los datos en el DataGridView
                        CargarDatosDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los datos: " + ex.Message);
                    }
                }
            }
        }


        private bool PeriodoEstaAsignado(int idHorarioActual, string periodoSeleccionado, string diasSeleccionados)
        {
            try
            {
                string cadenaConexion = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Consulta SQL para verificar si el periodo y día ya están asignados a otro idHorario
                    string consultaSql = "SELECT COUNT(*) FROM HorarioClases WHERE idHorario != @idHorario AND Periodo = @periodo AND Dias = @dias";

                    using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                    {
                        // Agregar los parámetros para el idHorario actual, el periodo seleccionado y el día seleccionado
                        comando.Parameters.AddWithValue("@idHorario", idHorarioActual);
                        comando.Parameters.AddWithValue("@periodo", periodoSeleccionado);
                        comando.Parameters.AddWithValue("@dias", diasSeleccionados);

                        // Ejecutar la consulta y obtener el resultado (número de coincidencias)
                        int count = Convert.ToInt32(comando.ExecuteScalar());

                        // Si el resultado es mayor que cero, significa que el periodo y día ya están asignados a otro idHorario
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el periodo y día: " + ex.Message);
                return false;
            }
        }


        private void cbx_idHorario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(cbx_idHorario.SelectedItem?.ToString(), out int idHorario))
            {
                idHorarioSeleccionado = idHorario;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (idHorarioSeleccionado == -1)
            {
                MessageBox.Show("Debe seleccionar un idHorario antes de confirmar los cambios.");
                return;
            }

            string periodoSeleccionado = cbx_Periodo.SelectedItem as string;
            string cursoSeleccionado = cbx_Curso.SelectedItem as string;
            string diasSeleccionados = cbx_Dia.SelectedItem as string;

            if (periodoSeleccionado == null || cursoSeleccionado == null || diasSeleccionados == null)
            {
                MessageBox.Show("Debe seleccionar valores válidos para Periodo, Curso y Día antes de confirmar los cambios.");
                return;
            }

            // Validar si el periodo y día ya están asignados a otro idHorario
            if (PeriodoEstaAsignado(idHorarioSeleccionado, periodoSeleccionado, diasSeleccionados))
            {
                MessageBox.Show("El periodo y día seleccionados ya están asignados a otro idHorario. Seleccione otro periodo o día.");
                return;
            }

            // Actualizar los datos en la base de datos
            ActualizarHorario(idHorarioSeleccionado, periodoSeleccionado, cursoSeleccionado, diasSeleccionados);

            // Cargar nuevamente los datos de la tabla HorarioClases en el DataGridView
            CargarDatosDataGridView();

            // Limpiar los ComboBox
            cbx_Periodo.SelectedIndex = -1;
            cbx_Curso.SelectedIndex = -1;
            cbx_Dia.SelectedIndex = -1;

            // Reiniciar el valor de idHorarioSeleccionado
            idHorarioSeleccionado = -1;

            MessageBox.Show("Cambios confirmados correctamente.");
        }


        private void ActualizarHorario(int idHorario, string periodo, string curso, string dias)
        {
            try
            {
                string cadenaConexion = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Consulta SQL para actualizar los datos en la tabla HorarioClases
                    string consultaSql = "UPDATE HorarioClases SET Periodo = @periodo, Curso = @curso, Dias = @dias WHERE idHorario = @idHorario";

                    using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                    {
                        // Agregar los parámetros
                        comando.Parameters.AddWithValue("@idHorario", idHorario);
                        comando.Parameters.AddWithValue("@periodo", periodo);
                        comando.Parameters.AddWithValue("@curso", curso);
                        comando.Parameters.AddWithValue("@dias", dias);

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message);
            }
        }

       

        private void CargarDatosDataGridView()
        {
            try
            {
                string cadenaConexion = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Obtener el RUT seleccionado en el ComboBox cbx_Rut
                    string rutSeleccionado = cbx_rut.SelectedItem as string;

                    // Consulta SQL para obtener los datos de la tabla HorarioClases según el RUT seleccionado
                    string consultaSql = "SELECT * FROM HorarioClases WHERE RUT = @rut";

                    using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                    {
                        // Agregar el parámetro para el RUT seleccionado en la consulta
                        comando.Parameters.AddWithValue("@rut", rutSeleccionado);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            // Crear un objeto DataTable para almacenar los datos
                            DataTable dtHorarioClases = new DataTable();
                            adaptador.Fill(dtHorarioClases);

                            // Asignar el DataTable como origen de datos del DataGridView
                            dataGridView1.DataSource = dtHorarioClases;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void cbx_idHorario_DropDownClosed(object sender, EventArgs e)
        {
            int idHorarioSeleccionado;
            if (int.TryParse(cbx_idHorario.SelectedItem?.ToString(), out idHorarioSeleccionado))
            {

                string cadenaConexion = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                // Obtener el RUT seleccionado en el ComboBox cbx_rut
                string rutSeleccionado = cbx_rut.SelectedItem as string;

                // Consulta SQL para obtener los datos desde la tabla Disponible según el idHorario seleccionado y el RUT
                string consultaSqlDisponible = "SELECT DISTINCT Dias, Periodo FROM Disponible WHERE profesor_rut = @rut AND idHorario = @idHorario";

                // Crear la conexión y el comando para obtener los datos de Disponible
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                using (SqlCommand comandoDisponible = new SqlCommand(consultaSqlDisponible, conexion))
                {
                    try
                    {
                        // Agregar los parámetros para el idHorario y el RUT seleccionados en la consulta de Disponible
                        comandoDisponible.Parameters.AddWithValue("@idHorario", idHorarioSeleccionado);
                        comandoDisponible.Parameters.AddWithValue("@rut", rutSeleccionado);

                        // Abrir la conexión
                        conexion.Open();

                        // Ejecutar la consulta y obtener un lector de datos para Disponible
                        SqlDataReader lectorDisponible = comandoDisponible.ExecuteReader();

                        // Leer los datos y actualizar los ComboBox correspondientes con los datos de Disponible
                        while (lectorDisponible.Read())
                        {
                            cbx_Dia.Items.Add(lectorDisponible["Dias"].ToString());
                            cbx_Periodo.Items.Add(lectorDisponible["Periodo"].ToString());
                        }

                        // Cerrar el lector de datos de Disponible
                        lectorDisponible.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los datos: " + ex.Message);
                    }
                }
            }
        }

        private int idHorarioSeleccionado = -1;

        private void cbx_Dia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el día seleccionado en el ComboBox cbx_Dia
            string diaSeleccionado = cbx_Dia.SelectedItem as string;

            if (diaSeleccionado != null)
            {
                // Limpiar el ComboBox cbx_Periodo antes de agregar los nuevos datos
                cbx_Periodo.Items.Clear();

                // Obtener el RUT seleccionado en el ComboBox cbx_rut
                string rutSeleccionado = cbx_rut.SelectedItem as string;

                // Consulta SQL para obtener los periodos desde la tabla Disponible según el RUT y el día seleccionados
                string consultaSqlPeriodo = "SELECT DISTINCT Periodo FROM Disponible WHERE profesor_rut = @rut AND Dias = @dia";

                // Cadena de conexión a la base de datos
                string cadenaConexion = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

                // Crear la conexión y el comando para obtener los periodos
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                using (SqlCommand comandoPeriodo = new SqlCommand(consultaSqlPeriodo, conexion))
                {
                    try
                    {
                        // Agregar los parámetros para el RUT y el día seleccionados en la consulta de periodos
                        comandoPeriodo.Parameters.AddWithValue("@rut", rutSeleccionado);
                        comandoPeriodo.Parameters.AddWithValue("@dia", diaSeleccionado);

                        // Abrir la conexión
                        conexion.Open();

                        // Ejecutar la consulta y obtener un lector de datos para los periodos
                        SqlDataReader lectorPeriodo = comandoPeriodo.ExecuteReader();

                        // Utilizar un conjunto HashSet para evitar repeticiones en el ComboBox de periodos
                        HashSet<string> periodosUnicos = new HashSet<string>();

                        // Leer los periodos y agregarlos al ComboBox
                        while (lectorPeriodo.Read())
                        {
                            string periodo = lectorPeriodo["Periodo"].ToString();

                            if (!string.IsNullOrEmpty(periodo) && periodosUnicos.Add(periodo))
                            {
                                cbx_Periodo.Items.Add(periodo);
                            }
                        }

                        // Cerrar el lector de datos de periodos
                        lectorPeriodo.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los periodos: " + ex.Message);
                    }
                }
            }
        }
    }
}
