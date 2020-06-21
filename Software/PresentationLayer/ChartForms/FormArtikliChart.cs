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
    public partial class FormArtikliChart : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        List<Artikl> listArtikla = new List<Artikl>();

        public FormArtikliChart()
        {
            InitializeComponent();
            listArtikla = unitOfWork.Artikli.GetAll();
        }
        
        private void FormArtikliChart_Load(object sender, EventArgs e)
        {
            chartArtikli.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            foreach (var item in listArtikla)
            {
                chartArtikli.Series["Artikli"].Points.AddXY(item.Naziv, item.Kolicina);
            }
        }

        private void FormArtikliChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}
