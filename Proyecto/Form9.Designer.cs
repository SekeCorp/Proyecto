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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GenerarHorario = new System.Windows.Forms.Button();
            this.combo_Materia = new System.Windows.Forms.ComboBox();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet6 = new Proyecto.ProyectoDataSet6();
            this.combo_Rut = new System.Windows.Forms.ComboBox();
            this.profesorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.combo_Curso = new System.Windows.Forms.ComboBox();
            this.btn_IngresarHorario = new System.Windows.Forms.Button();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new Proyecto.ProyectoDataSet6TableAdapters.MateriasTableAdapter();
            this.profesorTableAdapter = new Proyecto.ProyectoDataSet6TableAdapters.ProfesorTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 56);
            this.label4.TabIndex = 3;
            this.label4.Text = "Generar Horario";
            // 
            // btn_GenerarHorario
            // 
            this.btn_GenerarHorario.Location = new System.Drawing.Point(366, 527);
            this.btn_GenerarHorario.Name = "btn_GenerarHorario";
            this.btn_GenerarHorario.Size = new System.Drawing.Size(75, 23);
            this.btn_GenerarHorario.TabIndex = 7;
            this.btn_GenerarHorario.Text = "Generar Horario";
            this.btn_GenerarHorario.UseVisualStyleBackColor = true;
            // 
            // combo_Materia
            // 
            this.combo_Materia.DataSource = this.profesorBindingSource;
            this.combo_Materia.DisplayMember = "materia";
            this.combo_Materia.FormattingEnabled = true;
            this.combo_Materia.Location = new System.Drawing.Point(121, 85);
            this.combo_Materia.Name = "combo_Materia";
            this.combo_Materia.Size = new System.Drawing.Size(121, 21);
            this.combo_Materia.TabIndex = 8;
            this.combo_Materia.ValueMember = "materia";
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.proyectoDataSet6;
            // 
            // proyectoDataSet6
            // 
            this.proyectoDataSet6.DataSetName = "ProyectoDataSet6";
            this.proyectoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combo_Rut
            // 
            this.combo_Rut.DataSource = this.profesorBindingSource1;
            this.combo_Rut.DisplayMember = "rut";
            this.combo_Rut.FormattingEnabled = true;
            this.combo_Rut.Location = new System.Drawing.Point(366, 85);
            this.combo_Rut.Name = "combo_Rut";
            this.combo_Rut.Size = new System.Drawing.Size(121, 21);
            this.combo_Rut.TabIndex = 9;
            this.combo_Rut.ValueMember = "rut";
            // 
            // profesorBindingSource1
            // 
            this.profesorBindingSource1.DataMember = "Profesor";
            this.profesorBindingSource1.DataSource = this.proyectoDataSet6;
            // 
            // combo_Curso
            // 
            this.combo_Curso.FormattingEnabled = true;
            this.combo_Curso.Location = new System.Drawing.Point(560, 85);
            this.combo_Curso.Name = "combo_Curso";
            this.combo_Curso.Size = new System.Drawing.Size(121, 21);
            this.combo_Curso.TabIndex = 10;
            // 
            // btn_IngresarHorario
            // 
            this.btn_IngresarHorario.Location = new System.Drawing.Point(345, 384);
            this.btn_IngresarHorario.Name = "btn_IngresarHorario";
            this.btn_IngresarHorario.Size = new System.Drawing.Size(109, 23);
            this.btn_IngresarHorario.TabIndex = 27;
            this.btn_IngresarHorario.Text = "Ingresar Horario";
            this.btn_IngresarHorario.UseVisualStyleBackColor = true;
            this.btn_IngresarHorario.Click += new System.EventHandler(this.button2_Click);
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "Materias";
            this.materiasBindingSource.DataSource = this.proyectoDataSet6;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 257);
            this.dataGridView1.TabIndex = 30;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_IngresarHorario);
            this.Controls.Add(this.combo_Curso);
            this.Controls.Add(this.combo_Rut);
            this.Controls.Add(this.combo_Materia);
            this.Controls.Add(this.btn_GenerarHorario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_GenerarHorario;
        private System.Windows.Forms.ComboBox combo_Materia;
        private System.Windows.Forms.ComboBox combo_Rut;
        private System.Windows.Forms.ComboBox combo_Curso;
        private System.Windows.Forms.Button btn_IngresarHorario;
        private ProyectoDataSet6 proyectoDataSet6;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private ProyectoDataSet6TableAdapters.MateriasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private ProyectoDataSet6TableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.BindingSource profesorBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}