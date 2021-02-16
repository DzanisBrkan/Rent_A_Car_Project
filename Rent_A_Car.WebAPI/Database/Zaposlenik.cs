using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Zaposlenik
    {
        public Zaposlenik()
        {
            DojmoviZahtjevis = new HashSet<DojmoviZahtjevi>();
            Lociranjes = new HashSet<Lociranje>();
        }

        public int ZaposlenikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KontaktBr { get; set; }
        public string DatumRodjenja { get; set; }
        public string Spol { get; set; }
        public int? GradId { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string KorisnickoIme { get; set; }
        public int? KorisnickiNalogId { get; set; }
        public bool? Aktivan { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual KorisnickiNalog KorisnickiNalog { get; set; }
        public virtual ICollection<DojmoviZahtjevi> DojmoviZahtjevis { get; set; }
        public virtual ICollection<Lociranje> Lociranjes { get; set; }
    }
}
