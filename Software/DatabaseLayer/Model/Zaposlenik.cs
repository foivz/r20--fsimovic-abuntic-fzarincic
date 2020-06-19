using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Zaposlenik
    /// </summary>
    public class Zaposlenik
    {
        #region [Mapped properties]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string BrojZIroRacuna { get; set; }
        public bool Aktivan { get; set; }
        public string LozinkaHash { get; set; }
        public Uloga Uloga { get; set; }
        public string OIB { get; set; }
        public string KorisnickoIme { get; set; } 
        #endregion

        public Zaposlenik()
        {

        }

        public Zaposlenik(string ime, string prezime, string telefon, string email, string brojZiroRacuna, string lozinka, string oib, string korisnickoIme, Uloga uloga)
        {
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
            Email = email;
            BrojZIroRacuna = brojZiroRacuna;
            Aktivan = true;
            Uloga = null;
            OIB = oib;
            KorisnickoIme = korisnickoIme;
            LozinkaHash = lozinka;
            Uloga = uloga;
        }
    }
}
