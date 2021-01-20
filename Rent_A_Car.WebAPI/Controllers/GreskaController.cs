using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Model;
using Rent_A_Car.WebAPI.Services;

namespace Rent_A_Car.WebAPI.Controllers
{
    //zamisljeno je da se samo podaci upisuju u tabelu greska (insert)
    public class GreskaController : BaseController<Model.Greska, object>
    {
        public GreskaController(IService<Greska, object> service) : base(service)
        {
        }
    }
}