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
            this.SuspendLayout();
            // 
            // buttonQrLogin
            // 
            this.buttonQrLogin.Location = new System.Drawing.Point(63, 127);
            this.buttonQrLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQrLogin.Name = "buttonQrLogin";
            this.buttonQrLogin.Size = new System.Drawing.Size(100, 28);
            this.buttonQrLogin.TabIndex = 4;
            this.buttonQrLogin.Text = "Logiraj s QR";
            this.buttonQrLogin.UseVisualStyleBackColor = true;
            this.buttonQrLogin.Click += new System.EventHandler(this.buttonQrLogin_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(63, 74);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 28);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonGenQrFrom
            // 
            this.buttonGenQrFrom.Location = new System.Drawing.Point(63, 181);
            this.buttonGenQrFrom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenQrFrom.Name = "buttonGenQrFrom";
            this.buttonGenQrFrom.Size = new System.Drawing.Size(100, 28);
            this.buttonGenQrFrom.TabIndex = 6;
            this.buttonGenQrFrom.Text = "Gen QR";
            this.buttonGenQrFrom.UseVisualStyleBackColor = true;
            this.buttonGenQrFrom.Click += new System.EventHandler(this.buttonGenQrFrom_Click);
            // 
            // buttonRegistracija
            // 
            this.buttonRegistracija.Location = new System.Drawing.Point(248, 74);
            this.buttonRegistracija.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistracija.Name = "buttonRegistracija";
            this.buttonRegistracija.Size = new System.Drawing.Size(100, 28);
            this.buttonRegistracija.TabIndex = 7;
            this.buttonRegistracija.Text = "Registracija";
            this.buttonRegistracija.UseVisualStyleBackColor = true;
            this.buttonRegistracija.Click += new System.EventHandler(this.buttonRegistracija_Click);
            // 
            // buttonSviZaposlenici
            // 
            this.buttonSviZaposlenici.Location = new System.Drawing.Point(248, 127);
            this.buttonSviZaposlenici.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSviZaposlenici.Name = "buttonSviZaposlenici";
            this.buttonSviZaposlenici.Size = new System.Drawing.Size(100, 50);
            this.buttonSviZaposlenici.TabIndex = 8;
            this.buttonSviZaposlenici.Text = "Ispis zaposlenika";
            this.buttonSviZaposlenici.UseVisualStyleBackColor = true;
            this.buttonSviZaposlenici.Click += new System.EventHandler(this.buttonSviZaposlenici_Click);
            // 
            // buttonDodajArtikl
            // 
            this.buttonDodajArtikl.Location = new System.Drawing.Point(248, 185);
            this.buttonDodajArtikl.Name = "buttonDodajArtikl";
            this.buttonDodajArtikl.Size = new System.Drawing.Size(100, 23);
            this.buttonDodajArtikl.TabIndex = 9;
            this.buttonDodajArtikl.Text = "Dodaj racun";
            this.buttonDodajArtikl.UseVisualStyleBackColor = true;
            this.buttonDodajArtikl.Click += new System.EventHandler(this.buttonDodajArtikl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj primku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDodajArtikl);
            this.Controls.Add(this.buttonSviZaposlenici);
            this.Controls.Add(this.buttonRegistracija);
            this.Controls.Add(this.buttonGenQrFrom);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonQrLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHelp";
            this.Text = "FormHelp";
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
    }
}