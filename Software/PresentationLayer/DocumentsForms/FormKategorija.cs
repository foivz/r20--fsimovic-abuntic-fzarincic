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


namespace PresentationLayer.DocumentsForms
{
    public partial class FormKategorija : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());

        public FormKategorija()
        {
            InitializeComponent();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                KategorijaArtikla kategorija = new KategorijaArtikla(textBoxNaziv.Text);
                unitOfWork.KategorijaArtikla.Add(kategorija);
                unitOfWork.Complete();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
