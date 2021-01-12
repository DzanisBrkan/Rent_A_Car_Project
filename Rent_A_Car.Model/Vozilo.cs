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
        public string Tip { get; set; }
        public string BrVrata { get; set; }
        public string ZapreminaPrtljaznika { get; set; }
        public string Oprema { get; set; }
        public float CijenaPoSatu { get; set; }
        public bool Zauzeto { get; set; }
    }
}
