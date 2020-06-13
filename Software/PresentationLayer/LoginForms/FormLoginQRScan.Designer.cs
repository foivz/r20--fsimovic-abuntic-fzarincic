namespace PresentationLayer.LoginForms
{
    partial class FormLoginQRScan
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxQRScan = new System.Windows.Forms.PictureBox();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRScan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera:";
            // 
            // pictureBoxQRScan
            // 
            this.pictureBoxQRScan.BackColor = System.Drawing.Color.White;
            this.pictureBoxQRScan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxQRScan.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxQRScan.Name = "pictureBoxQRScan";
            this.pictureBoxQRScan.Size = new System.Drawing.Size(423, 352);
            this.pictureBoxQRScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxQRScan.TabIndex = 1;
            this.pictureBoxQRScan.TabStop = false;
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(64, 373);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(144, 21);
            this.comboBoxDevice.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(267, 373);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Započni";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(360, 373);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Završi";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // FormLoginQRScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 405);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.pictureBoxQRScan);
            this.Controls.Add(this.label1);
            this.Name = "FormLoginQRScan";
            this.Text = "Prijava s QR kodom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoginQRScan_FormClosing);
            this.Load += new System.EventHandler(this.FormLoginQRScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxQRScan;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
    }
}