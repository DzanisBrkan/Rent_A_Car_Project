using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Greska
    {
        public int GreskaId { get; set; }
        public string Greska1 { get; set; }
        public DateTime? VrijemeGreske { get; set; }
    }
}
