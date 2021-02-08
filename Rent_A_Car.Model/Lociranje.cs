using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public class Lociranje
    {
        public int LociranjeId { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public bool Prihvaceno { get; set; }
        public bool Odogovoreno { get; set; }
        public int? KlijentId { get; set; }
        public int? VoziloId { get; set; } // OVO NISAM IMO ??
        public int? ZaposlenikId { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
        public virtual Klijent Klijent { get; set; }
        public virtual Vozilo Vozilo { get; set; } // NISAM NI OVO ?
    }
}
