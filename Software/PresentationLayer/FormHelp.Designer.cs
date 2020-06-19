namespace PresentationLayer
{
    partial class FormHelp
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
            this.buttonQrLogin = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonGenQrFrom = new System.Windows.Forms.Button();
            this.buttonRegistracija = new System.Windows.Forms.Button();
            this.buttonSviZaposlenici = new System.Windows.Forms.Button();
            this.buttonDodajArtikl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQrLogin
            // 
            this.buttonQrLogin.Location = new System.Drawing.Point(47, 103);
            this.buttonQrLogin.Name = "buttonQrLogin";
            this.buttonQrLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonQrLogin.TabIndex = 4;
            this.buttonQrLogin.Text = "Logiraj s QR";
            this.buttonQrLogin.UseVisualStyleBackColor = true;
            this.buttonQrLogin.Click += new System.EventHandler(this.buttonQrLogin_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(47, 60);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonGenQrFrom
            // 
            this.buttonGenQrFrom.Location = new System.Drawing.Point(47, 147);
            this.buttonGenQrFrom.Name = "buttonGenQrFrom";
            this.buttonGenQrFrom.Size = new System.Drawing.Size(75, 23);
            this.buttonGenQrFrom.TabIndex = 6;
            this.buttonGenQrFrom.Text = "Gen QR";
            this.buttonGenQrFrom.UseVisualStyleBackColor = true;
            this.buttonGenQrFrom.Click += new System.EventHandler(this.buttonGenQrFrom_Click);
            // 
            // buttonRegistracija
            // 
            this.buttonRegistracija.Location = new System.Drawing.Point(186, 60);
            this.buttonRegistracija.Name = "buttonRegistracija";
            this.buttonRegistracija.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistracija.TabIndex = 7;
            this.buttonRegistracija.Text = "Registracija";
            this.buttonRegistracija.UseVisualStyleBackColor = true;
            this.buttonRegistracija.Click += new System.EventHandler(this.buttonRegistracija_Click);
            // 
            // buttonSviZaposlenici
            // 
            this.buttonSviZaposlenici.Location = new System.Drawing.Point(186, 103);
            this.buttonSviZaposlenici.Name = "buttonSviZaposlenici";
            this.buttonSviZaposlenici.Size = new System.Drawing.Size(75, 41);
            this.buttonSviZaposlenici.TabIndex = 8;
            this.buttonSviZaposlenici.Text = "Ispis zaposlenika";
            this.buttonSviZaposlenici.UseVisualStyleBackColor = true;
            this.buttonSviZaposlenici.Click += new System.EventHandler(this.buttonSviZaposlenici_Click);
            // 
            // buttonDodajArtikl
            // 
            this.buttonDodajArtikl.Location = new System.Drawing.Point(186, 150);
            this.buttonDodajArtikl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajArtikl.Name = "buttonDodajArtikl";
            this.buttonDodajArtikl.Size = new System.Drawing.Size(75, 19);
            this.buttonDodajArtikl.TabIndex = 9;
            this.buttonDodajArtikl.Text = "Dodaj racun";
            this.buttonDodajArtikl.UseVisualStyleBackColor = true;
            this.buttonDodajArtikl.Click += new System.EventHandler(this.buttonDodajArtikl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 19);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj primku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.Location = new System.Drawing.Point(47, 176);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(75, 23);
            this.btnIzvjestaji.TabIndex = 11;
            this.btnIzvjestaji.Text = "Izvještaji";
            this.btnIzvjestaji.UseVisualStyleBackColor = true;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 221);
            this.Controls.Add(this.btnIzvjestaji);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDodajArtikl);
            this.Controls.Add(this.buttonSviZaposlenici);
            this.Controls.Add(this.buttonRegistracija);
            this.Controls.Add(this.buttonGenQrFrom);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonQrLogin);
            this.KeyPreview = true;
            this.Name = "FormHelp";
            this.Text = "FormHelp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHelp_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormHelp_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQrLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonGenQrFrom;
        private System.Windows.Forms.Button buttonRegistracija;
        private System.Windows.Forms.Button buttonSviZaposlenici;
        private System.Windows.Forms.Button buttonDodajArtikl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIzvjestaji;
    }
}