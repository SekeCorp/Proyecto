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
            this.label1 = new System.Windows.Forms.Label();
            this.RUT = new System.Windows.Forms.Label();
            this.cbx_rut = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_idHorario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Curso = new System.Windows.Forms.ComboBox();
            this.cbx_Dia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_Periodo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Editar Horario";
            // 
            // RUT
            // 
            this.RUT.AutoSize = true;
            this.RUT.Location = new System.Drawing.Point(162, 139);
            this.RUT.Name = "RUT";
            this.RUT.Size = new System.Drawing.Size(30, 13);
            this.RUT.TabIndex = 57;
            this.RUT.Text = "RUT";
            // 
            // cbx_rut
            // 
            this.cbx_rut.FormattingEnabled = true;
            this.cbx_rut.Location = new System.Drawing.Point(233, 136);
            this.cbx_rut.Name = "cbx_rut";
            this.cbx_rut.Size = new System.Drawing.Size(121, 21);
            this.cbx_rut.TabIndex = 58;
            this.cbx_rut.SelectedIndexChanged += new System.EventHandler(this.cbx_rut_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "ID Horario";
            // 
            // cbx_idHorario
            // 
            this.cbx_idHorario.FormattingEnabled = true;
            this.cbx_idHorario.Location = new System.Drawing.Point(233, 190);
            this.cbx_idHorario.Name = "cbx_idHorario";
            this.cbx_idHorario.Size = new System.Drawing.Size(121, 21);
            this.cbx_idHorario.TabIndex = 60;
            this.cbx_idHorario.SelectedIndexChanged += new System.EventHandler(this.cbx_idHorario_SelectedIndexChanged_1);
            this.cbx_idHorario.DropDownClosed += new System.EventHandler(this.cbx_idHorario_DropDownClosed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Curso";
            // 
            // cbx_Curso
            // 
            this.cbx_Curso.FormattingEnabled = true;
            this.cbx_Curso.Location = new System.Drawing.Point(466, 136);
            this.cbx_Curso.Name = "cbx_Curso";
            this.cbx_Curso.Size = new System.Drawing.Size(121, 21);
            this.cbx_Curso.TabIndex = 71;
            // 
            // cbx_Dia
            // 
            this.cbx_Dia.FormattingEnabled = true;
            this.cbx_Dia.Location = new System.Drawing.Point(466, 190);
            this.cbx_Dia.Name = "cbx_Dia";
            this.cbx_Dia.Size = new System.Drawing.Size(121, 21);
            this.cbx_Dia.TabIndex = 72;
            this.cbx_Dia.SelectedIndexChanged += new System.EventHandler(this.cbx_Dia_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Dia";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(670, 188);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmar.TabIndex = 74;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 170);
            this.dataGridView1.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Periodo";
            // 
            // cbx_Periodo
            // 
            this.cbx_Periodo.FormattingEnabled = true;
            this.cbx_Periodo.Location = new System.Drawing.Point(670, 136);
            this.cbx_Periodo.Name = "cbx_Periodo";
            this.cbx_Periodo.Size = new System.Drawing.Size(121, 21);
            this.cbx_Periodo.TabIndex = 64;
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
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_Dia);
            this.Controls.Add(this.cbx_Curso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Periodo);
            this.Controls.Add(this.cbx_idHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_rut);
            this.Controls.Add(this.RUT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RUT;
        private System.Windows.Forms.ComboBox cbx_rut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_idHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Curso;
        private System.Windows.Forms.ComboBox cbx_Dia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Periodo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}