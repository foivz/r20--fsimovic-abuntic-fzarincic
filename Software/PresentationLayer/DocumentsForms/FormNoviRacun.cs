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
        private readonly UnitOfWork UnitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        private Racun NoviRacun = new Racun();

        public FormNoviRacun()
        {
            InitializeComponent();
        }
        private void FormNoviRacun_Load(object sender, EventArgs e)
        {
            DohvatiArtikle();
        }
        private void DohvatiArtikle()
        {
            //Uvjet da je količina > 0?
            cmbArtikl.DataSource = UnitOfWork.Artikli.GetAll();
            //To se treba na formi konfigurirati
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
            }
            else
            {
                NotificationService.InvalidInput();
            }
        }
        private void OsvjeziIznose()
        {
            double porezNaPotrosnju = NoviRacun.Ukupno * 0.03;
            double pdv = NoviRacun.Ukupno * 0.25;
            tboOsnovica.Text = pdv.ToString();
            tboPorezNaDodanuVrijednost.Text = porezNaPotrosnju.ToString();
            tboUkupno.Text = (NoviRacun.Ukupno + porezNaPotrosnju + pdv).ToString();
        }
        private void OsvjeziDgv()
        {
            dgvStavkeRacuna.DataSource = null;
            dgvStavkeRacuna.DataSource = NoviRacun.StavkaRacuna;
            //Konfigurirat na formi
            dgvStavkeRacuna.Columns["Racun"].Visible = false;
            dgvStavkeRacuna.Columns["RacunId"].Visible = false;
        }
        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            UnitOfWork.Racuni.Add(NoviRacun);
            string message = UnitOfWork.Complete() == 1 ? "Račun je uspješno kreiran" : "Račun nije moguće kreirati";
            NotificationService.Notify(message);
        }

        private void FormNoviRacun_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserManager.OdlogirajKorisnika();
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                this.Owner.Close();
        }
    }
}