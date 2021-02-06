using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Racun
    {
        public int RacunId { get; set; }
        public double? UkupnaCijena { get; set; }
        public int? NacinPlacanjaId { get; set; }
        public DateTime? DatumPlacanja { get; set; }
        public int? RezervacijaId { get; set; }
        public double? UkupanBrojDana { get; set; }
        public bool? Izdano { get; set; }

        public virtual NacinPlacanja NacinPlacanja { get; set; }
        public virtual Rezervacija Rezervacija { get; set; }
    }
}
