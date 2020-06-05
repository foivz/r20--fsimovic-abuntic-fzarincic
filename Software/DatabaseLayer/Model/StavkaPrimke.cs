using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class StavkaPrimke
    {
        public int Kolicina { get; set; }
        public virtual Primka Primka { get; set; }
        public virtual Artikl Artikl { get; set; }
    }
}
