﻿using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public interface IKlijentService
    {
        List<Model.Klijent> Get(KlijentSearchRequest request);

        Model.Klijent GetById(int id);

        Model.Klijent Insert(KlijentInsertRequest request);

        Model.Klijent Registracija(KlijentInsertRequest request);


        Model.Klijent Update(int id, KlijentUpdateRequest request);

        Model.Klijent Authenticiraj(string username, string pass);

    }
}
