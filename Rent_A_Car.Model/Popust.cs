using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class Popust
    {
        public int PopustId { get; set; }
        public string NazivPopusta { get; set; }
        public string Kod { get; set; }
        public DateTime? DatumIsteka { get; set; }
        public int? Postotak { get; set; }
    }
}
