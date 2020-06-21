using BusinessLayer.Services;
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
            if (UserManager.LogiranKorisnik.Uloga.Naziv == "Konobar")
            {
                buttonRegistriraj.Visible = false;
                buttonZaposlenici.Visible = false;
                buttonIzvještaj.Visible = false;
                buttonRegistriraj.Enabled = false;
                buttonZaposlenici.Enabled = false;
                buttonIzvještaj.Enabled = false;
            }
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
            FormChartSelect form = new FormChartSelect() { Owner = this };
            Hide();
            form.Show();
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            btnPomoc.Capture = false;
            SendMessage(this.Handle, WM_SYSCOMMAND, (IntPtr)SC_CONTEXTHELP, IntPtr.Zero);
        }
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_CONTEXTHELP = 0xf180;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}
