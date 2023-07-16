﻿using System;
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
                MessageBox.Show("LA FECHA DE PESTAMO NO DEBE SER MAYOR A LA DE DEVOLUCIÒN O REVERSA");
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
            String Consulta = "select * from Profesor where rut= "+comboBox_RUT.Text+"";
            SqlCommand comando = new SqlCommand(Consulta,con);
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
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet6.Profesor' Puede moverla o quitarla según sea necesario.
            this.profesorTableAdapter.Fill(this.proyectoDataSet6.Profesor);

            string path;
            DataTable dt = new DataTable();
            path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
            //path = "Data Source=DESKTOP-R338P94\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";
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
        }
        List<string> idsPrestados = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path, query, profesor_rut;
                string equipo_id = comboID_Equipos.Text;
                DateTime fecha_p, fecha_d;
                DataTable dt = new DataTable();
                path = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";
                profesor_rut = comboBox_RUT.Text;
                equipo_id = comboID_Equipos.Text;
                fecha_p = dtp_Fecha_P.Value;
                fecha_d = dtp_Fecha_D.Value;

                if (idsPrestados.Contains(equipo_id))
                {
                    MessageBox.Show("El Equipo ya ha sido prestado.");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(path))
                    {
                        con.Open();

                        query = "INSERT INTO Prestamos (equipo_id, profesor_rut, fecha_prestamo, fecha_devolucion) VALUES (@equipo_id, @profesor_rut, @fecha_prestamo, @fecha_devolucion)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@equipo_id", equipo_id);
                            cmd.Parameters.AddWithValue("@profesor_rut", profesor_rut);
                            cmd.Parameters.AddWithValue("@fecha_prestamo", fecha_p);
                            cmd.Parameters.AddWithValue("@fecha_devolucion", fecha_d);

                            cmd.ExecuteNonQuery();

                            idsPrestados.Add(equipo_id); // Agregar el ID prestado a la lista

                            MessageBox.Show("Prestamo OK");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex);
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
                dt.Columns.Add("profesor_rut");
                dt.Columns.Add("fecha_prestamo");
                dt.Columns.Add("fecha_devolucion");
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = dr["ID"];
                    row["equipo_id"] = dr["equipo_id"];
                    row["profesor_rut"] = dr["profesor_rut"];
                    row["fecha_prestamo"] = dr["fecha_prestamo"];
                    row["fecha_devolucion"] = dr["fecha_devolucion"];
                    dt.Rows.Add(row);
                }
                dataGridView1.DataSource = dt;

                con.Close();

                //// Cargar los IDs de equipos prestados en el comboBoxDevolucion
                //DataTable dtEquiposPrestados = new DataTable();
                //query = "SELECT DISTINCT equipo_id FROM Prestamos";
                //SqlCommand cmdEquipos = new SqlCommand(query, con);
                //con.Open();
                //dtEquiposPrestados.Load(cmdEquipos.ExecuteReader());
                //comboBoxDevolucion.DataSource = dtEquiposPrestados;
                //comboBoxDevolucion.DisplayMember = "equipo_id";
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los registros: " + ex.Message);
            }
        }

       

        private void ActualizarDataGridView1()
        {
            string query = "SELECT * FROM Prestamos";
            SqlDataAdapter adapter = new SqlDataAdapter(query, path);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }




    }
}
