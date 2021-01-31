using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Osiguranje
    {
        public Osiguranje()
        {
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public int OsiguranjeId { get; set; }
        public string BrojOsiguranja { get; set; }
        public string NazivOsiguranja { get; set; }

        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
