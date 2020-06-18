namespace PresentationLayer.QRForms
{
    partial class FormQrGenerate
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.buttonGenerateQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(58, 48);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(363, 49);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.BackColor = System.Drawing.Color.White;
            this.pictureBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxQR.Location = new System.Drawing.Point(58, 75);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(405, 343);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQR.TabIndex = 2;
            this.pictureBoxQR.TabStop = false;
            // 
            // buttonGenerateQR
            // 
            this.buttonGenerateQR.Location = new System.Drawing.Point(184, 424);
            this.buttonGenerateQR.Name = "buttonGenerateQR";
            this.buttonGenerateQR.Size = new System.Drawing.Size(142, 50);
            this.buttonGenerateQR.TabIndex = 3;
            this.buttonGenerateQR.Text = "Generiraj QR";
            this.buttonGenerateQR.UseVisualStyleBackColor = true;
            this.buttonGenerateQR.Click += new System.EventHandler(this.buttonGenerateQR_Click);
            // 
            // FormQrGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(521, 486);
            this.Controls.Add(this.buttonGenerateQR);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "FormQrGenerate";
            this.Text = "FormQrGenerate";
            this.Load += new System.EventHandler(this.FormQrGenerate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.Button buttonGenerateQR;
    }
}