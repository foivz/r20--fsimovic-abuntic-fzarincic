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

        public FormSviZaposlenici(Form form)
        {
            InitializeComponent();
            this.Owner = form;
        }

        private void FormSviZaposlenici_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewZaposlenici.DataSource = unitOfWork.Zaposlenici.GetAll();
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewZaposlenici.SelectedRows)
            {
                var cellValue = row.Cells["Id"].Value;
                unitOfWork.Zaposlenici.Delete(unitOfWork.Zaposlenici.GetById(int.Parse(cellValue.ToString())));
            }

            unitOfWork.Complete();

            RefreshDataGridView();
        }

        private void FormSviZaposlenici_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
