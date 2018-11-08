namespace Presentacion.Formularios
{
    partial class MenuPrincipal
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
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnPreguntaAgregar = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(179, 42);
            this.btnJugar.Margin = new System.Windows.Forms.Padding(2);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(212, 56);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnPreguntaAgregar
            // 
            this.btnPreguntaAgregar.Location = new System.Drawing.Point(179, 110);
            this.btnPreguntaAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreguntaAgregar.Name = "btnPreguntaAgregar";
            this.btnPreguntaAgregar.Size = new System.Drawing.Size(212, 56);
            this.btnPreguntaAgregar.TabIndex = 1;
            this.btnPreguntaAgregar.Text = "Agregar pregunta";
            this.btnPreguntaAgregar.UseVisualStyleBackColor = true;
            this.btnPreguntaAgregar.Click += new System.EventHandler(this.btnPreguntaAgregar_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(179, 186);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(212, 56);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(179, 259);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(2);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(212, 56);
            this.btnRanking.TabIndex = 3;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 292);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnPreguntaAgregar);
            this.Controls.Add(this.btnJugar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Preguntados";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnPreguntaAgregar;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnAtras;
    }
}