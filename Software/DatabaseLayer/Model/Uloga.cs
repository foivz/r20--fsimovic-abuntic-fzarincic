using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DatabaseLayer.Model
{
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
