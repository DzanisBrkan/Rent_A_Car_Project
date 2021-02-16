using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            DojmoviZahtjevis = new HashSet<DojmoviZahtjevi>();
            Lociranjes = new HashSet<Lociranje>();
            Ocjenas = new HashSet<Ocjena>();
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTel { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string DatumRodjenja { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] SlikaThumb { get; set; }

        public virtual ICollection<DojmoviZahtjevi> DojmoviZahtjevis { get; set; }
        public virtual ICollection<Lociranje> Lociranjes { get; set; }
        public virtual ICollection<Ocjena> Ocjenas { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
