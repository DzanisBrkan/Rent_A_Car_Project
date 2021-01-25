﻿using AutoMapper;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class OcjenaServices
     : BaseCRUDService<Model.Ocjena, OcjenaSearchRequest, Database.Ocjena, OcjenaUpsertRequest, OcjenaUpsertRequest>
    {
        public OcjenaServices(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Ocjena> Get(OcjenaSearchRequest search)
        {
            var query = _context.Set<Ocjena>().AsQueryable();
            if (search?.Ocjena1.HasValue == true)
            {
                query = query.Where(x => x.Ocjena1 == search.Ocjena1);
            }
            query = query.OrderBy(x => x.Ocjena1);
            var list = query.ToList();

            return _mapper.Map<List<Model.Ocjena>>(list);
        }
    }
}
