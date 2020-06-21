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
            unitOfWork = new UnitOfWork(new ClubbingPayDbContext());
            dataGridViewZaposlenici.DataSource = null;
            dataGridViewZaposlenici.DataSource = unitOfWork.Zaposlenici.DohvatiSveZaposlenikSUlogom();
            
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            //TODO
            var selectedZaposlenik = dataGridViewZaposlenici.CurrentRow.DataBoundItem as Zaposlenik;

            if (selectedZaposlenik == null)
            {
                NotificationService.Notify("Morate odabrati redak u tablici!");
                return;
            }
            unitOfWork.Zaposlenici.Delete(selectedZaposlenik);
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
            var selectedZaposlenik = dataGridViewZaposlenici.CurrentRow.DataBoundItem as Zaposlenik;

            if (selectedZaposlenik == null)
            {
                NotificationService.Notify("Morate odabrati redak u tablici!");
                return;
            }

            using (FormRegistrationOrEdit form = new FormRegistrationOrEdit(selectedZaposlenik) { Owner = this })
            {
                form.FormClosed += FormUrediZatvorena;
                form.ShowDialog();
            }
        }

        private void buttonRefreshDGV_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void buttonGenQr_Click(object sender, EventArgs e)
        {
            var selectedZaposlenik = dataGridViewZaposlenici.CurrentRow.DataBoundItem as Zaposlenik;

            if (selectedZaposlenik == null)
            {
                NotificationService.Notify("Morate odabrati redak u tablici!");
                return;
            }

            FormQrGenerate form = new FormQrGenerate(selectedZaposlenik) { Owner = this };
            Hide();
            form.ShowDialog();
        }

        private void FormUrediZatvorena(object sender, FormClosedEventArgs args)
        {
            RefreshDataGridView();
        }
    }
}

