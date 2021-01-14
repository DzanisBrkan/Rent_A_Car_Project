using AutoMapper;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class ZaposlenikService
        : BaseCRUDService<Model.Zaposlenik, ZaposlenikSearchRequest, Database.Zaposlenik, ZaposlenikUpsertRequest, ZaposlenikUpsertRequest>
    {
        public ZaposlenikService(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Zaposlenik> Get(ZaposlenikSearchRequest search)
        {
            var query = _context.Set<Zaposlenik>().AsQueryable();
            if (search?.ZaposlenikId.HasValue == true)
            {
                query = query.Where(x => x.ZaposlenikId == search.ZaposlenikId);
            }
            query = query.OrderBy(x => x.ZaposlenikId);
            var list = query.ToList();

            return _mapper.Map<List<Model.Zaposlenik>>(list);
        }
    }
}
