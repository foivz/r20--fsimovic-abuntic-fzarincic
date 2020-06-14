﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Narudžbenica
    /// </summary>
    public class Narudzbenica
    {
        //[Key]
        public int Id { get; set; }
        public DateTime DatumIVrijemeIzdavanja { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public Dobavljac Dobavljac { get; set; }

        public virtual ICollection<StavkaNarudzbenice> StavkaNarudzbe { get; set; }
    }
}