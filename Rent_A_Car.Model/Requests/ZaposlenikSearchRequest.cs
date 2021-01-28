using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class ZaposlenikSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string KorisnickoIme { get; set; }

    }
}
