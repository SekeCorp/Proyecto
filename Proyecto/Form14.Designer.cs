namespace Proyecto
{
    partial class Form14
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
            this.comboboxRut = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtApellidoProMod = new System.Windows.Forms.TextBox();
            this.lblModApellido = new System.Windows.Forms.Label();
            this.txtNombreModEq = new System.Windows.Forms.TextBox();
            this.btnModConfirmar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblModificarEquipo = new System.Windows.Forms.Label();
            this.lblModNombre = new System.Windows.Forms.Label();
            this.lblModRut = new System.Windows.Forms.Label();
            this.proyectoDataSet12 = new Proyecto.ProyectoDataSet12();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter = new Proyecto.ProyectoDataSet12TableAdapters.EquiposTableAdapter();
            this.proyectoDataSet13 = new Proyecto.ProyectoDataSet13();
            this.proyectoDataSet13BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter1 = new Proyecto.ProyectoDataSet13TableAdapters.EquiposTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroserieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equiposBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet13BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboboxRut
            // 
            this.comboboxRut.DataSource = this.equiposBindingSource2;
            this.comboboxRut.DisplayMember = "id";
            this.comboboxRut.FormattingEnabled = true;
            this.comboboxRut.Location = new System.Drawing.Point(167, 148);
            this.comboboxRut.Name = "comboboxRut";
            this.comboboxRut.Size = new System.Drawing.Size(134, 21);
            this.comboboxRut.TabIndex = 53;
            this.comboboxRut.ValueMember = "id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.Logo_Marca_Personal_Masculino_con_Iniciales_y_Nombre_Profesional_Blanco_y_Negro;
            this.pictureBox1.Location = new System.Drawing.Point(862, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // txtApellidoProMod
            // 
            this.txtApellidoProMod.Location = new System.Drawing.Point(167, 236);
            this.txtApellidoProMod.Name = "txtApellidoProMod";
            this.txtApellidoProMod.Size = new System.Drawing.Size(134, 20);
            this.txtApellidoProMod.TabIndex = 49;
            // 
            // lblModApellido
            // 
            this.lblModApellido.AutoSize = true;
            this.lblModApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModApellido.Location = new System.Drawing.Point(25, 235);
            this.lblModApellido.Name = "lblModApellido";
            this.lblModApellido.Size = new System.Drawing.Size(127, 18);
            this.lblModApellido.TabIndex = 48;
            this.lblModApellido.Text = "Numero de Serie";
            // 
            // txtNombreModEq
            // 
            this.txtNombreModEq.Location = new System.Drawing.Point(167, 197);
            this.txtNombreModEq.Name = "txtNombreModEq";
            this.txtNombreModEq.Size = new System.Drawing.Size(134, 20);
            this.txtNombreModEq.TabIndex = 47;
            // 
            // btnModConfirmar
            // 
            this.btnModConfirmar.Image = global::Proyecto.Properties.Resources.comprobar;
            this.btnModConfirmar.Location = new System.Drawing.Point(222, 294);
            this.btnModConfirmar.Name = "btnModConfirmar";
            this.btnModConfirmar.Size = new System.Drawing.Size(79, 29);
            this.btnModConfirmar.TabIndex = 46;
            this.btnModConfirmar.Text = "Confirmar";
            this.btnModConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModConfirmar.UseVisualStyleBackColor = true;
            this.btnModConfirmar.Click += new System.EventHandler(this.btnModConfirmar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(119, 294);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 29);
            this.btnModificar.TabIndex = 45;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.numeroserieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.equiposBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(342, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 316);
            this.dataGridView1.TabIndex = 44;
            // 
            // lblModificarEquipo
            // 
            this.lblModificarEquipo.AutoSize = true;
            this.lblModificarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblModificarEquipo.Location = new System.Drawing.Point(74, 98);
            this.lblModificarEquipo.Name = "lblModificarEquipo";
            this.lblModificarEquipo.Size = new System.Drawing.Size(190, 26);
            this.lblModificarEquipo.TabIndex = 43;
            this.lblModificarEquipo.Text = "Modificar Equipo";
            // 
            // lblModNombre
            // 
            this.lblModNombre.AutoSize = true;
            this.lblModNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModNombre.Location = new System.Drawing.Point(34, 197);
            this.lblModNombre.Name = "lblModNombre";
            this.lblModNombre.Size = new System.Drawing.Size(118, 18);
            this.lblModNombre.TabIndex = 40;
            this.lblModNombre.Text = "Nombre Equipo";
            // 
            // lblModRut
            // 
            this.lblModRut.AutoSize = true;
            this.lblModRut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModRut.Location = new System.Drawing.Point(129, 151);
            this.lblModRut.Name = "lblModRut";
            this.lblModRut.Size = new System.Drawing.Size(23, 18);
            this.lblModRut.TabIndex = 39;
            this.lblModRut.Text = "ID";
            // 
            // proyectoDataSet12
            // 
            this.proyectoDataSet12.DataSetName = "ProyectoDataSet12";
            this.proyectoDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.proyectoDataSet12;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // proyectoDataSet13
            // 
            this.proyectoDataSet13.DataSetName = "ProyectoDataSet13";
            this.proyectoDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoDataSet13BindingSource
            // 
            this.proyectoDataSet13BindingSource.DataSource = this.proyectoDataSet13;
            this.proyectoDataSet13BindingSource.Position = 0;
            // 
            // equiposBindingSource1
            // 
            this.equiposBindingSource1.DataMember = "Equipos";
            this.equiposBindingSource1.DataSource = this.proyectoDataSet13BindingSource;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // numeroserieDataGridViewTextBoxColumn
            // 
            this.numeroserieDataGridViewTextBoxColumn.DataPropertyName = "numero_serie";
            this.numeroserieDataGridViewTextBoxColumn.HeaderText = "numero_serie";
            this.numeroserieDataGridViewTextBoxColumn.Name = "numeroserieDataGridViewTextBoxColumn";
            // 
            // equiposBindingSource2
            // 
            this.equiposBindingSource2.DataMember = "Equipos";
            this.equiposBindingSource2.DataSource = this.proyectoDataSet13BindingSource;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 554);
            this.Controls.Add(this.comboboxRut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtApellidoProMod);
            this.Controls.Add(this.lblModApellido);
            this.Controls.Add(this.txtNombreModEq);
            this.Controls.Add(this.btnModConfirmar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblModificarEquipo);
            this.Controls.Add(this.lblModNombre);
            this.Controls.Add(this.lblModRut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet13BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxRut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtApellidoProMod;
        private System.Windows.Forms.Label lblModApellido;
        private System.Windows.Forms.TextBox txtNombreModEq;
        private System.Windows.Forms.Button btnModConfirmar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblModificarEquipo;
        private System.Windows.Forms.Label lblModNombre;
        private System.Windows.Forms.Label lblModRut;
        private ProyectoDataSet12 proyectoDataSet12;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private ProyectoDataSet12TableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.BindingSource proyectoDataSet13BindingSource;
        private ProyectoDataSet13 proyectoDataSet13;
        private System.Windows.Forms.BindingSource equiposBindingSource1;
        private ProyectoDataSet13TableAdapters.EquiposTableAdapter equiposTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroserieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource equiposBindingSource2;
    }
}