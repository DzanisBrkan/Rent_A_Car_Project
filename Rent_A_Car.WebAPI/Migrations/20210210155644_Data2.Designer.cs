﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rent_A_Car.WebAPI.Database;

namespace Rent_A_Car.WebAPI.Migrations
{
    [DbContext(typeof(Rent_A_CarContext))]
    [Migration("20210210155644_Data2")]
    partial class Data2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.DojmoviZahtjevi", b =>
                {
                    b.Property<int>("DojmoviZahtjeviId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DojmoviZahtjeviID")
                        .UseIdentityColumn();

                    b.Property<string>("Dojam")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("KlijentId")
                        .HasColumnType("int")
                        .HasColumnName("KlijentID");

                    b.Property<string>("KlijentKorisnickoIme")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<byte[]>("KlijentSlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NazivZahtjeva")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<int?>("RezervacijaId")
                        .HasColumnType("int")
                        .HasColumnName("RezervacijaID");

                    b.HasKey("DojmoviZahtjeviId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("DojmoviZahtjevi");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DrzavaID")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Oznaka")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzava");

                    b.HasData(
                        new
                        {
                            DrzavaId = 100,
                            Naziv = "Bosna i Hercegovina",
                            Oznaka = "BiH"
                        });
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GradID")
                        .UseIdentityColumn();

