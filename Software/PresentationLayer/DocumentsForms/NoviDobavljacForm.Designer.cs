namespace PresentationLayer.DocumentsForms
{
    partial class NoviDobavljacForm
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzradi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboNaziv = new System.Windows.Forms.TextBox();
            this.tboOIB = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.Label();
            this.tboTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboAdresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.AllowDrop = true;
            this.btnOdustani.Location = new System.Drawing.Point(134, 169);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(105, 48);
            this.btnOdustani.TabIndex = 22;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnIzradi
            // 
            this.btnIzradi.Location = new System.Drawing.Point(12, 169);
            this.btnIzradi.Name = "btnIzradi";
            this.btnIzradi.Size = new System.Drawing.Size(105, 48);
            this.btnIzradi.TabIndex = 21;
            this.btnIzradi.Text = "Izradi primku";
            this.btnIzradi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Naziv:";
            // 
            // tboNaziv
            // 
            this.tboNaziv.Location = new System.Drawing.Point(75, 26);
            this.tboNaziv.Name = "tboNaziv";
            this.tboNaziv.Size = new System.Drawing.Size(164, 22);
            this.tboNaziv.TabIndex = 24;
            // 
            // tboOIB
            // 
            this.tboOIB.Location = new System.Drawing.Point(75, 54);
            this.tboOIB.Name = "tboOIB";
            this.tboOIB.Size = new System.Drawing.Size(164, 22);
            this.tboOIB.TabIndex = 26;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(12, 54);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(35, 17);
            this.A.TabIndex = 25;
            this.A.Text = "OIB:";
            // 
            // tboTelefon
            // 
            this.tboTelefon.Location = new System.Drawing.Point(75, 85);
            this.tboTelefon.Name = "tboTelefon";
            this.tboTelefon.Size = new System.Drawing.Size(164, 22);
            this.tboTelefon.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefon:";
            // 
            // tboEmail
            // 
            this.tboEmail.Location = new System.Drawing.Point(75, 113);
            this.tboEmail.Name = "tboEmail";
            this.tboEmail.Size = new System.Drawing.Size(164, 22);
            this.tboEmail.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tboAdresa
            // 
            this.tboAdresa.Location = new System.Drawing.Point(75, 141);
            this.tboAdresa.Name = "tboAdresa";
            this.tboAdresa.Size = new System.Drawing.Size(164, 22);
            this.tboAdresa.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Adresa:";
            // 
            // NoviDobavljacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 236);
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
            this.Controls.Add(this.btnIzradi);
            this.Name = "NoviDobavljacForm";
            this.Text = "Novi dobavljač";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzradi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboNaziv;
        private System.Windows.Forms.TextBox tboOIB;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.TextBox tboTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboAdresa;
        private System.Windows.Forms.Label label5;
    }
}