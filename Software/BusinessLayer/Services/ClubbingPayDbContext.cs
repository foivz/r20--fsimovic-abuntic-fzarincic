using DatabaseLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public partial class ClubbingPayDbContext : DbContext
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
            modelBuilder.Entity<StavkaNarudzbenice>().HasKey(x => new { x.NarudzbenicaId, x.ArtiklId });
            modelBuilder.Entity<StavkaNarudzbenice>()
              .HasOne(x => x.Artikl)
              .WithMany(x => x.StavkaNarudzbe)
              .HasForeignKey(x => x.ArtiklId)
              .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<StavkaNarudzbenice>()
               .HasOne(x => x.Narudzbenica)
               .WithMany(x => x.StavkaNarudzbe)
               .HasForeignKey(x => x.NarudzbenicaId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StavkaPrimke>().HasKey(x => new { x.ArtiklId, x.PrimkaId });
            modelBuilder.Entity<StavkaPrimke>()
              .HasOne(x => x.Artikl)
              .WithMany(x => x.StavkaPrimke)
              .HasForeignKey(x => x.ArtiklId)
              .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<StavkaPrimke>()
               .HasOne(x => x.Primka)
               .WithMany(x => x.StavkaPrimke)
               .HasForeignKey(x => x.PrimkaId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StavkaRacuna>().HasKey(x => new { x.ArtiklId, x.RacunId });
            modelBuilder.Entity<StavkaRacuna>()
              .HasOne(x => x.Artikl)
              .WithMany(x => x.StavkaRacuna)
              .HasForeignKey(x => x.ArtiklId)
              .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<StavkaRacuna>()
               .HasOne(x => x.Racun)
               .WithMany(x => x.StavkaRacuna)
               .HasForeignKey(x => x.RacunId)
               .OnDelete(DeleteBehavior.Cascade);
           
            

            base.OnModelCreating(modelBuilder);
        }

        //U Server= staviti svoj localhost
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(
                "Data Source = 31.147.204.119\\PISERVER, 1433; Initial Catalog = PI20_030_DB; Persist Security Info=True;User ID = PI20_030_User; Password=iy-mBvVo");

    }
}
