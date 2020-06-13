using BusinessLayer.Enums;
using DatabaseLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    /// <summary>
    /// Klasa UserManager se bavi logiranjem i odlogiranjem korisnia.
    /// </summary>
    public static class UserManager
    {
        private static IUnitOfWork UnitOfWork = new UnitOfWork(new ClubbingPayDbContext());

        /// <summary>
        /// Proprerti koji sadržava trenutnog korisnika.
        /// </summary>
        public static Zaposlenik LogiranKorisnik { get; private set; }

        /// <summary>
        /// Metoda LogirajKorisnika logira korisnika u aplikaciju.
        /// </summary>
        /// <param name="user">user = username korisnika</param>
        /// <param name="password">password = password korisnika</param>
        /// <returns>Vraća enum o uspješnosti logina korisnika.</returns>
        public static LoginResult LogirajKorisnika(string user, string password)
        {
            var zaposlenik = UnitOfWork.Zaposlenici.PronadiZaposlenika(user, password);

            if (zaposlenik == null)
            {
                return LoginResult.NotFound;
            }
            else if (!zaposlenik.Aktivan)
            {
                return LoginResult.Inactive;
            }
            else
            {
                LogiranKorisnik = zaposlenik;
                return LoginResult.Succesful;
            }
        }

        /// <summary>
        /// Odlogira trenutnog korisnika. Postavlja properti LogiranKorisni na null.
        /// </summary>
        public static void OdlogirajKorisnika()
        {
            LogiranKorisnik = null;
        }
    }
}
