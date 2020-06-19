namespace PresentationLayer.DocumentsForms
{
    partial class FormIzvještaji
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
            this.btnSviZaposlenici = new System.Windows.Forms.Button();
            this.btnSviDobavljaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSviZaposlenici
            // 
            this.btnSviZaposlenici.Location = new System.Drawing.Point(38, 73);
            this.btnSviZaposlenici.Name = "btnSviZaposlenici";
            this.btnSviZaposlenici.Size = new System.Drawing.Size(97, 26);
            this.btnSviZaposlenici.TabIndex = 0;
            this.btnSviZaposlenici.Text = "Svi zaposlenici";
            this.btnSviZaposlenici.UseVisualStyleBackColor = true;
            this.btnSviZaposlenici.Click += new System.EventHandler(this.btnSviZaposlenici_Click);
            // 
            // btnSviDobavljaci
            // 
            this.btnSviDobavljaci.Location = new System.Drawing.Point(38, 129);
            this.btnSviDobavljaci.Name = "btnSviDobavljaci";
            this.btnSviDobavljaci.Size = new System.Drawing.Size(97, 26);
            this.btnSviDobavljaci.TabIndex = 1;
            this.btnSviDobavljaci.Text = "Svi dobavljači";
            this.btnSviDobavljaci.UseVisualStyleBackColor = true;
            this.btnSviDobavljaci.Click += new System.EventHandler(this.btnSviDobavljaci_Click);
            // 
            // FormIzvještaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 326);
            this.Controls.Add(this.btnSviDobavljaci);
            this.Controls.Add(this.btnSviZaposlenici);
            this.Name = "FormIzvještaji";
            this.Text = "Izvještaji";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSviZaposlenici;
        private System.Windows.Forms.Button btnSviDobavljaci;
    }
}