using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class DojmoviZahtjevi
    {
        public int DojmoviZahtjeviId { get; set; }
        public int? KlijentId { get; set; }
        public string KlijentKorisnickoIme { get; set; }
        public byte[] KlijentSlikaThumb { get; set; }
        public string NazivZahtjeva { get; set; }
        public string Dojam { get; set; }
        public int? RezervacijaId { get; set; }
        public string Odgovor { get; set; }
        public int? ZaposlenikId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Rezervacija Rezervacija { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}
