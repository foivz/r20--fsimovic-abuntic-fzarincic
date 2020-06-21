namespace PresentationLayer.MainForm
{
    partial class FormMain
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
            this.buttonRacun = new System.Windows.Forms.Button();
            this.buttonnarudzbenica = new System.Windows.Forms.Button();
            this.buttonPrimka = new System.Windows.Forms.Button();
            this.buttonIzvještaj = new System.Windows.Forms.Button();
            this.buttonRegistriraj = new System.Windows.Forms.Button();
            this.buttonZaposlenici = new System.Windows.Forms.Button();
            this.buttonArtiklChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRacun
            // 
            this.buttonRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRacun.Location = new System.Drawing.Point(12, 60);
            this.buttonRacun.Name = "buttonRacun";
            this.buttonRacun.Size = new System.Drawing.Size(187, 115);
            this.buttonRacun.TabIndex = 0;
            this.buttonRacun.Text = "Izdaj novi račun";
            this.buttonRacun.UseVisualStyleBackColor = true;
            this.buttonRacun.Click += new System.EventHandler(this.buttonRacun_Click);
            // 
            // buttonnarudzbenica
            // 
            this.buttonnarudzbenica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonnarudzbenica.Location = new System.Drawing.Point(12, 181);
            this.buttonnarudzbenica.Name = "buttonnarudzbenica";
            this.buttonnarudzbenica.Size = new System.Drawing.Size(187, 115);
            this.buttonnarudzbenica.TabIndex = 1;
            this.buttonnarudzbenica.Text = "Izdaj novu narudžbenicu";
            this.buttonnarudzbenica.UseVisualStyleBackColor = true;
            this.buttonnarudzbenica.Click += new System.EventHandler(this.buttonnarudzbenica_Click);
            // 
            // buttonPrimka
            // 
            this.buttonPrimka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrimka.Location = new System.Drawing.Point(12, 302);
            this.buttonPrimka.Name = "buttonPrimka";
            this.buttonPrimka.Size = new System.Drawing.Size(187, 115);
            this.buttonPrimka.TabIndex = 2;
            this.buttonPrimka.Text = "Izdaj novu primku";
            this.buttonPrimka.UseVisualStyleBackColor = true;
            this.buttonPrimka.Click += new System.EventHandler(this.buttonPrimka_Click);
            // 
            // buttonIzvještaj
            // 
            this.buttonIzvještaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzvještaj.Location = new System.Drawing.Point(255, 13);
            this.buttonIzvještaj.Name = "buttonIzvještaj";
            this.buttonIzvještaj.Size = new System.Drawing.Size(187, 115);
            this.buttonIzvještaj.TabIndex = 3;
            this.buttonIzvještaj.Text = "Izvještaji";
            this.buttonIzvještaj.UseVisualStyleBackColor = true;
            this.buttonIzvještaj.Click += new System.EventHandler(this.buttonIzvještaj_Click);
            // 
            // buttonRegistriraj
            // 
            this.buttonRegistriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegistriraj.Location = new System.Drawing.Point(255, 134);
            this.buttonRegistriraj.Name = "buttonRegistriraj";
            this.buttonRegistriraj.Size = new System.Drawing.Size(187, 115);
            this.buttonRegistriraj.TabIndex = 4;
            this.buttonRegistriraj.Text = "Registriraj novog zaposlenika";
            this.buttonRegistriraj.UseVisualStyleBackColor = true;
            this.buttonRegistriraj.Click += new System.EventHandler(this.buttonRegistriraj_Click);
            // 
            // buttonZaposlenici
            // 
            this.buttonZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaposlenici.Location = new System.Drawing.Point(255, 255);
            this.buttonZaposlenici.Name = "buttonZaposlenici";
            this.buttonZaposlenici.Size = new System.Drawing.Size(187, 115);
            this.buttonZaposlenici.TabIndex = 5;
            this.buttonZaposlenici.Text = "Popis svih zaposlenih";
            this.buttonZaposlenici.UseVisualStyleBackColor = true;
            this.buttonZaposlenici.Click += new System.EventHandler(this.buttonZaposlenici_Click);
            // 
            // buttonArtiklChart
            // 
            this.buttonArtiklChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonArtiklChart.Location = new System.Drawing.Point(255, 376);
            this.buttonArtiklChart.Name = "buttonArtiklChart";
            this.buttonArtiklChart.Size = new System.Drawing.Size(187, 115);
            this.buttonArtiklChart.TabIndex = 6;
            this.buttonArtiklChart.Text = "Stanje zaliha";
            this.buttonArtiklChart.UseVisualStyleBackColor = true;
            this.buttonArtiklChart.Click += new System.EventHandler(this.buttonArtiklChart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 503);
            this.Controls.Add(this.buttonArtiklChart);
            this.Controls.Add(this.buttonZaposlenici);
            this.Controls.Add(this.buttonRegistriraj);
            this.Controls.Add(this.buttonIzvještaj);
            this.Controls.Add(this.buttonPrimka);
            this.Controls.Add(this.buttonnarudzbenica);
            this.Controls.Add(this.buttonRacun);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni izbornik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRacun;
        private System.Windows.Forms.Button buttonnarudzbenica;
        private System.Windows.Forms.Button buttonPrimka;
        private System.Windows.Forms.Button buttonIzvještaj;
        private System.Windows.Forms.Button buttonRegistriraj;
        private System.Windows.Forms.Button buttonZaposlenici;
        private System.Windows.Forms.Button buttonArtiklChart;
    }
}