using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Tip
    {
        public Tip()
        {
            Vozilos = new HashSet<Vozilo>();
        }

        public int TipId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Vozilo> Vozilos { get; set; }
    }
}
