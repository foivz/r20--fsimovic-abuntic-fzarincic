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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZaposlenici
            // 
            this.dataGridViewZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZaposlenici.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewZaposlenici.Name = "dataGridViewZaposlenici";
            this.dataGridViewZaposlenici.Size = new System.Drawing.Size(775, 399);
            this.dataGridViewZaposlenici.TabIndex = 0;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(713, 418);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 1;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Location = new System.Drawing.Point(13, 418);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonIzbrisi.TabIndex = 2;
            this.buttonIzbrisi.Text = "Izbriši";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.buttonIzbrisi_Click);
            // 
            // FormSviZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.dataGridViewZaposlenici);
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
    }
}