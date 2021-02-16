using AutoMapper;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class SpecifikacijaServices
        : BaseCRUDService<Model.Specifikacija, SpecifikacijaSearchRequest, Database.Specifikacija, SpecifikacijaUpsertRequest, SpecifikacijaUpsertRequest>

    {
        public SpecifikacijaServices(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
