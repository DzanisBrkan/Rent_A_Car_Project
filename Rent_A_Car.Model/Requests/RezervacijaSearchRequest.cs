using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class RezervacijaSearchRequest
    {
        public int? RezervacijaId { get; set; }

        public int? KlijentId { get; set; }
        public string Status { get; set; }
    }
}
