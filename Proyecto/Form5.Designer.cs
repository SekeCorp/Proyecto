namespace Proyecto
{
    partial class Form5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet12 = new Proyecto.ProyectoDataSet12();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet4 = new Proyecto.ProyectoDataSet4();
            this.btnConfirmarElim = new System.Windows.Forms.Button();
            this.profesorTableAdapter = new Proyecto.ProyectoDataSet4TableAdapters.ProfesorTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.profesorTableAdapter1 = new Proyecto.ProyectoDataSet12TableAdapters.ProfesorTableAdapter();
            this.comboBoxRut = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "RUT Profesor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(99, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eliminar Profesor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.dataGridView1.DataSource = this.profesorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(350, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 316);
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
            // profesorBindingSource1
            // 
            this.profesorBindingSource1.DataMember = "Profesor";
            this.profesorBindingSource1.DataSource = this.proyectoDataSet12;
            // 
            // proyectoDataSet12
            // 
            this.proyectoDataSet12.DataSetName = "ProyectoDataSet12";
            this.proyectoDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnConfirmarElim
            // 
            this.btnConfirmarElim.Location = new System.Drawing.Point(136, 366);
            this.btnConfirmarElim.Name = "btnConfirmarElim";
            this.btnConfirmarElim.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarElim.TabIndex = 53;
            this.btnConfirmarElim.Text = "Confirmar";
            this.btnConfirmarElim.UseVisualStyleBackColor = true;
            this.btnConfirmarElim.Click += new System.EventHandler(this.btnConfirmarElim_Click);
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
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
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Proyecto.Properties.Resources.borrar;
            this.btnEliminar.Location = new System.Drawing.Point(125, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 33);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // profesorTableAdapter1
            // 
            this.profesorTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBoxRut
            // 
            this.comboBoxRut.FormattingEnabled = true;
            this.comboBoxRut.Location = new System.Drawing.Point(114, 260);
            this.comboBoxRut.Name = "comboBoxRut";
            this.comboBoxRut.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRut.TabIndex = 55;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.comboBoxRut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfirmarElim);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirmarElim;
        private ProyectoDataSet4 proyectoDataSet4;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private ProyectoDataSet4TableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ProyectoDataSet12 proyectoDataSet12;
        private System.Windows.Forms.BindingSource profesorBindingSource1;
        private ProyectoDataSet12TableAdapters.ProfesorTableAdapter profesorTableAdapter1;
        private System.Windows.Forms.ComboBox comboBoxRut;
    }
}