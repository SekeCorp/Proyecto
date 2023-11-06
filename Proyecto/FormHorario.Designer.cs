namespace Proyecto
{
    partial class FormHorario
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
            this.comboBoxProfesores = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridViewHorario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProfesores
            // 
            this.comboBoxProfesores.FormattingEnabled = true;
            this.comboBoxProfesores.Location = new System.Drawing.Point(26, 40);
            this.comboBoxProfesores.Name = "comboBoxProfesores";
            this.comboBoxProfesores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProfesores.TabIndex = 0;
            this.comboBoxProfesores.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfesores_SelectedIndexChanged_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(170, 40);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Generar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridViewHorario
            // 
            this.dataGridViewHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorario.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewHorario.Name = "dataGridViewHorario";
            this.dataGridViewHorario.Size = new System.Drawing.Size(776, 369);
            this.dataGridViewHorario.TabIndex = 2;
            // 
            // FormHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewHorario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboBoxProfesores);
            this.Name = "FormHorario";
            this.Text = "FormHorario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProfesores;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridViewHorario;
    }
}