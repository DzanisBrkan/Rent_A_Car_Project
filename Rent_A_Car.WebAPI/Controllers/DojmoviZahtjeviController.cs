using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Services;

namespace Rent_A_Car.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DojmoviZahtjeviController
        : BaseCRUDController<Model.DojmoviZahtjevi, DojmoviZahtjeviSearchRequest, DojmoviZahtjeviUpsertRequest, DojmoviZahtjeviUpsertRequest>
    {
        public DojmoviZahtjeviController(ICRUDService<DojmoviZahtjevi, DojmoviZahtjeviSearchRequest, DojmoviZahtjeviUpsertRequest, DojmoviZahtjeviUpsertRequest> service) : base(service)
        {
        }
    }
}