namespace PresentationLayer.LoginForms
{
    partial class FormLogin
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.helpProviderPomoc = new System.Windows.Forms.HelpProvider();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.helpProviderPomoc.SetHelpKeyword(this.buttonStart, "");
            this.helpProviderPomoc.SetHelpString(this.buttonStart, "Klikom na gumb se prijavljujete sa korisničkim imenom i lozinkom");
            this.buttonStart.Location = new System.Drawing.Point(208, 37);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.helpProviderPomoc.SetShowHelp(this.buttonStart, true);
            this.buttonStart.Size = new System.Drawing.Size(117, 94);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Prijavi";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lozinka:";
            // 
            // textBoxUsername
            // 
            this.helpProviderPomoc.SetHelpKeyword(this.textBoxUsername, "");
            this.helpProviderPomoc.SetHelpString(this.textBoxUsername, "Polje za unos vašeg korisničkog imena");
            this.textBoxUsername.Location = new System.Drawing.Point(21, 37);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.helpProviderPomoc.SetShowHelp(this.textBoxUsername, true);
            this.textBoxUsername.Size = new System.Drawing.Size(132, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.helpProviderPomoc.SetHelpKeyword(this.textBoxPassword, "");
            this.helpProviderPomoc.SetHelpString(this.textBoxPassword, "Polje za unos vaše lozinke");
            this.textBoxPassword.Location = new System.Drawing.Point(21, 106);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.helpProviderPomoc.SetShowHelp(this.textBoxPassword, true);
            this.textBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword.TabIndex = 2;
            // 
            // btnPomoc
            // 
            this.btnPomoc.Location = new System.Drawing.Point(208, 138);
            this.btnPomoc.Name = "btnPomoc";
            this.helpProviderPomoc.SetShowHelp(this.btnPomoc, false);
            this.btnPomoc.Size = new System.Drawing.Size(117, 23);
            this.btnPomoc.TabIndex = 7;
            this.btnPomoc.Text = "Pomoc";
            this.btnPomoc.UseVisualStyleBackColor = true;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(376, 162);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.helpProviderPomoc.SetHelpKeyword(this, "");
            this.helpProviderPomoc.SetHelpString(this, "Mozete se prijaviti pomoću QR koda ili korisnickog imena i lozinke");
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.helpProviderPomoc.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoginQRScan_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLoginQRScan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.HelpProvider helpProviderPomoc;
        private System.Windows.Forms.Button btnPomoc;
    }
}