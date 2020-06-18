using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dobavljaci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Oib = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljaci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KategorijeArtikla",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorijeArtikla", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artikli",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Kolicina = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    KategorijaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artikli_KategorijeArtikla_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "KategorijeArtikla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BrojZIroRacuna = table.Column<string>(nullable: true),
                    Aktivan = table.Column<bool>(nullable: false),
                    LozinkaHash = table.Column<string>(nullable: true),
                    UlogaId = table.Column<int>(nullable: true),
                    OIB = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zaposlenici_Uloge_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Narudzbenice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumIVrijemeIzdavanja = table.Column<DateTime>(nullable: false),
                    ZaposlenikId = table.Column<int>(nullable: true),
                    DobavljacId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzbenice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Narudzbenice_Dobavljaci_DobavljacId",
                        column: x => x.DobavljacId,
                        principalTable: "Dobavljaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Narudzbenice_Zaposlenici_ZaposlenikId",
                        column: x => x.ZaposlenikId,
                        principalTable: "Zaposlenici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Primke",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    Odgoda = table.Column<int>(nullable: false),
                    Napomena = table.Column<string>(nullable: true),
                    ZaposlenikId = table.Column<int>(nullable: true),
                    DobavljacId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Primke", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Primke_Dobavljaci_DobavljacId",
                        column: x => x.DobavljacId,
                        principalTable: "Dobavljaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Primke_Zaposlenici_ZaposlenikId",
                        column: x => x.ZaposlenikId,
                        principalTable: "Zaposlenici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Racuni",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumIVrijemeIzdavanja = table.Column<DateTime>(nullable: false),
                    ZaposlenikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racuni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racuni_Zaposlenici_ZaposlenikId",
                        column: x => x.ZaposlenikId,
                        principalTable: "Zaposlenici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkeNarudzbenice",
                columns: table => new
                {
                    NarudzbenicaId = table.Column<int>(nullable: false),
                    ArtiklId = table.Column<int>(nullable: false),
                    Kolicina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeNarudzbenice", x => new { x.NarudzbenicaId, x.ArtiklId });
                    table.ForeignKey(
                        name: "FK_StavkeNarudzbenice_Artikli_ArtiklId",
                        column: x => x.ArtiklId,
                        principalTable: "Artikli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeNarudzbenice_Narudzbenice_NarudzbenicaId",
                        column: x => x.NarudzbenicaId,
                        principalTable: "Narudzbenice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkePrimke",
                columns: table => new
                {
                    PrimkaId = table.Column<int>(nullable: false),
                    ArtiklId = table.Column<int>(nullable: false),
                    Kolicina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkePrimke", x => new { x.ArtiklId, x.PrimkaId });
                    table.ForeignKey(
                        name: "FK_StavkePrimke_Artikli_ArtiklId",
                        column: x => x.ArtiklId,
                        principalTable: "Artikli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkePrimke_Primke_PrimkaId",
                        column: x => x.PrimkaId,
                        principalTable: "Primke",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkeRacuna",
                columns: table => new
                {
                    RacunId = table.Column<int>(nullable: false),
                    ArtiklId = table.Column<int>(nullable: false),
                    Kolicina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeRacuna", x => new { x.ArtiklId, x.RacunId });
                    table.ForeignKey(
                        name: "FK_StavkeRacuna_Artikli_ArtiklId",
                        column: x => x.ArtiklId,
                        principalTable: "Artikli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeRacuna_Racuni_RacunId",
                        column: x => x.RacunId,
                        principalTable: "Racuni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_KategorijaId",
                table: "Artikli",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbenice_DobavljacId",
                table: "Narudzbenice",
                column: "DobavljacId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbenice_ZaposlenikId",
                table: "Narudzbenice",
                column: "ZaposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Primke_DobavljacId",
                table: "Primke",
                column: "DobavljacId");

            migrationBuilder.CreateIndex(
                name: "IX_Primke_ZaposlenikId",
                table: "Primke",
                column: "ZaposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Racuni_ZaposlenikId",
                table: "Racuni",
                column: "ZaposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeNarudzbenice_ArtiklId",
                table: "StavkeNarudzbenice",
                column: "ArtiklId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkePrimke_PrimkaId",
                table: "StavkePrimke",
                column: "PrimkaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeRacuna_RacunId",
                table: "StavkeRacuna",
                column: "RacunId");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenici_UlogaId",
                table: "Zaposlenici",
                column: "UlogaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StavkeNarudzbenice");

            migrationBuilder.DropTable(
                name: "StavkePrimke");

            migrationBuilder.DropTable(
                name: "StavkeRacuna");

            migrationBuilder.DropTable(
                name: "Narudzbenice");

            migrationBuilder.DropTable(
                name: "Primke");

            migrationBuilder.DropTable(
                name: "Artikli");

            migrationBuilder.DropTable(
                name: "Racuni");

            migrationBuilder.DropTable(
                name: "Dobavljaci");

            migrationBuilder.DropTable(
                name: "KategorijeArtikla");

            migrationBuilder.DropTable(
                name: "Zaposlenici");

            migrationBuilder.DropTable(
                name: "Uloge");
        }
    }
}
