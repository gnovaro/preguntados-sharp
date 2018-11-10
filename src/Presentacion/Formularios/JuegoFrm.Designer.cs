namespace Presentacion.Formularios
{
    partial class JuegoFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radOpcion4 = new System.Windows.Forms.RadioButton();
            this.radOpcion3 = new System.Windows.Forms.RadioButton();
            this.radOpcion2 = new System.Windows.Forms.RadioButton();
            this.radOpcion1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnResponderPregunta = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnOp1 = new System.Windows.Forms.Button();
            this.btnOp2 = new System.Windows.Forms.Button();
            this.btnOp3 = new System.Windows.Forms.Button();
            this.btnOp4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblCategoria);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblCategoria
            // 
            resources.ApplyResources(this.lblCategoria, "lblCategoria");
            this.lblCategoria.Name = "lblCategoria";
            // 
            // txtPregunta
            // 
            this.txtPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtPregunta, "txtPregunta");
            this.txtPregunta.Name = "txtPregunta";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radOpcion4);
            this.panel2.Controls.Add(this.radOpcion3);
            this.panel2.Controls.Add(this.radOpcion2);
            this.panel2.Controls.Add(this.radOpcion1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // radOpcion4
            // 
            resources.ApplyResources(this.radOpcion4, "radOpcion4");
            this.radOpcion4.Name = "radOpcion4";
            this.radOpcion4.TabStop = true;
            this.radOpcion4.UseVisualStyleBackColor = true;
            // 
            // radOpcion3
            // 
            resources.ApplyResources(this.radOpcion3, "radOpcion3");
            this.radOpcion3.Name = "radOpcion3";
            this.radOpcion3.TabStop = true;
            this.radOpcion3.UseVisualStyleBackColor = true;
            // 
            // radOpcion2
            // 
            resources.ApplyResources(this.radOpcion2, "radOpcion2");
            this.radOpcion2.Name = "radOpcion2";
            this.radOpcion2.TabStop = true;
            this.radOpcion2.UseVisualStyleBackColor = true;
            // 
            // radOpcion1
            // 
            resources.ApplyResources(this.radOpcion1, "radOpcion1");
            this.radOpcion1.Name = "radOpcion1";
            this.radOpcion1.TabStop = true;
            this.radOpcion1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnResponderPregunta
            // 
            resources.ApplyResources(this.btnResponderPregunta, "btnResponderPregunta");
            this.btnResponderPregunta.Name = "btnResponderPregunta";
            this.btnResponderPregunta.UseVisualStyleBackColor = true;
            this.btnResponderPregunta.Click += new System.EventHandler(this.btnResponderPregunta_Click);
            // 
            // lblTiempo
            // 
            resources.ApplyResources(this.lblTiempo, "lblTiempo");
            this.lblTiempo.Name = "lblTiempo";
            // 
            // btnOp1
            // 
            resources.ApplyResources(this.btnOp1, "btnOp1");
            this.btnOp1.Name = "btnOp1";
            this.btnOp1.UseVisualStyleBackColor = true;
            this.btnOp1.Click += new System.EventHandler(this.btnOp1_Click);
            // 
            // btnOp2
            // 
            resources.ApplyResources(this.btnOp2, "btnOp2");
            this.btnOp2.Name = "btnOp2";
            this.btnOp2.UseVisualStyleBackColor = true;
            this.btnOp2.Click += new System.EventHandler(this.btnOp2_Click);
            // 
            // btnOp3
            // 
            resources.ApplyResources(this.btnOp3, "btnOp3");
            this.btnOp3.Name = "btnOp3";
            this.btnOp3.UseVisualStyleBackColor = true;
            this.btnOp3.Click += new System.EventHandler(this.btnOp3_Click);
            // 
            // btnOp4
            // 
            resources.ApplyResources(this.btnOp4, "btnOp4");
            this.btnOp4.Name = "btnOp4";
            this.btnOp4.UseVisualStyleBackColor = true;
            this.btnOp4.Click += new System.EventHandler(this.btnOp4_Click);
            // 
            // JuegoFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOp4);
            this.Controls.Add(this.btnOp3);
            this.Controls.Add(this.btnOp2);
            this.Controls.Add(this.btnOp1);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnResponderPregunta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.panel1);
            this.Name = "JuegoFrm";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radOpcion4;
        private System.Windows.Forms.RadioButton radOpcion3;
        private System.Windows.Forms.RadioButton radOpcion2;
        private System.Windows.Forms.RadioButton radOpcion1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnResponderPregunta;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnOp1;
        private System.Windows.Forms.Button btnOp2;
        private System.Windows.Forms.Button btnOp3;
        private System.Windows.Forms.Button btnOp4;
    }
}