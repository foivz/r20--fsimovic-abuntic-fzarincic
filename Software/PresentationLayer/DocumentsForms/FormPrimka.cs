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
using BusinessLayer.Services;
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
            //TODOO
            var artikl = cmbArtikl.SelectedItem as Artikl;
            Artikl artiklUBazi;
            if (artikl != null && ValidationService.ParseNumber(tboKolicina.Text, out int kolicina) && kolicina > 0)
            {
                
              //  UnitOfWork.Artikli.Update(artiklUBazi);
            }
            else
            {
                NotificationService.InvalidInput();
            }
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
            NovaPrimka.Dobavljac = cboDobavljac.SelectedItem as Dobavljac;
            NovaPrimka.Napomena = tboNapomena.Text;
            if (ValidationService.ParseNumber(tboOdgoda.Text, out int odgoda))
            {
                NovaPrimka.Odgoda = odgoda;
            }
            else
            {
                NotificationService.InvalidInput(); 
            }
            string message = UnitOfWork.Complete() == 1 ? "Primka je uspješno kreirana" : "Primku nije moguće kreirati";
        }
    }
}
