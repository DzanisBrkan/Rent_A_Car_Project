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
    public class OcjenaController
        : BaseCRUDController<Model.Ocjena, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest>
    {
        private readonly IOcjenaService _service;
        public OcjenaController(ICRUDService<Ocjena, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest> service, IOcjenaService ocj_service) : base(service)
        {
            _service = ocj_service;
        }

        [HttpGet("GetOcjByRezID/{id}")]
        public Model.Ocjena GetOcjenaByRezervacijaID(int id)
        {
            return _service.GetOcjenaByRezervacijaID(id);
        }
    }
}