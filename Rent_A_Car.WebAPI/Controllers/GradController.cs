
﻿using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Rent_A_Car.WebAPI.Controllers
{
    [Authorize]
    public class GradController
        : BaseCRUDController<Grad, GradSearchRequest, GradUpsertRequest, GradUpsertRequest>
    {
        private readonly IGradService _service;
        public GradController(ICRUDService<Grad, GradSearchRequest, GradUpsertRequest, GradUpsertRequest> service, IGradService gradService) : base(service)
        {
            _service = gradService;
        }

        [HttpDelete]
        public Model.Grad Delete(int id)
        {
            return _service.Delete(id);
        }


    }
}

