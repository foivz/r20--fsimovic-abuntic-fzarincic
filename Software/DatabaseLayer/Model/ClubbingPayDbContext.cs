using DatabaseLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class ClubbingPayDbContext : DbContext
    {
        public DbSet<Zaposlenik> Zaposlenici { get; set; }
        public DbSet<Racun> Racuni { get; set; }
        public DbSet<Primka> Primke { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
