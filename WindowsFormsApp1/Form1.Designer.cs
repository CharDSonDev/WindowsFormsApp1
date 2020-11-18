
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.ButtonContinuar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.ButtonRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo electronico";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(233, 62);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(100, 20);
            this.textCorreo.TabIndex = 1;
            // 
            // ButtonContinuar
            // 
            this.ButtonContinuar.Location = new System.Drawing.Point(258, 193);
            this.ButtonContinuar.Name = "ButtonContinuar";
            this.ButtonContinuar.Size = new System.Drawing.Size(75, 23);
            this.ButtonContinuar.TabIndex = 2;
            this.ButtonContinuar.Text = "Continuar";
            this.ButtonContinuar.UseVisualStyleBackColor = true;
            this.ButtonContinuar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // textContrasena
            // 
            this.textContrasena.Location = new System.Drawing.Point(233, 123);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.Size = new System.Drawing.Size(100, 20);
            this.textContrasena.TabIndex = 4;
            // 
            // ButtonRegistrarse
            // 
            this.ButtonRegistrarse.Location = new System.Drawing.Point(87, 193);
            this.ButtonRegistrarse.Name = "ButtonRegistrarse";
            this.ButtonRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.ButtonRegistrarse.TabIndex = 5;
            this.ButtonRegistrarse.Text = "Registrarse";
            this.ButtonRegistrarse.UseVisualStyleBackColor = true;
            this.ButtonRegistrarse.Click += new System.EventHandler(this.ButtonRegistrarse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 291);
            this.Controls.Add(this.ButtonRegistrarse);
            this.Controls.Add(this.textContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonContinuar);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Button ButtonContinuar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textContrasena;
        private System.Windows.Forms.Button ButtonRegistrarse;
    }
}

