using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class StavkaRacuna
    {
        public Racun Racun { get; set; }
        public Artikl Artikl { get; set; }
        public double Kolicina { get; set; }
    }
}
