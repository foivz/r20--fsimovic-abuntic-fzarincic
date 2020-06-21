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
    public partial class FormPrimka : Form
    {
        private UnitOfWork UnitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        private Primka NovaPrimka = new Primka();
        public FormPrimka()
        {
            InitializeComponent();
        }

        private void PrimkaForm_Load(object sender, EventArgs e)
        {
            OsvjeziDobavljece();
            DohvatiArtikle();
            //tboZaposlenik.Text = UserManager.LogiranKorisnik.ToString();
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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboNapomena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNoviArtikl_Click(object sender, EventArgs e)
        {
            FormDodajArtikl form = new FormDodajArtikl();
            form.ShowDialog();
            DohvatiArtikle();
        }

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            
            var artikl = cmbArtikl.SelectedItem as Artikl;
            if (artikl != null && ValidationService.ParseNumber(tboKolicina.Text, out int kolicina) && kolicina > 0)
            {
                var PostojeciArtikl = NovaPrimka.StavkaPrimke.FirstOrDefault(sr => sr.Artikl.Id == artikl.Id);
                if (PostojeciArtikl != null)
                {
                    PostojeciArtikl.Kolicina += kolicina;
                }
                else
                {
                    NovaPrimka.StavkaPrimke.Add(new StavkaPrimke
                    {
                        Artikl = artikl,
                        Kolicina = kolicina,
                    });
                }

                Artikl ArtiklUBazi = UnitOfWork.Artikli.GetById(artikl.Id);
                ArtiklUBazi.Kolicina += kolicina;

            }
            else
            {
                NotificationService.InvalidInput();
            }
            OsvjeziDgv();

        }

        private void OsvjeziDgv()
        {
            dgvStavkePrimke.DataSource = null;
            dgvStavkePrimke.DataSource = NovaPrimka.StavkaPrimke;

            dgvStavkePrimke.Columns["Artikl"].DisplayIndex = 0;
            dgvStavkePrimke.Columns["Kolicina"].DisplayIndex = 1;
            dgvStavkePrimke.Columns["Primka"].Visible = false;
            dgvStavkePrimke.Columns["PrimkaId"].Visible = false;
            dgvStavkePrimke.Columns["ArtiklId"].Visible = false;
        }

        private void txtKolicina_Click(object sender, EventArgs e)
        {
        }

        private void tboKolicina_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArtikl_Click(object sender, EventArgs e)
        {

        }

        private void cmbArtikl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNoviDobavljac_Click(object sender, EventArgs e)
        {
            FormNoviDobavljac form = new FormNoviDobavljac();
            form.ShowDialog();
            OsvjeziDobavljece();
        }

        private void btnIzradi_Click(object sender, EventArgs e)
        {
            NovaPrimka.Datum = dtpDatum.Value;
            bool izdaj = true;
            if (ValidationService.IsNotNull(cboDobavljac.SelectedItem as Dobavljac))
            {
                NovaPrimka.Dobavljac = cboDobavljac.SelectedItem as Dobavljac;
            }
            else
            {
                NotificationService.InvalidInput();
                izdaj = false;
            }

            NovaPrimka.Zaposlenik = UserManager.LogiranKorisnik;
            NovaPrimka.Napomena = tboNapomena.Text;

            if (ValidationService.ParseNumber(tboOdgoda.Text, out int odgoda))
            {
                NovaPrimka.Odgoda = odgoda;
            }
            else
            {
                NotificationService.InvalidInput();
                izdaj = false;
            }

            UnitOfWork.Primke.Add(NovaPrimka);
            string message = "";
            if (UnitOfWork.Complete() >= 0 && izdaj)
            {
                message = "Uspješno izdana primka";
            }
            else
            {
                message = "Neuspješno izdana primkka";
            }
            NotificationService.Notify(message);
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Artikl artikl = cmbArtikl.SelectedItem as Artikl;
            FormAzurirajArtikl form = new FormAzurirajArtikl(artikl);
            form.ShowDialog();
            DohvatiArtikle();
        }
    }
}
