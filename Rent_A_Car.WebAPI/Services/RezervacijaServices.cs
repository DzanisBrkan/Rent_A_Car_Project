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
    public class RezervacijaServices
        : BaseCRUDService<Model.Rezervacija, RezervacijaSearchRequest, Database.Rezervacija, RezervacijaUpsertRequest, RezervacijaUpsertRequest>,
        IRezervacijaServicecs
    {

        public RezervacijaServices(Rent_A_CarContext context, IMapper mapper) : base(context, mapper)
        {

        }



        public Model.Rezervacija GetRezervacijaByUserID(int id)
        {
            var query = _context.Rezervacija.FirstOrDefault(x => x.KlijentId == id);

            if (query != null)
            {
                return _mapper.Map<Model.Rezervacija>(query);

            }
            throw new UserException("Rezervacija nije pronadjena");
        }
    }
}
