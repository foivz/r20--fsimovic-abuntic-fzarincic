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
            this.btnPomoc = new System.Windows.Forms.Button();
            this.helpProviderPomoc = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // buttonRacun
            // 
            this.buttonRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpProviderPomoc.SetHelpString(this.buttonRacun, "Klikom na ovaj gumb otvarate formu za izdavanje novog racuna");
            this.buttonRacun.Location = new System.Drawing.Point(17, 13);
            this.buttonRacun.Name = "buttonRacun";
            this.helpProviderPomoc.SetShowHelp(this.buttonRacun, true);
            this.buttonRacun.Size = new System.Drawing.Size(187, 115);
            this.buttonRacun.TabIndex = 0;
            this.buttonRacun.Text = "Izdaj novi račun";
            this.buttonRacun.UseVisualStyleBackColor = true;
            this.buttonRacun.Click += new System.EventHandler(this.buttonRacun_Click);
            // 
            // buttonnarudzbenica
            // 
            this.buttonnarudzbenica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpProviderPomoc.SetHelpString(this.buttonnarudzbenica, "Klikom na ovaj gumb otvarate formu za izdavanje nove narudžbenice");
            this.buttonnarudzbenica.Location = new System.Drawing.Point(17, 134);
            this.buttonnarudzbenica.Name = "buttonnarudzbenica";
            this.helpProviderPomoc.SetShowHelp(this.buttonnarudzbenica, true);
            this.buttonnarudzbenica.Size = new System.Drawing.Size(187, 115);
            this.buttonnarudzbenica.TabIndex = 1;
            this.buttonnarudzbenica.Text = "Izdaj novu narudžbenicu";
            this.buttonnarudzbenica.UseVisualStyleBackColor = true;
            this.buttonnarudzbenica.Click += new System.EventHandler(this.buttonnarudzbenica_Click);
            // 
            // buttonPrimka
            // 
            this.buttonPrimka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpProviderPomoc.SetHelpString(this.buttonPrimka, "Klikom na ovaj gumb otvarate formu za izdavanje nove primke");
            this.buttonPrimka.Location = new System.Drawing.Point(17, 255);
            this.buttonPrimka.Name = "buttonPrimka";
            this.helpProviderPomoc.SetShowHelp(this.buttonPrimka, true);
            this.buttonPrimka.Size = new System.Drawing.Size(187, 115);
            this.buttonPrimka.TabIndex = 2;
            this.buttonPrimka.Text = "Izdaj novu primku";
            this.buttonPrimka.UseVisualStyleBackColor = true;
            this.buttonPrimka.Click += new System.EventHandler(this.buttonPrimka_Click);
            // 
            // buttonIzvještaj
            // 
            this.buttonIzvještaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpProviderPomoc.SetHelpString(this.buttonIzvještaj, "Klikom na gumb prikazuju se izvještaji");
            this.buttonIzvještaj.Location = new System.Drawing.Point(255, 13);
            this.buttonIzvještaj.Name = "buttonIzvještaj";
            this.helpProviderPomoc.SetShowHelp(this.buttonIzvještaj, true);
            this.buttonIzvještaj.Size = new System.Drawing.Size(187, 115);
            this.buttonIzvještaj.TabIndex = 3;
            this.buttonIzvještaj.Text = "Izvještaji";
            this.buttonIzvještaj.UseVisualStyleBackColor = true;
            this.buttonIzvještaj.Click += new System.EventHandler(this.buttonIzvještaj_Click);
            // 
            // buttonRegistriraj
            // 
            this.buttonRegistriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpProviderPomoc.SetHelpString(this.buttonRegistriraj, "Klikom na gumb otvara se forma za registraciju novog zaposlenika");
            this.buttonRegistriraj.Location = new System.Drawing.Point(255, 134);
            this.buttonRegistriraj.Name = "buttonRegistriraj";
            this.helpProviderPomoc.SetShowHelp(this.buttonRegistriraj, true);
            this.buttonRegistriraj.Size = new System.Drawing.Size(187, 115);
            this.buttonRegistriraj.TabIndex = 4;
            this.buttonRegistriraj.Text = "Registriraj novog zaposlenika";
            this.buttonRegistriraj.UseVisualStyleBackColor = true;
            this.buttonRegistriraj.Click += new System.EventHandler(this.buttonRegistriraj_Click);
            // 
            // buttonZaposlenici
            // 
            this.buttonZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpProviderPomoc.SetHelpString(this.buttonZaposlenici, "Klikom na gumb otvarate popis zaposlenika");
            this.buttonZaposlenici.Location = new System.Drawing.Point(255, 255);
            this.buttonZaposlenici.Name = "buttonZaposlenici";
            this.helpProviderPomoc.SetShowHelp(this.buttonZaposlenici, true);
            this.buttonZaposlenici.Size = new System.Drawing.Size(187, 115);
            this.buttonZaposlenici.TabIndex = 5;
            this.buttonZaposlenici.Text = "Popis svih zaposlenih";
            this.buttonZaposlenici.UseVisualStyleBackColor = true;
            this.buttonZaposlenici.Click += new System.EventHandler(this.buttonZaposlenici_Click);
            // 
            // buttonArtiklChart
            // 
            this.buttonArtiklChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpProviderPomoc.SetHelpString(this.buttonArtiklChart, "Klikom na gumb prikazuje vam se stanje zaliha");
            this.buttonArtiklChart.Location = new System.Drawing.Point(17, 376);
            this.buttonArtiklChart.Name = "buttonArtiklChart";
            this.helpProviderPomoc.SetShowHelp(this.buttonArtiklChart, true);
            this.buttonArtiklChart.Size = new System.Drawing.Size(187, 115);
            this.buttonArtiklChart.TabIndex = 6;
            this.buttonArtiklChart.Text = "Stanje zaliha";
            this.buttonArtiklChart.UseVisualStyleBackColor = true;
            this.buttonArtiklChart.Click += new System.EventHandler(this.buttonArtiklChart_Click);
            // 
            // btnPomoc
            // 
            this.btnPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPomoc.ForeColor = System.Drawing.Color.Red;
            this.helpProviderPomoc.SetHelpString(this.btnPomoc, "-");
            this.btnPomoc.Location = new System.Drawing.Point(255, 376);
            this.btnPomoc.Name = "btnPomoc";
            this.helpProviderPomoc.SetShowHelp(this.btnPomoc, true);
            this.btnPomoc.Size = new System.Drawing.Size(187, 115);
            this.btnPomoc.TabIndex = 7;
            this.btnPomoc.Text = "Pomoć";
            this.btnPomoc.UseVisualStyleBackColor = true;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 503);
            this.Controls.Add(this.btnPomoc);
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
        private System.Windows.Forms.Button btnPomoc;
        private System.Windows.Forms.HelpProvider helpProviderPomoc;
    }
}