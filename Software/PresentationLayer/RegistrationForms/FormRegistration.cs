using BusinessLayer;
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

        public FormRegistration(Form form)
        {
            InitializeComponent();
            this.Owner = form;
        }

        private void buttonRegistriraj_Click(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik;

            if (ValidationService.IsNotNull(textBoxIme) ||
                ValidationService.IsNotNull(textBoxPrezime) ||
                ValidationService.IsNotNull(textBoxTelefon) ||
                ValidationService.IsNotNull(textBoxEmail) ||
                ValidationService.IsNotNull(textBoxOIB) ||
                ValidationService.IsNotNull(textBoxBrojZiroRacuna) ||
                ValidationService.IsNotNull(textBoxKorisnickoIme) ||
                ValidationService.IsNotNull(textBoxLozinka) ||
                ValidationService.IsNotNull(comboBoxUloga.SelectedItem))
            {
                NotificationService.InvalidInput();
            }
            else
            {
                zaposlenik = new Zaposlenik(
                                    textBoxIme.Text, textBoxPrezime.Text, textBoxTelefon.Text,
                                    textBoxEmail.Text, textBoxBrojZiroRacuna.Text, textBoxLozinka.Text,
                                    textBoxOIB.Text, textBoxKorisnickoIme.Text, comboBoxUloga.SelectedItem as Uloga);
                UnitOfWork.Zaposlenici.Add(zaposlenik);
                UnitOfWork.Complete();

                Close();
            }
        }


        private void FormRegistration_Load(object sender, EventArgs e)
        {
            GetComboBox();
        }

        private void GetComboBox()
        {
            List<Uloga> listaUloga = UnitOfWork.Uloge.GetAll();
            List<string> listaNazivaUloga = new List<string>();

            foreach (var item in listaUloga)
            {
                listaNazivaUloga.Add(item.Naziv.ToString());
            }

            comboBoxUloga.DataSource = listaNazivaUloga;
        }

        private void textBoxTest_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F1)
            //{
            //    HelpButton = true;
            //}
        }

        private void FormRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
