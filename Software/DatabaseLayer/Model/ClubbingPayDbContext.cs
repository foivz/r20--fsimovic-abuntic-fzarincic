using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class ClubbingPayDbContext : DbContext
    {
        public DbSet<Zaposlenik> Zaposlenici { get; set; }
        public DbSet<Racun> Racuni { get; set; }
        public DbSet<Artikl> Artikli { get; set; }
        public DbSet<KategorijaArtikla> KategorijeArtikla { get; set; }
        public DbSet<StavkaRacuna> StavkaRacuna { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}