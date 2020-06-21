using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLayer.Model;
using BusinessLayer.Services;
using PresentationLayer.Services;
using System;

namespace PresentationLayer.DocumentsForms
{
    public partial class FormAzurirajDobavljaca : Form
    {
        Dobavljac Dobavljac = new Dobavljac();
        private UnitOfWork UnitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        public FormAzurirajDobavljaca(Dobavljac dobavljac)
        {
            InitializeComponent();
            Dobavljac = dobavljac;
        }

        private void btnOdustani_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void FormAzurirajDobavljaca_Load(object sender, System.EventArgs e)
        {
            tboNaziv.Text = Dobavljac.Naziv;
            tboOIB.Text = Dobavljac.Oib;
            tboTelefon.Text = Dobavljac.Telefon;
            tboEmail.Text = Dobavljac.Email;
            tboAdresa.Text = Dobavljac.Adresa;
        }

        private void btnDodaj_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (
                    !ValidationService.IsNotEmpty(tboNaziv.Text) ||
                    !ValidationService.IsNotEmpty(tboOIB.Text) ||
                    !ValidationService.IsNotEmpty(tboTelefon.Text) ||
                    !ValidationService.IsNotEmpty(tboEmail.Text) ||
                    !ValidationService.IsNotEmpty(tboAdresa.Text) ||
                    !ValidationService.AssertEmail(tboEmail.Text)
                    ) throw new Exception();

                Dobavljac.Naziv = tboNaziv.Text;
                Dobavljac.Oib = tboOIB.Text;
                Dobavljac.Telefon = tboTelefon.Text;
                Dobavljac.Email = tboEmail.Text;
                Dobavljac.Adresa = tboAdresa.Text;
                UnitOfWork.Dobavljaci.Update(Dobavljac);
                UnitOfWork.Complete();
                this.Close();
            }
            catch (Exception)
            {
                NotificationService.InvalidInput();
            }
        }
    }
}