                    b.Property<int?>("DrzavaId")
                        .HasColumnType("int")
                        .HasColumnName("DrzavaID");

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PostanskiBr")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)");

                    b.HasKey("GradId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Grad");

                    b.HasData(
                        new
                        {
                            GradId = 100,
                            DrzavaId = 100,
                            Naziv = "Mostar",
                            PostanskiBr = "88000"
                        },
                        new
                        {
                            GradId = 101,
                            DrzavaId = 100,
                            Naziv = "Sarajevo",
                            PostanskiBr = "72000"
                        });
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Greska", b =>
                {
                    b.Property<int>("GreskaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GreskaID")
                        .UseIdentityColumn();

                    b.Property<string>("Greska1")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Greska");

                    b.Property<DateTime?>("VrijemeGreske")
                        .HasColumnType("datetime");

                    b.HasKey("GreskaId");

                    b.ToTable("Greska");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Kategorija", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KategorijaID")
                        .UseIdentityColumn();

                    b.Property<string>("MinDob")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Naziv")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Opis")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Oznaka")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Klijent", b =>
                {
                    b.Property<int>("KlijentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KlijentID")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("BrojTel")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("DatumRodjenja")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Datum_rodjenja");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<int?>("GradId")
                        .HasColumnType("int")
                        .HasColumnName("GradID");

                    b.Property<string>("Ime")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Prezime")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("KlijentId");

                    b.HasIndex("GradId");

                    b.ToTable("Klijent");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.KorisnickiNalog", b =>
                {
                    b.Property<int>("KorisnickiNalogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KorisnickiNalogID")
                        .UseIdentityColumn();

                    b.Property<string>("TipKorisnickogNaloga")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("KorisnickiNalogId");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Lociranje", b =>
                {
                    b.Property<int>("LociranjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("KlijentId")
                        .HasColumnType("int");

                    b.Property<string>("Lat")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Lng")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Odogovoreno")
                        .HasColumnType("bit");

                    b.Property<bool?>("Prihvaceno")
                        .HasColumnType("bit");

                    b.Property<int?>("VoziloId")
                        .HasColumnType("int");

                    b.Property<int?>("ZaposlenikId")
                        .HasColumnType("int");

                    b.HasKey("LociranjeId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("VoziloId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Lociranje");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Lokacija", b =>
                {
                    b.Property<int>("LokacijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LokacijaID")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)");

                    b.Property<int?>("GradId")
                        .HasColumnType("int")
                        .HasColumnName("GradID");

                    b.Property<string>("Naziv")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Ulica")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)");

                    b.HasKey("LokacijaId");

                    b.HasIndex("GradId");

                    b.ToTable("Lokacija");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.NacinPlacanja", b =>
                {
                    b.Property<int>("NacinPlacanjaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("NacinPlacanjaID")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("NacinPlacanjaId");

                    b.ToTable("NacinPlacanja");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Ocjena", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OcjenaID")
                        .UseIdentityColumn();

                    b.Property<int>("KlijentId")
                        .HasColumnType("int")
                        .HasColumnName("KlijentID");

                    b.Property<string>("Komentar")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Ocjena1")
                        .HasColumnType("int");

                    b.Property<int?>("RezervacijaId")
                        .HasColumnType("int")
                        .HasColumnName("RezervacijaID");

                    b.Property<int?>("VoziloId")
                        .HasColumnType("int")
                        .HasColumnName("VoziloID");

                    b.HasKey("OcjenaId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("RezervacijaId");

                    b.HasIndex("VoziloId");

                    b.ToTable("Ocjena");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Osiguranje", b =>
                {
                    b.Property<int>("OsiguranjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OsiguranjeID")
                        .UseIdentityColumn();

                    b.Property<string>("BrojOsiguranja")
                        .HasMaxLength(220)
                        .IsUnicode(false)
                        .HasColumnType("varchar(220)");

                    b.Property<string>("NazivOsiguranja")
                        .HasMaxLength(220)
                        .IsUnicode(false)
                        .HasColumnType("varchar(220)");

                    b.HasKey("OsiguranjeId");

                    b.ToTable("Osiguranje");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Popust", b =>
                {
                    b.Property<int>("PopustId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PopustID")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("DatumIsteka")
                        .HasColumnType("datetime");

                    b.Property<string>("Kod")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NazivPopusta")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)");

                    b.Property<int?>("Postotak")
                        .HasColumnType("int");

                    b.HasKey("PopustId");

                    b.ToTable("Popust");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Racun", b =>
                {
                    b.Property<int>("RacunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RacunID")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("DatumPlacanja")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Izdano")
                        .HasColumnType("bit");

                    b.Property<int?>("NacinPlacanjaId")
                        .HasColumnType("int")
                        .HasColumnName("NacinPlacanjaID");

                    b.Property<int?>("RezervacijaId")
                        .HasColumnType("int")
                        .HasColumnName("RezervacijaID");

                    b.Property<double?>("UkupanBrojDana")
                        .HasColumnType("float");

                    b.Property<double?>("UkupnaCijena")
                        .HasColumnType("float");

                    b.HasKey("RacunId");

                    b.HasIndex("NacinPlacanjaId");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("Racun");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RezervacijaID")
                        .UseIdentityColumn();

                    b.Property<int?>("KlijentId")
                        .HasColumnType("int")
                        .HasColumnName("KlijentID");

                    b.Property<DateTime?>("KrajRezervacije")
                        .HasColumnType("datetime");

                    b.Property<int?>("LokacijaId")
                        .HasColumnType("int")
                        .HasColumnName("LokacijaID");

                    b.Property<string>("Naziv")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("OsiguranjeId")
                        .HasColumnType("int")
                        .HasColumnName("OsiguranjeID");

                    b.Property<DateTime?>("PocetakRezervacije")
                        .HasColumnType("datetime");

                    b.Property<int?>("PopustId")
                        .HasColumnType("int")
                        .HasColumnName("PopustID");

                    b.Property<string>("Status")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<double?>("UkupnaCijena")
                        .HasColumnType("float");

                    b.Property<int?>("VoziloId")
                        .HasColumnType("int")
                        .HasColumnName("VoziloID");

                    b.HasKey("RezervacijaId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("LokacijaId");

                    b.HasIndex("OsiguranjeId");

                    b.HasIndex("PopustId");

                    b.HasIndex("VoziloId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Specifikacija", b =>
                {
                    b.Property<int>("SpecifikacijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SpecifikacijaID")
                        .UseIdentityColumn();

                    b.Property<string>("EuroNorma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Godiste")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Gorivo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Kilowataza")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Konjaza")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Kubikaza")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Mjenjac")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Pogon")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Potrosnja")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("SpecifikacijaId");

                    b.ToTable("Specifikacija");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Tip", b =>
                {
                    b.Property<int>("TipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipID")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("TipId");

                    b.ToTable("Tip");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Vozilo", b =>
                {
                    b.Property<int>("VoziloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VoziloID")
                        .UseIdentityColumn();

                    b.Property<string>("BrSjedista")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("BrVrata")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<double?>("CijenaPoSatu")
                        .HasColumnType("float");

                    b.Property<int?>("KategorijaId")
                        .HasColumnType("int")
                        .HasColumnName("KategorijaID");

                    b.Property<double?>("Langitude")
                        .HasColumnType("float");

                    b.Property<int?>("LokacijaId")
                        .HasColumnType("int")
                        .HasColumnName("LokacijaID");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Marka")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("RegistracijskiBroj")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("SpecifikacijaId")
                        .HasColumnType("int")
                        .HasColumnName("SpecifikacijaID");

                    b.Property<int?>("TipId")
                        .HasColumnType("int")
                        .HasColumnName("TipID");

                    b.Property<string>("ZapreminaPrtljaznika")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Zauzeto")
                        .HasColumnType("bit");

                    b.HasKey("VoziloId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("LokacijaId");

                    b.HasIndex("SpecifikacijaId");

                    b.HasIndex("TipId");

                    b.ToTable("Vozilo");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Zaposlenik", b =>
                {
                    b.Property<int>("ZaposlenikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ZaposlenikID")
                        .UseIdentityColumn();

                    b.Property<bool?>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("DatumRodjenja")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Datum_rodjenja");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("GradId")
                        .HasColumnType("int")
                        .HasColumnName("GradID");

                    b.Property<string>("Ime")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("KontaktBr")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)")
                        .HasColumnName("Kontakt_br");

                    b.Property<int?>("KorisnickiNalogId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnickiNalogID");

                    b.Property<string>("KorisnickoIme")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("LozinkaHash")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("LozinkaSalt")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Prezime")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Spol")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ZaposlenikId");

                    b.HasIndex("GradId");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("Zaposlenik");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.DojmoviZahtjevi", b =>
                {
                    b.HasOne("Rent_A_Car.WebAPI.Database.Klijent", "Klijent")
                        .WithMany("DojmoviZahtjevis")
                        .HasForeignKey("KlijentId")
                        .HasConstraintName("FK__DojmoviZa__Klije__02C769E9");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Rezervacija", "Rezervacija")
                        .WithMany("DojmoviZahtjevis")
                        .HasForeignKey("RezervacijaId")
                        .HasConstraintName("FK__DojmoviZa__Rezer__05A3D694");

                    b.Navigation("Klijent");

                    b.Navigation("Rezervacija");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Grad", b =>
                {
                    b.HasOne("Rent_A_Car.WebAPI.Database.Drzava", "Drzava")
                        .WithMany("Grads")
                        .HasForeignKey("DrzavaId")
                        .HasConstraintName("FK__Grad__DrzavaID__3E52440B");

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Klijent", b =>
                {
                    b.HasOne("Rent_A_Car.WebAPI.Database.Grad", "Grad")
                        .WithMany("Klijents")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK__Klijent__GradID__72C60C4A");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Lociranje", b =>
                {
                    b.HasOne("Rent_A_Car.WebAPI.Database.Klijent", "Klijent")
                        .WithMany("Lociranjes")
                        .HasForeignKey("KlijentId")
                        .HasConstraintName("FK__Lociranje__Klije__09746778");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Vozilo", "Vozilo")
                        .WithMany("Lociranjes")
                        .HasForeignKey("VoziloId")
                        .HasConstraintName("FK__Lociranje__Vozil__0880433F");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Zaposlenik", "Zaposlenik")
                        .WithMany("Lociranjes")
                        .HasForeignKey("ZaposlenikId")
                        .HasConstraintName("FK__Lociranje__Zapos__0A688BB1");

                    b.Navigation("Klijent");

                    b.Navigation("Vozilo");

                    b.Navigation("Zaposlenik");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Lokacija", b =>
                {
                    b.HasOne("Rent_A_Car.WebAPI.Database.Grad", "Grad")
                        .WithMany("Lokacijas")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK__Lokacija__GradID__4E88ABD4");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Ocjena", b =>
                {
                    b.HasOne("Rent_A_Car.WebAPI.Database.Klijent", "Klijent")
                        .WithMany("Ocjenas")
                        .HasForeignKey("KlijentId")
                        .HasConstraintName("FK__Ocjena__KlijentI__7FEAFD3E")
                        .IsRequired();

                    b.HasOne("Rent_A_Car.WebAPI.Database.Rezervacija", "Rezervacija")
                        .WithMany("Ocjenas")
                        .HasForeignKey("RezervacijaId")
                        .HasConstraintName("FK__Ocjena__Rezervac__7E02B4CC");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Vozilo", "Vozilo")
                        .WithMany("Ocjenas")
                        .HasForeignKey("VoziloId")
                        .HasConstraintName("FK__Ocjena__VoziloID__7EF6D905");

                    b.Navigation("Klijent");

                    b.Navigation("Rezervacija");

                    b.Navigation("Vozilo");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Racun", b =>
                {
                    b.HasOne("Rent_A_Car.WebAPI.Database.NacinPlacanja", "NacinPlacanja")
                        .WithMany("Racuns")
                        .HasForeignKey("NacinPlacanjaId")
                        .HasConstraintName("FK__Racun__NacinPlac__7A672E12");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Rezervacija", "Rezervacija")
                        .WithMany("Racuns")
                        .HasForeignKey("RezervacijaId")
                        .HasConstraintName("FK__Racun__Rezervaci__6166761E");

                    b.Navigation("NacinPlacanja");

                    b.Navigation("Rezervacija");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Rezervacija", b =>
                {
                    b.HasOne("Rent_A_Car.WebAPI.Database.Klijent", "Klijent")
                        .WithMany("Rezervacijas")
                        .HasForeignKey("KlijentId")
                        .HasConstraintName("FK__Rezervaci__Klije__7F2BE32F");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Lokacija", "Lokacija")
                        .WithMany("Rezervacijas")
                        .HasForeignKey("LokacijaId")
                        .HasConstraintName("FK__Rezervaci__Lokac__7D439ABD");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Osiguranje", "Osiguranje")
                        .WithMany("Rezervacijas")
                        .HasForeignKey("OsiguranjeId")
                        .HasConstraintName("FK__Rezervaci__Osigu__7E37BEF6");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Popust", "Popust")
                        .WithMany("Rezervacijas")
                        .HasForeignKey("PopustId")
                        .HasConstraintName("FK__Rezervaci__Popus__01142BA1");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Vozilo", "Vozilo")
                        .WithMany("Rezervacijas")
                        .HasForeignKey("VoziloId")
                        .HasConstraintName("FK__Rezervaci__Vozil__00200768");

                    b.Navigation("Klijent");

                    b.Navigation("Lokacija");

                    b.Navigation("Osiguranje");

                    b.Navigation("Popust");

                    b.Navigation("Vozilo");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Vozilo", b =>
                {
                    b.HasOne("Rent_A_Car.WebAPI.Database.Kategorija", "Kategorija")
                        .WithMany("Vozilos")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK__Vozilo__Kategori__5629CD9C");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Lokacija", "Lokacija")
                        .WithMany("Vozilos")
                        .HasForeignKey("LokacijaId")
                        .HasConstraintName("FK__Vozilo__Lokacija__5812160E");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Specifikacija", "Specifikacija")
                        .WithMany("Vozilos")
                        .HasForeignKey("SpecifikacijaId")
                        .HasConstraintName("FK__Vozilo__Specifik__571DF1D5");

                    b.HasOne("Rent_A_Car.WebAPI.Database.Tip", "Tip")
                        .WithMany("Vozilos")
                        .HasForeignKey("TipId")
                        .HasConstraintName("FK__Vozilo__TipID__160F4887");

                    b.Navigation("Kategorija");

                    b.Navigation("Lokacija");

                    b.Navigation("Specifikacija");

                    b.Navigation("Tip");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Zaposlenik", b =>
                {
                    b.HasOne("Rent_A_Car.WebAPI.Database.Grad", "Grad")
                        .WithMany("Zaposleniks")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK__Zaposleni__GradI__76969D2E");

                    b.HasOne("Rent_A_Car.WebAPI.Database.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany("Zaposleniks")
                        .HasForeignKey("KorisnickiNalogId")
                        .HasConstraintName("FK__Zaposleni__Koris__3C34F16F");

                    b.Navigation("Grad");

                    b.Navigation("KorisnickiNalog");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Drzava", b =>
                {
                    b.Navigation("Grads");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Grad", b =>
                {
                    b.Navigation("Klijents");

                    b.Navigation("Lokacijas");

                    b.Navigation("Zaposleniks");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Kategorija", b =>
                {
                    b.Navigation("Vozilos");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Klijent", b =>
                {
                    b.Navigation("DojmoviZahtjevis");

                    b.Navigation("Lociranjes");

                    b.Navigation("Ocjenas");

                    b.Navigation("Rezervacijas");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.KorisnickiNalog", b =>
                {
                    b.Navigation("Zaposleniks");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Lokacija", b =>
                {
                    b.Navigation("Rezervacijas");

                    b.Navigation("Vozilos");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.NacinPlacanja", b =>
                {
                    b.Navigation("Racuns");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Osiguranje", b =>
                {
                    b.Navigation("Rezervacijas");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Popust", b =>
                {
                    b.Navigation("Rezervacijas");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Rezervacija", b =>
                {
                    b.Navigation("DojmoviZahtjevis");

                    b.Navigation("Ocjenas");

                    b.Navigation("Racuns");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Specifikacija", b =>
                {
                    b.Navigation("Vozilos");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Tip", b =>
                {
                    b.Navigation("Vozilos");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Vozilo", b =>
                {
                    b.Navigation("Lociranjes");

                    b.Navigation("Ocjenas");

                    b.Navigation("Rezervacijas");
                });

            modelBuilder.Entity("Rent_A_Car.WebAPI.Database.Zaposlenik", b =>
                {
                    b.Navigation("Lociranjes");
                });
#pragma warning restore 612, 618
        }
    }
}
