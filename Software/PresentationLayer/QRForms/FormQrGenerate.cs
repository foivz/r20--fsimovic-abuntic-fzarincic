using BusinessLayer.Services;
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
        public FormQrGenerate()
        {
            InitializeComponent();
        }

        private void buttonGenerateQR_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;
            
            pictureBoxQR.Image = QRService.GenerirajQR(user, pass);
        }

        private void FormQrGenerate_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
