using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Stavka primke. Spojna tablica u bazi podataka između primke i artikla.
    /// </summary>
    public class StavkaPrimke
    {
        public int Kolicina { get; set; }
        //[Key, Column(Order = 0)]
        public int PrimkaId { get; set; }
        public Primka Primka { get; set; }
        //[Key, Column(Order = 1)]
        public int ArtiklId { get; set; }
        public Artikl Artikl { get; set; }
    }
}
