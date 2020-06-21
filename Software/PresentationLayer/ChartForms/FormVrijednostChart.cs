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

namespace PresentationLayer.ChartForms
{
    public partial class FormVrijednostZaliha : Form
    {
        private IUnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        List<Artikl> listArtikla = new List<Artikl>();

        public FormVrijednostZaliha()
        {
            InitializeComponent();
            listArtikla = unitOfWork.Artikli.GetAll();
        }

        private void FormVrijednostZaliha_Load(object sender, EventArgs e)
        {
            chartVrijednostStanjaZaliha.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            foreach (var item in listArtikla)
            {
                chartVrijednostStanjaZaliha.Series["Kune"].Points.AddXY(item.Naziv, item.Cijena * item.Kolicina);
            }
        }

        private void FormVrijednostZaliha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Owner.Visible = true;
            Owner.Dispose();
        }
    }
}
