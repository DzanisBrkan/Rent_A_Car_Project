using GalaSoft.MvvmLight.Command;
using Rent_A_Car.MobileAPP.Views;
using Rent_A_Car.MobileAPP.Views.Klijent;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    public class KreirajRacunViewModel : BaseViewModel
    {
        private readonly APIService _racunService = new APIService("Ugovor");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        private readonly APIService _voziloService = new APIService("Vozilo");
        private readonly APIService _nacinPlacanjaService = new APIService("NacinPlacanja");


        public string _rezervacijaId = string.Empty;
        public KreirajRacunViewModel(string rezervacijaId)
        {
            InitCommand = new Command(async () => await Init());
            PlatiCommand = new Command(async () => await Plati());
            //NazadCommand = new Command(async () => await Nazad());
            _rezervacijaId = rezervacijaId;
        }

        //za page binding potrebno
        public int RezervacijaID = 0;
        public ObservableCollection<NacinPlacanja> NacinPlacanja { get; set; } = new ObservableCollection<NacinPlacanja>();

        NacinPlacanja _selectedNacinPlacanja = null;
        public NacinPlacanja SelectedNacinPlacanja
        {
            get { return _selectedNacinPlacanja; }
            set
            {
                SetProperty(ref _selectedNacinPlacanja, value);
                if (value != null)
                {
                    InitCommand.Execute(null);

                }
            }
        }

        double? _ukupanBrojDana =0;
        public double? ukupanBrojDana
        {
            get { return _ukupanBrojDana; }
            set { SetProperty(ref _ukupanBrojDana, value); }
        }

        DateTime? _datumPlacanja = DateTime.Now;
        public DateTime? datumPlacanja
        {
            get { return _datumPlacanja; }
            set { SetProperty(ref _datumPlacanja, value); }
        }



        double? _ukupnaCijena = 0;
        public double? ukupnaCijena
        {
            get { return _ukupnaCijena; }
            set { SetProperty(ref _ukupnaCijena, value); }
        }

        string _nazivRezervacije = string.Empty;
        public string nazivRezervacije
        {
            get { return _nazivRezervacije; }
            set { SetProperty(ref _nazivRezervacije, value); }
        }

        public byte[] _SlikaThumb = null;
        public byte[] SlikaThumb
        {
            get { return _SlikaThumb; }
            set
            { SetProperty(ref _SlikaThumb, value); }
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var rezervacija = await _rezervacijaService.GetById<Rezervacija>(_rezervacijaId);
            var racun = await _racunService.GetActionResponse<Model.Ugovor>($"GetRacByRezID/{_rezervacijaId}");
            var vozilo = await _voziloService.GetById<Vozilo>(rezervacija.VoziloId);
            //get za page
            RezervacijaID = rezervacija.RezervacijaID;

            if (NacinPlacanja.Count == 0)
            {
                var nacinPlacanjaList = await _nacinPlacanjaService.Get<List<NacinPlacanja>>(null);

                foreach (var nacinPlacanja in nacinPlacanjaList)
                {
                    NacinPlacanja.Add(nacinPlacanja);
                }
            }
           

            nazivRezervacije = vozilo.Marka + " " + vozilo.Model;
            ukupnaCijena = racun.UkupnaCijena;
            datumPlacanja = DateTime.Now;
            ukupanBrojDana = racun.UkupanBrojDana;
            SlikaThumb = vozilo.SlikaThumb;

        }

        public ICommand PlatiCommand { get; set; }
        public async Task Plati()
        {
            var request = new UgovorStatusRequest()
            {
              
                NacinPlacanjaId = SelectedNacinPlacanja.NacinPlacanjaId, //iz pickera
                DatumPlacanja = DateTime.Now,
                Izdano = true
            };
            var racun = await _racunService.GetActionResponse<Model.Ugovor>($"GetRacByRezID/{_rezervacijaId}");
            var model = await _racunService.PutActionResponse<Model.Ugovor>("UpdateStatus", racun.RacunId, request);

            //vozilo stavljamo na slobodno
            var rezervacija = await _rezervacijaService.GetById<Rezervacija>(_rezervacijaId);
            var vozilo = await _voziloService.GetById<Vozilo>(rezervacija.VoziloId);
            if (vozilo != null)
            {
                var voziloRequest = new VoziloStatusRequest()
                {
                    Zauzeto = false
                };
                var modelVozilo = await _voziloService.PutActionResponse<Model.Vozilo>("UpdateStatus", vozilo.VoziloID, voziloRequest);
            }


            //rezervacuju stavljamo u zavrseno
            if (rezervacija != null)
            {
                var rezervacijaRequest = new RezervacijaStatusRequest()
                {
                    Status = "Zavrseno"
                };
                var modelRezervacija = await _rezervacijaService.PutActionResponse<Rezervacija>("UpdateStatus", rezervacija.RezervacijaID, rezervacijaRequest);
            }

            if (model != null)
            {
                var rezervacijaModel = await _rezervacijaService.GetById<Rezervacija>(_rezervacijaId);
                await Application.Current.MainPage.Navigation.PushModalAsync(new StripePaymentGatwayPage(rezervacijaModel));
            }
        }


    }
}
