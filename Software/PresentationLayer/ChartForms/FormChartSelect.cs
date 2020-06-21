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
    public partial class FormChartSelect : Form
    {
        public FormChartSelect()
        {
            InitializeComponent();
        }

        private void buttonStanjeZaliha_Click(object sender, EventArgs e)
        {
            FormArtikliChart form = new FormArtikliChart() { Owner = this };
            Hide();
            form.Show();
        }

        private void buttonVrijednostZaliha_Click(object sender, EventArgs e)
        {
            FormVrijednostZaliha form = new FormVrijednostZaliha() { Owner = this };
            Hide();
            form.Show();
        }

        private void FormChartSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}
