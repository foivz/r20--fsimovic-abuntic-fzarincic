﻿using BusinessLayer.Services;
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
    public partial class FormNovaPrimka : Form
    {
        private UnitOfWork UnitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        private Primka NovaPrimka = new Primka();
        public FormNovaPrimka()
        {
            InitializeComponent();
        }

        private void PrimkaForm_Load(object sender, EventArgs e)
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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnNoviDobavljac_Click(object sender, EventArgs e)
        {
            FormNoviDobavljac form = new FormNoviDobavljac() { Owner = this };
            Hide();
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
            FormAzurirajArtikl form = new FormAzurirajArtikl(artikl) { Owner = this };
            Hide();
            form.ShowDialog();
            DohvatiArtikle();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Artikl artikl = cmbArtikl.SelectedItem as Artikl;
            UnitOfWork.Artikli.Delete(artikl);
            UnitOfWork.Complete();
            DohvatiArtikle();
        }

        private void btnBrisiDobavljaca_Click(object sender, EventArgs e)
        {
            Dobavljac dobavljac = cboDobavljac.SelectedItem as Dobavljac;
            UnitOfWork.Dobavljaci.Delete(dobavljac);
            UnitOfWork.Complete();
            OsvjeziDobavljece();
        }

        private void btnAzurirajDobavljaca_Click(object sender, EventArgs e)
        {
            Dobavljac dobavljac = cboDobavljac.SelectedItem as Dobavljac;
            FormAzurirajDobavljaca form = new FormAzurirajDobavljaca(dobavljac) { Owner = this };
            Hide();
            form.ShowDialog();
            OsvjeziDobavljece();
        }

        private void FormNovaPrimka_FormClosing(object sender, FormClosingEventArgs e)
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
