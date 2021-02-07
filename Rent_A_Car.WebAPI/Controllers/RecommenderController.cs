using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Services;

namespace Rent_A_Car.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommenderController : ControllerBase
    {
        private readonly IRecommenderService _service;
        public RecommenderController(IRecommenderService service)
        {
            _service = service;
        }
        [HttpGet]
        public Model.RecommenderModel Get([FromQuery]UserRecommendationRequest request)
        {
            return _service.Get(request);
        }
    }
}