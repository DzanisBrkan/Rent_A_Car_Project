using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Ocjena
    {
        public int OcjenaId { get; set; }
        public int Ocjena1 { get; set; }
        public string Komentar { get; set; }
        public int? RezervacijaId { get; set; }
        public int? VoziloId { get; set; }
        public int KlijentId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Rezervacija Rezervacija { get; set; }
        public virtual Vozilo Vozilo { get; set; }
    }
}
