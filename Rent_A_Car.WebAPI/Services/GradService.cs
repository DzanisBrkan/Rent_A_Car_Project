using AutoMapper;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class GradService
        : BaseCRUDService<Model.Grad, GradSearchRequest, Database.Grad, GradUpsertRequest, GradUpsertRequest>,
        IGradService
    {
        public GradService(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {
        }


        public Model.Grad Delete(int id)
        {
            var entity = _context.Grad.Find(id);
            if (entity == null)
            {
                throw new Exception("Grad ne postoji u bazi!!!");
            }
             _context.Grad.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Grad>(entity);
        }
    }
}
