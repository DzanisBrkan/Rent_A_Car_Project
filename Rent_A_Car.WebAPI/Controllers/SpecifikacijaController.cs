﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Model;
using Rent_A_Car.WebAPI.Services;

namespace Rent_A_Car.WebAPI.Controllers
{
    public class SpecifikacijaController : BaseController<Model.Specifikacija, object>
    {
        public SpecifikacijaController(IService<Specifikacija, object> service) : base(service)
        {
        }
    }
}