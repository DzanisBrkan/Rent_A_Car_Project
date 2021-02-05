using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.Model;
using Rent_A_Car.WebAPI.Services;

namespace Rent_A_Car.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervacijaController 
        : BaseCRUDController<Rezervacija, RezervacijaSearchRequest, RezervacijaUpsertRequest, RezervacijaUpsertRequest>
    {
        private readonly IRezervacijaServicecs _service;
        public RezervacijaController(Services.ICRUDService<Rezervacija, RezervacijaSearchRequest, RezervacijaUpsertRequest, RezervacijaUpsertRequest> service, IRezervacijaServicecs rez_service) : base(service)
        {
            _service = rez_service;
        }

        [HttpGet("GetRezByUserID/{id}")]
        public Model.Rezervacija GetRezervacijaByUserID(int id)
        {
            return _service.GetRezervacijaByUserID(id);
        }

        [HttpPut("UpdateStatus/{id}")]
        public Model.Rezervacija UpdateStatus(int id, RezervacijaStatusRequest request)
        {
            return _service.UpdateStatus(id, request);
        }

    }
}