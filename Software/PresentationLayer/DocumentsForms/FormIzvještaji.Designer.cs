﻿namespace PresentationLayer.DocumentsForms
{
    partial class FormIzvještaji
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
            this.btnSviZaposlenici = new System.Windows.Forms.Button();
            this.btnSviDobavljaci = new System.Windows.Forms.Button();
            this.btnSviArtikli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSviZaposlenici
            // 
            this.btnSviZaposlenici.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSviZaposlenici.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSviZaposlenici.Location = new System.Drawing.Point(0, 0);
            this.btnSviZaposlenici.Name = "btnSviZaposlenici";
            this.btnSviZaposlenici.Size = new System.Drawing.Size(358, 127);
            this.btnSviZaposlenici.TabIndex = 0;
            this.btnSviZaposlenici.Text = "Svi zaposlenici";
            this.btnSviZaposlenici.UseVisualStyleBackColor = true;
            this.btnSviZaposlenici.Click += new System.EventHandler(this.btnSviZaposlenici_Click);
            // 
            // btnSviDobavljaci
            // 
            this.btnSviDobavljaci.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSviDobavljaci.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSviDobavljaci.Location = new System.Drawing.Point(170, 127);
            this.btnSviDobavljaci.Name = "btnSviDobavljaci";
            this.btnSviDobavljaci.Size = new System.Drawing.Size(188, 150);
            this.btnSviDobavljaci.TabIndex = 1;
            this.btnSviDobavljaci.Text = "Svi dobavljači";
            this.btnSviDobavljaci.UseVisualStyleBackColor = true;
            this.btnSviDobavljaci.Click += new System.EventHandler(this.btnSviDobavljaci_Click);
            // 
            // btnSviArtikli
            // 
            this.btnSviArtikli.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSviArtikli.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSviArtikli.Location = new System.Drawing.Point(0, 127);
            this.btnSviArtikli.Name = "btnSviArtikli";
            this.btnSviArtikli.Size = new System.Drawing.Size(169, 150);
            this.btnSviArtikli.TabIndex = 2;
            this.btnSviArtikli.Text = "Svi artikli";
            this.btnSviArtikli.UseVisualStyleBackColor = true;
            this.btnSviArtikli.Click += new System.EventHandler(this.btnSviArtikli_Click);
            // 
            // FormIzvještaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 277);
            this.Controls.Add(this.btnSviArtikli);
            this.Controls.Add(this.btnSviDobavljaci);
            this.Controls.Add(this.btnSviZaposlenici);
            this.MaximizeBox = false;
            this.Name = "FormIzvještaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaji";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIzvještaji_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSviZaposlenici;
        private System.Windows.Forms.Button btnSviDobavljaci;
        private System.Windows.Forms.Button btnSviArtikli;
    }
}