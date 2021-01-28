using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class Lokacija
    {
        public int LokacijaId { get; set; }
        public string Naziv { get; set; }
        public string Ulica { get; set; }
        public string Adresa { get; set; }
        public int? GradId { get; set; }

        //public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
        public virtual ICollection<Vozilo> Vozilos { get; set; }
    }
}
