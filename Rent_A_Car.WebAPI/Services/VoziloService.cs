using AutoMapper;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Rent_A_Car.WebAPI.RecommendationSystem.Recommander;

namespace Rent_A_Car.WebAPI.Services
{
    public class VoziloService 
       : BaseCRUDService<Model.Vozilo, VoziloSearchRequest, Database.Vozilo, VoziloUpsertRequest, VoziloUpsertRequest>,
        IVoziloService
    {
        public VoziloService(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Vozilo> Get(VoziloSearchRequest search)
        {
            var query = _context.Set<Database.Vozilo>().AsQueryable();
            var list = query.ToList();

            if (search?.TipId is int)
            {
                if (search?.TipId.HasValue == true)
                {
                    query = query.Where(x => x.TipId == search.TipId);
                }
                query = query.OrderBy(x => x.Tip);
                list = query.ToList();

            }
            else if(!string.IsNullOrWhiteSpace(search?.Model))
            {
                query = query.Where(x => (x.Model.ToLower().Contains(search.Model.ToLower()) || x.Marka.ToLower().Contains(search.Marka.ToLower())));
                list = query.ToList();
            }
                return _mapper.Map<List<Model.Vozilo>>(list);
        }

        public List<Model.Vozilo> Preporuka(int id)
        {
            RecommenderSystem rc = new RecommenderSystem();

            List<Model.Vozilo> vozila = new List<Model.Vozilo>();
            List<int> p = rc.GetRecomended(id).Select(x => x.Key).ToList();
            foreach (var voziloId in p)
                if (!_context.Vozilo.Find(voziloId).Zauzeto==false)
                {
                    p.Remove(voziloId);
                }
                else
                {
                    var vozilo = _context.Vozilo.Find(voziloId);
                    vozila.Add(_mapper.Map<Model.Vozilo>(vozilo));
                }

            return vozila;
        }

        public Model.Vozilo UpdateStatus(int id, VoziloStatusRequest request)
        {
            var entity = _context.Vozilo.Find(id);
            _context.Vozilo.Attach(entity);
            _context.Vozilo.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Vozilo>(entity);
        }


        public Model.Vozilo Delete(int id)
        {
            var entity = _context.Vozilo.Find(id);
            if (entity == null)
            {
                throw new Exception("Vozilo ne postoji u bazi!!!");
            }
            _context.Vozilo.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Vozilo>(entity);
        }
    }
}
