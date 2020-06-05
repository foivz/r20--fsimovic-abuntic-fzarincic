using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class StavkaPrimke
    {
        public int Kolicina { get; set; }
        [Key, Column(Order = 0)]
        public int PrimkaId { get; set; }
        public virtual Primka Primka { get; set; }
        [Key, Column(Order = 1)]
        public int ArtiklId { get; set; }
        public virtual Artikl Artikl { get; set; }
    }
}
