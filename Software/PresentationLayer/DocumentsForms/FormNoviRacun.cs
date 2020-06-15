using System;
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
    public partial class FormNoviRacun : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        public FormNoviRacun()
        {
            InitializeComponent();
        }

        private void FormNoviRacun_Load(object sender, EventArgs e)
        {
            DohvatiArtikle();
            
        }

        private void DohvatiArtikle()
        {
            cmbArtikl.DataSource = unitOfWork.Artikli.GetAll();
            cmbArtikl.DisplayMember = "Naziv";
        }
    }
}
