using GalaSoft.MvvmLight.Command;
using Rent_A_Car.MobileAPP.Views;
using Rent_A_Car.MobileAPP.Views.Klijent;
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
        private readonly APIService _UgovorService = new APIService("Ugovor");
        private readonly APIService _voziloService = new APIService("Vozilo");



        public RezervacijaVozilaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            OtkaziCommand = new RelayCommand<string>(async (sender) => await Otkazi(sender));
            PlatiCommand = new RelayCommand<string>(async (sender) => await Plati(sender));
        }

       


        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();
        public ObservableCollection<Rezervacija> _PronadjenaRezervacijaService { get; set; } = new ObservableCollection<Rezervacija>();
        public Rezervacija PronadjenaRezervacija { get; set; } = new Rezervacija();

        double UkupnaCijena = 0;

        string _Model = string.Empty;
        public string Model
        {
            get { return _Model; }
            set
            { SetProperty(ref _Model, value); }
        }

        string _Marka = string.Empty;
        public string Marka
        {
            get { return _Marka; }
            set
            { SetProperty(ref _Marka, value); }
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
            if (APIService.UserID != 0)
            {
                var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            }


            var list = await _rezervacijaService.Get<IEnumerable<Rezervacija>>(null);


            //rezervacije-----------------------------------------------------------
            RezervacijeList.Clear();
            _PronadjenaRezervacijaService.Clear();
            foreach (var rezervacije in list)
            {
                RezervacijeList.Add(rezervacije);
            }

            for (int i = 0; i < RezervacijeList.Count; i++)
            {
                if (RezervacijeList[i].KlijentId == APIService.UserID && RezervacijeList[i].Status == "U toku")
                {
                    _PronadjenaRezervacijaService.Add(RezervacijeList[i]);
                }
            }
        }


        public RelayCommand<string> OtkaziCommand { get; set; }

        public async Task Otkazi(object sender)
        {

            var rezervacija = await _rezervacijaService.GetById<Model.Rezervacija>(sender);
            var vozilo = await _voziloService.GetById<Model.Vozilo>(rezervacija.VoziloId);

            if (rezervacija != null)
            {
                var requestRezervacija = new RezervacijaStatusRequest()
                {
                    Status = "Otkazano"
                };

                //status vozila na false
                if (vozilo != null)
                {
                    var requestVozilo = new VoziloStatusRequest()
                    {
                        Zauzeto = false
                    };
                    var voziloStatusUpdated = await _voziloService.PutActionResponse<Model.Vozilo>("UpdateStatus", vozilo.VoziloID, requestVozilo);
                }

                    var modelUserUpdated = await _rezervacijaService.PutActionResponse<Model.Rezervacija>("UpdateStatus", rezervacija.RezervacijaID, requestRezervacija);
                await Application.Current.MainPage.DisplayAlert("Notifikacija", "Rezervacija otkazana!", "Ok");
            }
        }



        public RelayCommand<string> PlatiCommand { get; set; }
        public async Task Plati(string sender)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new KreirajRacunPage(sender));
        }
       
    }
}
