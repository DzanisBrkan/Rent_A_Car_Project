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
    [Authorize]
    public class KategorijaController : BaseController<Model.Kategorija, object>
    {
        public KategorijaController(IService<Kategorija, object> service) : base(service)
        {
        }
    }
}