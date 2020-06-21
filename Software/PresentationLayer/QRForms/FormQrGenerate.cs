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

namespace PresentationLayer.QRForms
{
    public partial class FormQrGenerate : Form
    {
        private Zaposlenik zaposlenik;

        public FormQrGenerate(Zaposlenik _zaposlenik)
        {
            InitializeComponent();
            zaposlenik = _zaposlenik;
        }

        private void FormQrGenerate_Load(object sender, EventArgs e)
        {
            pictureBoxQR.Image = QRService.GenerirajQR(zaposlenik.KorisnickoIme, zaposlenik.LozinkaHash);
        }

        private void FormQrGenerate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}
