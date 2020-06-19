using PresentationLayer.ReportForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.DocumentsForms
{
    public partial class FormIzvještaji : Form
    {
        public FormIzvještaji()
        {
            InitializeComponent();
        }

        private void btnSviZaposlenici_Click(object sender, EventArgs e)
        {
            ReportSviZaposlenici form = new ReportSviZaposlenici();
            form.ShowDialog();
        }

        private void btnSviDobavljaci_Click(object sender, EventArgs e)
        {
            ReportSviDobavljaci form = new ReportSviDobavljaci();
            form.ShowDialog();
        }

        private void btnSviArtikli_Click(object sender, EventArgs e)
        {
            ReportSviArtikli form = new ReportSviArtikli();
            form.ShowDialog();
        }
    }
}
