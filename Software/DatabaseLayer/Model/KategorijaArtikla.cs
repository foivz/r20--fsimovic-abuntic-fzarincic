﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Kategorija artikla
    /// </summary>
    public class KategorijaArtikla
    {
        //[Key]
        public int Id { get; set; }
        public string Naziv { get; set; }

        public KategorijaArtikla(string naziv)
        {
            Naziv = naziv;
        }

    }
}
