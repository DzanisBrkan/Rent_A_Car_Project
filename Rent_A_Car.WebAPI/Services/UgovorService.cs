using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using Rent_A_Car.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class UgovorService
        : BaseCRUDService<Model.Ugovor, UgovorSearchRequest, Database.Racun, UgovorUpsertRequest, UgovorUpsertRequest>,
        IUgovorService
    {
        public UgovorService(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public Model.Ugovor GetRacunByRezervacijaID(int id)
        {
            var query = _context.Racun.Include(x => x.Rezervacija).Where(x => x.RezervacijaId == id).FirstOrDefault();

            if (query != null)
            {
                return _mapper.Map<Model.Ugovor>(query);
            }
            throw new UserException("Racun nije pronađen");
        }

        public Model.Ugovor UpdateStatus(int id, UgovorStatusRequest request)
        {
            var entity = _context.Racun.Find(id);
            _context.Racun.Attach(entity);
            _context.Racun.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Ugovor>(entity);
        }
    }
}
