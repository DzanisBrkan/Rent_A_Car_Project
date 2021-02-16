using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class DojmoviZahtjeviUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public int? KlijentId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string KlijentKorisnickoIme { get; set; }
        public byte[] KlijentSlikaThumb { get; set; }
        public string NazivZahtjeva { get; set; }
        public string Dojam { get; set; }
        public int? RezervacijaId { get; set; }
        public string Odgovor { get; set; }
        public int? ZaposlenikId { get; set; }
    }
}
