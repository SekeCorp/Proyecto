namespace Proyecto
{
    partial class Form12
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
            this.idHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioClasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet9 = new Proyecto.ProyectoDataSet9();
            this.horarioClasesTableAdapter = new Proyecto.ProyectoDataSet9TableAdapters.HorarioClasesTableAdapter();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioClasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHorarioDataGridViewTextBoxColumn,
            this.rUTDataGridViewTextBoxColumn,
            this.materiaDataGridViewTextBoxColumn,
            this.salaDataGridViewTextBoxColumn,
            this.periodoDataGridViewTextBoxColumn,
            this.diasDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.horarioClasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // idHorarioDataGridViewTextBoxColumn
            // 
            this.idHorarioDataGridViewTextBoxColumn.DataPropertyName = "idHorario";
            this.idHorarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idHorarioDataGridViewTextBoxColumn.Name = "idHorarioDataGridViewTextBoxColumn";
            this.idHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rUTDataGridViewTextBoxColumn
            // 
            this.rUTDataGridViewTextBoxColumn.DataPropertyName = "RUT";
            this.rUTDataGridViewTextBoxColumn.HeaderText = "RUT";
            this.rUTDataGridViewTextBoxColumn.Name = "rUTDataGridViewTextBoxColumn";
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            this.materiaDataGridViewTextBoxColumn.DataPropertyName = "Materia";
            this.materiaDataGridViewTextBoxColumn.HeaderText = "Materia";
            this.materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            // 
            // salaDataGridViewTextBoxColumn
            // 
            this.salaDataGridViewTextBoxColumn.DataPropertyName = "Sala";
            this.salaDataGridViewTextBoxColumn.HeaderText = "Sala";
            this.salaDataGridViewTextBoxColumn.Name = "salaDataGridViewTextBoxColumn";
            // 
            // periodoDataGridViewTextBoxColumn
            // 
            this.periodoDataGridViewTextBoxColumn.DataPropertyName = "Periodo";
            this.periodoDataGridViewTextBoxColumn.HeaderText = "Periodo";
            this.periodoDataGridViewTextBoxColumn.Name = "periodoDataGridViewTextBoxColumn";
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "Dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "Dias";
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            // 
            // horarioClasesBindingSource
            // 
            this.horarioClasesBindingSource.DataMember = "HorarioClases";
            this.horarioClasesBindingSource.DataSource = this.proyectoDataSet9;
            // 
            // proyectoDataSet9
            // 
            this.proyectoDataSet9.DataSetName = "ProyectoDataSet9";
            this.proyectoDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horarioClasesTableAdapter
            // 
            this.horarioClasesTableAdapter.ClearBeforeFill = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(358, 403);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioClasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoDataSet9 proyectoDataSet9;
        private System.Windows.Forms.BindingSource horarioClasesBindingSource;
        private ProyectoDataSet9TableAdapters.HorarioClasesTableAdapter horarioClasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnImprimir;
    }
}