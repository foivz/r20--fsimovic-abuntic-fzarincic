using BusinessLayer;
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
    public partial class ReportSviArtikli : Form
    {
        private IUnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());

        public ReportSviArtikli()
        {
            InitializeComponent();
        }

        private void FormSviArtikliReport_Load(object sender, EventArgs e)
        {
            List<Artikl> listaArtikala = unitOfWork.Artikli.GetAll();

            ArtiklBindingSource.DataSource = listaArtikala;
            this.reportViewer1.RefreshReport();
        }
    }
}
