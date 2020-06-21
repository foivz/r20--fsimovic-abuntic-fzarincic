namespace PresentationLayer.ReportForms
{
    partial class ReportSviDobavljaci
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DobavljacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DobavljacBindingSource
            // 
            this.DobavljacBindingSource.DataSource = typeof(DatabaseLayer.Model.Dobavljac);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsDobavljaci";
            reportDataSource1.Value = this.DobavljacBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentationLayer.Reports.ReportDobavljaci.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(585, 303);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportSviDobavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(585, 303);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "ReportSviDobavljaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSviDobavljaciReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportSviDobavljaci_FormClosing);
            this.Load += new System.EventHandler(this.FormSviDobavljaciReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DobavljacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DobavljacBindingSource;
    }
}