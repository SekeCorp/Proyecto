﻿namespace Proyecto
{
    partial class Form8
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_Fecha_P = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fecha_D = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutProfesores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasprestadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet23 = new Proyecto.ProyectoDataSet23();
            this.prestamosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet21BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet21 = new Proyecto.ProyectoDataSet21();
            this.prestamosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDias_P = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboID_Equipos = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prestamosTableAdapter = new Proyecto.ProyectoDataSet6TableAdapters.PrestamosTableAdapter();
            this.comboBox_RUT = new System.Windows.Forms.ComboBox();
            this.profesoresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.profesoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter1 = new Proyecto.ProyectoDataSet12TableAdapters.PrestamosTableAdapter();
            this.profesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesoresTableAdapter = new Proyecto.ProyectoDataSet21TableAdapters.ProfesoresTableAdapter();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter = new Proyecto.ProyectoDataSet21TableAdapters.EquiposTableAdapter();
            this.prestamosTableAdapter2 = new Proyecto.ProyectoDataSet21TableAdapters.PrestamosTableAdapter();
            this.profesoresTableAdapter1 = new Proyecto.ProyectoDataSet23TableAdapters.ProfesoresTableAdapter();
            this.prestamosTableAdapter3 = new Proyecto.ProyectoDataSet23TableAdapters.PrestamosTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet21BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Préstamo Equipo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Solicitantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(722, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Equipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fecha de Prestamo";
            // 
            // button1
            // 
            this.button1.Image = global::Proyecto.Properties.Resources.lupa;
            this.button1.Location = new System.Drawing.Point(138, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Buscar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fecha de Devolución";
            // 
            // dtp_Fecha_P
            // 
            this.dtp_Fecha_P.Location = new System.Drawing.Point(646, 96);
            this.dtp_Fecha_P.Name = "dtp_Fecha_P";
            this.dtp_Fecha_P.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha_P.TabIndex = 22;
            // 
            // dtp_Fecha_D
            // 
            this.dtp_Fecha_D.Location = new System.Drawing.Point(646, 124);
            this.dtp_Fecha_D.Name = "dtp_Fecha_D";
            this.dtp_Fecha_D.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha_D.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rutProfesores,
            this.equipoidDataGridViewTextBoxColumn,
            this.fechaprestamoDataGridViewTextBoxColumn,
            this.fechadevolucionDataGridViewTextBoxColumn,
            this.diasprestadosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prestamosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(148, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 347);
            this.dataGridView1.TabIndex = 24;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutProfesores
            // 
            this.rutProfesores.DataPropertyName = "rutProfesores";
            this.rutProfesores.HeaderText = "rutProfesores";
            this.rutProfesores.Name = "rutProfesores";
            // 
            // equipoidDataGridViewTextBoxColumn
            // 
            this.equipoidDataGridViewTextBoxColumn.DataPropertyName = "equipo_id";
            this.equipoidDataGridViewTextBoxColumn.HeaderText = "equipo_id";
            this.equipoidDataGridViewTextBoxColumn.Name = "equipoidDataGridViewTextBoxColumn";
            // 
            // fechaprestamoDataGridViewTextBoxColumn
            // 
            this.fechaprestamoDataGridViewTextBoxColumn.DataPropertyName = "fecha_prestamo";
            this.fechaprestamoDataGridViewTextBoxColumn.HeaderText = "fecha_prestamo";
            this.fechaprestamoDataGridViewTextBoxColumn.Name = "fechaprestamoDataGridViewTextBoxColumn";
            // 
            // fechadevolucionDataGridViewTextBoxColumn
            // 
            this.fechadevolucionDataGridViewTextBoxColumn.DataPropertyName = "fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.HeaderText = "fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.Name = "fechadevolucionDataGridViewTextBoxColumn";
            // 
            // diasprestadosDataGridViewTextBoxColumn
            // 
            this.diasprestadosDataGridViewTextBoxColumn.DataPropertyName = "dias_prestados";
            this.diasprestadosDataGridViewTextBoxColumn.HeaderText = "dias_prestados";
            this.diasprestadosDataGridViewTextBoxColumn.Name = "diasprestadosDataGridViewTextBoxColumn";
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.proyectoDataSet23;
            // 
            // proyectoDataSet23
            // 
            this.proyectoDataSet23.DataSetName = "ProyectoDataSet23";
            this.proyectoDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource2
            // 
            this.prestamosBindingSource2.DataMember = "Prestamos";
            this.prestamosBindingSource2.DataSource = this.proyectoDataSet21BindingSource;
            // 
            // proyectoDataSet21BindingSource
            // 
            this.proyectoDataSet21BindingSource.DataSource = this.proyectoDataSet21;
            this.proyectoDataSet21BindingSource.Position = 0;
            // 
            // proyectoDataSet21
            // 
            this.proyectoDataSet21.DataSetName = "ProyectoDataSet21";
            this.proyectoDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Image = global::Proyecto.Properties.Resources.agregar;
            this.button2.Location = new System.Drawing.Point(374, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Registrar Prestamo";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Proyecto.Properties.Resources.boton_actualizar;
            this.button3.Location = new System.Drawing.Point(500, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Actualizar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDias_P
            // 
            this.txtDias_P.Location = new System.Drawing.Point(646, 159);
            this.txtDias_P.Name = "txtDias_P";
            this.txtDias_P.Size = new System.Drawing.Size(115, 20);
            this.txtDias_P.TabIndex = 28;
            this.txtDias_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(767, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 27);
            this.button5.TabIndex = 29;
            this.button5.Text = "Calcular Dias";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboID_Equipos
            // 
            this.comboID_Equipos.FormattingEnabled = true;
            this.comboID_Equipos.Location = new System.Drawing.Point(646, 64);
            this.comboID_Equipos.Name = "comboID_Equipos";
            this.comboID_Equipos.Size = new System.Drawing.Size(200, 21);
            this.comboID_Equipos.TabIndex = 30;
            this.comboID_Equipos.SelectedIndexChanged += new System.EventHandler(this.comboID_Equipos_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido";
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_RUT
            // 
            this.comboBox_RUT.DataSource = this.profesoresBindingSource2;
            this.comboBox_RUT.DisplayMember = "rut";
            this.comboBox_RUT.FormattingEnabled = true;
            this.comboBox_RUT.Location = new System.Drawing.Point(119, 64);
            this.comboBox_RUT.Name = "comboBox_RUT";
            this.comboBox_RUT.Size = new System.Drawing.Size(114, 21);
            this.comboBox_RUT.TabIndex = 32;
            // 
            // profesoresBindingSource2
            // 
            this.profesoresBindingSource2.DataMember = "Profesores";
            this.profesoresBindingSource2.DataSource = this.proyectoDataSet23;
            // 
            // profesoresBindingSource1
            // 
            this.profesoresBindingSource1.DataMember = "Profesores";
            this.profesoresBindingSource1.DataSource = this.proyectoDataSet21BindingSource;
            // 
            // prestamosTableAdapter1
            // 
            this.prestamosTableAdapter1.ClearBeforeFill = true;
            // 
            // profesoresBindingSource
            // 
            this.profesoresBindingSource.DataMember = "Profesores";
            this.profesoresBindingSource.DataSource = this.proyectoDataSet21BindingSource;
            // 
            // profesoresTableAdapter
            // 
            this.profesoresTableAdapter.ClearBeforeFill = true;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.proyectoDataSet21BindingSource;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // prestamosTableAdapter2
            // 
            this.prestamosTableAdapter2.ClearBeforeFill = true;
            // 
            // profesoresTableAdapter1
            // 
            this.profesoresTableAdapter1.ClearBeforeFill = true;
            // 
            // prestamosTableAdapter3
            // 
            this.prestamosTableAdapter3.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.logoxd;
            this.pictureBox1.Location = new System.Drawing.Point(873, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_RUT);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboID_Equipos);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtDias_P);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtp_Fecha_D);
            this.Controls.Add(this.dtp_Fecha_P);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "|";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet21BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_P;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_D;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDias_P;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboID_Equipos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private ProyectoDataSet6TableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_RUT;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.BindingSource prestamosBindingSource1;
        private ProyectoDataSet12TableAdapters.PrestamosTableAdapter prestamosTableAdapter1;
        private System.Windows.Forms.BindingSource proyectoDataSet21BindingSource;
        private ProyectoDataSet21 proyectoDataSet21;
        private System.Windows.Forms.BindingSource profesoresBindingSource;
        private ProyectoDataSet21TableAdapters.ProfesoresTableAdapter profesoresTableAdapter;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private ProyectoDataSet21TableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.BindingSource prestamosBindingSource2;
        private ProyectoDataSet21TableAdapters.PrestamosTableAdapter prestamosTableAdapter2;
        private System.Windows.Forms.BindingSource profesoresBindingSource1;
        private ProyectoDataSet23 proyectoDataSet23;
        private System.Windows.Forms.BindingSource profesoresBindingSource2;
        private ProyectoDataSet23TableAdapters.ProfesoresTableAdapter profesoresTableAdapter1;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private ProyectoDataSet23TableAdapters.PrestamosTableAdapter prestamosTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutProfesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasprestadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}