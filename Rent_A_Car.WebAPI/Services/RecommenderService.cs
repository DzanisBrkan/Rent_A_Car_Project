using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Services
{
    public class RecommenderService : IRecommenderService
    {
        private readonly Rent_A_CarContext _context;
        private readonly IMapper _mapper;
        public RecommenderService(Rent_A_CarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public Model.RecommenderModel Get(UserRecommendationRequest request)
        {
            var UserEntity = _context.Klijent.Find(request.UserID);
            var VoziloList = _context.Vozilo.Include(x => x.Lokacija).ToList();
            var ratingList = _context.Ocjena.Include(u => u.Klijent).ToList();

            float countRatings = 0;
            int brojacOcjena = 0;

            RecommenderModel model = new RecommenderModel();
            model.listToRecommend = new List<Model.Vozilo>();
            model.others = new List<Model.Vozilo>();

            foreach (var vozilo in VoziloList)
            {
                countRatings = 0;
                brojacOcjena = 0;
                if (vozilo.Lokacija.Naziv == "Mostar")
                {
                    foreach (var r in ratingList)
                    {
                        if (vozilo.VoziloId == r.VoziloId && r.KlijentId != UserEntity.KlijentId)
                        {
                            if (r.Ocjena1 >= 2)
                            {
                                countRatings+=r.Ocjena1;
                                brojacOcjena++;
                            }
                        }
                    }
                    float avg = 0;
                    if (countRatings != 0)
                    {
                        avg = (float)(countRatings / brojacOcjena);
                    }
                    if (avg >= 2.5)
                    {

                        model.listToRecommend.Add(new Model.Vozilo()
                        {
                            VoziloID = vozilo.VoziloId,
                            RegistracijskiBroj = vozilo.RegistracijskiBroj,
                            Model = vozilo.Model,
                            Marka = vozilo.Marka,
                            BrSjedista = vozilo.BrSjedista,
                            BrVrata = vozilo.BrVrata,
                            ZapreminaPrtljaznika = vozilo.ZapreminaPrtljaznika,
                            CijenaPoSatu = vozilo.CijenaPoSatu,
                            Zauzeto = vozilo.Zauzeto,
                            KategorijaId = vozilo.KategorijaId,
                            SpecifikacijaId = vozilo.SpecifikacijaId,
                            LokacijaId = vozilo.LokacijaId,
                            TipId = vozilo.TipId,
                            SlikaThumb = vozilo.SlikaThumb,
                            PositiveDifferent = avg
                        });
                    }
                    else
                    {
                        model.others.Add(new Model.Vozilo()
                        {
                            VoziloID = vozilo.VoziloId,
                            RegistracijskiBroj = vozilo.RegistracijskiBroj,
                            Model = vozilo.Model,
                            Marka = vozilo.Marka,
                            BrSjedista = vozilo.BrSjedista,
                            BrVrata = vozilo.BrVrata,
                            ZapreminaPrtljaznika = vozilo.ZapreminaPrtljaznika,
                            CijenaPoSatu = vozilo.CijenaPoSatu,
                            Zauzeto = vozilo.Zauzeto,
                            KategorijaId = vozilo.KategorijaId,
                            SpecifikacijaId = vozilo.SpecifikacijaId,
                            LokacijaId = vozilo.LokacijaId,
                            TipId = vozilo.TipId,
                            SlikaThumb = vozilo.SlikaThumb

                        });
                    }
                }
            }
            model.listToRecommend = model.listToRecommend.OrderByDescending(r => r.PositiveDifferent).ToList();


            return model;
        }

    }
}
