namespace Proyecto
{
    partial class Form9
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelContadorHoras = new System.Windows.Forms.Label();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet7 = new Proyecto.ProyectoDataSet7();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.profesorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet8 = new Proyecto.ProyectoDataSet8();
            this.profesorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new Proyecto.ProyectoDataSet7TableAdapters.MateriasTableAdapter();
            this.salasTableAdapter = new Proyecto.ProyectoDataSet7TableAdapters.SalasTableAdapter();
            this.profesorTableAdapter = new Proyecto.ProyectoDataSet7TableAdapters.ProfesorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profesorTableAdapter1 = new Proyecto.ProyectoDataSet8TableAdapters.ProfesorTableAdapter();
            this.profesorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnGenerarHorario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelContadorHoras
            // 
            this.labelContadorHoras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelContadorHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContadorHoras.ForeColor = System.Drawing.Color.Black;
            this.labelContadorHoras.Location = new System.Drawing.Point(370, 463);
            this.labelContadorHoras.Name = "labelContadorHoras";
            this.labelContadorHoras.Size = new System.Drawing.Size(271, 24);
            this.labelContadorHoras.TabIndex = 1;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "Materias";
            this.materiasBindingSource.DataSource = this.proyectoDataSet7BindingSource;
            // 
            // proyectoDataSet7BindingSource
            // 
            this.proyectoDataSet7BindingSource.DataSource = this.proyectoDataSet7;
            this.proyectoDataSet7BindingSource.Position = 0;
            // 
            // proyectoDataSet7
            // 
            this.proyectoDataSet7.DataSetName = "ProyectoDataSet7";
            this.proyectoDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.profesorBindingSource1, "rut", true));
            this.comboBox2.DataSource = this.profesorBindingSource3;
            this.comboBox2.DisplayMember = "rut";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(467, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "rut";
            // 
            // profesorBindingSource1
            // 
            this.profesorBindingSource1.DataMember = "Profesor";
            this.profesorBindingSource1.DataSource = this.proyectoDataSet8;
            // 
            // proyectoDataSet8
            // 
            this.proyectoDataSet8.DataSetName = "ProyectoDataSet8";
            this.proyectoDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesorBindingSource3
            // 
            this.profesorBindingSource3.DataMember = "Profesor";
            this.profesorBindingSource3.DataSource = this.proyectoDataSet8BindingSource;
            // 
            // proyectoDataSet8BindingSource
            // 
            this.proyectoDataSet8BindingSource.DataSource = this.proyectoDataSet8;
            this.proyectoDataSet8BindingSource.Position = 0;
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.proyectoDataSet7BindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "RUT Profesor";
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.proyectoDataSet7BindingSource;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Designar Disponibilidad";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(467, 490);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Designar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // profesorTableAdapter1
            // 
            this.profesorTableAdapter1.ClearBeforeFill = true;
            // 
            // profesorBindingSource2
            // 
            this.profesorBindingSource2.DataMember = "Profesor";
            this.profesorBindingSource2.DataSource = this.proyectoDataSet7BindingSource;
            // 
            // btnGenerarHorario
            // 
            this.btnGenerarHorario.Location = new System.Drawing.Point(467, 529);
            this.btnGenerarHorario.Name = "btnGenerarHorario";
            this.btnGenerarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarHorario.TabIndex = 37;
            this.btnGenerarHorario.Text = "Generar";
            this.btnGenerarHorario.UseVisualStyleBackColor = true;
            this.btnGenerarHorario.Click += new System.EventHandler(this.btnGenerarHorario_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.btnGenerarHorario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelContadorHoras);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelContadorHoras;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource proyectoDataSet7BindingSource;
        private ProyectoDataSet7 proyectoDataSet7;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private ProyectoDataSet7TableAdapters.MateriasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private ProyectoDataSet7TableAdapters.SalasTableAdapter salasTableAdapter;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private ProyectoDataSet7TableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ProyectoDataSet8 proyectoDataSet8;
        private System.Windows.Forms.BindingSource profesorBindingSource1;
        private ProyectoDataSet8TableAdapters.ProfesorTableAdapter profesorTableAdapter1;
        private System.Windows.Forms.BindingSource profesorBindingSource2;
        private System.Windows.Forms.BindingSource profesorBindingSource3;
        private System.Windows.Forms.BindingSource proyectoDataSet8BindingSource;
        private System.Windows.Forms.Button btnGenerarHorario;
    }
}