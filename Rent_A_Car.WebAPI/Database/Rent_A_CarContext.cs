using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Rent_A_CarContext : DbContext
    {
        public Rent_A_CarContext()
        {
        }

        public Rent_A_CarContext(DbContextOptions<Rent_A_CarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DojmoviZahtjevi> DojmoviZahtjevi { get; set; }
        public virtual DbSet<Drzava> Drzava { get; set; }
        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<Greska> Greska { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }
        public virtual DbSet<Lociranje> Lociranje { get; set; }
        public virtual DbSet<Lokacija> Lokacija { get; set; }
        public virtual DbSet<NacinPlacanja> NacinPlacanja { get; set; }
        public virtual DbSet<Ocjena> Ocjena { get; set; }
        public virtual DbSet<Osiguranje> Osiguranje { get; set; }
        public virtual DbSet<Popust> Popust { get; set; }
        public virtual DbSet<Racun> Racun { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<Specifikacija> Specifikacija { get; set; }
        public virtual DbSet<Tip> Tip { get; set; }
        public virtual DbSet<Vozilo> Vozilo { get; set; }
        public virtual DbSet<Zaposlenik> Zaposlenik { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Rent_A_Car;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<DojmoviZahtjevi>(entity =>
            {
                entity.ToTable("DojmoviZahtjevi");

                entity.Property(e => e.DojmoviZahtjeviId).HasColumnName("DojmoviZahtjeviID");

                entity.Property(e => e.Dojam)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.KlijentKorisnickoIme)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NazivZahtjeva)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Odgovor).HasMaxLength(255);

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.ZaposlenikId).HasColumnName("ZaposlenikID");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.DojmoviZahtjevis)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__DojmoviZa__Klije__02C769E9");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.DojmoviZahtjevis)
                    .HasForeignKey(d => d.RezervacijaId)
                    .HasConstraintName("FK__DojmoviZa__Rezer__05A3D694");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.DojmoviZahtjevis)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .HasConstraintName("FK__DojmoviZa__Zapos__2CBDA3B5");
            });

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.ToTable("Drzava");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Oznaka)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostanskiBr)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grads)
                    .HasForeignKey(d => d.DrzavaId)
                    .HasConstraintName("FK__Grad__DrzavaID__3E52440B");
            });

            modelBuilder.Entity<Greska>(entity =>
            {
                entity.ToTable("Greska");

                entity.Property(e => e.GreskaId).HasColumnName("GreskaID");

                entity.Property(e => e.Greska1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Greska");

                entity.Property(e => e.VrijemeGreske).HasColumnType("datetime");
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.ToTable("Kategorija");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.MinDob)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Oznaka)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.ToTable("Klijent");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Adresa)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BrojTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DatumRodjenja)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Datum_rodjenja");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ime)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Prezime)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KorisnickiNalog>(entity =>
            {
                entity.ToTable("KorisnickiNalog");

                entity.Property(e => e.KorisnickiNalogId).HasColumnName("KorisnickiNalogID");

                entity.Property(e => e.TipKorisnickogNaloga)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lociranje>(entity =>
            {
                entity.ToTable("Lociranje");

                entity.Property(e => e.Lat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Lociranjes)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__Lociranje__Klije__09746778");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.Lociranjes)
                    .HasForeignKey(d => d.VoziloId)
                    .HasConstraintName("FK__Lociranje__Vozil__0880433F");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.Lociranjes)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .HasConstraintName("FK__Lociranje__Zapos__0A688BB1");
            });

            modelBuilder.Entity<Lokacija>(entity =>
            {
                entity.ToTable("Lokacija");

                entity.Property(e => e.LokacijaId).HasColumnName("LokacijaID");

                entity.Property(e => e.Adresa)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Ulica)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Lokacijas)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Lokacija__GradID__4E88ABD4");
            });

            modelBuilder.Entity<NacinPlacanja>(entity =>
            {
                entity.ToTable("NacinPlacanja");

                entity.Property(e => e.NacinPlacanjaId).HasColumnName("NacinPlacanjaID");

                entity.Property(e => e.Naziv).HasMaxLength(255);
            });

            modelBuilder.Entity<Ocjena>(entity =>
            {
                entity.ToTable("Ocjena");

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Komentar).HasMaxLength(255);

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Ocjenas)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ocjena__KlijentI__7FEAFD3E");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Ocjenas)
                    .HasForeignKey(d => d.RezervacijaId)
                    .HasConstraintName("FK__Ocjena__Rezervac__7E02B4CC");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.Ocjenas)
                    .HasForeignKey(d => d.VoziloId)
                    .HasConstraintName("FK__Ocjena__VoziloID__7EF6D905");
            });

            modelBuilder.Entity<Osiguranje>(entity =>
            {
                entity.ToTable("Osiguranje");

                entity.Property(e => e.OsiguranjeId).HasColumnName("OsiguranjeID");

                entity.Property(e => e.BrojOsiguranja)
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.NazivOsiguranja)
                    .HasMaxLength(220)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Popust>(entity =>
            {
                entity.ToTable("Popust");

                entity.Property(e => e.PopustId).HasColumnName("PopustID");

                entity.Property(e => e.DatumIsteka).HasColumnType("datetime");

                entity.Property(e => e.Kod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NazivPopusta)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Racun>(entity =>
            {
                entity.ToTable("Racun");

                entity.Property(e => e.RacunId).HasColumnName("RacunID");

                entity.Property(e => e.DatumPlacanja).HasColumnType("datetime");

                entity.Property(e => e.NacinPlacanjaId).HasColumnName("NacinPlacanjaID");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.HasOne(d => d.NacinPlacanja)
                    .WithMany(p => p.Racuns)
                    .HasForeignKey(d => d.NacinPlacanjaId)
                    .HasConstraintName("FK__Racun__NacinPlac__7A672E12");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Racuns)
                    .HasForeignKey(d => d.RezervacijaId)
                    .HasConstraintName("FK__Racun__Rezervaci__6166761E");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.ToTable("Rezervacija");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.KrajRezervacije).HasColumnType("datetime");

                entity.Property(e => e.LokacijaId).HasColumnName("LokacijaID");

                entity.Property(e => e.Naziv).HasMaxLength(250);

                entity.Property(e => e.OsiguranjeId).HasColumnName("OsiguranjeID");

                entity.Property(e => e.PocetakRezervacije).HasColumnType("datetime");

                entity.Property(e => e.PopustId).HasColumnName("PopustID");

                entity.Property(e => e.Status).HasMaxLength(55);

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__Rezervaci__Klije__7F2BE32F");

                entity.HasOne(d => d.Lokacija)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.LokacijaId)
                    .HasConstraintName("FK__Rezervaci__Lokac__7D439ABD");

                entity.HasOne(d => d.Osiguranje)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.OsiguranjeId)
                    .HasConstraintName("FK__Rezervaci__Osigu__7E37BEF6");

                entity.HasOne(d => d.Popust)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.PopustId)
                    .HasConstraintName("FK__Rezervaci__Popus__01142BA1");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.VoziloId)
                    .HasConstraintName("FK__Rezervaci__Vozil__00200768");
            });

            modelBuilder.Entity<Specifikacija>(entity =>
            {
                entity.ToTable("Specifikacija");

                entity.Property(e => e.SpecifikacijaId).HasColumnName("SpecifikacijaID");

                entity.Property(e => e.EuroNorma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Godiste)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gorivo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kilowataza)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Konjaza)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Kubikaza)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mjenjac)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pogon)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Potrosnja)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tip>(entity =>
            {
                entity.ToTable("Tip");

                entity.Property(e => e.TipId).HasColumnName("TipID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vozilo>(entity =>
            {
                entity.ToTable("Vozilo");

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.Property(e => e.BrSjedista)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrVrata)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.LokacijaId).HasColumnName("LokacijaID");

                entity.Property(e => e.Marka)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistracijskiBroj)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SpecifikacijaId).HasColumnName("SpecifikacijaID");

                entity.Property(e => e.TipId).HasColumnName("TipID");

                entity.Property(e => e.ZapreminaPrtljaznika)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Vozilos)
                    .HasForeignKey(d => d.KategorijaId)
                    .HasConstraintName("FK__Vozilo__Kategori__5629CD9C");

                entity.HasOne(d => d.Lokacija)
                    .WithMany(p => p.Vozilos)
                    .HasForeignKey(d => d.LokacijaId)
                    .HasConstraintName("FK__Vozilo__Lokacija__5812160E");

                entity.HasOne(d => d.Specifikacija)
                    .WithMany(p => p.Vozilos)
                    .HasForeignKey(d => d.SpecifikacijaId)
                    .HasConstraintName("FK__Vozilo__Specifik__571DF1D5");

                entity.HasOne(d => d.Tip)
                    .WithMany(p => p.Vozilos)
                    .HasForeignKey(d => d.TipId)
                    .HasConstraintName("FK__Vozilo__TipID__160F4887");
            });

            modelBuilder.Entity<Zaposlenik>(entity =>
            {
                entity.ToTable("Zaposlenik");

                entity.Property(e => e.ZaposlenikId).HasColumnName("ZaposlenikID");

                entity.Property(e => e.DatumRodjenja)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Datum_rodjenja");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime).HasMaxLength(60);

                entity.Property(e => e.KontaktBr)
                    .HasMaxLength(16)
                    .HasColumnName("Kontakt_br");

                entity.Property(e => e.KorisnickiNalogId).HasColumnName("KorisnickiNalogID");

                entity.Property(e => e.KorisnickoIme)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LozinkaHash)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LozinkaSalt)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Prezime).HasMaxLength(60);

                entity.Property(e => e.Spol).HasMaxLength(10);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Zaposleniks)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Zaposleni__GradI__76969D2E");

                entity.HasOne(d => d.KorisnickiNalog)
                    .WithMany(p => p.Zaposleniks)
                    .HasForeignKey(d => d.KorisnickiNalogId)
                    .HasConstraintName("FK__Zaposleni__Koris__3C34F16F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
