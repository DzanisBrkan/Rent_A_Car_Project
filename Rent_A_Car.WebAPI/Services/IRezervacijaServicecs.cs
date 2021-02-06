using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public interface IRezervacijaServicecs
    {
        Model.Rezervacija GetRezervacijaByUserID(int id);

        Rezervacija UpdateStatus(int id, RezervacijaStatusRequest request);
    }
}
