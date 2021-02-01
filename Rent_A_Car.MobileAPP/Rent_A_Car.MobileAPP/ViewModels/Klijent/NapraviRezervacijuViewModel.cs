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
    public class NapraviRezervacijuViewModel : BaseViewModel
    {
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        private readonly APIService _klijentService = new APIService("Klijent");
        //private readonly APIService _UgovorService = new APIService("Ugovor");
        private readonly APIService _VozilaService = new APIService("Vozilo");
        private readonly APIService _lokacijaService = new APIService("Lokacija");
        private readonly APIService _osiguranjeService = new APIService("Osiguranje");
        private readonly APIService _popustService = new APIService("Popust");




        public Vozilo _vozilo = null;
        string _Model = string.Empty;
        string _Marka = string.Empty;
        double? _UkupnaCijena = 0;
        public byte[] _SlikaThumb = null;
        double _pdv = 1.17;


        public NapraviRezervacijuViewModel(Vozilo vozilo)
        {
            //SaveChangesCommand = new Command(async () => await SaveChanges());
            _vozilo = vozilo;
            InitCommand = new Command(async () => await Init());
            SaveCommand = new Command(async () => await SaveChanges());
            Model = vozilo.Model;
            Marka = vozilo.Marka;
            _UkupnaCijena = vozilo.CijenaPoSatu * _pdv;
            _SlikaThumb = vozilo.SlikaThumb;
        }

        public byte[] SlikaThumb
        {
            get { return _SlikaThumb; }
            set
            { SetProperty(ref _SlikaThumb, value); }
        }
        public string Model
        {
            get { return _Model; }
            set
            { SetProperty(ref _Model, value);}
        }
        public string Marka
        {
            get { return _Marka; }
            set
            {SetProperty(ref _Marka, value);}
        }

        //preimenuj na cijena po satu
        public double? UkupnaCijena
        {
            get { return _UkupnaCijena; }
            set { SetProperty(ref _UkupnaCijena, value); }
        }

        string _selectedStatus = string.Empty;
        public string selectedStatus
        {
            get { return _selectedStatus; }
            set { SetProperty(ref _selectedStatus, value); }
        }

        //LokacijaId dobijamo iz DROPDOWN
        Lokacija _selectedLokacija = null;
        public Lokacija selectedLokacija
        {
            get { return _selectedLokacija; }
            set 
            { SetProperty(ref _selectedLokacija, value);}
        }

        //OsiguranjeId dobijamo iz DROPDOWN
        Osiguranje _selectedOsiguranje = null;
        public Osiguranje selectedOsiguranje
        {
            get { return _selectedOsiguranje; }
            set 
            { SetProperty(ref _selectedOsiguranje, value);            }
        }

        //PopustId dobijamo iz DROPDOWN
        Popust _selectedPopust = null;
        public Popust selectedPopust
        {
            get { return _selectedPopust; }
            set 
            {  SetProperty(ref _selectedPopust, value);}
        }

        //OsiguranjeId dobijamo iz sesije (saljemo id klijenta)
        int _KlijentId = 0;
        public int KlijentId
        {
            get { return _KlijentId; }
            set { SetProperty(ref _KlijentId, value); }
        }

        //KrajRezervacije dobijamo iz prethodnog viewa (prikaz Vozila)
        DateTime _KrajRezervacije = DateTime.Now;
        public DateTime krajRezervacije
        {
            get { return _KrajRezervacije; }
            set { SetProperty(ref _KrajRezervacije, value); }
        }

        DateTime _PocetakRezervacije = DateTime.Now;
        public DateTime pocetakRezervacije
        {
            get { return _PocetakRezervacije; }
            set { SetProperty(ref _PocetakRezervacije, value); }
        }


        public ICommand InitCommand { get; set; }
        public ICommand SaveCommand { get; set; }


        public ObservableCollection<Lokacija> lokacijaList { get; set; } = new ObservableCollection<Lokacija>();
        public ObservableCollection<Osiguranje> osiguranjeList { get; set; } = new ObservableCollection<Osiguranje>();
        public ObservableCollection<Popust> popustList { get; set; } = new ObservableCollection<Popust>();
 
        public async Task Init()
        {

            if (lokacijaList.Count == 0)
            {
                var resposneLokacijaList = await _lokacijaService.Get<List<Lokacija>>(null);
                foreach (var lokacija in resposneLokacijaList)
                {
                    lokacijaList.Add(lokacija);
                }
            }

            if (osiguranjeList.Count == 0)
            {
                var resposneOsiguranjeList = await _osiguranjeService.Get<List<Osiguranje>>(null);
                foreach (var osiguranje in resposneOsiguranjeList)
                {
                   osiguranjeList.Add(osiguranje);
                }
            }

            if (popustList.Count == 0)
            {
                var resposnePopustList = await _popustService.Get<List<Popust>>(null);
                foreach (var popust in resposnePopustList)
                {
                    popustList.Add(popust);
                }
            }

        }

        public async Task SaveChanges()
        {
            var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);

            if (krajRezervacije == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Unesite datum za kraj rezervacije!", "Ok");
                return;
            }

            if (selectedLokacija == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite lokaciju!", "Ok");
                return;
            }

            if (selectedOsiguranje == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite osiguranje!", "Ok");
                return;
            }

            if (selectedPopust == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite popust!", "Ok");
                return;
            }


            var request = new RezervacijaUpsertRequest()
            {
                Status = "U toku",
                UkupnaCijena = _UkupnaCijena,
                LokacijaId = selectedLokacija.LokacijaId,
                OsiguranjeId = selectedOsiguranje.OsiguranjeId,
                KlijentId = KlijentModel.KlijentId,
                VoziloId = _vozilo.VoziloID,
                PopustId = selectedPopust.PopustId,
                KrajRezervacije = krajRezervacije,
                PocetakRezervacije = pocetakRezervacije
            };

            if(_vozilo != null)
            {
                //treba novi api za status

                var requestVozilo = new VoziloStatusRequest()
                {
                    Zauzeto = true
                };

                var modelUserUpdated = await _VozilaService.PutActionResponse<Model.Vozilo>("UpdateStatus", _vozilo.VoziloID, requestVozilo);
            }
                     
            
            var model = await _rezervacijaService.Insert<Model.Rezervacija>(request);

            if (model != null)
            {

                await Application.Current.MainPage.DisplayAlert("Notifikacija", "Rezervacija uspješno kreirana!.", "Ok");
                await Application.Current.MainPage.Navigation.PushModalAsync(new StripePaymentGatwayPage(model));

            }

        }
    }
}
