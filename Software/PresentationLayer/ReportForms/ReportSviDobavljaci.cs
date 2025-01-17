﻿using BusinessLayer;
using BusinessLayer.Services;
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

namespace PresentationLayer.ReportForms
{
    public partial class ReportSviDobavljaci : Form
    {
        private IUnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());

        public ReportSviDobavljaci()
        {
            InitializeComponent();
        }

        private void FormSviDobavljaciReport_Load(object sender, EventArgs e)
        {
            List<Dobavljac> listaDobavljaca = unitOfWork.Dobavljaci.GetAll();
            DobavljacBindingSource.DataSource = listaDobavljaca;
            this.reportViewer1.RefreshReport();
        }

        private void ReportSviDobavljaci_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Owner.Visible = true;
            Owner.Dispose();
        }
    }
}
