﻿using PresentationLayer.LoginForms;
using PresentationLayer.QRForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void buttonQrLogin_Click(object sender, EventArgs e)
        {
            FormLoginQRScan form = new FormLoginQRScan();
            form.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }

        private void buttonGenQrFrom_Click(object sender, EventArgs e)
        {
            FormQrGenerate form = new FormQrGenerate();
            form.Show();
            this.Hide();
        }
    }
}