using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class VoziloSearchRequest
    {
        public int? VoziloId { get; set; }

        public int? KategorijaId { get; set; }
        public int? TipId { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
    }
}
