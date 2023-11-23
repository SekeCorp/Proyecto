using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form8 : Form
    {
        private string path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
        public Form8()
        {
            InitializeComponent();
            Load += Form8_Load;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime fec = DateTime.Now;
            DateTime fecdev = dtp_Fecha_D.Value;
            DateTime fecpre = dtp_Fecha_P.Value;

            if (fecpre > fecdev)
            {
                MessageBox.Show("LA FECHA DE PRESTAMO NO DEBE SER MAYOR A LA DE DEVOLUCIÒN O REVERSA");
                dtp_Fecha_P.Value = DateTime.Now;
                dtp_Fecha_D.Value = DateTime.Now;
            }
            else
            {
                TimeSpan x = (fecdev - fecpre);
                int numDias = x.Days + 1;
                txtDias_P.Text = numDias.ToString();  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            DataTable dt = new DataTable();
            path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con.Open();

            // Usar parámetros en la consulta para evitar problemas de inyección de SQL
            string consulta = "SELECT * FROM Profesores WHERE rut = @rut";
            SqlCommand comando = new SqlCommand(consulta, con);

            // Asignar el valor del RUT al parámetro
            comando.Parameters.AddWithValue("@rut", comboBox_RUT.Text);

            SqlDataReader leer;
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                textBox2.Text = leer["nombre"].ToString();
                textBox3.Text = leer["apellido"].ToString();
            }
            con.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet23.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter3.Fill(this.proyectoDataSet23.Prestamos);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet23.Profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter1.Fill(this.proyectoDataSet23.Profesores);

            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet21.Equipos' Puede moverla o quitarla según sea necesario.
            this.equiposTableAdapter.Fill(this.proyectoDataSet21.Equipos);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet21.Profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this.proyectoDataSet21.Profesores);


            // Limpiar los elementos del ComboBox antes de cargar los nuevos datos
            comboID_Equipos.Items.Clear();

            string path;
            DataTable dt = new DataTable();
            path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            String Consulta = "select id from Equipos";
            SqlCommand comando = new SqlCommand(Consulta, con);
            SqlDataReader reg;
            reg = comando.ExecuteReader();
            while (reg.Read())
            {
                comboID_Equipos.Items.Add(reg["id"].ToString());
            }

            con.Close();
        }

        List<string> idsPrestados = new List<string>();


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path, query, profesor_rut;
                string equipo_id = comboID_Equipos.Text;
                DateTime fecha_p, fecha_d;
                int diasPrestados;
                DataTable dt = new DataTable();
                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                profesor_rut = comboBox_RUT.Text;
                equipo_id = comboID_Equipos.Text;
                fecha_p = dtp_Fecha_P.Value;
                fecha_d = dtp_Fecha_D.Value;
                diasPrestados = int.Parse(txtDias_P.Text);

                if (idsPrestados.Contains(equipo_id))
                {
                    MessageBox.Show("El Equipo ya ha sido prestado.");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(path))
                    {
                        con.Open();

                        // Insertar los datos en la tabla "Prestamos" con el valor de "Días Prestados"
                        query = "INSERT INTO Prestamos (equipo_id, rutProfesores, fecha_prestamo, fecha_devolucion, dias_prestados) " +
                                "VALUES (@equipo_id, @profesor_rut, @fecha_prestamo, @fecha_devolucion, @dias_prestados)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@equipo_id", equipo_id);
                            cmd.Parameters.AddWithValue("@profesor_rut", profesor_rut);
                            cmd.Parameters.AddWithValue("@fecha_prestamo", fecha_p);
                            cmd.Parameters.AddWithValue("@fecha_devolucion", fecha_d);
                            cmd.Parameters.AddWithValue("@dias_prestados", diasPrestados);

                            cmd.ExecuteNonQuery();

                            idsPrestados.Add(equipo_id); // Agregar el ID prestado a la lista

                            MessageBox.Show("Préstamo OK");
                        }
                    }

                    // Actualizar el DataGridView con los nuevos datos después de la inserción
                    ActualizarDataGridView1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
        }








        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path, query;
                DataTable dt = new DataTable();
                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                //path = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";
                SqlDataReader dr;
                SqlConnection con = new SqlConnection(path);
                query = "Select*from Prestamos";
                SqlCommand cmd = new SqlCommand(query, con);
                dt.Columns.Add("ID");
                dt.Columns.Add("equipo_id");
                dt.Columns.Add("rutProfesores");
                dt.Columns.Add("fecha_prestamo");
                dt.Columns.Add("fecha_devolucion");
                dt.Columns.Add("dias_prestados");
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = dr["ID"];
                    row["equipo_id"] = dr["equipo_id"];
                    row["rutProfesores"] = dr["rutProfesores"];
                    row["fecha_prestamo"] = dr["fecha_prestamo"];
                    row["fecha_devolucion"] = dr["fecha_devolucion"];
                    row["dias_prestados"] = dr["dias_prestados"];
                    dt.Rows.Add(row);
                }
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los registros: " + ex.Message);
            }
        }



        private void ActualizarDataGridView1()
        {
            try
            {
                string query = "SELECT * FROM Prestamos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, path);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Eliminar la columna "Dias Prestados" si ya existe en el DataTable
                if (dt.Columns.Contains("Dias Prestados"))
                {
                    dt.Columns.Remove("Dias Prestados");
                }

                // Agregar nuevamente la columna "Dias Prestados" al DataTable
                dt.Columns.Add("Dias Prestados", typeof(int));

                // Actualizar el valor de la columna "Dias Prestados" en el DataTable
                foreach (DataRow row in dt.Rows)
                {
                    DateTime fechaPrestamo = Convert.ToDateTime(row["fecha_prestamo"]);
                    DateTime fechaDevolucion = Convert.ToDateTime(row["fecha_devolucion"]);
                    int diasPrestados = (fechaDevolucion - fechaPrestamo).Days + 1;
                    row["Dias Prestados"] = diasPrestados;
                }

                // Antes de asignar el DataSource, agregamos la columna "Dias Prestados" al DataGridView
                if (!dataGridView1.Columns.Contains("Dias Prestados"))
                {
                    dataGridView1.Columns.Add("Dias Prestados", "Dias Prestados");
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los registros: " + ex.Message);
            }
        }

        private void comboID_Equipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
