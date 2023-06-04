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
            this.txtModHoras = new System.Windows.Forms.TextBox();
            this.txtModMateria = new System.Windows.Forms.TextBox();
            this.txtNombreModPro = new System.Windows.Forms.TextBox();
            this.btnModConfirmar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtModRut = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet1 = new Proyecto.ProyectoDataSet1();
            this.lblModificarProfesor = new System.Windows.Forms.Label();
            this.lblModHoras = new System.Windows.Forms.Label();
            this.lblModMateria = new System.Windows.Forms.Label();
            this.lblModNombre = new System.Windows.Forms.Label();
            this.lblModRut = new System.Windows.Forms.Label();
            this.profesorTableAdapter = new Proyecto.ProyectoDataSet1TableAdapters.ProfesorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModHoras
            // 
            this.txtModHoras.Location = new System.Drawing.Point(142, 299);
            this.txtModHoras.Name = "txtModHoras";
            this.txtModHoras.Size = new System.Drawing.Size(50, 20);
            this.txtModHoras.TabIndex = 23;
            // 
            // txtModMateria
            // 
            this.txtModMateria.Location = new System.Drawing.Point(142, 252);
            this.txtModMateria.Name = "txtModMateria";
            this.txtModMateria.Size = new System.Drawing.Size(134, 20);
            this.txtModMateria.TabIndex = 22;
            // 
            // txtNombreModPro
            // 
            this.txtNombreModPro.Location = new System.Drawing.Point(142, 203);
            this.txtNombreModPro.Name = "txtNombreModPro";
            this.txtNombreModPro.Size = new System.Drawing.Size(134, 20);
            this.txtNombreModPro.TabIndex = 21;
            // 
            // btnModConfirmar
            // 
            this.btnModConfirmar.Location = new System.Drawing.Point(201, 360);
            this.btnModConfirmar.Name = "btnModConfirmar";
            this.btnModConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnModConfirmar.TabIndex = 20;
            this.btnModConfirmar.Text = "Confirmar";
            this.btnModConfirmar.UseVisualStyleBackColor = true;
            this.btnModConfirmar.Click += new System.EventHandler(this.btnModConfirmar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(117, 360);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtModRut
            // 
            this.txtModRut.Location = new System.Drawing.Point(142, 159);
            this.txtModRut.Name = "txtModRut";
            this.txtModRut.Size = new System.Drawing.Size(134, 20);
            this.txtModRut.TabIndex = 18;
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
            this.horasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profesorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(339, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 316);
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
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.proyectoDataSet1BindingSource;
            // 
            // proyectoDataSet1BindingSource
            // 
            this.proyectoDataSet1BindingSource.DataSource = this.proyectoDataSet1;
            this.proyectoDataSet1BindingSource.Position = 0;
            // 
            // proyectoDataSet1
            // 
            this.proyectoDataSet1.DataSetName = "ProyectoDataSet1";
            this.proyectoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblModificarProfesor
            // 
            this.lblModificarProfesor.AutoSize = true;
            this.lblModificarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblModificarProfesor.Location = new System.Drawing.Point(46, 67);
            this.lblModificarProfesor.Name = "lblModificarProfesor";
            this.lblModificarProfesor.Size = new System.Drawing.Size(206, 26);
            this.lblModificarProfesor.TabIndex = 16;
            this.lblModificarProfesor.Text = "Modificar Profesor";
            // 
            // lblModHoras
            // 
            this.lblModHoras.AutoSize = true;
            this.lblModHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblModHoras.Location = new System.Drawing.Point(46, 299);
            this.lblModHoras.Name = "lblModHoras";
            this.lblModHoras.Size = new System.Drawing.Size(65, 24);
            this.lblModHoras.TabIndex = 15;
            this.lblModHoras.Text = "Horas";
            // 
            // lblModMateria
            // 
            this.lblModMateria.AutoSize = true;
            this.lblModMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblModMateria.Location = new System.Drawing.Point(46, 252);
            this.lblModMateria.Name = "lblModMateria";
            this.lblModMateria.Size = new System.Drawing.Size(78, 24);
            this.lblModMateria.TabIndex = 14;
            this.lblModMateria.Text = "Materia";
            // 
            // lblModNombre
            // 
            this.lblModNombre.AutoSize = true;
            this.lblModNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblModNombre.Location = new System.Drawing.Point(46, 203);
            this.lblModNombre.Name = "lblModNombre";
            this.lblModNombre.Size = new System.Drawing.Size(85, 24);
            this.lblModNombre.TabIndex = 13;
            this.lblModNombre.Text = "Nombre";
            // 
            // lblModRut
            // 
            this.lblModRut.AutoSize = true;
            this.lblModRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModRut.Location = new System.Drawing.Point(46, 159);
            this.lblModRut.Name = "lblModRut";
            this.lblModRut.Size = new System.Drawing.Size(41, 24);
            this.lblModRut.TabIndex = 12;
            this.lblModRut.Text = "Rut";
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 421);
            this.Controls.Add(this.txtModHoras);
            this.Controls.Add(this.txtModMateria);
            this.Controls.Add(this.txtNombreModPro);
            this.Controls.Add(this.btnModConfirmar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtModRut);
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
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModHoras;
        private System.Windows.Forms.TextBox txtModMateria;
        private System.Windows.Forms.TextBox txtNombreModPro;
        private System.Windows.Forms.Button btnModConfirmar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtModRut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblModificarProfesor;
        private System.Windows.Forms.Label lblModHoras;
        private System.Windows.Forms.Label lblModMateria;
        private System.Windows.Forms.Label lblModNombre;
        private System.Windows.Forms.Label lblModRut;
        private System.Windows.Forms.BindingSource proyectoDataSet1BindingSource;
        private ProyectoDataSet1 proyectoDataSet1;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private ProyectoDataSet1TableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
    }
}