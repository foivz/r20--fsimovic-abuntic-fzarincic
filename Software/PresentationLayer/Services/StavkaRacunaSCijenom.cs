using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.Model;
namespace PresentationLayer.Services
{
    class StavkaRacunaSCijenom : StavkaRacuna
    {
        public double Cijena { get; set; }
        public double Ukupno { get { return Cijena * Kolicina; } set {;} }
    }
}
