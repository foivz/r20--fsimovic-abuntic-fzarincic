namespace PresentationLayer.DocumentsForms
{
    partial class FormSviZaposlenici
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
            this.dataGridViewZaposlenici = new System.Windows.Forms.DataGridView();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.buttonUredi = new System.Windows.Forms.Button();
            this.buttonRefreshDGV = new System.Windows.Forms.Button();
            this.buttonGenQr = new System.Windows.Forms.Button();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojZIroRacunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ulogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZaposlenici
            // 
            this.dataGridViewZaposlenici.AllowUserToAddRows = false;
            this.dataGridViewZaposlenici.AutoGenerateColumns = false;
            this.dataGridViewZaposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.brojZIroRacunaDataGridViewTextBoxColumn,
            this.aktivanDataGridViewCheckBoxColumn,
            this.ulogaDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.korisnickoImeDataGridViewTextBoxColumn});
            this.dataGridViewZaposlenici.DataSource = this.zaposlenikBindingSource;
            this.dataGridViewZaposlenici.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewZaposlenici.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewZaposlenici.MultiSelect = false;
            this.dataGridViewZaposlenici.Name = "dataGridViewZaposlenici";
            this.dataGridViewZaposlenici.ReadOnly = true;
            this.dataGridViewZaposlenici.Size = new System.Drawing.Size(757, 401);
            this.dataGridViewZaposlenici.TabIndex = 0;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonZatvori.Location = new System.Drawing.Point(643, 401);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(114, 66);
            this.buttonZatvori.TabIndex = 1;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Location = new System.Drawing.Point(140, 410);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(86, 49);
            this.buttonIzbrisi.TabIndex = 3;
            this.buttonIzbrisi.Text = "Izbriši";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.buttonIzbrisi_Click);
            // 
            // buttonUredi
            // 
            this.buttonUredi.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonUredi.Location = new System.Drawing.Point(0, 401);
            this.buttonUredi.Name = "buttonUredi";
            this.buttonUredi.Size = new System.Drawing.Size(111, 66);
            this.buttonUredi.TabIndex = 2;
            this.buttonUredi.Text = "Uredi";
            this.buttonUredi.UseVisualStyleBackColor = true;
            this.buttonUredi.Click += new System.EventHandler(this.buttonUredi_Click);
            // 
            // buttonRefreshDGV
            // 
            this.buttonRefreshDGV.Location = new System.Drawing.Point(527, 410);
            this.buttonRefreshDGV.Name = "buttonRefreshDGV";
            this.buttonRefreshDGV.Size = new System.Drawing.Size(86, 49);
            this.buttonRefreshDGV.TabIndex = 4;
            this.buttonRefreshDGV.Text = "Osvježi zapise";
            this.buttonRefreshDGV.UseVisualStyleBackColor = true;
            this.buttonRefreshDGV.Click += new System.EventHandler(this.buttonRefreshDGV_Click);
            // 
            // buttonGenQr
            // 
            this.buttonGenQr.Location = new System.Drawing.Point(333, 410);
            this.buttonGenQr.Name = "buttonGenQr";
            this.buttonGenQr.Size = new System.Drawing.Size(86, 47);
            this.buttonGenQr.TabIndex = 5;
            this.buttonGenQr.Text = "Generiraj QR";
            this.buttonGenQr.UseVisualStyleBackColor = true;
            this.buttonGenQr.Click += new System.EventHandler(this.buttonGenQr_Click);
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(DatabaseLayer.Model.Zaposlenik);
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.Width = 69;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonDataGridViewTextBoxColumn.Width = 68;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // brojZIroRacunaDataGridViewTextBoxColumn
            // 
            this.brojZIroRacunaDataGridViewTextBoxColumn.DataPropertyName = "BrojZIroRacuna";
            this.brojZIroRacunaDataGridViewTextBoxColumn.HeaderText = "BrojZIroRacuna";
            this.brojZIroRacunaDataGridViewTextBoxColumn.Name = "brojZIroRacunaDataGridViewTextBoxColumn";
            this.brojZIroRacunaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojZIroRacunaDataGridViewTextBoxColumn.Width = 107;
            // 
            // aktivanDataGridViewCheckBoxColumn
            // 
            this.aktivanDataGridViewCheckBoxColumn.DataPropertyName = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.HeaderText = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.Name = "aktivanDataGridViewCheckBoxColumn";
            this.aktivanDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aktivanDataGridViewCheckBoxColumn.Width = 49;
            // 
            // ulogaDataGridViewTextBoxColumn
            // 
            this.ulogaDataGridViewTextBoxColumn.DataPropertyName = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.HeaderText = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.Name = "ulogaDataGridViewTextBoxColumn";
            this.ulogaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ulogaDataGridViewTextBoxColumn.Width = 60;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            this.oIBDataGridViewTextBoxColumn.Width = 50;
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            this.korisnickoImeDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnickoImeDataGridViewTextBoxColumn.Width = 98;
            // 
            // FormSviZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(757, 467);
            this.Controls.Add(this.buttonGenQr);
            this.Controls.Add(this.buttonRefreshDGV);
            this.Controls.Add(this.buttonUredi);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.dataGridViewZaposlenici);
            this.MaximizeBox = false;
            this.Name = "FormSviZaposlenici";
            this.Text = "Svi zaposlenici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSviZaposlenici_FormClosing);
            this.Load += new System.EventHandler(this.FormSviZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZaposlenici;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Button buttonUredi;
        private System.Windows.Forms.Button buttonRefreshDGV;
        private System.Windows.Forms.Button buttonGenQr;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojZIroRacunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
    }
}