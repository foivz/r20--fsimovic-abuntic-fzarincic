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

namespace PresentationLayer.DocumentsForms
{
    public partial class FormSviZaposlenici : Form
    {
        private IUnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());

        public FormSviZaposlenici()
        {
            InitializeComponent();
        }

        private void FormSviZaposlenici_Load(object sender, EventArgs e)
        {
            dataGridViewZaposlenici.DataSource = unitOfWork.Zaposlenici.GetAll();
        }
    }
}
