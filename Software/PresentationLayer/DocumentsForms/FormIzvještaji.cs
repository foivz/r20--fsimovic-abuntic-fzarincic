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
            ReportSviZaposlenici form = new ReportSviZaposlenici() { Owner = this };
            Hide();
            form.ShowDialog();
        }

        private void btnSviDobavljaci_Click(object sender, EventArgs e)
        {
            ReportSviDobavljaci form = new ReportSviDobavljaci() { Owner = this };
            Hide();
            form.ShowDialog();
        }

        private void btnSviArtikli_Click(object sender, EventArgs e)
        {
            ReportSviArtikli form = new ReportSviArtikli() { Owner = this };
            Hide();
            form.ShowDialog();
        }

        private void FormIzvještaji_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}
