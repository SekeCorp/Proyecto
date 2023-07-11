namespace Proyecto
{
    partial class BarraQr
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBarra = new System.Windows.Forms.TextBox();
            this.btnBarra = new System.Windows.Forms.Button();
            this.btnGuardarQr = new System.Windows.Forms.Button();
            this.imgBarra = new System.Windows.Forms.PictureBox();
            this.imgQr = new System.Windows.Forms.PictureBox();
            this.btnGqR = new System.Windows.Forms.Button();
            this.btnQr = new System.Windows.Forms.Button();
            this.txtQr = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgBarra);
            this.groupBox1.Controls.Add(this.btnGuardarQr);
            this.groupBox1.Controls.Add(this.btnBarra);
            this.groupBox1.Controls.Add(this.txtBarra);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo Barras";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgQr);
            this.groupBox2.Controls.Add(this.txtQr);
            this.groupBox2.Controls.Add(this.btnGqR);
            this.groupBox2.Controls.Add(this.btnQr);
            this.groupBox2.Location = new System.Drawing.Point(409, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 410);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Codigo QR";
            // 
            // txtBarra
            // 
            this.txtBarra.Location = new System.Drawing.Point(17, 39);
            this.txtBarra.Name = "txtBarra";
            this.txtBarra.Size = new System.Drawing.Size(328, 20);
            this.txtBarra.TabIndex = 0;
            // 
            // btnBarra
            // 
            this.btnBarra.Location = new System.Drawing.Point(103, 93);
            this.btnBarra.Name = "btnBarra";
            this.btnBarra.Size = new System.Drawing.Size(81, 33);
            this.btnBarra.TabIndex = 1;
            this.btnBarra.Text = "Generar";
            this.btnBarra.UseVisualStyleBackColor = true;
            this.btnBarra.Click += new System.EventHandler(this.btnBarra_Click);
            // 
            // btnGuardarQr
            // 
            this.btnGuardarQr.Location = new System.Drawing.Point(190, 93);
            this.btnGuardarQr.Name = "btnGuardarQr";
            this.btnGuardarQr.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarQr.TabIndex = 2;
            this.btnGuardarQr.Text = "Guardar";
            this.btnGuardarQr.UseVisualStyleBackColor = true;
            this.btnGuardarQr.Click += new System.EventHandler(this.btnGuardarQr_Click);
            // 
            // imgBarra
            // 
            this.imgBarra.Location = new System.Drawing.Point(17, 219);
            this.imgBarra.Name = "imgBarra";
            this.imgBarra.Size = new System.Drawing.Size(328, 134);
            this.imgBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBarra.TabIndex = 3;
            this.imgBarra.TabStop = false;
            // 
            // imgQr
            // 
            this.imgQr.Location = new System.Drawing.Point(114, 206);
            this.imgQr.Name = "imgQr";
            this.imgQr.Size = new System.Drawing.Size(156, 156);
            this.imgQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQr.TabIndex = 7;
            this.imgQr.TabStop = false;
            // 
            // btnGqR
            // 
            this.btnGqR.Location = new System.Drawing.Point(201, 93);
            this.btnGqR.Name = "btnGqR";
            this.btnGqR.Size = new System.Drawing.Size(81, 33);
            this.btnGqR.TabIndex = 6;
            this.btnGqR.Text = "Guardar";
            this.btnGqR.UseVisualStyleBackColor = true;
            // 
            // btnQr
            // 
            this.btnQr.Location = new System.Drawing.Point(114, 93);
            this.btnQr.Name = "btnQr";
            this.btnQr.Size = new System.Drawing.Size(81, 33);
            this.btnQr.TabIndex = 5;
            this.btnQr.Text = "Generar";
            this.btnQr.UseVisualStyleBackColor = true;
            this.btnQr.Click += new System.EventHandler(this.btnQr_Click);
            // 
            // txtQr
            // 
            this.txtQr.Location = new System.Drawing.Point(21, 39);
            this.txtQr.Name = "txtQr";
            this.txtQr.Size = new System.Drawing.Size(328, 20);
            this.txtQr.TabIndex = 4;
            // 
            // BarraQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BarraQr";
            this.Text = "BarraQr";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgBarra;
        private System.Windows.Forms.Button btnGuardarQr;
        private System.Windows.Forms.Button btnBarra;
        private System.Windows.Forms.TextBox txtBarra;
        private System.Windows.Forms.PictureBox imgQr;
        private System.Windows.Forms.TextBox txtQr;
        private System.Windows.Forms.Button btnGqR;
        private System.Windows.Forms.Button btnQr;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}