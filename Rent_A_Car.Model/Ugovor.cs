using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public class Ugovor
    {
        //sad hoce li ovo radit ja nez
        public int RacunId { get; set; }
        public double? UkupnaCijena { get; set; }
        public int? NacinPlacanjaId { get; set; }
        public DateTime? DatumPlacanja { get; set; }
        public int? RezervacijaId { get; set; }
        public double? UkupanBrojDana { get; set; }
        public bool? Izdano { get; set; }
        //public int Placen { get; set; } 
        public virtual NacinPlacanja NacinPlacanja { get; set; }
    }
}
