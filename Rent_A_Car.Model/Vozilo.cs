using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class Vozilo
    {
        public int VoziloID { get; set; }
        public string RegistracijskiBroj { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string BrSjedista { get; set; }
        public string BrVrata { get; set; }
        public string ZapreminaPrtljaznika { get; set; }
        public double? CijenaPoSatu { get; set; }
        public bool Zauzeto { get; set; }
        public int? KategorijaId { get; set; }
        public int? SpecifikacijaId { get; set; }
        public int? LokacijaId { get; set; }
        public int? TipId { get; set; }
        public byte[] SlikaThumb { get; set; }
        public double? Langitude { get; set; }

        public double? Longitude { get; set; }
        public float PositiveDifferent { get; set; } = 0;
        public string Color { get; set; }

    }
}
