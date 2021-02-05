using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class UgovorUpsertRequest
    {
        //[Required(AllowEmptyStrings = false)]
        public int RacunId { get; set; }
        public double? UkupnaCijena { get; set; }
        public int? NacinPlacanjaId { get; set; }
        public DateTime? DatumPlacanja { get; set; }
        public int? RezervacijaId { get; set; }
        public double? UkupanBrojDana { get; set; }
        public bool? Izdano { get; set; }
    }
}
