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
            //comboBoxKategorija.SelectedItem = Artikl.KategorijaId;
            //comboBoxKategorija.SelectedItem = UnitOfWork.KategorijaArtikla.GetById(Artikl.Kategorija.Id) as KategorijaArtikla;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            
        }
    }
}
