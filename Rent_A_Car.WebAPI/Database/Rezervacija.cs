﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Rezervacija
    {
        public Rezervacija()
        {
            Ocjenas = new HashSet<Ocjena>();
        }

        public int RezervacijaId { get; set; }
        public string VrijemePocetak { get; set; }
        public string VrijemeRezervacije { get; set; }
        public int? Kolicina { get; set; }
        public string Status { get; set; }
        public double? Cijena { get; set; }
        public int? LokacijaId { get; set; }
        public int? OsiguranjeId { get; set; }
        public int? KlijentId { get; set; }
        public int? VoziloId { get; set; }
        public int? PopustId { get; set; }
        public int? RacunId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Lokacija Lokacija { get; set; }
        public virtual Osiguranje Osiguranje { get; set; }
        public virtual Popust Popust { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual Vozilo Vozilo { get; set; }
        public virtual ICollection<Ocjena> Ocjenas { get; set; }
    }
}
