using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Controllers
{
    public class GradController : BaseController<Model.Grad, object>
    {
        public GradController(IService<Grad, object> service) : base(service)
        {
        }
    }
}
