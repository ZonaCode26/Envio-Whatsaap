namespace EnvioWhatsaap
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mensaje = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mensaje
            // 
            this.Mensaje.Location = new System.Drawing.Point(63, 40);
            this.Mensaje.Multiline = true;
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(594, 159);
            this.Mensaje.TabIndex = 0;
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(322, 249);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 1;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 306);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.Mensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Mensaje;
        private System.Windows.Forms.Button Enviar;
    }
}

