﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Repositories;
using BusinessLayer.Services;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Model;

namespace PresentationLayer.DocumentsForms
{
    public partial class FormDodajArtikl : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        public FormDodajArtikl()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Artikl artikl = new Artikl(textBoxNaziv.Text, double.Parse(textBoxCijena.Text), comboBoxKategorija.SelectedItem as KategorijaArtikla);
                unitOfWork.Artikli.Add(artikl);
                unitOfWork.Complete();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovaKategorija_Click(object sender, EventArgs e)
        {
            FormKategorija form = new FormKategorija();
            form.ShowDialog();
            OsvjeziKategorije();
        }

        private void OsvjeziKategorije()
        {
            comboBoxKategorija.DataSource = unitOfWork.KategorijaArtikla.GetAll();
            comboBoxKategorija.DisplayMember = "Naziv";
        }

        private void FormDodajArtikl_Load(object sender, EventArgs e)
        {
            OsvjeziKategorije();
        }
    }
}