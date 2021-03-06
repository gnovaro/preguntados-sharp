﻿namespace Presentacion.Formularios
{
    partial class IdiomaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdiomaFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptarIdioma = new System.Windows.Forms.Button();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radEspanol = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptarIdioma);
            this.groupBox1.Controls.Add(this.radEnglish);
            this.groupBox1.Controls.Add(this.radEspanol);
            this.groupBox1.Location = new System.Drawing.Point(300, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(217, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un idioma";
            // 
            // btnAceptarIdioma
            // 
            this.btnAceptarIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptarIdioma.Location = new System.Drawing.Point(71, 87);
            this.btnAceptarIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarIdioma.Name = "btnAceptarIdioma";
            this.btnAceptarIdioma.Size = new System.Drawing.Size(67, 32);
            this.btnAceptarIdioma.TabIndex = 5;
            this.btnAceptarIdioma.Text = "Aceptar";
            this.btnAceptarIdioma.UseVisualStyleBackColor = false;
            this.btnAceptarIdioma.Click += new System.EventHandler(this.btnAceptarIdioma_Click);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(148, 45);
            this.radEnglish.Margin = new System.Windows.Forms.Padding(2);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 4;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            // 
            // radEspanol
            // 
            this.radEspanol.AutoSize = true;
            this.radEspanol.Location = new System.Drawing.Point(10, 45);
            this.radEspanol.Margin = new System.Windows.Forms.Padding(2);
            this.radEspanol.Name = "radEspanol";
            this.radEspanol.Size = new System.Drawing.Size(63, 17);
            this.radEspanol.TabIndex = 3;
            this.radEspanol.Text = "Español";
            this.radEspanol.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 241);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // IdiomaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IdiomaFrm";
            this.Text = "IdiomaFrm";
            this.Load += new System.EventHandler(this.IdiomaFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptarIdioma;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radEspanol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}