namespace Presentacion.Formularios
{
    partial class DenunciaFrm
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtdenuncia = new System.Windows.Forms.TextBox();
            this.lbldenuncia = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(278, 234);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 36);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Enviar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtdenuncia
            // 
            this.txtdenuncia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdenuncia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdenuncia.Location = new System.Drawing.Point(79, 61);
            this.txtdenuncia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdenuncia.Multiline = true;
            this.txtdenuncia.Name = "txtdenuncia";
            this.txtdenuncia.Size = new System.Drawing.Size(313, 113);
            this.txtdenuncia.TabIndex = 2;
            // 
            // lbldenuncia
            // 
            this.lbldenuncia.AutoSize = true;
            this.lbldenuncia.Location = new System.Drawing.Point(75, 30);
            this.lbldenuncia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldenuncia.Name = "lbldenuncia";
            this.lbldenuncia.Size = new System.Drawing.Size(136, 17);
            this.lbldenuncia.TabIndex = 3;
            this.lbldenuncia.Text = "Ingrese su denuncia";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(78, 234);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(91, 36);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // DenunciaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 328);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lbldenuncia);
            this.Controls.Add(this.txtdenuncia);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DenunciaFrm";
            this.Text = "Denuncia";
            this.Load += new System.EventHandler(this.Denuncia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtdenuncia;
        private System.Windows.Forms.Label lbldenuncia;
        private System.Windows.Forms.Button btnAtras;
    }
}