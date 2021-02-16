using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
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
        public bool visible { get; set; }
    }
}
