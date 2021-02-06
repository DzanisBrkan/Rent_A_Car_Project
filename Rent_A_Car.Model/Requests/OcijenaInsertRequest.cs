using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    public class OcijenaInsertRequest
    {
        public int Ocjena1 { get; set; }
        public string Komentar { get; set; }
        public int? RezervacijaId { get; set; }
        public int? VoziloId { get; set; }
        public int KlijentId { get; set; }
    }
}
