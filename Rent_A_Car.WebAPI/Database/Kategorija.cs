using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Vozilos = new HashSet<Vozilo>();
        }

        public int KategorijaId { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string MinDob { get; set; }

        public virtual ICollection<Vozilo> Vozilos { get; set; }
    }
}
