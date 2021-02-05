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
    [Route("api/[controller]")]
    [ApiController]
    public class UgovorController
        : BaseCRUDController<Model.Ugovor, UgovorSearchRequest, UgovorUpsertRequest, UgovorUpsertRequest>
    {
        private readonly IUgovorService _service;
        public UgovorController(ICRUDService<Ugovor, UgovorSearchRequest, UgovorUpsertRequest, UgovorUpsertRequest> service, IUgovorService rac_service) : base(service)
        {
            _service = rac_service;
        }

        [HttpGet("GetRacByRezID/{id}")]
        public Model.Ugovor GetRacunByRezervacijaID(int id)
        {
            return _service.GetRacunByRezervacijaID(id);
        }

        [HttpPut("UpdateStatus/{id}")]
        public Model.Ugovor UpdateStatus(int id, UgovorStatusRequest request)
        {
            return _service.UpdateStatus(id, request);
        }
    }
}