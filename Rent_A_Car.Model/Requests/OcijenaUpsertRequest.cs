﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class OcijenaUpsertRequest
    {
        public int? Ocjena1 { get; set; }
        public string Komentar { get; set; }
        public int? RezervacijaId { get; set; }
    }
}
