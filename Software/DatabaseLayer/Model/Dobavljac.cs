using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Dobavljač
    /// </summary>
    public class Dobavljac
    {
        //[Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oib { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }

        public Dobavljac()
        {

        }

        public Dobavljac(string ime, string oib, string telefon, string email, string adresa)
        {
            Naziv = ime;
            Oib = oib;
            Telefon = telefon;
            Email = email;
            Adresa = adresa;
        }
    }
}
