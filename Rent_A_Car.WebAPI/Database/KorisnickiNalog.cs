using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class KorisnickiNalog
    {
        public KorisnickiNalog()
        {
            Klijents = new HashSet<Klijent>();
            Zaposleniks = new HashSet<Zaposlenik>();
        }

        public int KorisnickiNalogId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string TipKorisnickogNaloga { get; set; }

        public virtual ICollection<Klijent> Klijents { get; set; }
        public virtual ICollection<Zaposlenik> Zaposleniks { get; set; }
    }
}
