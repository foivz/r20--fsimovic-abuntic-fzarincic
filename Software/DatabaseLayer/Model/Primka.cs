using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class Primka
    {
        private int id { get; set; }
        public DateTime DatumIVrijemeIzdavanja { get; set; }
        public string OIBDobavljača { get; set; }
        public string NazivDobavljača { get; set; }
        public DateTime Datum { get; set; }
        public int Odgoda { get; set; }
        public DateTime DatumDospijeca { get; set; }
        public string Napomena { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public List<StavkaPrimke> StavkePrime { get; set; }
    }
}
