namespace PresentationLayer.DocumentsForms
{
    partial class FormNovaNarudzbenica
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
            this.tboZaposlenik = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArtikl = new System.Windows.Forms.Label();
            this.dgvStavkeNarudzbenice = new System.Windows.Forms.DataGridView();
            this.cmbArtikl = new System.Windows.Forms.ComboBox();
            this.tboKolicina = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.Label();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.btnNoviArtikl = new System.Windows.Forms.Button();
            this.btnNoviDobavljac = new System.Windows.Forms.Button();
            this.cboDobavljac = new System.Windows.Forms.ComboBox();
            this.txtDobavljac = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtZaposlenik = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzradi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbenice)).BeginInit();
            this.SuspendLayout();
            // 
            // tboZaposlenik
            // 
            this.tboZaposlenik.Enabled = false;
            this.tboZaposlenik.Location = new System.Drawing.Point(667, 31);
            this.tboZaposlenik.Name = "tboZaposlenik";
            this.tboZaposlenik.Size = new System.Drawing.Size(100, 22);
            this.tboZaposlenik.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArtikl);
            this.groupBox1.Controls.Add(this.dgvStavkeNarudzbenice);
            this.groupBox1.Controls.Add(this.cmbArtikl);
            this.groupBox1.Controls.Add(this.tboKolicina);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.btnDodajArtikl);
            this.groupBox1.Controls.Add(this.btnNoviArtikl);
            this.groupBox1.Location = new System.Drawing.Point(3, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 366);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke narudzbenice:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtArtikl
            // 
            this.txtArtikl.AutoSize = true;
            this.txtArtikl.Location = new System.Drawing.Point(17, 29);
            this.txtArtikl.Name = "txtArtikl";
            this.txtArtikl.Size = new System.Drawing.Size(43, 17);
            this.txtArtikl.TabIndex = 30;
            this.txtArtikl.Text = "Artikl:";
            // 
            // dgvStavkeNarudzbenice
            // 
            this.dgvStavkeNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNarudzbenice.Location = new System.Drawing.Point(14, 93);
            this.dgvStavkeNarudzbenice.Name = "dgvStavkeNarudzbenice";
            this.dgvStavkeNarudzbenice.RowTemplate.Height = 24;
            this.dgvStavkeNarudzbenice.Size = new System.Drawing.Size(776, 260);
            this.dgvStavkeNarudzbenice.TabIndex = 18;
            // 
            // cmbArtikl
            // 
            this.cmbArtikl.FormattingEnabled = true;
            this.cmbArtikl.Location = new System.Drawing.Point(17, 52);
            this.cmbArtikl.Name = "cmbArtikl";
            this.cmbArtikl.Size = new System.Drawing.Size(121, 24);
            this.cmbArtikl.TabIndex = 29;
            // 
            // tboKolicina
            // 
            this.tboKolicina.Location = new System.Drawing.Point(161, 52);
            this.tboKolicina.Name = "tboKolicina";
            this.tboKolicina.Size = new System.Drawing.Size(100, 22);
            this.tboKolicina.TabIndex = 31;
            // 
            // txtKolicina
            // 
            this.txtKolicina.AutoSize = true;
            this.txtKolicina.Location = new System.Drawing.Point(162, 31);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(57, 17);
            this.txtKolicina.TabIndex = 32;
            this.txtKolicina.Text = "Kolicina";
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Location = new System.Drawing.Point(270, 36);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(105, 48);
            this.btnDodajArtikl.TabIndex = 33;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // btnNoviArtikl
            // 
            this.btnNoviArtikl.Location = new System.Drawing.Point(392, 36);
            this.btnNoviArtikl.Name = "btnNoviArtikl";
            this.btnNoviArtikl.Size = new System.Drawing.Size(105, 48);
            this.btnNoviArtikl.TabIndex = 36;
            this.btnNoviArtikl.Text = "Dodaj novi artikl";
            this.btnNoviArtikl.UseVisualStyleBackColor = true;
            this.btnNoviArtikl.Click += new System.EventHandler(this.btnNoviArtikl_Click);
            // 
            // btnNoviDobavljac
            // 
            this.btnNoviDobavljac.Location = new System.Drawing.Point(589, 100);
            this.btnNoviDobavljac.Name = "btnNoviDobavljac";
            this.btnNoviDobavljac.Size = new System.Drawing.Size(199, 34);
            this.btnNoviDobavljac.TabIndex = 59;
            this.btnNoviDobavljac.Text = "Novi dobavljac";
            this.btnNoviDobavljac.UseVisualStyleBackColor = true;
            this.btnNoviDobavljac.Click += new System.EventHandler(this.btnNoviDobavljac_Click);
            // 
            // cboDobavljac
            // 
            this.cboDobavljac.FormattingEnabled = true;
            this.cboDobavljac.Location = new System.Drawing.Point(667, 60);
            this.cboDobavljac.Name = "cboDobavljac";
            this.cboDobavljac.Size = new System.Drawing.Size(121, 24);
            this.cboDobavljac.TabIndex = 58;
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.AutoSize = true;
            this.txtDobavljac.Location = new System.Drawing.Point(586, 60);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(74, 17);
            this.txtDobavljac.TabIndex = 57;
            this.txtDobavljac.Text = "Dobavljač:";
            // 
            // txtDatum
            // 
            this.txtDatum.AutoSize = true;
            this.txtDatum.Location = new System.Drawing.Point(55, 31);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(53, 17);
            this.txtDatum.TabIndex = 52;
            this.txtDatum.Text = "Datum:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(58, 48);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(222, 22);
            this.dtpDatum.TabIndex = 51;
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.AutoSize = true;
            this.txtZaposlenik.Location = new System.Drawing.Point(585, 31);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(81, 17);
            this.txtZaposlenik.TabIndex = 50;
            this.txtZaposlenik.Text = "Zaposlenik:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.AllowDrop = true;
            this.btnOdustani.Location = new System.Drawing.Point(671, 516);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(105, 48);
            this.btnOdustani.TabIndex = 49;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIzradi
            // 
            this.btnIzradi.Location = new System.Drawing.Point(549, 516);
            this.btnIzradi.Name = "btnIzradi";
            this.btnIzradi.Size = new System.Drawing.Size(105, 48);
            this.btnIzradi.TabIndex = 48;
            this.btnIzradi.Text = "Izradi narudžbenicu";
            this.btnIzradi.UseVisualStyleBackColor = true;
            this.btnIzradi.Click += new System.EventHandler(this.btnIzradi_Click);
            // 
            // FormNovaNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.tboZaposlenik);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNoviDobavljac);
            this.Controls.Add(this.cboDobavljac);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzradi);
            this.Name = "FormNovaNarudzbenica";
            this.Text = "Nova narudžbenica";
            this.Load += new System.EventHandler(this.FormNovaNarudzbenica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbenice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboZaposlenik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtArtikl;
        private System.Windows.Forms.DataGridView dgvStavkeNarudzbenice;
        private System.Windows.Forms.ComboBox cmbArtikl;
        private System.Windows.Forms.TextBox tboKolicina;
        private System.Windows.Forms.Label txtKolicina;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.Button btnNoviArtikl;
        private System.Windows.Forms.Button btnNoviDobavljac;
        private System.Windows.Forms.ComboBox cboDobavljac;
        private System.Windows.Forms.Label txtDobavljac;
        private System.Windows.Forms.Label txtDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label txtZaposlenik;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzradi;
    }
}