using AutoMapper;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class VoziloService 
        : BaseCRUDService<Model.Vozilo, VoziloSearchRequest, Database.Vozilo, VoziloUpsertRequest, VoziloUpsertRequest>
    {
        public VoziloService(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Vozilo> Get(VoziloSearchRequest search)
        {
            var query = _context.Set<Vozilo>().AsQueryable();
            if(search?.KategorijaId.HasValue == true)
            {
                query = query.Where(x => x.KategorijaId == search.KategorijaId);
            }
            query = query.OrderBy(x => x.Kategorija);
            var list = query.ToList();

            return _mapper.Map<List<Model.Vozilo>>(list);
        }
    }
}
