namespace PresentationLayer.DocumentsForms
{
    partial class FormNoviRacun
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtZaposlenikIme = new System.Windows.Forms.Label();
            this.txtZaposlenik = new System.Windows.Forms.Label();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.Label();
            this.tboKolicina = new System.Windows.Forms.TextBox();
            this.txtArtikl = new System.Windows.Forms.Label();
            this.cmbArtikl = new System.Windows.Forms.ComboBox();
            this.tboUkupno = new System.Windows.Forms.TextBox();
            this.txtUkupno = new System.Windows.Forms.Label();
            this.tboPorezNaDodanuVrijednost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboPorezNaPotrosnju = new System.Windows.Forms.TextBox();
            this.txtPorezNaPotrošnju = new System.Windows.Forms.Label();
            this.tboOsnovica = new System.Windows.Forms.TextBox();
            this.txtOsnovica = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzdaj = new System.Windows.Forms.Button();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Stavke racuna:";
            // 
            // txtZaposlenikIme
            // 
            this.txtZaposlenikIme.AutoSize = true;
            this.txtZaposlenikIme.Location = new System.Drawing.Point(633, 14);
            this.txtZaposlenikIme.Name = "txtZaposlenikIme";
            this.txtZaposlenikIme.Size = new System.Drawing.Size(0, 17);
            this.txtZaposlenikIme.TabIndex = 36;
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.AutoSize = true;
            this.txtZaposlenik.Location = new System.Drawing.Point(545, 14);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(81, 17);
            this.txtZaposlenik.TabIndex = 35;
            this.txtZaposlenik.Text = "Zaposlenik:";
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Location = new System.Drawing.Point(265, 39);
            this.btnDodajArtikl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(105, 48);
            this.btnDodajArtikl.TabIndex = 34;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.AutoSize = true;
            this.txtKolicina.Location = new System.Drawing.Point(157, 34);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(57, 17);
            this.txtKolicina.TabIndex = 33;
            this.txtKolicina.Text = "Kolicina";
            // 
            // tboKolicina
            // 
            this.tboKolicina.Location = new System.Drawing.Point(156, 55);
            this.tboKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboKolicina.Name = "tboKolicina";
            this.tboKolicina.Size = new System.Drawing.Size(100, 22);
            this.tboKolicina.TabIndex = 32;
            // 
            // txtArtikl
            // 
            this.txtArtikl.AutoSize = true;
            this.txtArtikl.Location = new System.Drawing.Point(12, 32);
            this.txtArtikl.Name = "txtArtikl";
            this.txtArtikl.Size = new System.Drawing.Size(43, 17);
            this.txtArtikl.TabIndex = 31;
            this.txtArtikl.Text = "Artikl:";
            // 
            // cmbArtikl
            // 
            this.cmbArtikl.FormattingEnabled = true;
            this.cmbArtikl.Location = new System.Drawing.Point(12, 55);
            this.cmbArtikl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbArtikl.Name = "cmbArtikl";
            this.cmbArtikl.Size = new System.Drawing.Size(121, 24);
            this.cmbArtikl.TabIndex = 30;
            // 
            // tboUkupno
            // 
            this.tboUkupno.Location = new System.Drawing.Point(331, 401);
            this.tboUkupno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboUkupno.Name = "tboUkupno";
            this.tboUkupno.Size = new System.Drawing.Size(100, 22);
            this.tboUkupno.TabIndex = 29;
            // 
            // txtUkupno
            // 
            this.txtUkupno.AutoSize = true;
            this.txtUkupno.Location = new System.Drawing.Point(331, 380);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(61, 17);
            this.txtUkupno.TabIndex = 28;
            this.txtUkupno.Text = "Ukupno:";
            // 
            // tboPorezNaDodanuVrijednost
            // 
            this.tboPorezNaDodanuVrijednost.Location = new System.Drawing.Point(224, 401);
            this.tboPorezNaDodanuVrijednost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboPorezNaDodanuVrijednost.Name = "tboPorezNaDodanuVrijednost";
            this.tboPorezNaDodanuVrijednost.Size = new System.Drawing.Size(100, 22);
            this.tboPorezNaDodanuVrijednost.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "PDV:";
            // 
            // tboPorezNaPotrosnju
            // 
            this.tboPorezNaPotrosnju.Location = new System.Drawing.Point(117, 401);
            this.tboPorezNaPotrosnju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboPorezNaPotrosnju.Name = "tboPorezNaPotrosnju";
            this.tboPorezNaPotrosnju.Size = new System.Drawing.Size(100, 22);
            this.tboPorezNaPotrosnju.TabIndex = 25;
            // 
            // txtPorezNaPotrošnju
            // 
            this.txtPorezNaPotrošnju.AutoSize = true;
            this.txtPorezNaPotrošnju.Location = new System.Drawing.Point(119, 380);
            this.txtPorezNaPotrošnju.Name = "txtPorezNaPotrošnju";
            this.txtPorezNaPotrošnju.Size = new System.Drawing.Size(40, 17);
            this.txtPorezNaPotrošnju.TabIndex = 24;
            this.txtPorezNaPotrošnju.Text = "PNP:";
            // 
            // tboOsnovica
            // 
            this.tboOsnovica.Location = new System.Drawing.Point(12, 401);
            this.tboOsnovica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboOsnovica.Name = "tboOsnovica";
            this.tboOsnovica.Size = new System.Drawing.Size(100, 22);
            this.tboOsnovica.TabIndex = 23;
            // 
            // txtOsnovica
            // 
            this.txtOsnovica.AutoSize = true;
            this.txtOsnovica.Location = new System.Drawing.Point(13, 380);
            this.txtOsnovica.Name = "txtOsnovica";
            this.txtOsnovica.Size = new System.Drawing.Size(71, 17);
            this.txtOsnovica.TabIndex = 22;
            this.txtOsnovica.Text = "Osnovica:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.AllowDrop = true;
            this.btnOdustani.Location = new System.Drawing.Point(683, 390);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(105, 48);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIzdaj
            // 
            this.btnIzdaj.Location = new System.Drawing.Point(561, 390);
            this.btnIzdaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzdaj.Name = "btnIzdaj";
            this.btnIzdaj.Size = new System.Drawing.Size(105, 48);
            this.btnIzdaj.TabIndex = 20;
            this.btnIzdaj.Text = "Izdaj račun";
            this.btnIzdaj.UseVisualStyleBackColor = true;
            this.btnIzdaj.Click += new System.EventHandler(this.btnIzdaj_Click);
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(12, 113);
            this.dgvStavkeRacuna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.RowTemplate.Height = 24;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(776, 260);
            this.dgvStavkeRacuna.TabIndex = 19;
            // 
            // FormNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZaposlenikIme);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.btnDodajArtikl);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.tboKolicina);
            this.Controls.Add(this.txtArtikl);
            this.Controls.Add(this.cmbArtikl);
            this.Controls.Add(this.tboUkupno);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.tboPorezNaDodanuVrijednost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboPorezNaPotrosnju);
            this.Controls.Add(this.txtPorezNaPotrošnju);
            this.Controls.Add(this.tboOsnovica);
            this.Controls.Add(this.txtOsnovica);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzdaj);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNoviRacun";
            this.Text = "Novi racun";
            this.Load += new System.EventHandler(this.FormNoviRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtZaposlenikIme;
        private System.Windows.Forms.Label txtZaposlenik;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.Label txtKolicina;
        private System.Windows.Forms.TextBox tboKolicina;
        private System.Windows.Forms.Label txtArtikl;
        private System.Windows.Forms.ComboBox cmbArtikl;
        private System.Windows.Forms.TextBox tboUkupno;
        private System.Windows.Forms.Label txtUkupno;
        private System.Windows.Forms.TextBox tboPorezNaDodanuVrijednost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboPorezNaPotrosnju;
        private System.Windows.Forms.Label txtPorezNaPotrošnju;
        private System.Windows.Forms.TextBox tboOsnovica;
        private System.Windows.Forms.Label txtOsnovica;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzdaj;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
    }
}