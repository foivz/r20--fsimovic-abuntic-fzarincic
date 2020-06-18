
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
    public partial class FormSviZaposleniciReport : Form
    {
        private IUnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());

        public FormSviZaposleniciReport()
        {
            InitializeComponent();
        }

        private void FormSviZaposleniciReport_Load(object sender, EventArgs e)
        {
            List<Zaposlenik> listaZaposlenika = unitOfWork.Zaposlenici.GetAll();

            this.reportViewer1.RefreshReport();
        }
    }
}
