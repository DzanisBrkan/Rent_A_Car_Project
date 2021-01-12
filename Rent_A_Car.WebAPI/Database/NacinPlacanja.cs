using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class NacinPlacanja
    {
        public NacinPlacanja()
        {
            Racuns = new HashSet<Racun>();
        }

        public int NacinPlacanjaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Racun> Racuns { get; set; }
    }
}
