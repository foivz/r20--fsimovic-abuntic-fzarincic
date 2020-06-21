using BusinessLayer;
using BusinessLayer.Enums;
using BusinessLayer.Services;
using PresentationLayer.DocumentsForms;
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
    public partial class FormLogin : Form
    {
        private VideoService video = new VideoService();

        private int Counter;

        public FormLogin()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
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
                if (QRService.ProcitajQR(video.Picture) == LoginResult.Succesful)
                {
                    FormNoviRacun form = new FormNoviRacun()
                    {
                        Owner = this
                    };

                    video.UgaisKameru();

                    //form.Show();
                    //this.Hide();
                    if (IsHandleCreated)
                    {
                        Invoke((Action)(() => { form.Show(); }));
                        Invoke((Action)(() => { this.Hide(); }));
                    }
                }
                else
                {
                    NotificationService.NotifyLoginResult(QRService.ProcitajQR(video.Picture));
                }
            }
            Counter++;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            var result = UserManager.LogirajKorisnika(username, password);

            if (result != LoginResult.Succesful)
            {
                NotificationService.NotifyLoginResult(result);
                textBoxPassword.Clear();
            }
            else
            {
                FormNoviRacun form = new FormNoviRacun()
                {
                    Owner = this
                };
                video.UgaisKameru();

                form.Show();
                this.Hide();

                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
