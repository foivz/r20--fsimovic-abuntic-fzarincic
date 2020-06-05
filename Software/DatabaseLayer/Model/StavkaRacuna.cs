using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class StavkaRacuna
    {
        public int Kolicina { get; set; }
        [Key, Column(Order = 0)]
        public int RacunId { get; set; }
        public virtual Racun Racun { get; set; }
        [Key, Column(Order = 1)]
        public int ArtiklId { get; set; }
        public virtual Artikl Artikl { get; set; }
    }
}
