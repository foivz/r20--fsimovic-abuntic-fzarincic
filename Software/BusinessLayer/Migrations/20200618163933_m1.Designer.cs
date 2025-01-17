﻿// <auto-generated />
using System;
using BusinessLayer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessLayer.Migrations
{
    [DbContext(typeof(ClubbingPayDbContext))]
    [Migration("20200618163933_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatabaseLayer.Model.Artikl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena");

                    b.Property<int?>("KategorijaId");

                    b.Property<int>("Kolicina");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Artikli");
                });

            modelBuilder.Entity("DatabaseLayer.Model.Dobavljac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<string>("Email");

                    b.Property<string>("Naziv");

                    b.Property<string>("Oib");

                    b.Property<string>("Telefon");

                    b.HasKey("Id");

                    b.ToTable("Dobavljaci");
                });

            modelBuilder.Entity("DatabaseLayer.Model.KategorijaArtikla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("KategorijeArtikla");
                });

            modelBuilder.Entity("DatabaseLayer.Model.Narudzbenica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIVrijemeIzdavanja");

                    b.Property<int?>("DobavljacId");

                    b.Property<int?>("ZaposlenikId");

                    b.HasKey("Id");

                    b.HasIndex("DobavljacId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Narudzbenice");
                });

            modelBuilder.Entity("DatabaseLayer.Model.Primka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<int?>("DobavljacId");

                    b.Property<string>("Napomena");

                    b.Property<int>("Odgoda");

                    b.Property<int?>("ZaposlenikId");

                    b.HasKey("Id");

                    b.HasIndex("DobavljacId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Primke");
                });

            modelBuilder.Entity("DatabaseLayer.Model.Racun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIVrijemeIzdavanja");

                    b.Property<int?>("ZaposlenikId");

                    b.HasKey("Id");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Racuni");
                });

            modelBuilder.Entity("DatabaseLayer.Model.StavkaNarudzbenice", b =>
                {
                    b.Property<int>("NarudzbenicaId");

                    b.Property<int>("ArtiklId");

                    b.Property<int>("Kolicina");

                    b.HasKey("NarudzbenicaId", "ArtiklId");

                    b.HasIndex("ArtiklId");

                    b.ToTable("StavkeNarudzbenice");
                });

            modelBuilder.Entity("DatabaseLayer.Model.StavkaPrimke", b =>
                {
                    b.Property<int>("ArtiklId");

                    b.Property<int>("PrimkaId");

                    b.Property<int>("Kolicina");

                    b.HasKey("ArtiklId", "PrimkaId");

                    b.HasIndex("PrimkaId");

                    b.ToTable("StavkePrimke");
                });

            modelBuilder.Entity("DatabaseLayer.Model.StavkaRacuna", b =>
                {
                    b.Property<int>("ArtiklId");

                    b.Property<int>("RacunId");

                    b.Property<int>("Kolicina");

                    b.HasKey("ArtiklId", "RacunId");

                    b.HasIndex("RacunId");

                    b.ToTable("StavkeRacuna");
                });

            modelBuilder.Entity("DatabaseLayer.Model.Uloga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("DatabaseLayer.Model.Zaposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan");

                    b.Property<string>("BrojZIroRacuna");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("LozinkaHash");

                    b.Property<string>("OIB");

                    b.Property<string>("Prezime");

                    b.Property<string>("Telefon");

                    b.Property<int?>("UlogaId");

                    b.HasKey("Id");

                    b.HasIndex("UlogaId");

                    b.ToTable("Zaposlenici");
                });

            modelBuilder.Entity("DatabaseLayer.Model.Artikl", b =>
                {
                    b.HasOne("DatabaseLayer.Model.KategorijaArtikla", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId");
                });

            modelBuilder.Entity("DatabaseLayer.Model.Narudzbenica", b =>
                {
                    b.HasOne("DatabaseLayer.Model.Dobavljac", "Dobavljac")
                        .WithMany()
                        .HasForeignKey("DobavljacId");

                    b.HasOne("DatabaseLayer.Model.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId");
                });

            modelBuilder.Entity("DatabaseLayer.Model.Primka", b =>
                {
                    b.HasOne("DatabaseLayer.Model.Dobavljac", "Dobavljac")
                        .WithMany()
                        .HasForeignKey("DobavljacId");

                    b.HasOne("DatabaseLayer.Model.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId");
                });

            modelBuilder.Entity("DatabaseLayer.Model.Racun", b =>
                {
                    b.HasOne("DatabaseLayer.Model.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId");
                });

            modelBuilder.Entity("DatabaseLayer.Model.StavkaNarudzbenice", b =>
                {
                    b.HasOne("DatabaseLayer.Model.Artikl", "Artikl")
                        .WithMany("StavkaNarudzbe")
                        .HasForeignKey("ArtiklId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DatabaseLayer.Model.Narudzbenica", "Narudzbenica")
                        .WithMany("StavkaNarudzbe")
                        .HasForeignKey("NarudzbenicaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DatabaseLayer.Model.StavkaPrimke", b =>
                {
                    b.HasOne("DatabaseLayer.Model.Artikl", "Artikl")
                        .WithMany("StavkaPrimke")
                        .HasForeignKey("ArtiklId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DatabaseLayer.Model.Primka", "Primka")
                        .WithMany("StavkaPrimke")
                        .HasForeignKey("PrimkaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DatabaseLayer.Model.StavkaRacuna", b =>
                {
                    b.HasOne("DatabaseLayer.Model.Artikl", "Artikl")
                        .WithMany("StavkaRacuna")
                        .HasForeignKey("ArtiklId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DatabaseLayer.Model.Racun", "Racun")
                        .WithMany("StavkaRacuna")
                        .HasForeignKey("RacunId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DatabaseLayer.Model.Zaposlenik", b =>
                {
                    b.HasOne("DatabaseLayer.Model.Uloga", "Uloga")
                        .WithMany()
                        .HasForeignKey("UlogaId");
                });
#pragma warning restore 612, 618
        }
    }
}
