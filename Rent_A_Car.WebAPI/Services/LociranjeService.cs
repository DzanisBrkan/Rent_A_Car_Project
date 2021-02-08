using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class LociranjeService
        : BaseCRUDService<Model.Lociranje, LociranjeSearchRequest, LociranjeUpsertRequest, LociranjeUpsertRequest, Database.Lociranje>
    {
        public LociranjeService(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Lociranje> Get(LociranjeSearchRequest search = null)
        {
            var query = _context.Set<Database.Lociranje>().AsQueryable();

            query = query.Include(x => x.Klijent).Include(x => x.Zaposlenik);

            var list = query.ToList();

            return _mapper.Map<List<Model.Lociranje>>(list);
        }
    }
}
