using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Racun
    {
        public Racun()
        {
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public int RacunId { get; set; }
        public DateTime? Datum { get; set; }
        public double? UkupnaCijena { get; set; }
        public int? UkupnaKolicina { get; set; }
        public int? NacinPlacanjaId { get; set; }
        public bool Placen { get; set; }

        public virtual NacinPlacanja NacinPlacanja { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
