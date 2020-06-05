using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class StavkaNarudzbe
    {
        public int Kolicina { get; set; }
        public virtual Narudzbenica Narudzbenica { get; set; }
        public virtual Artikl Artikl { get; set; }
    }
}
