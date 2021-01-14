using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Model;
using Rent_A_Car.WebAPI.Services;

namespace Rent_A_Car.WebAPI.Controllers
{
    //Grad mora biti crud jer ce ih unositi i mijenjati admin
    [Authorize]
    public class GradController : BaseController<Model.Grad, object>
    {
        public GradController(IService<Grad, object> service) : base(service)
        {
        }
    }
}