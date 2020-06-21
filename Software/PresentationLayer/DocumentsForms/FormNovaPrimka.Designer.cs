﻿namespace PresentationLayer.DocumentsForms
{
    partial class FormNovaPrimka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaPrimka));
            this.txtZaposlenik = new System.Windows.Forms.Label();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.Label();
            this.tboKolicina = new System.Windows.Forms.TextBox();
            this.txtArtikl = new System.Windows.Forms.Label();
            this.cmbArtikl = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzradi = new System.Windows.Forms.Button();
            this.dgvStavkePrimke = new System.Windows.Forms.DataGridView();
            this.btnNoviArtikl = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtDatum = new System.Windows.Forms.Label();
            this.txtOdgoda = new System.Windows.Forms.Label();
            this.tboOdgoda = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.Label();
            this.tboNapomena = new System.Windows.Forms.TextBox();
            this.txtDobavljac = new System.Windows.Forms.Label();
            this.cboDobavljac = new System.Windows.Forms.ComboBox();
            this.btnNoviDobavljac = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.tboZaposlenik = new System.Windows.Forms.TextBox();
            this.btnBrisiDobavljaca = new System.Windows.Forms.Button();
            this.btnAzurirajDobavljaca = new System.Windows.Forms.Button();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.AutoSize = true;
            this.txtZaposlenik.Location = new System.Drawing.Point(539, 9);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(81, 17);
            this.txtZaposlenik.TabIndex = 34;
            this.txtZaposlenik.Text = "Zaposlenik:";
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Location = new System.Drawing.Point(269, 36);
            this.btnDodajArtikl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(105, 48);
            this.btnDodajArtikl.TabIndex = 33;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.AutoSize = true;
            this.txtKolicina.Location = new System.Drawing.Point(163, 31);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(57, 17);
            this.txtKolicina.TabIndex = 32;
            this.txtKolicina.Text = "Kolicina";
            // 
            // tboKolicina
            // 
            this.tboKolicina.Location = new System.Drawing.Point(161, 52);
            this.tboKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboKolicina.Name = "tboKolicina";
            this.tboKolicina.Size = new System.Drawing.Size(100, 22);
            this.tboKolicina.TabIndex = 31;
            // 
            // txtArtikl
            // 
            this.txtArtikl.AutoSize = true;
            this.txtArtikl.Location = new System.Drawing.Point(17, 30);
            this.txtArtikl.Name = "txtArtikl";
            this.txtArtikl.Size = new System.Drawing.Size(43, 17);
            this.txtArtikl.TabIndex = 30;
            this.txtArtikl.Text = "Artikl:";
            // 
            // cmbArtikl
            // 
            this.cmbArtikl.FormattingEnabled = true;
            this.cmbArtikl.Location = new System.Drawing.Point(17, 52);
            this.cmbArtikl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbArtikl.Name = "cmbArtikl";
            this.cmbArtikl.Size = new System.Drawing.Size(137, 24);
            this.cmbArtikl.TabIndex = 29;
            // 
            // btnOdustani
            // 
            this.btnOdustani.AllowDrop = true;
            this.btnOdustani.Location = new System.Drawing.Point(699, 497);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(105, 48);
            this.btnOdustani.TabIndex = 20;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIzradi
            // 
            this.btnIzradi.Location = new System.Drawing.Point(569, 497);
            this.btnIzradi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzradi.Name = "btnIzradi";
            this.btnIzradi.Size = new System.Drawing.Size(105, 48);
            this.btnIzradi.TabIndex = 19;
            this.btnIzradi.Text = "Izradi primku";
            this.btnIzradi.UseVisualStyleBackColor = true;
            this.btnIzradi.Click += new System.EventHandler(this.btnIzradi_Click);
            // 
            // dgvStavkePrimke
            // 
            this.dgvStavkePrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePrimke.Location = new System.Drawing.Point(13, 94);
            this.dgvStavkePrimke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStavkePrimke.Name = "dgvStavkePrimke";
            this.dgvStavkePrimke.RowTemplate.Height = 24;
            this.dgvStavkePrimke.Size = new System.Drawing.Size(776, 260);
            this.dgvStavkePrimke.TabIndex = 18;
            // 
            // btnNoviArtikl
            // 
            this.btnNoviArtikl.Location = new System.Drawing.Point(427, 36);
            this.btnNoviArtikl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoviArtikl.Name = "btnNoviArtikl";
            this.btnNoviArtikl.Size = new System.Drawing.Size(105, 48);
            this.btnNoviArtikl.TabIndex = 36;
            this.btnNoviArtikl.Text = "Dodaj novi artikl";
            this.btnNoviArtikl.UseVisualStyleBackColor = true;
            this.btnNoviArtikl.Click += new System.EventHandler(this.btnNoviArtikl_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(15, 26);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(223, 22);
            this.dtpDatum.TabIndex = 37;
            // 
            // txtDatum
            // 
            this.txtDatum.AutoSize = true;
            this.txtDatum.Location = new System.Drawing.Point(12, 9);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(53, 17);
            this.txtDatum.TabIndex = 38;
            this.txtDatum.Text = "Datum:";
            // 
            // txtOdgoda
            // 
            this.txtOdgoda.AutoSize = true;
            this.txtOdgoda.Location = new System.Drawing.Point(12, 62);
            this.txtOdgoda.Name = "txtOdgoda";
            this.txtOdgoda.Size = new System.Drawing.Size(63, 17);
            this.txtOdgoda.TabIndex = 39;
            this.txtOdgoda.Text = "Odgoda:";
            // 
            // tboOdgoda
            // 
            this.tboOdgoda.Location = new System.Drawing.Point(81, 58);
            this.tboOdgoda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboOdgoda.Name = "tboOdgoda";
            this.tboOdgoda.Size = new System.Drawing.Size(100, 22);
            this.tboOdgoda.TabIndex = 40;
            // 
            // txtNapomena
            // 
            this.txtNapomena.AutoSize = true;
            this.txtNapomena.Location = new System.Drawing.Point(248, 9);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(81, 17);
            this.txtNapomena.TabIndex = 41;
            this.txtNapomena.Text = "Napomena:";
            // 
            // tboNapomena
            // 
            this.tboNapomena.Location = new System.Drawing.Point(251, 30);
            this.tboNapomena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboNapomena.Multiline = true;
            this.tboNapomena.Name = "tboNapomena";
            this.tboNapomena.Size = new System.Drawing.Size(241, 86);
            this.tboNapomena.TabIndex = 42;
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.AutoSize = true;
            this.txtDobavljac.Location = new System.Drawing.Point(540, 38);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(74, 17);
            this.txtDobavljac.TabIndex = 43;
            this.txtDobavljac.Text = "Dobavljač:";
            // 
            // cboDobavljac
            // 
            this.cboDobavljac.FormattingEnabled = true;
            this.cboDobavljac.Location = new System.Drawing.Point(629, 38);
            this.cboDobavljac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDobavljac.Name = "cboDobavljac";
            this.cboDobavljac.Size = new System.Drawing.Size(159, 24);
            this.cboDobavljac.TabIndex = 44;
            // 
            // btnNoviDobavljac
            // 
            this.btnNoviDobavljac.Location = new System.Drawing.Point(725, 68);
            this.btnNoviDobavljac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoviDobavljac.Name = "btnNoviDobavljac";
            this.btnNoviDobavljac.Size = new System.Drawing.Size(81, 53);
            this.btnNoviDobavljac.TabIndex = 45;
            this.btnNoviDobavljac.Text = "Novi dobavljac";
            this.btnNoviDobavljac.UseVisualStyleBackColor = true;
            this.btnNoviDobavljac.Click += new System.EventHandler(this.btnNoviDobavljac_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrisi);
            this.groupBox1.Controls.Add(this.btnAzuriraj);
            this.groupBox1.Controls.Add(this.txtArtikl);
            this.groupBox1.Controls.Add(this.dgvStavkePrimke);
            this.groupBox1.Controls.Add(this.cmbArtikl);
            this.groupBox1.Controls.Add(this.tboKolicina);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.btnDodajArtikl);
            this.groupBox1.Controls.Add(this.btnNoviArtikl);
            this.groupBox1.Location = new System.Drawing.Point(15, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(797, 366);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke primke:";
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(667, 36);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(123, 48);
            this.btnIzbrisi.TabIndex = 38;
            this.btnIzbrisi.Text = "Izbrisi odabrani artikl";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(537, 36);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(123, 48);
            this.btnAzuriraj.TabIndex = 37;
            this.btnAzuriraj.Text = "Azuriraj odabrani artikl";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // tboZaposlenik
            // 
            this.tboZaposlenik.Enabled = false;
            this.tboZaposlenik.Location = new System.Drawing.Point(629, 9);
            this.tboZaposlenik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboZaposlenik.Name = "tboZaposlenik";
            this.tboZaposlenik.Size = new System.Drawing.Size(159, 22);
            this.tboZaposlenik.TabIndex = 47;
            // 
            // btnBrisiDobavljaca
            // 
            this.btnBrisiDobavljaca.Location = new System.Drawing.Point(531, 68);
            this.btnBrisiDobavljaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrisiDobavljaca.Name = "btnBrisiDobavljaca";
            this.btnBrisiDobavljaca.Size = new System.Drawing.Size(93, 53);
            this.btnBrisiDobavljaca.TabIndex = 48;
            this.btnBrisiDobavljaca.Text = "Brisi dobavljaca";
            this.btnBrisiDobavljaca.UseVisualStyleBackColor = true;
            this.btnBrisiDobavljaca.Click += new System.EventHandler(this.btnBrisiDobavljaca_Click);
            // 
            // btnAzurirajDobavljaca
            // 
            this.btnAzurirajDobavljaca.Location = new System.Drawing.Point(629, 68);
            this.btnAzurirajDobavljaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzurirajDobavljaca.Name = "btnAzurirajDobavljaca";
            this.btnAzurirajDobavljaca.Size = new System.Drawing.Size(89, 53);
            this.btnAzurirajDobavljaca.TabIndex = 49;
            this.btnAzurirajDobavljaca.Text = "Azuriraj dobavljaca";
            this.btnAzurirajDobavljaca.UseVisualStyleBackColor = true;
            this.btnAzurirajDobavljaca.Click += new System.EventHandler(this.btnAzurirajDobavljaca_Click);
            // 
            // btnPomoc
            // 
            this.btnPomoc.ForeColor = System.Drawing.Color.Red;
            this.btnPomoc.Location = new System.Drawing.Point(15, 496);
            this.btnPomoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(105, 48);
            this.btnPomoc.TabIndex = 50;
            this.btnPomoc.Text = "Pomoć";
            this.btnPomoc.UseVisualStyleBackColor = true;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // FormNovaPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 550);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.btnAzurirajDobavljaca);
            this.Controls.Add(this.btnBrisiDobavljaca);
            this.Controls.Add(this.tboZaposlenik);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNoviDobavljac);
            this.Controls.Add(this.cboDobavljac);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.tboNapomena);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.tboOdgoda);
            this.Controls.Add(this.txtOdgoda);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzradi);
            this.helpProvider1.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNovaPrimka";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova primka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNovaPrimka_FormClosing);
            this.Load += new System.EventHandler(this.PrimkaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtZaposlenik;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.Label txtKolicina;
        private System.Windows.Forms.TextBox tboKolicina;
        private System.Windows.Forms.Label txtArtikl;
        private System.Windows.Forms.ComboBox cmbArtikl;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzradi;
        private System.Windows.Forms.DataGridView dgvStavkePrimke;
        private System.Windows.Forms.Button btnNoviArtikl;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label txtDatum;
        private System.Windows.Forms.Label txtOdgoda;
        private System.Windows.Forms.TextBox tboOdgoda;
        private System.Windows.Forms.Label txtNapomena;
        private System.Windows.Forms.TextBox tboNapomena;
        private System.Windows.Forms.Label txtDobavljac;
        private System.Windows.Forms.ComboBox cboDobavljac;
        private System.Windows.Forms.Button btnNoviDobavljac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboZaposlenik;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnBrisiDobavljaca;
        private System.Windows.Forms.Button btnAzurirajDobavljaca;
        private System.Windows.Forms.Button btnPomoc;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}