namespace PresentationLayer.DocumentsForms
{
    partial class FormAzurirajDobavljaca
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
            this.tboAdresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboOIB = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.Label();
            this.tboNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboAdresa
            // 
            this.tboAdresa.Location = new System.Drawing.Point(75, 124);
            this.tboAdresa.Name = "tboAdresa";
            this.tboAdresa.Size = new System.Drawing.Size(164, 22);
            this.tboAdresa.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Adresa:";
            // 
            // tboEmail
            // 
            this.tboEmail.Location = new System.Drawing.Point(75, 96);
            this.tboEmail.Name = "tboEmail";
            this.tboEmail.Size = new System.Drawing.Size(164, 22);
            this.tboEmail.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Email:";
            // 
            // tboTelefon
            // 
            this.tboTelefon.Location = new System.Drawing.Point(75, 68);
            this.tboTelefon.Name = "tboTelefon";
            this.tboTelefon.Size = new System.Drawing.Size(164, 22);
            this.tboTelefon.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Telefon:";
            // 
            // tboOIB
            // 
            this.tboOIB.Location = new System.Drawing.Point(75, 37);
            this.tboOIB.Name = "tboOIB";
            this.tboOIB.Size = new System.Drawing.Size(164, 22);
            this.tboOIB.TabIndex = 38;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(12, 37);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(35, 17);
            this.A.TabIndex = 37;
            this.A.Text = "OIB:";
            // 
            // tboNaziv
            // 
            this.tboNaziv.Location = new System.Drawing.Point(75, 9);
            this.tboNaziv.Name = "tboNaziv";
            this.tboNaziv.Size = new System.Drawing.Size(164, 22);
            this.tboNaziv.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Naziv:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.AllowDrop = true;
            this.btnOdustani.Location = new System.Drawing.Point(134, 152);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(105, 48);
            this.btnOdustani.TabIndex = 34;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 152);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 48);
            this.btnDodaj.TabIndex = 33;
            this.btnDodaj.Text = "Azuriraj dobavljaca";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormAzurirajDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 218);
            this.Controls.Add(this.tboAdresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboOIB);
            this.Controls.Add(this.A);
            this.Controls.Add(this.tboNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FormAzurirajDobavljaca";
            this.Text = "Azuriraj dobavljaca";
            this.Load += new System.EventHandler(this.FormAzurirajDobavljaca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboAdresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboOIB;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.TextBox tboNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
    }
}