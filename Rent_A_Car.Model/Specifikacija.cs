using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class Specifikacija
    {
        public int SpecifikacijaId { get; set; }
        public string Gorivo { get; set; }
        public string EuroNorma { get; set; }
        public string Kubikaza { get; set; }
        public string Konjaza { get; set; }
        public string Kilowataza { get; set; }
        public string Pogon { get; set; }
        public string Potrosnja { get; set; }
        public string Godiste { get; set; }
        public string Mjenjac { get; set; }
    }
}
