﻿namespace Proyecto
{
    partial class Login
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
            this.Validar_btn = new System.Windows.Forms.Button();
            this.Clave_txt = new System.Windows.Forms.TextBox();
            this.Usuario_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Validar_btn
            // 
            this.Validar_btn.Enabled = false;
            this.Validar_btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validar_btn.Location = new System.Drawing.Point(436, 344);
            this.Validar_btn.Name = "Validar_btn";
            this.Validar_btn.Size = new System.Drawing.Size(89, 33);
            this.Validar_btn.TabIndex = 28;
            this.Validar_btn.Text = "Ingresar";
            this.Validar_btn.UseVisualStyleBackColor = true;
            this.Validar_btn.Click += new System.EventHandler(this.Validar_btn_Click_1);
            // 
            // Clave_txt
            // 
            this.Clave_txt.Enabled = false;
            this.Clave_txt.Location = new System.Drawing.Point(461, 284);
            this.Clave_txt.Name = "Clave_txt";
            this.Clave_txt.PasswordChar = '*';
            this.Clave_txt.Size = new System.Drawing.Size(100, 20);
            this.Clave_txt.TabIndex = 27;
            this.Clave_txt.TextChanged += new System.EventHandler(this.Clave_txt_TextChanged);
            this.Clave_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clave_txt_KeyDown);
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.Location = new System.Drawing.Point(461, 223);
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(100, 20);
            this.Usuario_txt.TabIndex = 26;
            this.Usuario_txt.TextChanged += new System.EventHandler(this.Usuario_txt_TextChanged_1);
            this.Usuario_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Usuario_txt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "Inicio de Sesión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.logoxd;
            this.pictureBox1.Location = new System.Drawing.Point(833, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_btn.Image = global::Proyecto.Properties.Resources.borrar;
            this.Cancelar_btn.Location = new System.Drawing.Point(447, 383);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(67, 26);
            this.Cancelar_btn.TabIndex = 29;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 593);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
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