using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Rezervacija
    {
        public Rezervacija()
        {
            DojmoviZahtjevis = new HashSet<DojmoviZahtjevi>();
            Ocjenas = new HashSet<Ocjena>();
            Racuns = new HashSet<Racun>();
        }

        public int RezervacijaId { get; set; }
        public string Status { get; set; }
        public double? UkupnaCijena { get; set; }
        public int? LokacijaId { get; set; }
        public int? OsiguranjeId { get; set; }
        public int? KlijentId { get; set; }
        public int? VoziloId { get; set; }
        public int? PopustId { get; set; }
        public DateTime? PocetakRezervacije { get; set; }
        public DateTime? KrajRezervacije { get; set; }
        public string Naziv { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Lokacija Lokacija { get; set; }
        public virtual Osiguranje Osiguranje { get; set; }
        public virtual Popust Popust { get; set; }
        public virtual Vozilo Vozilo { get; set; }
        public virtual ICollection<DojmoviZahtjevi> DojmoviZahtjevis { get; set; }
        public virtual ICollection<Ocjena> Ocjenas { get; set; }
        public virtual ICollection<Racun> Racuns { get; set; }
    }
}
