using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class UgovorUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public DateTime? DatumUgovora { get; set; }
        public string CijenaAutomobila { get; set; }
        public string UkupnaKolicina { get; set; }
        public string NacinPlacanjaId { get; set; }
        public string VoziloID { get; set; }
        //public string Placen { get; set; }
    }
}
