namespace Proyecto
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listCurso = new System.Windows.Forms.ListBox();
            this.listMateria = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mATERIAS = new Proyecto.MATERIAS();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new Proyecto.MATERIASTableAdapters.MateriasTableAdapter();
            this.cURSOS = new Proyecto.CURSOS();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Proyecto.CURSOSTableAdapters.CursoTableAdapter();
            this.cURSOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(74, 335);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(50, 18);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso";
            // 
            // lblIngresoProfesor
            // 
            this.lblIngresoProfesor.AutoSize = true;
            this.lblIngresoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblIngresoProfesor.Location = new System.Drawing.Point(72, 59);
            this.lblIngresoProfesor.Name = "lblIngresoProfesor";
            this.lblIngresoProfesor.Size = new System.Drawing.Size(196, 26);
            this.lblIngresoProfesor.TabIndex = 4;
            this.lblIngresoProfesor.Text = "Ingresar Profesor";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(107, 410);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Ingresar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::Proyecto.Properties.Resources.boton_actualizar;
            this.btnConfirmar.Location = new System.Drawing.Point(192, 410);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(87, 23);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Actualizar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtApellidoPro
            // 
            this.txtApellidoPro.Location = new System.Drawing.Point(168, 210);
            this.txtApellidoPro.Name = "txtApellidoPro";
            this.txtApellidoPro.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoPro.TabIndex = 33;
            // 
            // lblModApellido
            // 
            this.lblModApellido.AutoSize = true;
            this.lblModApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModApellido.Location = new System.Drawing.Point(73, 212);
            this.lblModApellido.Name = "lblModApellido";
            this.lblModApellido.Size = new System.Drawing.Size(65, 18);
            this.lblModApellido.TabIndex = 32;
            this.lblModApellido.Text = "Apellido";
            // 
            // txtNombreIngPro
            // 
            this.txtNombreIngPro.Location = new System.Drawing.Point(168, 166);
            this.txtNombreIngPro.Name = "txtNombreIngPro";
            this.txtNombreIngPro.Size = new System.Drawing.Size(121, 20);
            this.txtNombreIngPro.TabIndex = 30;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(168, 124);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(121, 20);
            this.txtRut.TabIndex = 29;
            // 
            // lblModMateria
            // 
            this.lblModMateria.AutoSize = true;
            this.lblModMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModMateria.Location = new System.Drawing.Point(72, 255);
            this.lblModMateria.Name = "lblModMateria";
            this.lblModMateria.Size = new System.Drawing.Size(61, 18);
            this.lblModMateria.TabIndex = 28;
            this.lblModMateria.Text = "Materia";
            // 
            // lblModNombre
            // 
            this.lblModNombre.AutoSize = true;
            this.lblModNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModNombre.Location = new System.Drawing.Point(72, 168);
            this.lblModNombre.Name = "lblModNombre";
            this.lblModNombre.Size = new System.Drawing.Size(64, 18);
            this.lblModNombre.TabIndex = 27;
            this.lblModNombre.Text = "Nombre";
            // 
            // lblModRut
            // 
            this.lblModRut.AutoSize = true;
            this.lblModRut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModRut.Location = new System.Drawing.Point(72, 124);
            this.lblModRut.Name = "lblModRut";
            this.lblModRut.Size = new System.Drawing.Size(31, 18);
            this.lblModRut.TabIndex = 26;
            this.lblModRut.Text = "Rut";
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
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // listCurso
            // 
            this.listCurso.DataSource = this.cursoBindingSource;
            this.listCurso.DisplayMember = "curso";
            this.listCurso.FormattingEnabled = true;
            this.listCurso.Location = new System.Drawing.Point(169, 335);
            this.listCurso.Name = "listCurso";
            this.listCurso.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCurso.Size = new System.Drawing.Size(120, 69);
            this.listCurso.TabIndex = 37;
            this.listCurso.ValueMember = "curso";
            // 
            // listMateria
            // 
            this.listMateria.DataSource = this.materiasBindingSource;
            this.listMateria.DisplayMember = "nombre";
            this.listMateria.FormattingEnabled = true;
            this.listMateria.Location = new System.Drawing.Point(169, 255);
            this.listMateria.Name = "listMateria";
            this.listMateria.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMateria.Size = new System.Drawing.Size(120, 69);
            this.listMateria.TabIndex = 38;
            this.listMateria.ValueMember = "nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(77, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 82);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // mATERIAS
            // 
            this.mATERIAS.DataSetName = "MATERIAS";
            this.mATERIAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "Materias";
            this.materiasBindingSource.DataSource = this.mATERIAS;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // cURSOS
            // 
            this.cURSOS.DataSetName = "CURSOS";
            this.cURSOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.cURSOS;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // cURSOSBindingSource
            // 
            this.cURSOSBindingSource.DataSource = this.cURSOS;
            this.cURSOSBindingSource.Position = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listMateria);
            this.Controls.Add(this.listCurso);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOSBindingSource)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listCurso;
        private System.Windows.Forms.ListBox listMateria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MATERIAS mATERIAS;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private MATERIASTableAdapters.MateriasTableAdapter materiasTableAdapter;
        private CURSOS cURSOS;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private CURSOSTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource cURSOSBindingSource;
    }
}