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
            this.profesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet23 = new Proyecto.ProyectoDataSet23();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblModificarProfesor = new System.Windows.Forms.Label();
            this.lblModNombre = new System.Windows.Forms.Label();
            this.lblModRut = new System.Windows.Forms.Label();
            this.txtApellidoProMod = new System.Windows.Forms.TextBox();
            this.lblModApellido = new System.Windows.Forms.Label();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesorTableAdapter = new Proyecto.ProyectoDataSet13TableAdapters.ProfesorTableAdapter();
            this.comboBoxRut = new System.Windows.Forms.ComboBox();
            this.materiasTableAdapter = new Proyecto.ProyectoDataSet13TableAdapters.MateriasTableAdapter();
            this.listCurso = new System.Windows.Forms.ListBox();
            this.cursosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursos = new Proyecto.Cursos();
            this.lblModMateria = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.profesoresTableAdapter = new Proyecto.ProyectoDataSet23TableAdapters.ProfesoresTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cursosTableAdapter = new Proyecto.CursosTableAdapters.CursosTableAdapter();
            this.mATERIAS = new Proyecto.MATERIAS();
            this.materiasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter1 = new Proyecto.MATERIASTableAdapters.MateriasTableAdapter();
            this.materiasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.listMateria = new System.Windows.Forms.ListBox();
            this.materiasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet24 = new Proyecto.ProyectoDataSet24();
            this.materiasTableAdapter2 = new Proyecto.ProyectoDataSet24TableAdapters.MateriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet24)).BeginInit();
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
            this.btnModificar.Image = global::Proyecto.Properties.Resources.agregar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(366, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 316);
            this.dataGridView1.TabIndex = 17;
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
            // listCurso
            // 
            this.listCurso.DataSource = this.cursosBindingSource1;
            this.listCurso.DisplayMember = "nombreCurso";
            this.listCurso.FormattingEnabled = true;
            this.listCurso.Location = new System.Drawing.Point(159, 377);
            this.listCurso.Name = "listCurso";
            this.listCurso.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCurso.Size = new System.Drawing.Size(136, 69);
            this.listCurso.TabIndex = 41;
            this.listCurso.ValueMember = "nombreCurso";
            // 
            // cursosBindingSource1
            // 
            this.cursosBindingSource1.DataMember = "Cursos";
            this.cursosBindingSource1.DataSource = this.cursosBindingSource;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataSource = this.cursos;
            this.cursosBindingSource.Position = 0;
            // 
            // cursos
            // 
            this.cursos.DataSetName = "Cursos";
            this.cursos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::Proyecto.Properties.Resources.boton_actualizar;
            this.btnConfirmar.Location = new System.Drawing.Point(545, 470);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(82, 29);
            this.btnConfirmar.TabIndex = 44;
            this.btnConfirmar.Text = "Actualizar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // mATERIAS
            // 
            this.mATERIAS.DataSetName = "MATERIAS";
            this.mATERIAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasBindingSource1
            // 
            this.materiasBindingSource1.DataMember = "Materias";
            this.materiasBindingSource1.DataSource = this.mATERIAS;
            // 
            // materiasTableAdapter1
            // 
            this.materiasTableAdapter1.ClearBeforeFill = true;
            // 
            // materiasBindingSource2
            // 
            this.materiasBindingSource2.DataMember = "Materias";
            this.materiasBindingSource2.DataSource = this.mATERIAS;
            // 
            // listMateria
            // 
            this.listMateria.DataSource = this.materiasBindingSource3;
            this.listMateria.DisplayMember = "nombreMateria";
            this.listMateria.FormattingEnabled = true;
            this.listMateria.Location = new System.Drawing.Point(159, 296);
            this.listMateria.Name = "listMateria";
            this.listMateria.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMateria.Size = new System.Drawing.Size(136, 69);
            this.listMateria.TabIndex = 45;
            this.listMateria.ValueMember = "nombreMateria";
            // 
            // materiasBindingSource3
            // 
            this.materiasBindingSource3.DataMember = "Materias";
            this.materiasBindingSource3.DataSource = this.proyectoDataSet24;
            // 
            // proyectoDataSet24
            // 
            this.proyectoDataSet24.DataSetName = "ProyectoDataSet24";
            this.proyectoDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasTableAdapter2
            // 
            this.materiasTableAdapter2.ClearBeforeFill = true;
            // 
            // ModificarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.listMateria);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listCurso);
            this.Controls.Add(this.lblModMateria);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.comboBoxRut);
            this.Controls.Add(this.txtApellidoProMod);
            this.Controls.Add(this.lblModApellido);
            this.Controls.Add(this.txtNombreModPro);
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
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreModPro;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblModificarProfesor;
        private System.Windows.Forms.Label lblModNombre;
        private System.Windows.Forms.Label lblModRut;
        private System.Windows.Forms.TextBox txtApellidoProMod;
        private System.Windows.Forms.Label lblModApellido;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private ProyectoDataSet13TableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxRut;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private ProyectoDataSet13TableAdapters.MateriasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.ListBox listCurso;
        private System.Windows.Forms.Label lblModMateria;
        private System.Windows.Forms.Label lblCurso;
        private ProyectoDataSet23 proyectoDataSet23;
        private System.Windows.Forms.BindingSource profesoresBindingSource;
        private ProyectoDataSet23TableAdapters.ProfesoresTableAdapter profesoresTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private Cursos cursos;
        private System.Windows.Forms.BindingSource cursosBindingSource1;
        private CursosTableAdapters.CursosTableAdapter cursosTableAdapter;
        private MATERIAS mATERIAS;
        private System.Windows.Forms.BindingSource materiasBindingSource1;
        private MATERIASTableAdapters.MateriasTableAdapter materiasTableAdapter1;
        private System.Windows.Forms.BindingSource materiasBindingSource2;
        private System.Windows.Forms.ListBox listMateria;
        private ProyectoDataSet24 proyectoDataSet24;
        private System.Windows.Forms.BindingSource materiasBindingSource3;
        private ProyectoDataSet24TableAdapters.MateriasTableAdapter materiasTableAdapter2;
    }
}