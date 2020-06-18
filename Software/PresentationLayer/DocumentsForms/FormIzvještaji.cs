﻿using PresentationLayer.ReportForms;
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
    public partial class FormIzvještaji : Form
    {
        public FormIzvještaji()
        {
            InitializeComponent();
        }

        private void btnSviZaposlenici_Click(object sender, EventArgs e)
        {
            FormSviZaposleniciReport form = new FormSviZaposleniciReport();
            form.ShowDialog();
        }

        private void btnSviDobavljaci_Click(object sender, EventArgs e)
        {
            FormSviDobavljaciReport form = new FormSviDobavljaciReport();
            form.ShowDialog();
        }

        private void btnSviArtikli_Click(object sender, EventArgs e)
        {
            FormSviArtikliReport form = new FormSviArtikliReport();
            form.ShowDialog();
        }
    }
}
