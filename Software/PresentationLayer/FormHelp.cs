using PresentationLayer.DocumentsForms;
using PresentationLayer.LoginForms;
using PresentationLayer.QRForms;
using PresentationLayer.RegistrationForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void buttonQrLogin_Click(object sender, EventArgs e)
        {
            FormLoginQRScan form = new FormLoginQRScan();
            form.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }

        private void buttonGenQrFrom_Click(object sender, EventArgs e)
        {
            FormQrGenerate form = new FormQrGenerate();
            form.Show();
            this.Hide();
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            FormRegistration form = new FormRegistration();
            form.Show();
            this.Hide();
        }

        private void buttonSviZaposlenici_Click(object sender, EventArgs e)
        {
            FormSviZaposlenici form = new FormSviZaposlenici();
            form.Show();
            this.Hide();
        }

        private void buttonDodajArtikl_Click(object sender, EventArgs e)
        {
            FormNoviRacun form = new FormNoviRacun();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrimka form = new FormPrimka();
            form.ShowDialog();
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            FormIzvještaji form = new FormIzvještaji();
            form.ShowDialog();
        }
    }
}
