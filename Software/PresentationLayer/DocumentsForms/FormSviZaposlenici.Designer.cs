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
            this.dataGridViewZaposlenici = new System.Windows.Forms.DataGridView();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.buttonUredi = new System.Windows.Forms.Button();
            this.buttonRefreshDGV = new System.Windows.Forms.Button();
            this.buttonGenQr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZaposlenici
            // 
            this.dataGridViewZaposlenici.AllowUserToAddRows = false;
            this.dataGridViewZaposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZaposlenici;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Button buttonUredi;
        private System.Windows.Forms.Button buttonRefreshDGV;
        private System.Windows.Forms.Button buttonGenQr;
    }
}