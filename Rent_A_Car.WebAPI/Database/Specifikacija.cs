using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Specifikacija
    {
        public Specifikacija()
        {
            Vozilos = new HashSet<Vozilo>();
        }

        public int SpecifikacijaId { get; set; }
        public string Gorivo { get; set; }
        public string EuroNorma { get; set; }
        public string Kubikaza { get; set; }
        public string Konjaza { get; set; }
        public string Kilowataza { get; set; }
        public string Pogon { get; set; }
        public string Potrosnja { get; set; }
        public string Godiste { get; set; }
        public string Mjenjac { get; set; }

        public virtual ICollection<Vozilo> Vozilos { get; set; }
    }
}
