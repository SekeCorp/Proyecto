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
    public partial class IngresoProfesor : Form
    {
        public IngresoProfesor()
        {
            InitializeComponent();
            btnConfirmar.Click += btnConfirmar_Click;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cursos._Cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.cursos._Cursos);
            // TODO: esta línea de código carga datos en la tabla 'materiaid.Materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.materiaid.Materias);
            // TODO: esta línea de código carga datos en la tabla 'cursos._Cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.cursos._Cursos);


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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            List<string> selectedMaterias = listMateria.SelectedItems.Cast<DataRowView>()
                                   .Select(item => item["nombreMateria"].ToString())
                                   .ToList();

            // Capturar los elementos seleccionados de listCurso
            List<string> selectedCursos = listCurso.SelectedItems.Cast<DataRowView>()
                                          .Select(item => item["nombreCurso"].ToString())
                                          .ToList();
            string rut = txtRut.Text;
            string nombre = txtNombreIngPro.Text;
            string apellido = txtApellidoPro.Text;

            // Crear y mostrar Form16 pasando los elementos seleccionados de materias y cursos
            Form16 f16 = new Form16 (selectedMaterias, selectedCursos, rut, nombre, apellido);
            f16.Show();

        }
        
       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            LoadProfesorData();
        }
    }
}
