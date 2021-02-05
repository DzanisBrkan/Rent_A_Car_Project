using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class UgovorStatusRequest
    {
        public bool? Izdano { get; set; }
        public DateTime? DatumPlacanja { get; set; }
        public int? NacinPlacanjaId { get; set; }

    }
}
