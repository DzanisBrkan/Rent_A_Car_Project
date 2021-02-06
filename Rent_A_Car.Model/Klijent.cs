using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class Klijent
    {
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTel { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string DatumRodjenja { get; set; }
        public int? GradId { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] SlikaThumb { get; set; }

    }
}
