﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class RezervacijaUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        //public string VrijemePocetka { get; set; }
        //public string VrijemeRezervacije { get; set; }
        //public string Kolicina { get; set; }

        public string KrajRezervacije { get; set; }

        public string Status { get; set; }
        public string UkupnaCijena { get; set; }

        public int? LokacijaId { get; set; }
        public int? OsiguranjeId { get; set; }
        public int? KlijentId { get; set; }
        public int? VoziloId { get; set; }
        public int? PopustId { get; set; }
        public int? RacunId { get; set; }
    }
}