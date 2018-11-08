namespace Presentacion.Formularios
{
    partial class Resultado
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
            this.btnAburrida = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnDenunciar = new System.Windows.Forms.Button();
            this.btnDivertida = new System.Windows.Forms.Button();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAburrida
            // 
            this.btnAburrida.Location = new System.Drawing.Point(33, 146);
            this.btnAburrida.Name = "btnAburrida";
            this.btnAburrida.Size = new System.Drawing.Size(139, 56);
            this.btnAburrida.TabIndex = 0;
            this.btnAburrida.Text = "Aburrida";
            this.btnAburrida.UseVisualStyleBackColor = true;
            this.btnAburrida.Click += new System.EventHandler(this.btnAburrida_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(94, 236);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(191, 38);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnDenunciar
            // 
            this.btnDenunciar.Location = new System.Drawing.Point(353, 263);
            this.btnDenunciar.Name = "btnDenunciar";
            this.btnDenunciar.Size = new System.Drawing.Size(96, 23);
            this.btnDenunciar.TabIndex = 3;
            this.btnDenunciar.Text = "Denunciar";
            this.btnDenunciar.UseVisualStyleBackColor = true;
            this.btnDenunciar.Click += new System.EventHandler(this.btnDenunciar_Click);
            // 
            // btnDivertida
            // 
            this.btnDivertida.Location = new System.Drawing.Point(210, 146);
            this.btnDivertida.Name = "btnDivertida";
            this.btnDivertida.Size = new System.Drawing.Size(139, 56);
            this.btnDivertida.TabIndex = 4;
            this.btnDivertida.Text = "Divertida";
            this.btnDivertida.UseVisualStyleBackColor = true;
            this.btnDivertida.Click += new System.EventHandler(this.btnDivertida_Click);
            // 
            // txtPregunta
            // 
            this.txtPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(60, 27);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(235, 92);
            this.txtPregunta.TabIndex = 2;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.btnDivertida);
            this.Controls.Add(this.btnDenunciar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnAburrida);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAburrida;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnDenunciar;
        private System.Windows.Forms.Button btnDivertida;
        private System.Windows.Forms.TextBox txtPregunta;
    }
}