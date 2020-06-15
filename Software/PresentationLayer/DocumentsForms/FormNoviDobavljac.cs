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
    public partial class FormNoviDobavljac : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ClubbingPayDbContext());
        public FormNoviDobavljac()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzradi_Click(object sender, EventArgs e)
        {
            try
            {
                Dobavljac dobavljac = new Dobavljac(tboNaziv.Text, tboOIB.Text, tboTelefon.Text, tboEmail.Text, tboAdresa.Text);
                unitOfWork.Dobavljaci.Add(dobavljac);
                unitOfWork.Complete();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
