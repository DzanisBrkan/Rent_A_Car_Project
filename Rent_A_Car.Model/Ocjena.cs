using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class Ocjena
    {
        public int OcjenaId { get; set; }
        public int? Ocjena1 { get; set; }
        public string Komentar { get; set; }
        public string Zahtjev { get; set; }
        public string Dojam { get; set; }
        public int? RezervacijaId { get; set; }
    }
}
