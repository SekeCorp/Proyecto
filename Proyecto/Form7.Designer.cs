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
            this.enprestamoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet3 = new Proyecto.ProyectoDataSet3();
            this.equiposTableAdapter = new Proyecto.ProyectoDataSet3TableAdapters.EquiposTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomEquipo_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numSerie_txt = new System.Windows.Forms.TextBox();
            this.Agregar_btn = new System.Windows.Forms.Button();
            this.Actualizar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Equipo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.numeroserieDataGridViewTextBoxColumn,
            this.enprestamoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.equiposBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(333, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 327);
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
            // enprestamoDataGridViewCheckBoxColumn
            // 
            this.enprestamoDataGridViewCheckBoxColumn.DataPropertyName = "en_prestamo";
            this.enprestamoDataGridViewCheckBoxColumn.HeaderText = "en_prestamo";
            this.enprestamoDataGridViewCheckBoxColumn.Name = "enprestamoDataGridViewCheckBoxColumn";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese ID";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(171, 135);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 4;
            this.id_txt.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de Equipo";
            // 
            // nomEquipo_txt
            // 
            this.nomEquipo_txt.Location = new System.Drawing.Point(171, 191);
            this.nomEquipo_txt.Name = "nomEquipo_txt";
            this.nomEquipo_txt.Size = new System.Drawing.Size(100, 20);
            this.nomEquipo_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero de Serie";
            // 
            // numSerie_txt
            // 
            this.numSerie_txt.Location = new System.Drawing.Point(171, 246);
            this.numSerie_txt.Name = "numSerie_txt";
            this.numSerie_txt.Size = new System.Drawing.Size(100, 20);
            this.numSerie_txt.TabIndex = 8;
            // 
            // Agregar_btn
            // 
            this.Agregar_btn.Location = new System.Drawing.Point(114, 345);
            this.Agregar_btn.Name = "Agregar_btn";
            this.Agregar_btn.Size = new System.Drawing.Size(83, 23);
            this.Agregar_btn.TabIndex = 9;
            this.Agregar_btn.Text = "Agregar";
            this.Agregar_btn.UseVisualStyleBackColor = true;
            this.Agregar_btn.Click += new System.EventHandler(this.Agregar_btn_Click);
            // 
            // Actualizar_btn
            // 
            this.Actualizar_btn.Location = new System.Drawing.Point(608, 489);
            this.Actualizar_btn.Name = "Actualizar_btn";
            this.Actualizar_btn.Size = new System.Drawing.Size(75, 23);
            this.Actualizar_btn.TabIndex = 10;
            this.Actualizar_btn.Text = "Actualizar";
            this.Actualizar_btn.UseVisualStyleBackColor = true;
            this.Actualizar_btn.Click += new System.EventHandler(this.Actualizar_btn_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 590);
            this.Controls.Add(this.Actualizar_btn);
            this.Controls.Add(this.Agregar_btn);
            this.Controls.Add(this.numSerie_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomEquipo_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoDataSet3 proyectoDataSet3;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private ProyectoDataSet3TableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroserieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enprestamoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomEquipo_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numSerie_txt;
        private System.Windows.Forms.Button Agregar_btn;
        private System.Windows.Forms.Button Actualizar_btn;
    }
}