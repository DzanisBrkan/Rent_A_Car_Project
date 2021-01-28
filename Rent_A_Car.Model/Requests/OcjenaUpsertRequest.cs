using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class OcjenaUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public int? Ocjena1 { get; set; }
        public string Komentar { get; set; }
        public int? RezervacijaId { get; set; }

        //public virtual Rezervacija Rezervacija { get; set; }
    }
}
