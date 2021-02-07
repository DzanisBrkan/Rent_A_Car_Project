using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public interface IVoziloService
    {
        Vozilo UpdateStatus(int id, VoziloStatusRequest request);
        List<Model.Vozilo> Preporuka(int id);
        Model.Vozilo Delete(int id);
    }
}
