using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class StavkaRacuna
    {
        public int Kolicina { get; set; }

        public virtual Racun Racun { get; set; }
        public virtual Artikl Artikl { get; set; }
    }
}
