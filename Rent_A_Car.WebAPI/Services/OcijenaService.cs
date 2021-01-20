using AutoMapper;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class OcijenaService
        : BaseCRUDService<Model.Ocjena, OcijenaSearchRequest, Database.Ocjena, OcijenaUpsertRequest, OcijenaUpsertRequest>

    {
        public OcijenaService(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {
        }




        //public override List<Model.Ocjena> Get(OcijenaSearchRequest search)
        //{
        //    var query = _context.Set<Ocjena>().AsQueryable();
        //    if (search?.OcijenaId.HasValue == true)
        //    {
        //        query = query.Where(x => x.OcjenaId == search.OcijenaId);
        //    }
        //    query = query.OrderBy(x => x.OcjenaId);
        //    var list = query.ToList();

        //    return _mapper.Map<List<Model.Ocjena>>(list);
        //}
    }
}
