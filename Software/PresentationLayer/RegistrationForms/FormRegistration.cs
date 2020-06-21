using BusinessLayer;
using BusinessLayer.Enums;
using BusinessLayer.Services;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Model;
using PresentationLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.RegistrationForms
{
    public partial class FormRegistration : Form
    {
        private IUnitOfWork UnitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        private Zaposlenik dohvaceniZaposlenik = new Zaposlenik();

        public FormRegistration()
        {
            InitializeComponent();

            #region [Properties changed]
            labelRegistracijaIliUredivanje.Text = "Registracija novog korisnika";
            buttonAzuriraj.Enabled = false;
            buttonAzuriraj.Visible = false;
            radioButtonActive.Visible = false;
            radioButtonActive.Enabled = false;
            radioButtonInactive.Visible = false;
            radioButtonInactive.Enabled = false;
            #endregion
        }

        public FormRegistration(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            dohvaceniZaposlenik = zaposlenik;

            #region [Properties changed]
            this.Text = "Uređivanje";
            labelRegistracijaIliUredivanje.Text = "Uređivanje podataka o korisniku";
            textBoxIme.Text = zaposlenik.Ime;
            textBoxPrezime.Text = zaposlenik.Prezime;
            textBoxEmail.Text = zaposlenik.Email;
            textBoxTelefon.Text = zaposlenik.Telefon;
            textBoxOIB.Text = zaposlenik.OIB;
            textBoxOIB.Enabled = false;
            textBoxBrojZiroRacuna.Text = zaposlenik.BrojZIroRacuna;
            textBoxKorisnickoIme.Text = zaposlenik.KorisnickoIme;
            textBoxKorisnickoIme.Enabled = false;
            textBoxLozinka.Text = zaposlenik.LozinkaHash;
            textBoxLozinka.UseSystemPasswordChar = true;
            comboBoxUloga.SelectedItem = zaposlenik.Uloga;
            //comboBoxUloga.DisplayMember = "Naziv";
            buttonRegistriraj.Enabled = false;
            buttonRegistriraj.Visible = false;
            radioButtonActive.Checked = true;
            #endregion

        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            GetComboBox();
        }

        private void GetComboBox()
        {
            comboBoxUloga.DataSource = UnitOfWork.Uloge.GetAll();
            comboBoxUloga.DisplayMember = "Naziv";
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik = UnitOfWork.Zaposlenici.GetById(dohvaceniZaposlenik.Id);

            if (ProvjeriPopunjenost())
            {
                ProvjeraPredznaka();
                if (!ValidationService.AssertEmail(textBoxEmail.Text))
                {
                    NotificationService.Notify($"Email nije ispravnog formata!");
                }
                else if (!ValidationService.AssertPositive(textBoxTelefon.Text))
                {
                    NotificationService.NumberField("Polja: Telefon");
                }
                else if (!ValidationService.AssertStringLenght(textBoxKorisnickoIme.Text, 6) || !ValidationService.AssertStringLenght(textBoxLozinka.Text, 6))
                {
                    NotificationService.Notify($"Korisničko ime i lozinka moraju sadržavat minimalno 6 znakova!");
                }
                else
                {
                    #region [Attach properties]
                    zaposlenik.Ime = textBoxIme.Text;
                    zaposlenik.Prezime = textBoxPrezime.Text;
                    zaposlenik.Telefon = textBoxTelefon.Text;
                    zaposlenik.Email = textBoxEmail.Text;
                    zaposlenik.BrojZIroRacuna = textBoxBrojZiroRacuna.Text;
                    zaposlenik.KorisnickoIme = textBoxKorisnickoIme.Text;
                    zaposlenik.LozinkaHash = textBoxLozinka.Text;
                    zaposlenik.Uloga = comboBoxUloga.SelectedItem as Uloga;
                    zaposlenik.Aktivan = radioButtonActive.Checked ? true : false;
                    #endregion

                    UnitOfWork.Zaposlenici.Update(zaposlenik);
                    UnitOfWork.Complete();

                    Close(); 
                }
            }
            else
            {
                NotificationService.InvalidInput();
            }
        }

        private void buttonRegistriraj_Click(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik;

            if (ProvjeriPopunjenost())
            {
                if (UnitOfWork.Zaposlenici.UsporediOIB(textBoxOIB.Text))
                {
                    NotificationService.EmployeeCheck("Korisnik postoji u bazi!");
                }
                else if (UnitOfWork.Zaposlenici.UsporediKorisnickoIme(textBoxKorisnickoIme.Text))
                {
                    NotificationService.Notify($"Korisničko ime: {textBoxKorisnickoIme.Text} je zauzeto!");
                }
                else if (!ValidationService.AssertEmail(textBoxEmail.Text))
                {
                    NotificationService.Notify($"Email nije ispravnog formata!");
                }
                else if (!ValidationService.AssertPositive(textBoxTelefon.Text) || !ValidationService.AssertPositive(textBoxOIB.Text))
                {
                    NotificationService.NumberField("Polja: Telefon i OIB");
                }
                else if (!ValidationService.AssertStringLenght(textBoxKorisnickoIme.Text, 6) || !ValidationService.AssertStringLenght(textBoxLozinka.Text, 6))
                {
                    NotificationService.Notify($"Korisničko ime i lozinka moraju sadržavat minimalno 6 znakova!");
                }
                else
                {
                    ProvjeraPredznaka();
                    #region [Set Zaposlenik]
                    zaposlenik = new Zaposlenik(
                                     textBoxIme.Text, textBoxPrezime.Text, textBoxTelefon.Text,
                                     textBoxEmail.Text, textBoxBrojZiroRacuna.Text, textBoxLozinka.Text,
                                     textBoxOIB.Text, textBoxKorisnickoIme.Text, comboBoxUloga.SelectedItem as Uloga);
                    #endregion
                    UnitOfWork.Zaposlenici.Add(zaposlenik);
                    UnitOfWork.Complete();

                    Close();
                }
            }
            else
            {
                NotificationService.InvalidInput();
            }
        }

        private void ProvjeraPredznaka()
        {
            if (textBoxTelefon.Text.Contains("-"))
            {
                textBoxTelefon.Text = textBoxTelefon.Text.Substring(1);
            }
            if (textBoxOIB.Text.Contains("-"))
            {
                textBoxOIB.Text = textBoxOIB.Text.Substring(1);
            }
        }

        private bool ProvjeriPopunjenost()
        {
            return ValidationService.IsNotEmpty(textBoxIme.Text) &&
                   ValidationService.IsNotEmpty(textBoxPrezime.Text) &&
                   ValidationService.IsNotEmpty(textBoxTelefon.Text) &&
                   ValidationService.IsNotEmpty(textBoxEmail.Text) &&
                   ValidationService.IsNotEmpty(textBoxOIB.Text) &&
                   ValidationService.IsNotEmpty(textBoxBrojZiroRacuna.Text) &&
                   ValidationService.IsNotEmpty(textBoxKorisnickoIme.Text) &&
                   ValidationService.IsNotEmpty(textBoxLozinka.Text);
        }

        private void FormRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
