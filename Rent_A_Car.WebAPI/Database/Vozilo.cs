using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Vozilo
    {
        public Vozilo()
        {
            Lociranjes = new HashSet<Lociranje>();
            Ocjenas = new HashSet<Ocjena>();
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public int VoziloId { get; set; }
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

        public virtual Kategorija Kategorija { get; set; }
        public virtual Lokacija Lokacija { get; set; }
        public virtual Specifikacija Specifikacija { get; set; }
        public virtual Tip Tip { get; set; }
        public virtual ICollection<Lociranje> Lociranjes { get; set; }
        public virtual ICollection<Ocjena> Ocjenas { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
