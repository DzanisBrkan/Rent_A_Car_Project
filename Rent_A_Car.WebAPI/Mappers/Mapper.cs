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
            CreateMap<Database.Klijent, KlijentUpdateRequest>().ReverseMap();
            CreateMap<Database.Ocjena, OcjenaUpsertRequest>().ReverseMap();


            CreateMap<Database.Rezervacija, RezervacijaUpsertRequest>().ReverseMap();
            CreateMap<Database.Racun, UgovorUpsertRequest>().ReverseMap();

            CreateMap<Database.Zaposlenik, Model.Zaposlenik>();
            CreateMap<Database.Zaposlenik, ZaposlenikInsertRequest>().ReverseMap();

            //CreateMap<Database.Grad, GradUpsertRequest>().ReverseMap();


            CreateMap<Database.Vozilo, Model.Vozilo>();
            CreateMap<Database.Kategorija, Model.Kategorija>();

            CreateMap<Database.Specifikacija, Model.Specifikacija>();
            CreateMap<Database.Grad, Model.Grad>();

            CreateMap<Database.KorisnickiNalog, Model.KorisnickiNalog>();
            CreateMap<Database.Tip, Model.Tip>();
            CreateMap<Database.Drzava, Model.Drzava>();
            CreateMap<Database.Greska, Model.Greska>();
            CreateMap<Database.Lokacija, Model.Lokacija>();
            CreateMap<Database.Ocjena, Model.Ocjena>();
            CreateMap<Database.Rezervacija, Model.Rezervacija>();
            CreateMap<Database.Racun, Model.Ugovor>();
            //proba dva

        }
    }
}
