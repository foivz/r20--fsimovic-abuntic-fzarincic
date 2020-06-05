using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseLayer.Model
{
    public class ClubbingPayDbContext : DbContext
    {

        public DbSet<Zaposlenik> Zaposlenici { get; set; }
        public DbSet<Racun> Racuni { get; set; }
        public DbSet<Artikl> Artikli { get; set; }
        public DbSet<KategorijaArtikla> KategorijeArtikla { get; set; }
        public DbSet<Dobavljac> Dobavljaci { get; set; }
        public DbSet<Narudzbenica> Narudzbenice { get; set; }
        public DbSet<Primka> Primke { get; set; }
        public DbSet<StavkaNarudzbenice> StavkeNarudzbenice { get; set; }
        public DbSet<StavkaPrimke> StavkePrimke { get; set; }
        public DbSet<StavkaRacuna> StavkaRacuna { get; set; }
        public DbSet<Uloga> Uloge { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zaposlenik>().ToTable("Zaposlenici");
            modelBuilder.Entity<Racun>().ToTable("Racuni");
            modelBuilder.Entity<Artikl>().ToTable("Artikli");
            modelBuilder.Entity<KategorijaArtikla>().ToTable("KategorijaArtikala");
            modelBuilder.Entity<Dobavljac>().ToTable("Dobavljaci");
            modelBuilder.Entity<Narudzbenica>().ToTable("Narudzbenice");
            modelBuilder.Entity<Primka>().ToTable("Primke");
            modelBuilder.Entity<Uloga>().ToTable("Uloge");
            modelBuilder.Entity<StavkaNarudzbenice>().ToTable("StavkeNarudzbenice").HasKey(x => new { x.NarudzbenicaId, x.ArtiklId });
            modelBuilder.Entity<StavkaPrimke>().ToTable("StavkePrimke").HasKey(x => new { x.ArtiklId, x.PrimkaId });
            modelBuilder.Entity<StavkaRacuna>().ToTable("StavkeRacuna").HasKey(x => new { x.ArtiklId, x.RacunId });
            
            base.OnModelCreating(modelBuilder);
        }

        //U Server= staviti svoj localhost
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(
                "Server = DESKTOP-H4KS5T0;" +
                "Database = dbClubbingPay;" +
                "Trusted_Connection = true;");
    }
}