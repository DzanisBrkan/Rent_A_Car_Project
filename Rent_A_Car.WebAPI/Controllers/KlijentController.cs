﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using Rent_A_Car.WebAPI.Services;

namespace Rent_A_Car.WebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KlijentController : ControllerBase
    {

        private readonly IKlijentService _service;
        public KlijentController(IKlijentService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Klijent>> Get([FromQuery]KlijentSearchRequest request)
        {
            return _service.Get(request); 
        }

        [HttpGet("{id}")]
        public Model.Klijent GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Klijent Insert(KlijentInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Klijent Update(int id, KlijentInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}