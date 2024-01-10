using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proyecto
{
    public partial class Form15 : Form
    {
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;
        private string connectionString = "Data Source=LAPTOP-HP6EH3TV\\SQLEXPRESS01;Initial Catalog=Proyecto;Integrated Security=True";

        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // Llenar el DataGridView con datos de la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM HorarioClases";
                dataAdapter = new SqlDataAdapter(query, connection);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
            }

            dataGridView1.DataSource = dataTable;

            // Llenar comboBoxId con valores de idHorario
            foreach (DataRow row in dataTable.Rows)
            {
                comboBoxId.Items.Add(row["idHorario"]);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Verificar si idHorario ha cambiado
                        if (row.RowState == DataRowState.Modified && row.HasVersion(DataRowVersion.Original) && !row["idHorario", DataRowVersion.Original].Equals(row["idHorario"]))
                        {
                            MessageBox.Show("No se puede modificar el campo idHorario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Revertir cambios en el campo idHorario
                            row.RejectChanges();

                            // Actualizar el DataGridView
                            dataGridView1.Refresh();

                            return; // Salir del bucle si hay un error
                        }

                        // Actualizar la base de datos con una consulta UPDATE
                        string updateQuery = "UPDATE HorarioClases SET " +
                                             "RUT = @RUT, " +
                                             "Materia = @Materia, " +
                                             "Periodo = @Periodo, " +
                                             "Dias = @Dias, " +
                                             "Curso = @Curso, " +
                                             "Sala = @Sala " +
                                             "WHERE idHorario = @idHorario";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@RUT", row["RUT"]);
                            updateCommand.Parameters.AddWithValue("@Materia", row["Materia"]);
                            updateCommand.Parameters.AddWithValue("@Periodo", row["Periodo"]);
                            updateCommand.Parameters.AddWithValue("@Dias", row["Dias"]);
                            updateCommand.Parameters.AddWithValue("@Curso", row["Curso"]);
                            updateCommand.Parameters.AddWithValue("@Sala", row["Sala"]);
                            updateCommand.Parameters.AddWithValue("@idHorario", row["idHorario"]);

                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar el DataGridView con los datos de HorarioClases
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM HorarioClases";
                dataAdapter.SelectCommand = new SqlCommand(query, connection);
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                dataGridView1.Refresh();

                // Limpiar y volver a llenar el comboBoxId
                comboBoxId.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    comboBoxId.Items.Add(row["idHorario"]);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (comboBoxId.SelectedItem != null)
                    {
                        int idToDelete = (int)comboBoxId.SelectedItem;

                        // Eliminar TODOS los datos del idHorario seleccionado
                        string deleteQuery = "DELETE FROM HorarioClases WHERE idHorario = @idHorario";

                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@idHorario", idToDelete);
                            deleteCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Datos eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView
                        btnActualizar.PerformClick();

                        // Quitar el idHorario eliminado del comboBoxId
                        comboBoxId.Items.Remove(idToDelete);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un idHorario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al eliminar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
