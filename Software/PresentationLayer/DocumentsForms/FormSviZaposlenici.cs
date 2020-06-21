using BusinessLayer;
using BusinessLayer.Services;
using DatabaseLayer.Model;
using PresentationLayer.QRForms;
using PresentationLayer.RegistrationForms;
using PresentationLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.DocumentsForms
{
    public partial class FormSviZaposlenici : Form
    {
        private IUnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());

        public FormSviZaposlenici()
        {
            InitializeComponent();
        }

        private void FormSviZaposlenici_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewZaposlenici.DataSource = null;
            dataGridViewZaposlenici.DataSource = unitOfWork.Zaposlenici.GetAll(new Zaposlenik());

            dataGridViewZaposlenici.Columns["Id"].Visible = false;
            dataGridViewZaposlenici.Columns["LozinkaHash"].Visible = false;

            dataGridViewZaposlenici.Columns["OIB"].DisplayIndex = 6;
            dataGridViewZaposlenici.Columns[10].DisplayIndex = 7;
            dataGridViewZaposlenici.Columns["Aktivan"].DisplayIndex = 10;

            dataGridViewZaposlenici.Columns["Email"].HeaderText = "E-mail adresa";
            dataGridViewZaposlenici.Columns["BrojZIroRacuna"].HeaderText = "Broj bankovnog računa";
            dataGridViewZaposlenici.Columns["KorisnickoIme"].HeaderText = "Korisničko  ime";
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewZaposlenici.SelectedRows)
            {
                var cellValue = row.Cells["Id"].Value;
                unitOfWork.Zaposlenici.Delete(unitOfWork.Zaposlenici.GetById(int.Parse(cellValue.ToString())));
            }

            unitOfWork.Complete();

            RefreshDataGridView();
        }

        private void FormSviZaposlenici_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUredi_Click(object sender, EventArgs e)
        {
            Zaposlenik currentObject;

            if (dataGridViewZaposlenici.SelectedRows.Count != 0)
            {
                currentObject = (Zaposlenik)dataGridViewZaposlenici.CurrentRow.DataBoundItem;
                FormRegistration form = new FormRegistration(currentObject)
                {
                    Owner = this
                };

                this.Hide();
                form.ShowDialog();
            }
            else
            {
                NotificationService.Notify("Morate odabrati redak u tablici!");
            }
        }

        private void buttonRefreshDGV_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void buttonGenQr_Click(object sender, EventArgs e)
        {
            Zaposlenik selectedZaposlenik;
            
            if (dataGridViewZaposlenici.SelectedRows.Count != 0)
            {
                selectedZaposlenik = (Zaposlenik)dataGridViewZaposlenici.CurrentRow.DataBoundItem;
                FormQrGenerate form = new FormQrGenerate(selectedZaposlenik);
                form.ShowDialog();
            }
        }
    }
}
