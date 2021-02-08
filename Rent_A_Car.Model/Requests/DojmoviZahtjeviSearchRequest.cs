using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class DojmoviZahtjeviSearchRequest
    {
        public int DojmoviZahtjeviId { get; set; }
        public int? KlijentId { get; set; }
        public int? VoziloId { get; set; }
    }
}
