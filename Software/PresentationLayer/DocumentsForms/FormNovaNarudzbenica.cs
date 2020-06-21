using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLayer.Model;
using PresentationLayer.Services;

namespace PresentationLayer.DocumentsForms
{
    public partial class FormNovaNarudzbenica : Form
    {
        private UnitOfWork UnitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        private Narudzbenica NovaNarudzbenica = new Narudzbenica();
        public FormNovaNarudzbenica()
        {
            InitializeComponent();
        }

        private void FormNovaNarudzbenica_Load(object sender, EventArgs e)
        {
            OsvjeziDobavljece();
            DohvatiArtikle();
            tboZaposlenik.Text = UserManager.LogiranKorisnik.KorisnickoIme;
        }

        private void DohvatiArtikle()
        {
            cmbArtikl.DataSource = UnitOfWork.Artikli.GetAll();
            cmbArtikl.DisplayMember = "Naziv";
        }

        private void OsvjeziDobavljece()
        {
            cboDobavljac.DataSource = UnitOfWork.Dobavljaci.GetAll();
            cboDobavljac.DisplayMember = "Naziv";

        }

        private void btnNoviArtikl_Click(object sender, EventArgs e)
        {
            FormDodajArtikl form = new FormDodajArtikl() { Owner = this };
            Hide();
            form.ShowDialog();
            DohvatiArtikle();
        }

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            var artikl = cmbArtikl.SelectedItem as Artikl;
            if (artikl != null && ValidationService.ParseNumber(tboKolicina.Text, out int kolicina) && kolicina > 0)
            {
                var PostojeciArtikl = NovaNarudzbenica.StavkaNarudzbe.FirstOrDefault(sr => sr.Artikl.Id == artikl.Id);
                if (PostojeciArtikl != null)
                {
                    PostojeciArtikl.Kolicina += kolicina;
                }
                else
                {
                    NovaNarudzbenica.StavkaNarudzbe.Add(new StavkaNarudzbenice
                    {
                        Artikl = artikl,
                        Kolicina = kolicina,
                    });
                }
            }
            else
            {
                NotificationService.InvalidInput();
            }
            OsvjeziDgv();
        }

        private void OsvjeziDgv()
        {
            dgvStavkeNarudzbenice.DataSource = null;
            dgvStavkeNarudzbenice.DataSource = NovaNarudzbenica.StavkaNarudzbe;

            dgvStavkeNarudzbenice.Columns["Artikl"].DisplayIndex = 0;
            dgvStavkeNarudzbenice.Columns["Kolicina"].DisplayIndex = 1;
            dgvStavkeNarudzbenice.Columns["Narudzbenica"].Visible = false;
            dgvStavkeNarudzbenice.Columns["NarudzbenicaId"].Visible = false;
            dgvStavkeNarudzbenice.Columns["ArtiklId"].Visible = false;
        }

        private void btnNoviDobavljac_Click(object sender, EventArgs e)
        {
            FormNoviDobavljac form = new FormNoviDobavljac() { Owner = this };
            Hide();
            form.ShowDialog();
            OsvjeziDobavljece();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzradi_Click(object sender, EventArgs e)
        {
            bool izdaj = true;
            NovaNarudzbenica.DatumIVrijemeIzdavanja = dtpDatum.Value;
            if (ValidationService.IsNotNull(cboDobavljac.SelectedItem as Dobavljac))
            {
                NovaNarudzbenica.Dobavljac = cboDobavljac.SelectedItem as Dobavljac;
            }
            else
            {
                NotificationService.InvalidInput();
                izdaj = false;
            }
            NovaNarudzbenica.Zaposlenik = UserManager.LogiranKorisnik;

            UnitOfWork.Narudzbenica.Add(NovaNarudzbenica);
            string message = "";
            if (UnitOfWork.Complete() >= 0 && izdaj)
            {
                message = "Uspješno izdana narudzbenica";
            }
            else
            {
                message = "Neuspješno izdana narudzbenica";
            }
            NotificationService.Notify(message);
            this.Close();
        }

        private void FormNovaNarudzbenica_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
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
