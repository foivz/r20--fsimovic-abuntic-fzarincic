using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DatabaseLayer.Model
{
    public class Artikl
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        [Required]
        public KategorijaArtikla Kategorija { get; set; }

        public virtual ICollection<StavkaRacuna> StavkaRacuna { get; set; }
        public virtual ICollection<StavkaNarudzbenice> StavkaNarudzbe { get; set; }
        public virtual ICollection<StavkaPrimke> StavkaPrimke { get; set; }
    }
}
