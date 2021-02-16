using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Lokacijas = new HashSet<Lokacija>();
            Zaposleniks = new HashSet<Zaposlenik>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public string PostanskiBr { get; set; }
        public int? DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Lokacija> Lokacijas { get; set; }
        public virtual ICollection<Zaposlenik> Zaposleniks { get; set; }
    }
}
