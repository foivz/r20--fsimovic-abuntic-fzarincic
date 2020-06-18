using BusinessLayer.Enums;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace BusinessLayer.Services
{
    public static class QRService
    {
        public static Bitmap GenerirajQR(string user, string pass)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(user + " " + pass, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            return code.GetGraphic(15);
        }

        public static LoginResult ProcitajQR(Bitmap bitmap)
        {
            string user = "";
            string pass = "";
            BarcodeReader reader = new BarcodeReader { AutoRotate = true, TryInverted = true };
            try
            {
                Result result = reader.Decode(bitmap);
                string[] decoded;
                if (result != null)
                {
                    decoded = result.ToString().Split(' ');

                    user = decoded[0];
                    pass = decoded[1];

                    return UserManager.LogirajKorisnika(user, pass);
                }
            }
            catch (Exception)
            {
                return LoginResult.Null;
            }
            return LoginResult.Null;
        }
    }
}
