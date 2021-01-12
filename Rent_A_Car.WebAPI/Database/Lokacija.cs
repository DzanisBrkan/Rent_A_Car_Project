using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Lokacija
    {
        public Lokacija()
        {
            Rezervacijas = new HashSet<Rezervacija>();
            Vozilos = new HashSet<Vozilo>();
        }

        public int LokacijaId { get; set; }
        public string Naziv { get; set; }
        public string Ulica { get; set; }
        public string Adresa { get; set; }
        public int? GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
        public virtual ICollection<Vozilo> Vozilos { get; set; }
    }
}
