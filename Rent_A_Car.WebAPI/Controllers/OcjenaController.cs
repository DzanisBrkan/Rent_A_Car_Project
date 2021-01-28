using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Services;

namespace Rent_A_Car.WebAPI.Controllers
{
    [Authorize(Roles = "Zaposlenik")]
    public class OcjenaController
        : BaseCRUDController<Model.Ocjena, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest>
    {
        public OcjenaController(ICRUDService<Ocjena, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest> service) : base(service)
        {
        }
    }
}