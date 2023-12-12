namespace Proyecto
{
    partial class ModificarProfesor
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
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet23 = new Proyecto.ProyectoDataSet23();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblModificarProfesor = new System.Windows.Forms.Label();
            this.lblModNombre = new System.Windows.Forms.Label();
            this.lblModRut = new System.Windows.Forms.Label();
            this.txtApellidoProMod = new System.Windows.Forms.TextBox();
            this.lblModApellido = new System.Windows.Forms.Label();
            this.btnModConfirmar = new System.Windows.Forms.Button();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesorTableAdapter = new Proyecto.ProyectoDataSet13TableAdapters.ProfesorTableAdapter();
            this.comboBoxRut = new System.Windows.Forms.ComboBox();
            this.materiasTableAdapter = new Proyecto.ProyectoDataSet13TableAdapters.MateriasTableAdapter();
            this.listMateria = new System.Windows.Forms.ListBox();
            this.listCurso = new System.Windows.Forms.ListBox();
            this.lblModMateria = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.profesoresTableAdapter = new Proyecto.ProyectoDataSet23TableAdapters.ProfesoresTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreModPro
            // 
            this.txtNombreModPro.Location = new System.Drawing.Point(161, 198);
            this.txtNombreModPro.Name = "txtNombreModPro";
            this.txtNombreModPro.Size = new System.Drawing.Size(134, 20);
            this.txtNombreModPro.TabIndex = 21;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(179, 470);
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
            this.apellidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profesoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(456, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 316);
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
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // profesoresBindingSource
            // 
            this.profesoresBindingSource.DataMember = "Profesores";
            this.profesoresBindingSource.DataSource = this.proyectoDataSet23;
            // 
            // proyectoDataSet23
            // 
            this.proyectoDataSet23.DataSetName = "ProyectoDataSet23";
            this.proyectoDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblModificarProfesor
            // 
            this.lblModificarProfesor.AutoSize = true;
            this.lblModificarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblModificarProfesor.Location = new System.Drawing.Point(126, 69);
            this.lblModificarProfesor.Name = "lblModificarProfesor";
            this.lblModificarProfesor.Size = new System.Drawing.Size(206, 26);
            this.lblModificarProfesor.TabIndex = 16;
            this.lblModificarProfesor.Text = "Modificar Profesor";
            // 
            // lblModNombre
            // 
            this.lblModNombre.AutoSize = true;
            this.lblModNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModNombre.Location = new System.Drawing.Point(66, 194);
            this.lblModNombre.Name = "lblModNombre";
            this.lblModNombre.Size = new System.Drawing.Size(64, 18);
            this.lblModNombre.TabIndex = 13;
            this.lblModNombre.Text = "Nombre";
            // 
            // lblModRut
            // 
            this.lblModRut.AutoSize = true;
            this.lblModRut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModRut.Location = new System.Drawing.Point(66, 150);
            this.lblModRut.Name = "lblModRut";
            this.lblModRut.Size = new System.Drawing.Size(31, 18);
            this.lblModRut.TabIndex = 12;
            this.lblModRut.Text = "Rut";
            // 
            // txtApellidoProMod
            // 
            this.txtApellidoProMod.Location = new System.Drawing.Point(161, 242);
            this.txtApellidoProMod.Name = "txtApellidoProMod";
            this.txtApellidoProMod.Size = new System.Drawing.Size(134, 20);
            this.txtApellidoProMod.TabIndex = 25;
            // 
            // lblModApellido
            // 
            this.lblModApellido.AutoSize = true;
            this.lblModApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModApellido.Location = new System.Drawing.Point(65, 238);
            this.lblModApellido.Name = "lblModApellido";
            this.lblModApellido.Size = new System.Drawing.Size(65, 18);
            this.lblModApellido.TabIndex = 24;
            this.lblModApellido.Text = "Apellido";
            // 
            // btnModConfirmar
            // 
            this.btnModConfirmar.Image = global::Proyecto.Properties.Resources.comprobar;
            this.btnModConfirmar.Location = new System.Drawing.Point(179, 505);
            this.btnModConfirmar.Name = "btnModConfirmar";
            this.btnModConfirmar.Size = new System.Drawing.Size(82, 29);
            this.btnModConfirmar.TabIndex = 20;
            this.btnModConfirmar.Text = "Confirmar";
            this.btnModConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModConfirmar.UseVisualStyleBackColor = true;
            this.btnModConfirmar.Click += new System.EventHandler(this.btnModConfirmar_Click);
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxRut
            // 
            this.comboBoxRut.FormattingEnabled = true;
            this.comboBoxRut.Location = new System.Drawing.Point(161, 150);
            this.comboBoxRut.Name = "comboBoxRut";
            this.comboBoxRut.Size = new System.Drawing.Size(134, 21);
            this.comboBoxRut.TabIndex = 38;
            this.comboBoxRut.SelectedIndexChanged += new System.EventHandler(this.comboBoxRut_SelectedIndexChanged);
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // listMateria
            // 
            this.listMateria.DataSource = this.materiasBindingSource;
            this.listMateria.DisplayMember = "nombreMateria";
            this.listMateria.FormattingEnabled = true;
            this.listMateria.Location = new System.Drawing.Point(161, 296);
            this.listMateria.Name = "listMateria";
            this.listMateria.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMateria.Size = new System.Drawing.Size(134, 69);
            this.listMateria.TabIndex = 42;
            this.listMateria.ValueMember = "idMateria";
            // 
            // listCurso
            // 
            this.listCurso.DisplayMember = "nombreCurso";
            this.listCurso.FormattingEnabled = true;
            this.listCurso.Location = new System.Drawing.Point(159, 377);
            this.listCurso.Name = "listCurso";
            this.listCurso.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCurso.Size = new System.Drawing.Size(136, 69);
            this.listCurso.TabIndex = 41;
            this.listCurso.ValueMember = "idCurso";
            // 
            // lblModMateria
            // 
            this.lblModMateria.AutoSize = true;
            this.lblModMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModMateria.Location = new System.Drawing.Point(78, 296);
            this.lblModMateria.Name = "lblModMateria";
            this.lblModMateria.Size = new System.Drawing.Size(61, 18);
            this.lblModMateria.TabIndex = 40;
            this.lblModMateria.Text = "Materia";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(78, 377);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(50, 18);
            this.lblCurso.TabIndex = 39;
            this.lblCurso.Text = "Curso";
            // 
            // profesoresTableAdapter
            // 
            this.profesoresTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.logoxd;
            this.pictureBox1.Location = new System.Drawing.Point(873, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // ModificarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listMateria);
            this.Controls.Add(this.listCurso);
            this.Controls.Add(this.lblModMateria);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.comboBoxRut);
            this.Controls.Add(this.txtApellidoProMod);
            this.Controls.Add(this.lblModApellido);
            this.Controls.Add(this.txtNombreModPro);
            this.Controls.Add(this.btnModConfirmar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblModificarProfesor);
            this.Controls.Add(this.lblModNombre);
            this.Controls.Add(this.lblModRut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreModPro;
        private System.Windows.Forms.Button btnModConfirmar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblModificarProfesor;
        private System.Windows.Forms.Label lblModNombre;
        private System.Windows.Forms.Label lblModRut;
        private System.Windows.Forms.TextBox txtApellidoProMod;
        private System.Windows.Forms.Label lblModApellido;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private ProyectoDataSet13TableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxRut;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private ProyectoDataSet13TableAdapters.MateriasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.ListBox listMateria;
        private System.Windows.Forms.ListBox listCurso;
        private System.Windows.Forms.Label lblModMateria;
        private System.Windows.Forms.Label lblCurso;
        private ProyectoDataSet23 proyectoDataSet23;
        private System.Windows.Forms.BindingSource profesoresBindingSource;
        private ProyectoDataSet23TableAdapters.ProfesoresTableAdapter profesoresTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}