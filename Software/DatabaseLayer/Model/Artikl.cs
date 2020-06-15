﻿using System;
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
        //[Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        //[Required]
        public KategorijaArtikla Kategorija { get; set; }

        public virtual ICollection<StavkaRacuna> StavkaRacuna { get; set; }
        public virtual ICollection<StavkaNarudzbenice> StavkaNarudzbe { get; set; }
        public virtual ICollection<StavkaPrimke> StavkaPrimke { get; set; }

        public Artikl(string naziv, double cijena, KategorijaArtikla kategorija)
        {
            Naziv = naziv;
            Cijena = cijena;
            Kategorija = kategorija;
        }
        public Artikl()
        {

        }
    }
}