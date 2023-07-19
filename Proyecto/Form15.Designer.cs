namespace Proyecto
{
    partial class Form15
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
            this.Materia = new System.Windows.Forms.Label();
            this.Sala = new System.Windows.Forms.Label();
            this.Periodo = new System.Windows.Forms.Label();
            this.Dias = new System.Windows.Forms.Label();
            this.Curso = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Materia
            // 
            this.Materia.AutoSize = true;
            this.Materia.Location = new System.Drawing.Point(91, 78);
            this.Materia.Name = "Materia";
            this.Materia.Size = new System.Drawing.Size(42, 13);
            this.Materia.TabIndex = 0;
            this.Materia.Text = "Materia";
            // 
            // Sala
            // 
            this.Sala.AutoSize = true;
            this.Sala.Location = new System.Drawing.Point(91, 114);
            this.Sala.Name = "Sala";
            this.Sala.Size = new System.Drawing.Size(28, 13);
            this.Sala.TabIndex = 1;
            this.Sala.Text = "Sala";
            // 
            // Periodo
            // 
            this.Periodo.AutoSize = true;
            this.Periodo.Location = new System.Drawing.Point(91, 156);
            this.Periodo.Name = "Periodo";
            this.Periodo.Size = new System.Drawing.Size(43, 13);
            this.Periodo.TabIndex = 2;
            this.Periodo.Text = "Periodo";
            // 
            // Dias
            // 
            this.Dias.AutoSize = true;
            this.Dias.Location = new System.Drawing.Point(91, 198);
            this.Dias.Name = "Dias";
            this.Dias.Size = new System.Drawing.Size(28, 13);
            this.Dias.TabIndex = 3;
            this.Dias.Text = "Dias";
            // 
            // Curso
            // 
            this.Curso.AutoSize = true;
            this.Curso.Location = new System.Drawing.Point(91, 245);
            this.Curso.Name = "Curso";
            this.Curso.Size = new System.Drawing.Size(34, 13);
            this.Curso.TabIndex = 4;
            this.Curso.Text = "Curso";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(161, 70);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(100, 20);
            this.txtMateria.TabIndex = 5;
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(161, 111);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(100, 20);
            this.txtSala.TabIndex = 6;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(161, 153);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodo.TabIndex = 7;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(161, 195);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 8;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(161, 238);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(161, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 235);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.Curso);
            this.Controls.Add(this.Dias);
            this.Controls.Add(this.Periodo);
            this.Controls.Add(this.Sala);
            this.Controls.Add(this.Materia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form15";
            this.Text = "Form15";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Materia;
        private System.Windows.Forms.Label Sala;
        private System.Windows.Forms.Label Periodo;
        private System.Windows.Forms.Label Dias;
        private System.Windows.Forms.Label Curso;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}