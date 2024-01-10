namespace Proyecto
{
    partial class Form17
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
            this.label2 = new System.Windows.Forms.Label();
            this.Materia = new System.Windows.Forms.Label();
            this.insertarbtn = new System.Windows.Forms.Button();
            this.cursocbx = new System.Windows.Forms.ComboBox();
            this.materiacbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(116, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Curso";
            // 
            // Materia
            // 
            this.Materia.AutoSize = true;
            this.Materia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Materia.Location = new System.Drawing.Point(113, 36);
            this.Materia.Name = "Materia";
            this.Materia.Size = new System.Drawing.Size(42, 13);
            this.Materia.TabIndex = 10;
            this.Materia.Text = "Materia";
            // 
            // insertarbtn
            // 
            this.insertarbtn.Location = new System.Drawing.Point(91, 157);
            this.insertarbtn.Name = "insertarbtn";
            this.insertarbtn.Size = new System.Drawing.Size(75, 23);
            this.insertarbtn.TabIndex = 9;
            this.insertarbtn.Text = "Insertar";
            this.insertarbtn.UseVisualStyleBackColor = true;
            this.insertarbtn.Click += new System.EventHandler(this.insertarbtn_Click_1);
            // 
            // cursocbx
            // 
            this.cursocbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cursocbx.FormattingEnabled = true;
            this.cursocbx.Location = new System.Drawing.Point(70, 111);
            this.cursocbx.Name = "cursocbx";
            this.cursocbx.Size = new System.Drawing.Size(121, 21);
            this.cursocbx.TabIndex = 8;
            // 
            // materiacbx
            // 
            this.materiacbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materiacbx.FormattingEnabled = true;
            this.materiacbx.Location = new System.Drawing.Point(70, 55);
            this.materiacbx.Name = "materiacbx";
            this.materiacbx.Size = new System.Drawing.Size(121, 21);
            this.materiacbx.TabIndex = 7;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Proyecto.Properties.Resources.logoxd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(270, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Materia);
            this.Controls.Add(this.insertarbtn);
            this.Controls.Add(this.cursocbx);
            this.Controls.Add(this.materiacbx);
            this.DoubleBuffered = true;
            this.Name = "Form17";
            this.Text = "Form17";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Materia;
        private System.Windows.Forms.Button insertarbtn;
        private System.Windows.Forms.ComboBox cursocbx;
        private System.Windows.Forms.ComboBox materiacbx;
    }
}