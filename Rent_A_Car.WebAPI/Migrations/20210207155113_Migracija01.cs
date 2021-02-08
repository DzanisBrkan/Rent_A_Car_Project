using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent_A_Car.WebAPI.Migrations
{
    public partial class Migracija01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Oznaka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Greska",
                columns: table => new
                {
                    GreskaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Greska = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    VrijemeGreske = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Greska", x => x.GreskaID);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    KategorijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oznaka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Naziv = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Opis = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MinDob = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.KategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "KorisnickiNalog",
                columns: table => new
                {
                    KorisnickiNalogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipKorisnickogNaloga = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiNalog", x => x.KorisnickiNalogID);
                });

            migrationBuilder.CreateTable(
                name: "NacinPlacanja",
                columns: table => new
                {
                    NacinPlacanjaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NacinPlacanja", x => x.NacinPlacanjaID);
                });

            migrationBuilder.CreateTable(
                name: "Osiguranje",
                columns: table => new
                {
                    OsiguranjeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojOsiguranja = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true),
                    NazivOsiguranja = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osiguranje", x => x.OsiguranjeID);
                });

            migrationBuilder.CreateTable(
                name: "Popust",
                columns: table => new
                {
                    PopustID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivPopusta = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    Kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DatumIsteka = table.Column<DateTime>(type: "datetime", nullable: true),
                    Postotak = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Popust", x => x.PopustID);
                });

            migrationBuilder.CreateTable(
                name: "Specifikacija",
                columns: table => new
                {
                    SpecifikacijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gorivo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EuroNorma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Kubikaza = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Konjaza = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Kilowataza = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Pogon = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Potrosnja = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Godiste = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Mjenjac = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifikacija", x => x.SpecifikacijaID);
                });

            migrationBuilder.CreateTable(
                name: "Tip",
                columns: table => new
                {
                    TipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tip", x => x.TipID);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PostanskiBr = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    DrzavaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradID);
                    table.ForeignKey(
                        name: "FK__Grad__DrzavaID__3E52440B",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Klijent",
                columns: table => new
                {
                    KlijentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Prezime = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    BrojTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Adresa = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Datum_rodjenja = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GradID = table.Column<int>(type: "int", nullable: true),
                    LozinkaHash = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    LozinkaSalt = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    KorisnickoIme = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    SlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijent", x => x.KlijentID);
                    table.ForeignKey(
                        name: "FK__Klijent__GradID__72C60C4A",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    LokacijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    Ulica = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    Adresa = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    GradID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.LokacijaID);
                    table.ForeignKey(
                        name: "FK__Lokacija__GradID__4E88ABD4",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenik",
                columns: table => new
                {
                    ZaposlenikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Kontakt_br = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Datum_rodjenja = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Spol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GradID = table.Column<int>(type: "int", nullable: true),
                    LozinkaHash = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    LozinkaSalt = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    KorisnickoIme = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    KorisnickiNalogID = table.Column<int>(type: "int", nullable: true),
                    Aktivan = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenik", x => x.ZaposlenikID);
                    table.ForeignKey(
                        name: "FK__Zaposleni__GradI__76969D2E",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Zaposleni__Koris__3C34F16F",
                        column: x => x.KorisnickiNalogID,
                        principalTable: "KorisnickiNalog",
                        principalColumn: "KorisnickiNalogID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    VoziloID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistracijskiBroj = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Model = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Marka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BrSjedista = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BrVrata = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ZapreminaPrtljaznika = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CijenaPoSatu = table.Column<double>(type: "float", nullable: true),
                    Zauzeto = table.Column<bool>(type: "bit", nullable: false),
                    KategorijaID = table.Column<int>(type: "int", nullable: true),
                    SpecifikacijaID = table.Column<int>(type: "int", nullable: true),
                    LokacijaID = table.Column<int>(type: "int", nullable: true),
                    TipID = table.Column<int>(type: "int", nullable: true),
                    SlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.VoziloID);
                    table.ForeignKey(
                        name: "FK__Vozilo__Kategori__5629CD9C",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Vozilo__Lokacija__5812160E",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacija",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Vozilo__Specifik__571DF1D5",
                        column: x => x.SpecifikacijaID,
                        principalTable: "Specifikacija",
                        principalColumn: "SpecifikacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Vozilo__TipID__160F4887",
                        column: x => x.TipID,
                        principalTable: "Tip",
                        principalColumn: "TipID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DojmoviZahtjevi",
                columns: table => new
                {
                    DojmoviZahtjeviID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlijentID = table.Column<int>(type: "int", nullable: true),
                    VoziloID = table.Column<int>(type: "int", nullable: true),
                    KlijentKorisnickoIme = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    KlijentSlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NazivZahtjeva = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Dojam = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DojmoviZahtjevi", x => x.DojmoviZahtjeviID);
                    table.ForeignKey(
                        name: "FK__DojmoviZa__Klije__02C769E9",
                        column: x => x.KlijentID,
                        principalTable: "Klijent",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__DojmoviZa__Vozil__03BB8E22",
                        column: x => x.VoziloID,
                        principalTable: "Vozilo",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    UkupnaCijena = table.Column<double>(type: "float", nullable: true),
                    LokacijaID = table.Column<int>(type: "int", nullable: true),
                    OsiguranjeID = table.Column<int>(type: "int", nullable: true),
                    KlijentID = table.Column<int>(type: "int", nullable: true),
                    VoziloID = table.Column<int>(type: "int", nullable: true),
                    PopustID = table.Column<int>(type: "int", nullable: true),
                    PocetakRezervacije = table.Column<DateTime>(type: "datetime", nullable: true),
                    KrajRezervacije = table.Column<DateTime>(type: "datetime", nullable: true),
                    Naziv = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "FK__Rezervaci__Klije__7F2BE32F",
                        column: x => x.KlijentID,
                        principalTable: "Klijent",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Rezervaci__Lokac__7D439ABD",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacija",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Rezervaci__Osigu__7E37BEF6",
                        column: x => x.OsiguranjeID,
                        principalTable: "Osiguranje",
                        principalColumn: "OsiguranjeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Rezervaci__Popus__01142BA1",
                        column: x => x.PopustID,
                        principalTable: "Popust",
                        principalColumn: "PopustID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Rezervaci__Vozil__00200768",
                        column: x => x.VoziloID,
                        principalTable: "Vozilo",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ocjena",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena1 = table.Column<int>(type: "int", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RezervacijaID = table.Column<int>(type: "int", nullable: true),
                    VoziloID = table.Column<int>(type: "int", nullable: true),
                    KlijentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "FK__Ocjena__KlijentI__7FEAFD3E",
                        column: x => x.KlijentID,
                        principalTable: "Klijent",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Ocjena__Rezervac__7E02B4CC",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacija",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Ocjena__VoziloID__7EF6D905",
                        column: x => x.VoziloID,
                        principalTable: "Vozilo",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    RacunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UkupnaCijena = table.Column<double>(type: "float", nullable: true),
                    NacinPlacanjaID = table.Column<int>(type: "int", nullable: true),
                    DatumPlacanja = table.Column<DateTime>(type: "datetime", nullable: true),
                    RezervacijaID = table.Column<int>(type: "int", nullable: true),
                    UkupanBrojDana = table.Column<double>(type: "float", nullable: true),
                    Izdano = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.RacunID);
                    table.ForeignKey(
                        name: "FK__Racun__NacinPlac__7A672E12",
                        column: x => x.NacinPlacanjaID,
                        principalTable: "NacinPlacanja",
                        principalColumn: "NacinPlacanjaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Racun__Rezervaci__6166761E",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacija",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DojmoviZahtjevi_KlijentID",
                table: "DojmoviZahtjevi",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_DojmoviZahtjevi_VoziloID",
                table: "DojmoviZahtjevi",
                column: "VoziloID");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaID",
                table: "Grad",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Klijent_GradID",
                table: "Klijent",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Lokacija_GradID",
                table: "Lokacija",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_KlijentID",
                table: "Ocjena",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_RezervacijaID",
                table: "Ocjena",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_VoziloID",
                table: "Ocjena",
                column: "VoziloID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_NacinPlacanjaID",
                table: "Racun",
                column: "NacinPlacanjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_RezervacijaID",
                table: "Racun",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KlijentID",
                table: "Rezervacija",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_LokacijaID",
                table: "Rezervacija",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_OsiguranjeID",
                table: "Rezervacija",
                column: "OsiguranjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_PopustID",
                table: "Rezervacija",
                column: "PopustID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_VoziloID",
                table: "Rezervacija",
                column: "VoziloID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_KategorijaID",
                table: "Vozilo",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_LokacijaID",
                table: "Vozilo",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_SpecifikacijaID",
                table: "Vozilo",
                column: "SpecifikacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_TipID",
                table: "Vozilo",
                column: "TipID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_GradID",
                table: "Zaposlenik",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_KorisnickiNalogID",
                table: "Zaposlenik",
                column: "KorisnickiNalogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DojmoviZahtjevi");

            migrationBuilder.DropTable(
                name: "Greska");

            migrationBuilder.DropTable(
                name: "Ocjena");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "Zaposlenik");

            migrationBuilder.DropTable(
                name: "NacinPlacanja");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "KorisnickiNalog");

            migrationBuilder.DropTable(
                name: "Klijent");

            migrationBuilder.DropTable(
                name: "Osiguranje");

            migrationBuilder.DropTable(
                name: "Popust");

            migrationBuilder.DropTable(
                name: "Vozilo");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "Lokacija");

            migrationBuilder.DropTable(
                name: "Specifikacija");

            migrationBuilder.DropTable(
                name: "Tip");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
