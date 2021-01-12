using AutoMapper;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using Rent_A_Car.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class KlijentService : IKlijentService
    {
        private readonly Rent_A_CarContext _context;
        private readonly IMapper _mapper;

        public KlijentService(Rent_A_CarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Klijent> Get(KlijentSearchRequest request)
        {
            //querry
            var query = _context.Klijent.AsQueryable();

            if(!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Klijent>>(list);
        }

        //GET BY ID -----------------------------------------
        public Model.Klijent GetById(int id)
        {
            var entity = _context.Klijent.Find(id);
            return _mapper.Map<Model.Klijent>(entity);
        }

        public Model.Klijent Insert(KlijentInsertRequest request)
        {
            var entity = _mapper.Map<Database.Klijent>(request);

            if(request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slažu!");
            }
            entity.LozinkaHash = "test";
            entity.LozinkaSalt = "test";

            _context.Klijent.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Klijent>(entity);
        }

        public Model.Klijent Update(int id, KlijentInsertRequest request)
        {
            //var entity = _context.Klijent.Find(id);

            //_mapper.Map(request, entity);

            //if(!string.IsNullOrWhiteSpace(request.Password))
            //{
            //    if(request.Password != request.PasswordConfirmation)
            //    {
            //        throw new Exception("Paswordi se ne slažu!!!");
            //    }
            //    //TODO: update password
            //}

            //_context.SaveChanges();
            //return _mapper.Map<Model.Klijent>(entity);

            var entity = _context.Klijent.Find(id);
            _context.Klijent.Attach(entity);
            _context.Klijent.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Klijent>(entity);
        }
    }
}
