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
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 221);
            this.Controls.Add(this.buttonGenQrFrom);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonQrLogin);
            this.Name = "FormHelp";
            this.Text = "FormHelp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQrLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonGenQrFrom;
    }
}