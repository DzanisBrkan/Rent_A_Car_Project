using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Popust
    {
        public Popust()
        {
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public int PopustId { get; set; }
        public string NazivPopusta { get; set; }
        public string Kod { get; set; }
        public DateTime? DatumIsteka { get; set; }
        public int? Postotak { get; set; }

        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
