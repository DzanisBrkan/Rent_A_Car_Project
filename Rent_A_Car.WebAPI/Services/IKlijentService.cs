using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public interface IKlijentService
    {
        //get
        List<Model.Klijent> Get(KlijentSearchRequest request);

        //get by id
        Model.Klijent GetById(int id);

        Model.Klijent Insert(KlijentInsertRequest request);

        Model.Klijent Update(int id, KlijentInsertRequest request);

    }
}
