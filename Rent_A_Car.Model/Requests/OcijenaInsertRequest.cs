using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class OcijenaInsertRequest
    {
        //[Required(AllowEmptyStrings = false)]
        public string Ocjena { get; set; }

        //[Required(AllowEmptyStrings = false)]
        public string Komentar { get; set; }
        public int? RezevacijaId { get; set; }
    }
}
