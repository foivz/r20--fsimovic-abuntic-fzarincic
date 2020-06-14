﻿using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Services
{
    /// <summary>
    /// Klasa za poruke o pogreškama tokom unosa podataka
    /// </summary>
    public static class NotificationService
    {
        /// <summary>
        /// Metoda koja vraća poruku o neispravnom unosu
        /// </summary>
        public static void InvalidInput()
        {
            MessageBox.Show("Unijeli ste neispravne podatke!");
        }

        public static void QrError()
        {
            MessageBox.Show("Zaposlenik nije pronađen ili se dogodila greška priliom čitanja Qr koda!");
        }

        public static void InactiveEmployee()
        {
            MessageBox.Show("Zaposlenik nije aktivan!");
        }

        public static void NotifyLoginResult(LoginResult loginResult)
        {
            {
                switch (loginResult)
                {
                    case LoginResult.NotFound:
                        QrError();
                        break;
                    case LoginResult.Inactive:
                        InactiveEmployee();
                        break;
                }
                
            }
        }
    }
}