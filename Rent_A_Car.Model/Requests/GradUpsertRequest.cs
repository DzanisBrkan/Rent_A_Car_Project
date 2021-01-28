using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class GradUpsertRequest
    {
        //kasnije dodati required parametre
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        public string PostanskiBr { get; set; }
        public int? DrzavaId { get; set; }
    }
}
