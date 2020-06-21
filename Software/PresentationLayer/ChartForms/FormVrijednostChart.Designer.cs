namespace PresentationLayer.ChartForms
{
    partial class FormVrijednostZaliha
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartVrijednostStanjaZaliha = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartVrijednostStanjaZaliha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartVrijednostStanjaZaliha
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVrijednostStanjaZaliha.ChartAreas.Add(chartArea2);
            this.chartVrijednostStanjaZaliha.DataSource = this.artiklBindingSource;
            this.chartVrijednostStanjaZaliha.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartVrijednostStanjaZaliha.Legends.Add(legend2);
            this.chartVrijednostStanjaZaliha.Location = new System.Drawing.Point(0, 0);
            this.chartVrijednostStanjaZaliha.Name = "chartVrijednostStanjaZaliha";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Kune";
            this.chartVrijednostStanjaZaliha.Series.Add(series2);
            this.chartVrijednostStanjaZaliha.Size = new System.Drawing.Size(800, 450);
            this.chartVrijednostStanjaZaliha.TabIndex = 0;
            this.chartVrijednostStanjaZaliha.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Vrijednost zaliha";
            this.chartVrijednostStanjaZaliha.Titles.Add(title2);
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(DatabaseLayer.Model.Artikl);
            // 
            // FormVrijednostZaliha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartVrijednostStanjaZaliha);
            this.Name = "FormVrijednostZaliha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zalihe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVrijednostZaliha_FormClosing);
            this.Load += new System.EventHandler(this.FormVrijednostZaliha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVrijednostStanjaZaliha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVrijednostStanjaZaliha;
        private System.Windows.Forms.BindingSource artiklBindingSource;
    }
}