using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Services;

namespace Rent_A_Car.WebAPI.Controllers
{
    public class SpecifikacijaController
    : BaseCRUDController<Model.Specifikacija, SpecifikacijaSearchRequest, SpecifikacijaUpsertRequest, SpecifikacijaUpsertRequest>
    {
        public SpecifikacijaController(ICRUDService<Specifikacija, SpecifikacijaSearchRequest, SpecifikacijaUpsertRequest, SpecifikacijaUpsertRequest> service) : base(service)
        {
        }
    }
}