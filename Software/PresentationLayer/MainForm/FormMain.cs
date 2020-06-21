using PresentationLayer.ChartForms;
using PresentationLayer.DocumentsForms;
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

namespace PresentationLayer.MainForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Owner.Visible = true;
        }

        private void buttonRacun_Click(object sender, EventArgs e)
        {
            FormNoviRacun form = new FormNoviRacun() { Owner = this };
            Hide();
            form.Show();
        }

        private void buttonnarudzbenica_Click(object sender, EventArgs e)
        {
            FormNovaNarudzbenica form = new FormNovaNarudzbenica() { Owner = this };
            Hide();
            form.Show();
        }

        private void buttonPrimka_Click(object sender, EventArgs e)
        {
            FormNovaPrimka form = new FormNovaPrimka() { Owner = this };
            Hide();
            form.Show();
        }

        private void buttonIzvještaj_Click(object sender, EventArgs e)
        {
            FormIzvještaji form = new FormIzvještaji() { Owner = this };
            Hide();
            form.Show();
        }

        private void buttonRegistriraj_Click(object sender, EventArgs e)
        {
            FormRegistrationOrEdit form = new FormRegistrationOrEdit() { Owner = this };
            Hide();
            form.Show();
        }

        private void buttonZaposlenici_Click(object sender, EventArgs e)
        {
            FormSviZaposlenici form = new FormSviZaposlenici() { Owner = this };
            Hide();
            form.Show();
        }

        private void buttonArtiklChart_Click(object sender, EventArgs e)
        {
            FormArtikliChart form = new FormArtikliChart() { Owner = this };
            Hide();
            form.Show();
        }
    }
}
