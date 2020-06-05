﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DatabaseLayer.Model
{
    public class Primka
    {
        [Key]
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int Odgoda { get; set; }
        public string Napomena { get; set; }
        [Required]
        public Zaposlenik Zaposlenik { get; set; }
        [Required]
        public Dobavljac Dobavljac { get; set; }
        public virtual ICollection<StavkaPrimke> StavkaPrimke { get; set; }
    }
}
