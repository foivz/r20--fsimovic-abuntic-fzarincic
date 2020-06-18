using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Stavka narudžbenice. Spojna tablica u bazi podataka između narudžbenice i artikla.
    /// </summary>
    public class StavkaNarudzbenice
    {
        public int Kolicina { get; set; }
        //[Key, Column(Order = 0)]
        public int NarudzbenicaId { get; set; }
        public Narudzbenica Narudzbenica { get; set; }
        //[Key, Column(Order = 1)]
        public int ArtiklId { get; set; }
        public Artikl Artikl { get; set; }
    }
}
