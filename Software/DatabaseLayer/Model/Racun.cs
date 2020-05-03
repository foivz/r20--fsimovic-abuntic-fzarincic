using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class Racun
    {
        private int id { get; set; }
        public DateTime DatumIVrijemeIzdavanja { get; set; }
        public double Osnovica { get; set; }
        public double PorezNaDodanuVrijednost { get; set; }
        public double PorezNaPotrosnju { get; set; }
        public double UkupniIznos { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public List<StavkaRacuna> StavkeRacuna { get; set; }
    }
}
