namespace Proyecto
{
    partial class Form7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroserieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet3 = new Proyecto.ProyectoDataSet3();
            this.equiposTableAdapter = new Proyecto.ProyectoDataSet3TableAdapters.EquiposTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.nomEquipo_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numSerie_txt = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.imgBarra = new System.Windows.Forms.PictureBox();
            this.btnGuardarQr = new System.Windows.Forms.Button();
            this.Actualizar_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cbx_id = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Equipo";
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
            this.dataGridView1.DataSource = this.equiposBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(396, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 201);
            this.dataGridView1.TabIndex = 2;
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
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.proyectoDataSet3;
            // 
            // proyectoDataSet3
            // 
            this.proyectoDataSet3.DataSetName = "ProyectoDataSet3";
            this.proyectoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de Equipo";
            // 
            // nomEquipo_txt
            // 
            this.nomEquipo_txt.Location = new System.Drawing.Point(190, 158);
            this.nomEquipo_txt.Name = "nomEquipo_txt";
            this.nomEquipo_txt.Size = new System.Drawing.Size(100, 20);
            this.nomEquipo_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero de Serie";
            // 
            // numSerie_txt
            // 
            this.numSerie_txt.Location = new System.Drawing.Point(190, 213);
            this.numSerie_txt.Name = "numSerie_txt";
            this.numSerie_txt.Size = new System.Drawing.Size(100, 20);
            this.numSerie_txt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Generador de Código de Barra";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Proyecto.Properties.Resources.agregar;
            this.btnAgregar.Location = new System.Drawing.Point(190, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 39);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // imgBarra
            // 
            this.imgBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBarra.Location = new System.Drawing.Point(333, 382);
            this.imgBarra.Name = "imgBarra";
            this.imgBarra.Size = new System.Drawing.Size(451, 134);
            this.imgBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBarra.TabIndex = 3;
            this.imgBarra.TabStop = false;
            // 
            // btnGuardarQr
            // 
            this.btnGuardarQr.Image = global::Proyecto.Properties.Resources.salvar;
            this.btnGuardarQr.Location = new System.Drawing.Point(441, 522);
            this.btnGuardarQr.Name = "btnGuardarQr";
            this.btnGuardarQr.Size = new System.Drawing.Size(100, 27);
            this.btnGuardarQr.TabIndex = 2;
            this.btnGuardarQr.Text = "Guardar Barra";
            this.btnGuardarQr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardarQr.UseVisualStyleBackColor = true;
            this.btnGuardarQr.Click += new System.EventHandler(this.btnGuardarQr_Click_1);
            // 
            // Actualizar_btn
            // 
            this.Actualizar_btn.Image = global::Proyecto.Properties.Resources.boton_actualizar;
            this.Actualizar_btn.Location = new System.Drawing.Point(518, 312);
            this.Actualizar_btn.Name = "Actualizar_btn";
            this.Actualizar_btn.Size = new System.Drawing.Size(100, 23);
            this.Actualizar_btn.TabIndex = 10;
            this.Actualizar_btn.Text = "Actualizar";
            this.Actualizar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Actualizar_btn.UseVisualStyleBackColor = true;
            this.Actualizar_btn.Click += new System.EventHandler(this.Actualizar_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 37;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(190, 436);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 23);
            this.btnGenerar.TabIndex = 38;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cbx_id
            // 
            this.cbx_id.FormattingEnabled = true;
            this.cbx_id.Location = new System.Drawing.Point(190, 409);
            this.cbx_id.Name = "cbx_id";
            this.cbx_id.Size = new System.Drawing.Size(100, 21);
            this.cbx_id.TabIndex = 39;
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
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbx_id);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.imgBarra);
            this.Controls.Add(this.btnGuardarQr);
            this.Controls.Add(this.Actualizar_btn);
            this.Controls.Add(this.numSerie_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomEquipo_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoDataSet3 proyectoDataSet3;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private ProyectoDataSet3TableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomEquipo_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numSerie_txt;
        private System.Windows.Forms.Button Actualizar_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroserieDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox imgBarra;
        private System.Windows.Forms.Button btnGuardarQr;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cbx_id;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}