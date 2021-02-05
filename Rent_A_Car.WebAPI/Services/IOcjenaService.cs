using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public interface IOcjenaService
    {
        Model.Ocjena GetOcjenaByRezervacijaID(int id);
    }
}
