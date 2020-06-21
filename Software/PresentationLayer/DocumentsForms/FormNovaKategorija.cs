using BusinessLayer.Repositories;
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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.DocumentsForms
{
    public partial class FormNovaKategorija : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());

        public FormNovaKategorija()
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
                if (ValidationService.AssertStringLenght(textBoxNaziv.Text, 1) == false) throw new Exception();
                KategorijaArtikla kategorija = new KategorijaArtikla(textBoxNaziv.Text);
                unitOfWork.KategorijaArtikla.Add(kategorija);
                unitOfWork.Complete();
                this.Close();
            }
            catch (Exception)
            {

                NotificationService.Notify("Dogodila se greška prilokom unosa!");
            }
        }

        private void FormNovaKategorija_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}
