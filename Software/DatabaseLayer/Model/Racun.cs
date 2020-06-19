using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Račun
    /// </summary>
    public class Racun
    {
        #region [Mapped properties]
        public int Id { get; set; }
        public DateTime DatumIVrijemeIzdavanja { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public List<StavkaRacuna> StavkaRacuna { get; set; }
        #endregion
        #region [Not mapped properties]
        [NotMapped]
        public double Ukupno
        {
            get
            {
                return StavkaRacuna.Sum(sr => sr.Artikl.Cijena * sr.Kolicina);
            }
        }
        [NotMapped]
        public double Pdv
        {
            get
            {
                return Ukupno * 0.25;
            }
        }
        [NotMapped]
        public double PorezNaPotrosnju
        {
            get
            {
                return Ukupno * 0.03;
            }
        }
        [NotMapped]
        public double Osnovica
        {
            get
            {
                return Ukupno - Pdv - PorezNaPotrosnju;
            }
        }
        #endregion
        public Racun()
        {
            StavkaRacuna = new List<StavkaRacuna>();
        }
    }
}