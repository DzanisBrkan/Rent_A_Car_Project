using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class Zaposlenik
    {
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

        public virtual KorisnickiNalog KorisnickiNalog { get; set; }

    }
}
