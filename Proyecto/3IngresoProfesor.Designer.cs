namespace Proyecto
{
    partial class IngresoProfesor
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblIngresoProfesor = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtApellidoPro = new System.Windows.Forms.TextBox();
            this.lblModApellido = new System.Windows.Forms.Label();
            this.txtNombreIngPro = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.lblModMateria = new System.Windows.Forms.Label();
            this.lblModNombre = new System.Windows.Forms.Label();
            this.lblModRut = new System.Windows.Forms.Label();
            this.listCurso = new System.Windows.Forms.ListBox();
            this.cursosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursos = new Proyecto.Cursos();
            this.listMateria = new System.Windows.Forms.ListBox();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaid = new Proyecto.Materiaid();
            this.materiasTableAdapter = new Proyecto.MateriaidTableAdapters.MateriasTableAdapter();
            this.cursosTableAdapter = new Proyecto.CursosTableAdapters.CursosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(55, 368);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(50, 18);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso";
            // 
            // lblIngresoProfesor
            // 
            this.lblIngresoProfesor.AutoSize = true;
            this.lblIngresoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblIngresoProfesor.Location = new System.Drawing.Point(65, 80);
            this.lblIngresoProfesor.Name = "lblIngresoProfesor";
            this.lblIngresoProfesor.Size = new System.Drawing.Size(196, 26);
            this.lblIngresoProfesor.TabIndex = 4;
            this.lblIngresoProfesor.Text = "Ingresar Profesor";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(149, 443);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Siguiente";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::Proyecto.Properties.Resources.boton_actualizar;
            this.btnConfirmar.Location = new System.Drawing.Point(563, 485);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(87, 23);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Actualizar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtApellidoPro
            // 
            this.txtApellidoPro.Location = new System.Drawing.Point(149, 243);
            this.txtApellidoPro.Name = "txtApellidoPro";
            this.txtApellidoPro.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoPro.TabIndex = 33;
            // 
            // lblModApellido
            // 
            this.lblModApellido.AutoSize = true;
            this.lblModApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModApellido.Location = new System.Drawing.Point(54, 245);
            this.lblModApellido.Name = "lblModApellido";
            this.lblModApellido.Size = new System.Drawing.Size(65, 18);
            this.lblModApellido.TabIndex = 32;
            this.lblModApellido.Text = "Apellido";
            // 
            // txtNombreIngPro
            // 
            this.txtNombreIngPro.Location = new System.Drawing.Point(149, 199);
            this.txtNombreIngPro.Name = "txtNombreIngPro";
            this.txtNombreIngPro.Size = new System.Drawing.Size(121, 20);
            this.txtNombreIngPro.TabIndex = 30;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(149, 157);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(121, 20);
            this.txtRut.TabIndex = 29;
            // 
            // lblModMateria
            // 
            this.lblModMateria.AutoSize = true;
            this.lblModMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModMateria.Location = new System.Drawing.Point(53, 288);
            this.lblModMateria.Name = "lblModMateria";
            this.lblModMateria.Size = new System.Drawing.Size(61, 18);
            this.lblModMateria.TabIndex = 28;
            this.lblModMateria.Text = "Materia";
            // 
            // lblModNombre
            // 
            this.lblModNombre.AutoSize = true;
            this.lblModNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModNombre.Location = new System.Drawing.Point(53, 201);
            this.lblModNombre.Name = "lblModNombre";
            this.lblModNombre.Size = new System.Drawing.Size(64, 18);
            this.lblModNombre.TabIndex = 27;
            this.lblModNombre.Text = "Nombre";
            // 
            // lblModRut
            // 
            this.lblModRut.AutoSize = true;
            this.lblModRut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModRut.Location = new System.Drawing.Point(53, 157);
            this.lblModRut.Name = "lblModRut";
            this.lblModRut.Size = new System.Drawing.Size(31, 18);
            this.lblModRut.TabIndex = 26;
            this.lblModRut.Text = "Rut";
            // 
            // listCurso
            // 
            this.listCurso.DataSource = this.cursosBindingSource1;
            this.listCurso.DisplayMember = "nombreCurso";
            this.listCurso.FormattingEnabled = true;
            this.listCurso.Location = new System.Drawing.Point(122, 368);
            this.listCurso.Name = "listCurso";
            this.listCurso.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCurso.Size = new System.Drawing.Size(148, 69);
            this.listCurso.TabIndex = 37;
            this.listCurso.ValueMember = "idCurso";
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
            // listMateria
            // 
            this.listMateria.DataSource = this.materiasBindingSource;
            this.listMateria.DisplayMember = "nombreMateria";
            this.listMateria.FormattingEnabled = true;
            this.listMateria.Location = new System.Drawing.Point(122, 288);
            this.listMateria.Name = "listMateria";
            this.listMateria.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMateria.Size = new System.Drawing.Size(148, 69);
            this.listMateria.TabIndex = 38;
            this.listMateria.ValueMember = "idMateria";
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "Materias";
            this.materiasBindingSource.DataSource = this.materiaid;
            // 
            // materiaid
            // 
            this.materiaid.DataSetName = "Materiaid";
            this.materiaid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 309);
            this.dataGridView1.TabIndex = 40;
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
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listMateria);
            this.Controls.Add(this.listCurso);
            this.Controls.Add(this.txtApellidoPro);
            this.Controls.Add(this.lblModApellido);
            this.Controls.Add(this.txtNombreIngPro);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.lblModMateria);
            this.Controls.Add(this.lblModNombre);
            this.Controls.Add(this.lblModRut);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblIngresoProfesor);
            this.Controls.Add(this.lblCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblIngresoProfesor;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtApellidoPro;
        private System.Windows.Forms.Label lblModApellido;
        private System.Windows.Forms.TextBox txtNombreIngPro;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label lblModMateria;
        private System.Windows.Forms.Label lblModNombre;
        private System.Windows.Forms.Label lblModRut;
        private System.Windows.Forms.ListBox listCurso;
        private System.Windows.Forms.ListBox listMateria;
        private MateriaidTableAdapters.MateriasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private Cursos cursos;
        private System.Windows.Forms.BindingSource cursosBindingSource1;
        private CursosTableAdapters.CursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private Materiaid materiaid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}