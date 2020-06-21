﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Uloga
    /// </summary>
    public class Uloga
    {
        #region [Mapped properies]
        public int Id { get; set; }
        public string Naziv { get; set; }
        #endregion

        public override string ToString()
        {
            return Naziv;
        }
    }
}
