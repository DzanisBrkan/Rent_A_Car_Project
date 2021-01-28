using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public partial class Drzava
    {
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }

        public virtual ICollection<Grad> Grads { get; set; }

    }
}
