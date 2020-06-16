using System;
using System.Collections.Generic;
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
        //[Key]
        public int Id { get; set; }
        public DateTime DatumIVrijemeIzdavanja { get; set; }
        //[Required]
        public Zaposlenik Zaposlenik { get; set; }

        public virtual ICollection<StavkaRacuna> StavkaRacuna { get; set; }

        public Racun()
        {

        }
    }
}
