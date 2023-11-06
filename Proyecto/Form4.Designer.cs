namespace Proyecto
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNombreModPro = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet13BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet13 = new Proyecto.ProyectoDataSet13();
            this.lblModificarProfesor = new System.Windows.Forms.Label();
            this.lblModHoras = new System.Windows.Forms.Label();
            this.lblModMateria = new System.Windows.Forms.Label();
            this.lblModNombre = new System.Windows.Forms.Label();
            this.lblModRut = new System.Windows.Forms.Label();
            this.txtApellidoProMod = new System.Windows.Forms.TextBox();
            this.lblModApellido = new System.Windows.Forms.Label();
            this.HorasNup = new System.Windows.Forms.NumericUpDown();
            this.btnModConfirmar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboboxmateria = new System.Windows.Forms.ComboBox();
            this.profesorTableAdapter = new Proyecto.ProyectoDataSet13TableAdapters.ProfesorTableAdapter();
            this.comboBoxRut = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new Proyecto.ProyectoDataSet13TableAdapters.MateriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet13BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorasNup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreModPro
            // 
            this.txtNombreModPro.Location = new System.Drawing.Point(161, 199);
            this.txtNombreModPro.Name = "txtNombreModPro";
            this.txtNombreModPro.Size = new System.Drawing.Size(134, 20);
            this.txtNombreModPro.TabIndex = 21;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(88, 386);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 29);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.materiaDataGridViewTextBoxColumn,
            this.horasDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profesorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(350, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 316);
            this.dataGridView1.TabIndex = 17;
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            this.materiaDataGridViewTextBoxColumn.DataPropertyName = "materia";
            this.materiaDataGridViewTextBoxColumn.HeaderText = "materia";
            this.materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            // 
            // horasDataGridViewTextBoxColumn
            // 
            this.horasDataGridViewTextBoxColumn.DataPropertyName = "horas";
            this.horasDataGridViewTextBoxColumn.HeaderText = "horas";
            this.horasDataGridViewTextBoxColumn.Name = "horasDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.proyectoDataSet13BindingSource;
            // 
            // proyectoDataSet13BindingSource
            // 
            this.proyectoDataSet13BindingSource.DataSource = this.proyectoDataSet13;
            this.proyectoDataSet13BindingSource.Position = 0;
            // 
            // proyectoDataSet13
            // 
            this.proyectoDataSet13.DataSetName = "ProyectoDataSet13";
            this.proyectoDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblModificarProfesor
            // 
            this.lblModificarProfesor.AutoSize = true;
            this.lblModificarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblModificarProfesor.Location = new System.Drawing.Point(83, 102);
            this.lblModificarProfesor.Name = "lblModificarProfesor";
            this.lblModificarProfesor.Size = new System.Drawing.Size(206, 26);
            this.lblModificarProfesor.TabIndex = 16;
            this.lblModificarProfesor.Text = "Modificar Profesor";
            // 
            // lblModHoras
            // 
            this.lblModHoras.AutoSize = true;
            this.lblModHoras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModHoras.Location = new System.Drawing.Point(66, 333);
            this.lblModHoras.Name = "lblModHoras";
            this.lblModHoras.Size = new System.Drawing.Size(50, 18);
            this.lblModHoras.TabIndex = 15;
            this.lblModHoras.Text = "Horas";
            // 
            // lblModMateria
            // 
            this.lblModMateria.AutoSize = true;
            this.lblModMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModMateria.Location = new System.Drawing.Point(66, 282);
            this.lblModMateria.Name = "lblModMateria";
            this.lblModMateria.Size = new System.Drawing.Size(61, 18);
            this.lblModMateria.TabIndex = 14;
            this.lblModMateria.Text = "Materia";
            // 
            // lblModNombre
            // 
            this.lblModNombre.AutoSize = true;
            this.lblModNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModNombre.Location = new System.Drawing.Point(66, 195);
            this.lblModNombre.Name = "lblModNombre";
            this.lblModNombre.Size = new System.Drawing.Size(64, 18);
            this.lblModNombre.TabIndex = 13;
            this.lblModNombre.Text = "Nombre";
            // 
            // lblModRut
            // 
            this.lblModRut.AutoSize = true;
            this.lblModRut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModRut.Location = new System.Drawing.Point(66, 151);
            this.lblModRut.Name = "lblModRut";
            this.lblModRut.Size = new System.Drawing.Size(31, 18);
            this.lblModRut.TabIndex = 12;
            this.lblModRut.Text = "Rut";
            // 
            // txtApellidoProMod
            // 
            this.txtApellidoProMod.Location = new System.Drawing.Point(161, 243);
            this.txtApellidoProMod.Name = "txtApellidoProMod";
            this.txtApellidoProMod.Size = new System.Drawing.Size(134, 20);
            this.txtApellidoProMod.TabIndex = 25;
            // 
            // lblModApellido
            // 
            this.lblModApellido.AutoSize = true;
            this.lblModApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModApellido.Location = new System.Drawing.Point(65, 239);
            this.lblModApellido.Name = "lblModApellido";
            this.lblModApellido.Size = new System.Drawing.Size(65, 18);
            this.lblModApellido.TabIndex = 24;
            this.lblModApellido.Text = "Apellido";
            // 
            // HorasNup
            // 
            this.HorasNup.Location = new System.Drawing.Point(161, 333);
            this.HorasNup.Name = "HorasNup";
            this.HorasNup.Size = new System.Drawing.Size(134, 20);
            this.HorasNup.TabIndex = 26;
            this.HorasNup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HorasNup.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnModConfirmar
            // 
            this.btnModConfirmar.Image = global::Proyecto.Properties.Resources.comprobar;
            this.btnModConfirmar.Location = new System.Drawing.Point(193, 386);
            this.btnModConfirmar.Name = "btnModConfirmar";
            this.btnModConfirmar.Size = new System.Drawing.Size(79, 29);
            this.btnModConfirmar.TabIndex = 20;
            this.btnModConfirmar.Text = "Confirmar";
            this.btnModConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModConfirmar.UseVisualStyleBackColor = true;
            this.btnModConfirmar.Click += new System.EventHandler(this.btnModConfirmar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.Logo_Marca_Personal_Masculino_con_Iniciales_y_Nombre_Profesional_Blanco_y_Negro;
            this.pictureBox1.Location = new System.Drawing.Point(871, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // comboboxmateria
            // 
            this.comboboxmateria.DataSource = this.materiasBindingSource;
            this.comboboxmateria.DisplayMember = "nombre";
            this.comboboxmateria.FormattingEnabled = true;
            this.comboboxmateria.Location = new System.Drawing.Point(161, 283);
            this.comboboxmateria.Name = "comboboxmateria";
            this.comboboxmateria.Size = new System.Drawing.Size(134, 21);
            this.comboboxmateria.TabIndex = 37;
            this.comboboxmateria.ValueMember = "nombre";
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxRut
            // 
            this.comboBoxRut.FormattingEnabled = true;
            this.comboBoxRut.Location = new System.Drawing.Point(161, 151);
            this.comboBoxRut.Name = "comboBoxRut";
            this.comboBoxRut.Size = new System.Drawing.Size(134, 21);
            this.comboBoxRut.TabIndex = 38;
            this.comboBoxRut.SelectedIndexChanged += new System.EventHandler(this.comboBoxRut_SelectedIndexChanged);
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "Materias";
            this.materiasBindingSource.DataSource = this.proyectoDataSet13BindingSource;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.comboBoxRut);
            this.Controls.Add(this.comboboxmateria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HorasNup);
            this.Controls.Add(this.txtApellidoProMod);
            this.Controls.Add(this.lblModApellido);
            this.Controls.Add(this.txtNombreModPro);
            this.Controls.Add(this.btnModConfirmar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblModificarProfesor);
            this.Controls.Add(this.lblModHoras);
            this.Controls.Add(this.lblModMateria);
            this.Controls.Add(this.lblModNombre);
            this.Controls.Add(this.lblModRut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet13BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorasNup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreModPro;
        private System.Windows.Forms.Button btnModConfirmar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblModificarProfesor;
        private System.Windows.Forms.Label lblModHoras;
        private System.Windows.Forms.Label lblModMateria;
        private System.Windows.Forms.Label lblModNombre;
        private System.Windows.Forms.Label lblModRut;
        private System.Windows.Forms.TextBox txtApellidoProMod;
        private System.Windows.Forms.Label lblModApellido;
        private System.Windows.Forms.NumericUpDown HorasNup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboboxmateria;
        private System.Windows.Forms.BindingSource proyectoDataSet13BindingSource;
        private ProyectoDataSet13 proyectoDataSet13;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private ProyectoDataSet13TableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxRut;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private ProyectoDataSet13TableAdapters.MateriasTableAdapter materiasTableAdapter;
    }
}