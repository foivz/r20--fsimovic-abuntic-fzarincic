namespace PresentationLayer.ChartForms
{
    partial class FormArtikliChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartArtikli = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartArtikli
            // 
            chartArea1.Name = "ChartArea1";
            this.chartArtikli.ChartAreas.Add(chartArea1);
            this.chartArtikli.DataSource = this.artiklBindingSource;
            this.chartArtikli.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartArtikli.Legends.Add(legend1);
            this.chartArtikli.Location = new System.Drawing.Point(0, 0);
            this.chartArtikli.Name = "chartArtikli";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Artikli";
            this.chartArtikli.Series.Add(series1);
            this.chartArtikli.Size = new System.Drawing.Size(638, 514);
            this.chartArtikli.TabIndex = 0;
            this.chartArtikli.Text = "Artikli na stanju";
            title1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "chart_Artkili";
            title1.Text = "Stanje Zaliha";
            this.chartArtikli.Titles.Add(title1);
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(DatabaseLayer.Model.Artikl);
            // 
            // FormArtikliChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 514);
            this.Controls.Add(this.chartArtikli);
            this.Name = "FormArtikliChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stanje zaliha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormArtikliChart_FormClosing);
            this.Load += new System.EventHandler(this.FormArtikliChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartArtikli;
        private System.Windows.Forms.BindingSource artiklBindingSource;
    }
}