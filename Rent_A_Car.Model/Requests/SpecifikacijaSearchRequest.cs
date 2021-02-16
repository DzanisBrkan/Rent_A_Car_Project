using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class SpecifikacijaSearchRequest
    {
        public int SpecifikacijaId { get; set; }
        public string EuroNorma { get; set; }
        public string Kubikaza { get; set; }
        public string Konjaza { get; set; }
    }
}
