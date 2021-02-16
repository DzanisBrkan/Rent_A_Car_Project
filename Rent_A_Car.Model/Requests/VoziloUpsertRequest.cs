using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rent_A_Car.Model.Requests
{
    //insert and update
    public class VoziloUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string RegistracijskiBroj { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string BrSjedista { get; set; }
        public string BrVrata { get; set; }
        public string ZapreminaPrtljaznika { get; set; }

        [Range(0, double.MaxValue)]
        public double? CijenaPoSatu { get; set; }
        [Required(AllowEmptyStrings = false)]
        public bool Zauzeto { get; set; }

        public int? KategorijaId { get; set; }
        public int? SpecifikacijaId { get; set; }
        public int? LokacijaId { get; set; }
        public int? TipId { get; set; }
        [Required(AllowEmptyStrings = true)]
        public byte[] SlikaThumb { get; set; }
        public double? Langitude { get; set; }
        public double? Longitude { get; set; }

    }
}
