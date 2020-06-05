using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DatabaseLayer.Model
{
    public class Racun
    {
        [Key]
        public int Id { get; set; }
        public DateTime DatumIVrijemeIzdavanja { get; set; }
        [Required]
        public Zaposlenik Zaposlenik { get; set; }

        public virtual ICollection<StavkaRacuna> StavkaRacuna { get; set; }
    }
}
