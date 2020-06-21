using PresentationLayer.LoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.StartForm
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin()
            {
                Owner = this
            };

            form.Show();
            this.Hide();
        }

        private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
