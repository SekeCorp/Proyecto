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
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblIngresoProfesor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet4 = new Proyecto.ProyectoDataSet4();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtApellidoPro = new System.Windows.Forms.TextBox();
            this.lblModApellido = new System.Windows.Forms.Label();
            this.txtNombreIngPro = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.lblModMateria = new System.Windows.Forms.Label();
            this.lblModNombre = new System.Windows.Forms.Label();
            this.lblModRut = new System.Windows.Forms.Label();
            this.proyectoDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesorTableAdapter = new Proyecto.ProyectoDataSet4TableAdapters.ProfesorTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet7 = new Proyecto.ProyectoDataSet7();
            this.materiasTableAdapter = new Proyecto.ProyectoDataSet7TableAdapters.MateriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHoras.Location = new System.Drawing.Point(37, 285);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(65, 24);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas";
            // 
            // lblIngresoProfesor
            // 
            this.lblIngresoProfesor.AutoSize = true;
            this.lblIngresoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblIngresoProfesor.Location = new System.Drawing.Point(37, 53);
            this.lblIngresoProfesor.Name = "lblIngresoProfesor";
            this.lblIngresoProfesor.Size = new System.Drawing.Size(196, 26);
            this.lblIngresoProfesor.TabIndex = 4;
            this.lblIngresoProfesor.Text = "Ingresar Profesor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.materiaDataGridViewTextBoxColumn,
            this.horasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profesorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(260, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 316);
            this.dataGridView1.TabIndex = 5;
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
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.proyectoDataSet4;
            // 
            // proyectoDataSet4
            // 
            this.proyectoDataSet4.DataSetName = "ProyectoDataSet4";
            this.proyectoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(73, 331);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(158, 331);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(133, 289);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtApellidoPro
            // 
            this.txtApellidoPro.Location = new System.Drawing.Point(133, 206);
            this.txtApellidoPro.Name = "txtApellidoPro";
            this.txtApellidoPro.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoPro.TabIndex = 33;
            // 
            // lblModApellido
            // 
            this.lblModApellido.AutoSize = true;
            this.lblModApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblModApellido.Location = new System.Drawing.Point(38, 206);
            this.lblModApellido.Name = "lblModApellido";
            this.lblModApellido.Size = new System.Drawing.Size(87, 24);
            this.lblModApellido.TabIndex = 32;
            this.lblModApellido.Text = "Apellido";
            // 
            // txtNombreIngPro
            // 
            this.txtNombreIngPro.Location = new System.Drawing.Point(133, 162);
            this.txtNombreIngPro.Name = "txtNombreIngPro";
            this.txtNombreIngPro.Size = new System.Drawing.Size(121, 20);
            this.txtNombreIngPro.TabIndex = 30;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(133, 118);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(121, 20);
            this.txtRut.TabIndex = 29;
            // 
            // lblModMateria
            // 
            this.lblModMateria.AutoSize = true;
            this.lblModMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblModMateria.Location = new System.Drawing.Point(37, 249);
            this.lblModMateria.Name = "lblModMateria";
            this.lblModMateria.Size = new System.Drawing.Size(78, 24);
            this.lblModMateria.TabIndex = 28;
            this.lblModMateria.Text = "Materia";
            // 
            // lblModNombre
            // 
            this.lblModNombre.AutoSize = true;
            this.lblModNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblModNombre.Location = new System.Drawing.Point(37, 162);
            this.lblModNombre.Name = "lblModNombre";
            this.lblModNombre.Size = new System.Drawing.Size(85, 24);
            this.lblModNombre.TabIndex = 27;
            this.lblModNombre.Text = "Nombre";
            // 
            // lblModRut
            // 
            this.lblModRut.AutoSize = true;
            this.lblModRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModRut.Location = new System.Drawing.Point(37, 118);
            this.lblModRut.Name = "lblModRut";
            this.lblModRut.Size = new System.Drawing.Size(41, 24);
            this.lblModRut.TabIndex = 26;
            this.lblModRut.Text = "Rut";
            // 
            // proyectoDataSet4BindingSource
            // 
            this.proyectoDataSet4BindingSource.DataSource = this.proyectoDataSet4;
            this.proyectoDataSet4BindingSource.Position = 0;
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.materiasBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.ValueMember = "nombre";
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "Materias";
            this.materiasBindingSource.DataSource = this.proyectoDataSet7;
            // 
            // proyectoDataSet7
            // 
            this.proyectoDataSet7.DataSetName = "ProyectoDataSet7";
            this.proyectoDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 421);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtApellidoPro);
            this.Controls.Add(this.lblModApellido);
            this.Controls.Add(this.txtNombreIngPro);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.lblModMateria);
            this.Controls.Add(this.lblModNombre);
            this.Controls.Add(this.lblModRut);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblIngresoProfesor);
            this.Controls.Add(this.lblHoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblIngresoProfesor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtApellidoPro;
        private System.Windows.Forms.Label lblModApellido;
        private System.Windows.Forms.TextBox txtNombreIngPro;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label lblModMateria;
        private System.Windows.Forms.Label lblModNombre;
        private System.Windows.Forms.Label lblModRut;
        private System.Windows.Forms.BindingSource proyectoDataSet4BindingSource;
        private ProyectoDataSet4 proyectoDataSet4;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private ProyectoDataSet4TableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private ProyectoDataSet7 proyectoDataSet7;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private ProyectoDataSet7TableAdapters.MateriasTableAdapter materiasTableAdapter;
    }
}