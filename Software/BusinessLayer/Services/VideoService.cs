using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace BusinessLayer.Services
{
    public class VideoService : INotifyPropertyChanged
    {
        private Bitmap _picture;
        public Bitmap Picture
        {
            get
            {
                return _picture;
            }
            set
            {
                _picture = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Picture"));
            }
        }

        private readonly FilterInfoCollection videoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        private VideoCaptureDevice finalVideo = new VideoCaptureDevice();

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public void UpaliKameru()
        {
            if (finalVideo.IsRunning == true) finalVideo.Stop();

            finalVideo = new VideoCaptureDevice(videoCaptureDevices[0].MonikerString);
            finalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);

            finalVideo.Start();
        }

        public void UgaisKameru()
        {
            if (finalVideo != null)
            {
                finalVideo.NewFrame -= new NewFrameEventHandler(FinalVideo_NewFrame);
                finalVideo.SignalToStop();
                finalVideo = null;
            }
        }

        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Picture = (Bitmap)eventArgs.Frame.Clone();
            Picture.RotateFlip(RotateFlipType.Rotate180FlipY);
        }
    }
}
