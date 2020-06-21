using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Stavka računa. Spojna tablica u bazi podataka između računa i artikla.
    /// </summary>
    [Table("StavkeRacuna")]
    public class StavkaRacuna
    {
        public int Kolicina { get; set; }
        //[Key, Column(Order = 0)]
        public int RacunId { get; set; }
        public Racun Racun { get; set; }
        //[Key, Column(Order = 1)]
        public int ArtiklId { get; set; }
        public Artikl Artikl { get; set; }
        #region [Not mapped properties]
        [NotMapped]
        public double Ukupno { get { return Artikl.Cijena * Kolicina; } set {; } }
        [NotMapped]
        public double Cijena { get { return Artikl.Cijena; } set {; } }
        [NotMapped]
        public string Ime { get { return Artikl.Naziv; } set {; } }
        #endregion
    }
}
