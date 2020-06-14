using BusinessLayer.Services;
using PresentationLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.LoginForms
{
    public partial class FormLoginQRScan : Form
    {
        private VideoService video = new VideoService();

        private int Counter;

        public FormLoginQRScan()
        {
            InitializeComponent();
        }

        private void FormLoginQRScan_Load(object sender, EventArgs e)
        {
            video.UpaliKameru();
            video.PropertyChanged += Image_PropertyChanged;
        }

        private void FormLoginQRScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            video.UgaisKameru();
        }

        private void Image_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Picture")
            {
                CheckLogin();
            }
        }

        private void CheckLogin()
        {
            if (Counter % 15 == 0)
            {
                NotificationService.NotifyLoginResult(QRService.ProcitajQR(video.Picture));
            }
            Counter++;
        }
    }
}
