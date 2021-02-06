﻿using Rent_A_Car.MobileAPP.Views;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    public class RezervacijaVozilaViewModel : BaseViewModel
    {
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _vozilaService = new APIService("Vozilo");

        private readonly APIService _UgovorService = new APIService("Ugovor");



        public RezervacijaVozilaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SaveChangesCommand = new Command(async () => await SaveChanges());

        }


        public DateTime _KrajRezervacije;
        public DateTime KrajRezervacije
        {
            get { return _KrajRezervacije; }
            set { SetProperty(ref _KrajRezervacije, value); }
        }


        string _Status = string.Empty;
        public string Status
        {
            get { return _Status; }
            set { SetProperty(ref _Status, value); }
        }


        string _UkupnaCijena = string.Empty;
        public string UkupnaCijena
        {
            get { return _UkupnaCijena; }
            set { SetProperty(ref _UkupnaCijena, value); }
        }





        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();
        public ObservableCollection<Rezervacija> _PronadjenaRezervacijaService { get; set; } = new ObservableCollection<Rezervacija>();

        public ICommand SaveChangesCommand { get; set; }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (APIService.UserID != 0)
            {
                var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            }

            //ovdje bi trebo napraviti request ili nesto da poredi iz REZERVACIJE id klijenta
            //var RezervacijaModel = await _rezervacijaService.GetById<Model.Rezervacija>(KlijentModel.KlijentId);

            //RezervacijeList.Clear();
            //RezervacijeList.Add(RezervacijaModel);

            var list = await _rezervacijaService.Get<IEnumerable<Rezervacija>>(null);

            RezervacijeList.Clear();
            _PronadjenaRezervacijaService.Clear();
            foreach (var rezervacije in list)
            {
                RezervacijeList.Add(rezervacije);
            }


            for (int i = 0; i < RezervacijeList.Count; i++)
            {
                if (RezervacijeList[i].KlijentId == APIService.UserID)
                {
                    _PronadjenaRezervacijaService.Add(RezervacijeList[i]);
                }
            }
            //radi ovog puca
            //APIService.UserRacunID = _PronadjenaRezervacijaService.First().RacunId;


        }



        public async Task SaveChanges()
        {

            //mora se uzet rezervacija koja se odabere
            //var RezervacijaModel = await _rezervacijaService.GetActionResponse<Model.Rezervacija>($"GetRezByUserID/{APIService.UserID}");


            _KrajRezervacije = KrajRezervacije;
            _Status = Status;
            _UkupnaCijena = UkupnaCijena;




            try
            {

                if (KrajRezervacije != null)
                {
                    if (KrajRezervacije.Month < DateTime.Now.Month)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti ispravan datum", "Ok");
                        return;
                    }



                }


                var RezervacijaModel = await _rezervacijaService.GetActionResponse<Model.Rezervacija>($"GetRezByUserID/{APIService.UserID}");

                //get last Racun(ugvoor)
                var UgovorModel = await _UgovorService.GetById<Model.Ugovor>(RezervacijaModel.RacunId);
                APIService.UserRacunID = RezervacijaModel.RacunId;



                var VozilModel = await _vozilaService.GetById<Vozilo>(APIService.UserVoziloID);
                //var ugovorModel = await _UgovorService.GetById<Ugovor>(APIService.UserRacunID);


                var DatumUgovora = DateTime.Now.Day;

                var KrajDatumaUgovora = KrajRezervacije.Day;

                int DaniRezervacije = 0;
                int ukupnaCijena = 0;

                //if (KrajRezervacije.Month >= DateTime.Now.Month)
                //{
                if (KrajDatumaUgovora < DatumUgovora)
                {
                    DatumUgovora = 0;
                }
                DaniRezervacije = KrajDatumaUgovora - DatumUgovora;
                ukupnaCijena = (int)VozilModel.CijenaPoSatu * DaniRezervacije;
                //}






                var request = new RezervacijaUpsertRequest()
                {
                    KrajRezervacije = KrajRezervacije,
                    Status = Status,
                    UkupnaCijena = ukupnaCijena.ToString(),
                    //LokacijaId = _LokacijaId,
                    //OsiguranjeId = _OsiguranjeId,
                    KlijentId = APIService.UserID,
                    //VoziloId = _VoziloId,
                    //PopustId = _PopustId,
                    RacunId = APIService.UserRacunID
                };



                var modelRezervacija = await _rezervacijaService.Insert<Model.Rezervacija>(request);


                if (modelRezervacija != null)
                {
                    //if (modelRezervacija.Status.ToString() != "Faulted")
                    //{
                    await Application.Current.MainPage.DisplayAlert("Notifikacija", "Uspješno ste modifikovali rezervaicuju. Cijena iznosi:" + ukupnaCijena.ToString() + "KM", "Ok");
                    //await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
                    //}
                    //await Application.Current.MainPage.DisplayAlert("Error.", "Doslo je do greske.", "Ok");
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
