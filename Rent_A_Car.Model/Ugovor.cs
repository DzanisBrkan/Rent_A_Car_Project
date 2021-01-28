using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public class Ugovor
    {
        //sad hoce li ovo radit ja nez
        public int RacunID { get; set; }
        public string DatumUgovora { get; set; }
        public string CijenaAutomobila { get; set; }
        public int UkupnaKolicina { get; set; }
        public int NacinPlacanjaId { get; set; }
        //public int Placen { get; set; } 
    }
}
