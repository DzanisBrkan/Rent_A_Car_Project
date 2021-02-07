using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Services;
using static Rent_A_Car.WebAPI.RecommendationSystem.Recommander;

namespace Rent_A_Car.WebAPI.Controllers
{
    public class VoziloController
        : BaseCRUDController<Model.Vozilo, VoziloSearchRequest, VoziloUpsertRequest, VoziloUpsertRequest>
    {
        private readonly IVoziloService _service;
        public VoziloController(ICRUDService<Vozilo, VoziloSearchRequest, VoziloUpsertRequest, VoziloUpsertRequest> service, IVoziloService voziloService) : base(service)
        {
            _service = voziloService;
        }

   

        [HttpPut("UpdateStatus/{id}")]
        public Model.Vozilo UpdateStatus(int id, VoziloStatusRequest request)
        {
            return _service.UpdateStatus(id, request);
        }

        // GET: sistem preporuke
        [HttpGet("Preporuka/{id}")]
        public List<Model.Vozilo> Preporuka(int id)
        {
            return _service.Preporuka(id);
        }

        [HttpDelete]
        public Model.Vozilo Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}