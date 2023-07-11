namespace Proyecto
{
    partial class Form2
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
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.Validar_btn = new System.Windows.Forms.Button();
            this.Clave_txt = new System.Windows.Forms.TextBox();
            this.Usuario_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_btn.Location = new System.Drawing.Point(347, 303);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(51, 20);
            this.Cancelar_btn.TabIndex = 29;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click_1);
            // 
            // Validar_btn
            // 
            this.Validar_btn.Enabled = false;
            this.Validar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validar_btn.Location = new System.Drawing.Point(333, 268);
            this.Validar_btn.Name = "Validar_btn";
            this.Validar_btn.Size = new System.Drawing.Size(81, 29);
            this.Validar_btn.TabIndex = 28;
            this.Validar_btn.Text = "Validar";
            this.Validar_btn.UseVisualStyleBackColor = true;
            this.Validar_btn.Click += new System.EventHandler(this.Validar_btn_Click_1);
            // 
            // Clave_txt
            // 
            this.Clave_txt.Enabled = false;
            this.Clave_txt.Location = new System.Drawing.Point(361, 204);
            this.Clave_txt.Name = "Clave_txt";
            this.Clave_txt.PasswordChar = '*';
            this.Clave_txt.Size = new System.Drawing.Size(100, 20);
            this.Clave_txt.TabIndex = 27;
            this.Clave_txt.TextChanged += new System.EventHandler(this.Clave_txt_TextChanged);
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.Location = new System.Drawing.Point(361, 143);
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(100, 20);
            this.Usuario_txt.TabIndex = 26;
            this.Usuario_txt.TextChanged += new System.EventHandler(this.Usuario_txt_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "Inicio de Sesión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.Logo_Marca_Personal_Masculino_con_Iniciales_y_Nombre_Profesional_Blanco_y_Negro;
            this.pictureBox1.Location = new System.Drawing.Point(685, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(795, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Validar_btn);
            this.Controls.Add(this.Clave_txt);
            this.Controls.Add(this.Usuario_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Button Validar_btn;
        private System.Windows.Forms.TextBox Clave_txt;
        private System.Windows.Forms.TextBox Usuario_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}