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
    public partial class FormAzurirajArtikl : Form
    {
        private Artikl Artikl;
        private UnitOfWork UnitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        public FormAzurirajArtikl(Artikl artikl)
        {
            InitializeComponent();
            Artikl = artikl;
            
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAzurirajArtikl_Load(object sender, EventArgs e)
        {
            textBoxNaziv.Text = Artikl.Naziv.ToString();
            textBoxCijena.Text = Artikl.Cijena.ToString();
            comboBoxKategorija.DataSource = null;
            comboBoxKategorija.DataSource = UnitOfWork.KategorijaArtikla.GetAll();
            comboBoxKategorija.DisplayMember = "Naziv";
            //comboBoxKategorija.SelectedItem = UnitOfWork.KategorijaArtikla.GetById(Artikl.Kategorija.Id) as KategorijaArtikla;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationService.ParseDoubleNumber(textBoxCijena.Text, out double number) == false) throw new Exception();
                if (ValidationService.AssertStringLenght(textBoxNaziv.Text, 1) == false) throw new Exception();
                if (double.Parse(textBoxCijena.Text) < 0) throw new Exception();
                Artikl.Naziv = textBoxNaziv.Text;
                Artikl.Cijena = double.Parse(textBoxCijena.Text);
                Artikl.Kategorija = comboBoxKategorija.SelectedItem as KategorijaArtikla;
                UnitOfWork.Artikli.Update(Artikl);
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
