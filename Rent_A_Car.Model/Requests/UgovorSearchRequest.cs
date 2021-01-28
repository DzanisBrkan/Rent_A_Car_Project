using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class UgovorSearchRequest
    {
        public int? RacunId { get; set; }
        public string CijenaAutomobila { get; set; }
    }
}
