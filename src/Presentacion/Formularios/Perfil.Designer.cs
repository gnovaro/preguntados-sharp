﻿namespace Presentacion.Formularios
{
    partial class Perfil
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(264, 343);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(156, 57);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(88, 46);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(40, 17);
            this.lblProfile.TabIndex = 1;
            this.lblProfile.Text = "Perfil";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(193, 91);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(52, 17);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Puntos";
            // 
            // txtPoints
            // 
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoints.Enabled = false;
            this.txtPoints.Location = new System.Drawing.Point(273, 91);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(147, 15);
            this.txtPoints.TabIndex = 3;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.btnAtras);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Perfil";
            this.Text = "t";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtPoints;
    }
}