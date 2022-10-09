
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImagenQR = new System.Windows.Forms.PictureBox();
            this.CuadroTexto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonGenerador = new System.Windows.Forms.Button();
            this.AdvertenciaText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenQR)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenQR
            // 
            this.ImagenQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImagenQR.Location = new System.Drawing.Point(224, 237);
            this.ImagenQR.Name = "ImagenQR";
            this.ImagenQR.Size = new System.Drawing.Size(300, 300);
            this.ImagenQR.TabIndex = 0;
            this.ImagenQR.TabStop = false;
            // 
            // CuadroTexto
            // 
            this.CuadroTexto.Location = new System.Drawing.Point(224, 12);
            this.CuadroTexto.MaxLength = 4296;
            this.CuadroTexto.Name = "CuadroTexto";
            this.CuadroTexto.Size = new System.Drawing.Size(300, 197);
            this.CuadroTexto.TabIndex = 1;
            this.CuadroTexto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba el texto a transformar:";
            // 
            // BotonGenerador
            // 
            this.BotonGenerador.Location = new System.Drawing.Point(113, 180);
            this.BotonGenerador.Name = "BotonGenerador";
            this.BotonGenerador.Size = new System.Drawing.Size(94, 29);
            this.BotonGenerador.TabIndex = 3;
            this.BotonGenerador.Text = "Generar QR";
            this.BotonGenerador.UseVisualStyleBackColor = true;
            this.BotonGenerador.Click += new System.EventHandler(this.BotonGenerador_Click);
            // 
            // AdvertenciaText
            // 
            this.AdvertenciaText.Location = new System.Drawing.Point(12, 237);
            this.AdvertenciaText.Name = "AdvertenciaText";
            this.AdvertenciaText.Size = new System.Drawing.Size(206, 280);
            this.AdvertenciaText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 549);
            this.Controls.Add(this.AdvertenciaText);
            this.Controls.Add(this.BotonGenerador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuadroTexto);
            this.Controls.Add(this.ImagenQR);
            this.Name = "Form1";
            this.Text = "Generador QR";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenQR;
        private System.Windows.Forms.RichTextBox CuadroTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonGenerador;
        private System.Windows.Forms.Label AdvertenciaText;
    }
}

