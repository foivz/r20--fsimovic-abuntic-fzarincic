using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Artikl
    /// </summary>
    public class Artikl
    {
        #region [Mapped properties]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public KategorijaArtikla Kategorija { get; set; }
        public List<StavkaRacuna> StavkaRacuna { get; set; }
        public List<StavkaNarudzbenice> StavkaNarudzbe { get; set; }
        public List<StavkaPrimke> StavkaPrimke { get; set; }
        #endregion

        public Artikl(string naziv, double cijena, KategorijaArtikla kategorija)
        {
            Naziv = naziv;
            Cijena = cijena;
            Kategorija = kategorija;
        }

        public Artikl()
        {
            StavkaRacuna = new List<StavkaRacuna>();
            StavkaPrimke = new List<StavkaPrimke>();
            StavkaNarudzbe = new List<StavkaNarudzbenice>();
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}