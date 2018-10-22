namespace Presentacion
{
    partial class Principal
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
            this.btnAceptarIdioma = new System.Windows.Forms.Button();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radEspanol = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptarIdioma);
            this.groupBox1.Controls.Add(this.radEnglish);
            this.groupBox1.Controls.Add(this.radEspanol);
            this.groupBox1.Location = new System.Drawing.Point(221, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un idioma";
            // 
            // btnAceptarIdioma
            // 
            this.btnAceptarIdioma.Location = new System.Drawing.Point(114, 107);
            this.btnAceptarIdioma.Name = "btnAceptarIdioma";
            this.btnAceptarIdioma.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarIdioma.TabIndex = 5;
            this.btnAceptarIdioma.Text = "Aceptar";
            this.btnAceptarIdioma.UseVisualStyleBackColor = true;
            this.btnAceptarIdioma.Click += new System.EventHandler(this.btnAceptarIdioma_Click);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(197, 55);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(75, 21);
            this.radEnglish.TabIndex = 4;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            // 
            // radEspanol
            // 
            this.radEspanol.AutoSize = true;
            this.radEspanol.Location = new System.Drawing.Point(13, 55);
            this.radEspanol.Name = "radEspanol";
            this.radEspanol.Size = new System.Drawing.Size(80, 21);
            this.radEspanol.TabIndex = 3;
            this.radEspanol.TabStop = true;
            this.radEspanol.Text = "Español";
            this.radEspanol.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(705, 375);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Preguntados ESBA Grupo 1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radEspanol;
        private System.Windows.Forms.Button btnAceptarIdioma;
    }
}