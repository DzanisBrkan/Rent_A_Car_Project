using AutoMapper;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Klijent, Model.Klijent>();
            CreateMap<Database.Klijent, KlijentInsertRequest>().ReverseMap();


            CreateMap<Database.Vozilo, Model.Vozilo>();

            CreateMap<Database.Kategorija, Model.Kategorija>();

            CreateMap<Database.Specifikacija, Model.Specifikacija>();
            CreateMap<Database.Grad, Model.Grad>();


            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Zaposlenik, Model.Zaposlenik>();
            CreateMap<Database.KorisnickiNalog, Model.KorisnickiNalog>();
            CreateMap<Database.Tip, Model.Tip>();
            CreateMap<Database.Ocjena, Model.Ocjena>();
            CreateMap<Database.Racun, Model.Racun>();
            CreateMap<Database.Rezervacija, Model.Rezervacija>();



        }
    }
}
