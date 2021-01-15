using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class KorisnickiNalog
    {
        public int KorisnickiNalogId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string TipKorisnickogNaloga { get; set; }
    }
}
