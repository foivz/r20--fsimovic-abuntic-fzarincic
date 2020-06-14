using BusinessLayer.Repositories;
using BusinessLayer.Services;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.RegistrationForms
{
    public partial class FormRegistration : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());

        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonRegistriraj_Click(object sender, EventArgs e)
        {
            try
            {
                Zaposlenik zaposlenik = new Zaposlenik(
                    textBoxIme.Text, textBoxPrezime.Text, textBoxTelefon.Text,
                    textBoxEmail.Text, textBoxBrojZiroRacuna.Text, textBoxLozinka.Text,
                    textBoxOIB.Text, textBoxKorisnickoIme.Text);
                unitOfWork.Zaposlenici.Add(zaposlenik);
                unitOfWork.Complete();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            Uloga uloga = new Uloga();
            comboBoxUloga.DataSource = null;
        }
    }
}
