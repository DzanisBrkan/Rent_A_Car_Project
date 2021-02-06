using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class Rezervacija
    {
        public int RezervacijaID { get; set; }

        //public string VrijemePocetka { get; set; } 
        //public string VrijemeRezervacije { get; set; }
        //public int Kolicina { get; set; }
        public string Status { get; set; }
        public double UkupnaCijena { get; set; }
        public int LokacijaId { get; set; }
        public int OsiguranjeId { get; set; }
        public int KlijentId { get; set; }
        public int VoziloId { get; set; }
        public int PopustId { get; set; }
        public int RacunId { get; set; }
        public DateTime? PocetakRezervacije { get; set; }
        public DateTime? KrajRezervacije { get; set; }
        public string Naziv { get; set; }

    }
}
