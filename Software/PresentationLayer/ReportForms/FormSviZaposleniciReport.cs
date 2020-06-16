
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.ReportForms
{
    public partial class FormSviZaposleniciReport : Form
    {
        public FormSviZaposleniciReport()
        {
            InitializeComponent();
        }

        private void FormSviZaposleniciReport_Load(object sender, EventArgs e)
        {
            //using(var context = new ClubbingPayDbContext)
            this.reportViewer1.RefreshReport();
        }
    }
}
