using PresentationLayer.DocumentsForms;
using PresentationLayer.LoginForms;
using PresentationLayer.QRForms;
using PresentationLayer.RegistrationForms;
using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.ChartForms;

namespace PresentationLayer
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            FormRegistration form = new FormRegistration()
            {
                Owner = this
            };
            form.Show();
            this.Hide();
        }

        private void buttonSviZaposlenici_Click(object sender, EventArgs e)
        {
            FormSviZaposlenici form = new FormSviZaposlenici()
            {
                Owner = this
            };
            form.Show();
            this.Hide();
        }

        private void buttonDodajArtikl_Click(object sender, EventArgs e)
        {
            FormNoviRacun form = new FormNoviRacun();
            form.ShowDialog();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrimka form = new FormPrimka();
            form.ShowDialog();
            //this.Hide();
        }

        private bool closedForm = false;

        private void FormHelp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedForm)
            {
                closedForm = true;
                this.Close();
            }
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            FormIzvještaji form = new FormIzvještaji();
            form.ShowDialog();
        }

        private void FormHelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F1)
            {
                HelpButton = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNovaNarudzbenica form = new FormNovaNarudzbenica();
            form.ShowDialog();
        }

        private void buttonChartArtikl_Click(object sender, EventArgs e)
        {
            FormArtikliChart form = new FormArtikliChart()
            {
                Owner = this
            };
            this.Hide();
            form.Show();
        }
    }
}
