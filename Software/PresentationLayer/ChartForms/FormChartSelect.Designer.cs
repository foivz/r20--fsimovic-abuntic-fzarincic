namespace PresentationLayer.ChartForms
{
    partial class FormChartSelect
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
            this.buttonStanjeZaliha = new System.Windows.Forms.Button();
            this.buttonVrijednostZaliha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStanjeZaliha
            // 
            this.buttonStanjeZaliha.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStanjeZaliha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStanjeZaliha.Location = new System.Drawing.Point(0, 0);
            this.buttonStanjeZaliha.Name = "buttonStanjeZaliha";
            this.buttonStanjeZaliha.Size = new System.Drawing.Size(307, 145);
            this.buttonStanjeZaliha.TabIndex = 0;
            this.buttonStanjeZaliha.Text = "Stanje zaliha";
            this.buttonStanjeZaliha.UseVisualStyleBackColor = true;
            this.buttonStanjeZaliha.Click += new System.EventHandler(this.buttonStanjeZaliha_Click);
            // 
            // buttonVrijednostZaliha
            // 
            this.buttonVrijednostZaliha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonVrijednostZaliha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVrijednostZaliha.Location = new System.Drawing.Point(0, 144);
            this.buttonVrijednostZaliha.Name = "buttonVrijednostZaliha";
            this.buttonVrijednostZaliha.Size = new System.Drawing.Size(307, 132);
            this.buttonVrijednostZaliha.TabIndex = 1;
            this.buttonVrijednostZaliha.Text = "Vrijednost zaliha";
            this.buttonVrijednostZaliha.UseVisualStyleBackColor = true;
            this.buttonVrijednostZaliha.Click += new System.EventHandler(this.buttonVrijednostZaliha_Click);
            // 
            // FormChartSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 276);
            this.Controls.Add(this.buttonVrijednostZaliha);
            this.Controls.Add(this.buttonStanjeZaliha);
            this.Name = "FormChartSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafovi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChartSelect_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStanjeZaliha;
        private System.Windows.Forms.Button buttonVrijednostZaliha;
    }
}