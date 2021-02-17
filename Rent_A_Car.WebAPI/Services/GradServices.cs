using AutoMapper;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class GradServices
        : BaseCRUDService<Model.Grad, GradSearchRequest, Database.Grad, GradUpsertRequest, GradUpsertRequest>

    {
        public GradServices(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Grad> Get(GradSearchRequest search)
        {
            var query = _context.Set<Grad>().AsQueryable();
            if (!string.IsNullOrEmpty(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv.ToLower()));
            }
            query = query.OrderBy(x => x.Naziv);
            var list = query.ToList();

            return _mapper.Map<List<Model.Grad>>(list);
        }

    }
}
