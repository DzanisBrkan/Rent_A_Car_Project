using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class Racun
    {
        public int RacunId { get; set; }
        public DateTime? Datum { get; set; }
        public double? UkupnaCijena { get; set; }
        public int? UkupnaKolicina { get; set; }
        public int? NacinPlacanjaId { get; set; }
        public bool Placen { get; set; }
    }
}
