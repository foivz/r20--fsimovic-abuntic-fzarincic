﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class Racun
    {
        public int Id { get; set; }
        public DateTime DatumIVrijemeIzdavanja { get; set; }
        public Zaposlenik Zaposlenik { get; set; }

        public virtual ICollection<StavkaRacuna> StavkaRacuna { get; set; }
    }
}
