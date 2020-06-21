using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Repositories;
using BusinessLayer.Services;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Model;
using PresentationLayer.LoginForms;
using PresentationLayer.Services;
namespace PresentationLayer.DocumentsForms
{
    public partial class FormNoviRacun : Form
    {
        private UnitOfWork UnitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        private Racun NoviRacun = new Racun();
        List<Artikl> Artikli;
        List<Artikl> ArtikliNaStanju = new List<Artikl>();
        List<StavkaRacuna> StavkaRacua = new List<StavkaRacuna>();

        public FormNoviRacun()
        {
            InitializeComponent();
        }
        private void FormNoviRacun_Load(object sender, EventArgs e)
        {
            Artikli = UnitOfWork.Artikli.GetAll();
            DohvatiArtikle();
            textBoxZaposlenik.Name = UserManager.LogiranKorisnik.KorisnickoIme;
            //tboZaposlenik.Text = UserManager.LogiranKorisnik.ToString();
        }
        private void DohvatiArtikle()
        {

            foreach (var item in Artikli)
            {
                if (item.Kolicina > 0)
                {
                    ArtikliNaStanju.Add(item);
                }
            }
            cmbArtikl.DataSource = ArtikliNaStanju;
            cmbArtikl.DisplayMember = "Naziv";
        }
        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            var artikal = cmbArtikl.SelectedItem as Artikl;
            if (artikal != null && ValidationService.ParseNumber(tboKolicina.Text, out int kolicina) && kolicina > 0)
            {                
                var postojeciArtikal = NoviRacun.StavkaRacuna.FirstOrDefault(sr => sr.Artikl.Id == artikal.Id);
                if (postojeciArtikal != null)
                {
                    postojeciArtikal.Kolicina += kolicina;
                }
                else
                {
                    NoviRacun.StavkaRacuna.Add(new StavkaRacuna
                    {
                        Artikl = artikal,
                        Kolicina = kolicina,
                    });
                }
                OsvjeziDgv();
                OsvjeziIznose();

                Artikl ArtiklUBazi = UnitOfWork.Artikli.GetById(artikal.Id);
                ArtiklUBazi.Kolicina -= kolicina;

            }
            else
            {
                NotificationService.InvalidInput();
            }
        }
        private void OsvjeziIznose()
        {
            tboOsnovica.Text = NoviRacun.Osnovica.ToString();
            tboPorezNaDodanuVrijednost.Text = NoviRacun.Pdv.ToString();
            tboPorezNaPotrosnju.Text = NoviRacun.PorezNaPotrosnju.ToString();
            tboUkupno.Text = NoviRacun.Ukupno.ToString();
        }
        private void OsvjeziDgv()
        {
            dgvStavkeRacuna.DataSource = null;
            dgvStavkeRacuna.DataSource = NoviRacun.StavkaRacuna;

            dgvStavkeRacuna.Columns["Racun"].Visible = false;
            dgvStavkeRacuna.Columns["RacunId"].Visible = false;
            dgvStavkeRacuna.Columns["ArtiklId"].Visible = false;
            dgvStavkeRacuna.Columns["Ime"].Visible = false;
            dgvStavkeRacuna.Columns["Artikl"].DisplayIndex = 0;
            dgvStavkeRacuna.Columns["Kolicina"].DisplayIndex = 1;
            dgvStavkeRacuna.Columns["Cijena"].DisplayIndex = 2;
            dgvStavkeRacuna.Columns["Ukupno"].DisplayIndex = 3;
        }
        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            NoviRacun.DatumIVrijemeIzdavanja = DateTime.Now;
            NoviRacun.Zaposlenik = UserManager.LogiranKorisnik;
            UnitOfWork.Racuni.Add(NoviRacun);
            //Projvera zasto ne sprema u bazu
            string message = "";
            if (UnitOfWork.Complete() >= 0)
            {
                message = "Uspješno izdan račun";
            }
            else
            {
                message = "Neuspješno izdan račun";
            }
            NotificationService.Notify(message);
            this.Close();
        }

        private void FormNoviRacun_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
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