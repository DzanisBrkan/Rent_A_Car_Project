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
        private readonly APIService _VozilaService = new APIService("Vozilo");
        private readonly APIService _lokacijaService = new APIService("Lokacija");
        private readonly APIService _osiguranjeService = new APIService("Osiguranje");
        private readonly APIService _popustService = new APIService("Popust");
        private readonly APIService _racunService = new APIService("Ugovor");
        private readonly APIService _ocjenaService = new APIService("Ocjena");


        public Vozilo _vozilo = null;
        string _Model = string.Empty;
        string _Marka = string.Empty;
        public byte[] _SlikaThumb = null;


        public NapraviRezervacijuViewModel(Vozilo vozilo)
        {
            _vozilo = vozilo;
            InitCommand = new Command(async () => await Init());
            SaveCommand = new Command(async () => await SaveChanges());
            Model = vozilo.Model;
            Marka = vozilo.Marka;
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


        string _selectedStatus = string.Empty;
        public string selectedStatus
        {
            get { return _selectedStatus; }
            set { SetProperty(ref _selectedStatus, value); }
        }

        Lokacija _selectedLokacija = null;
        public Lokacija selectedLokacija
        {
            get { return _selectedLokacija; }
            set 
            { SetProperty(ref _selectedLokacija, value);}
        }

        Osiguranje _selectedOsiguranje = null;
        public Osiguranje selectedOsiguranje
        {
            get { return _selectedOsiguranje; }
            set 
            { SetProperty(ref _selectedOsiguranje, value);            }
        }

        Popust _selectedPopust = null;
        public Popust selectedPopust
        {
            get { return _selectedPopust; }
            set 
            {  SetProperty(ref _selectedPopust, value);}
        }

        int _KlijentId = 0;
        public int KlijentId
        {
            get { return _KlijentId; }
            set { SetProperty(ref _KlijentId, value); }
        }

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

        double? _ukupnaCijena = 0;
        public double? ukupnaCijena
        {
            get { return _ukupnaCijena; }
            set { SetProperty(ref _ukupnaCijena, value); }
        }

        public ObservableCollection<Lokacija> lokacijaList { get; set; } = new ObservableCollection<Lokacija>();
        public ObservableCollection<Osiguranje> osiguranjeList { get; set; } = new ObservableCollection<Osiguranje>();
        public ObservableCollection<Popust> popustList { get; set; } = new ObservableCollection<Popust>();
 
        public ICommand InitCommand { get; set; }
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

            ukupnaCijena = _vozilo.CijenaPoSatu * 1.17;
        }

        public ICommand SaveCommand { get; set; }
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

            //dodavanje nove rezervacije
            int hrsDiff = (krajRezervacije - pocetakRezervacije).Hours;
            int dayDiff = (int)(krajRezervacije - pocetakRezervacije).TotalDays;

            var request = new RezervacijaUpsertRequest()
            {
                Status = "U toku",
                UkupnaCijena = _vozilo.CijenaPoSatu * 1.17 * hrsDiff,
                LokacijaId = selectedLokacija.LokacijaId,
                OsiguranjeId = selectedOsiguranje.OsiguranjeId,
                KlijentId = KlijentModel.KlijentId,
                VoziloId = _vozilo.VoziloID,
                PopustId = selectedPopust.PopustId,
                KrajRezervacije = krajRezervacije,
                PocetakRezervacije = pocetakRezervacije,
                Naziv = "Rezerviranje" + " " + _vozilo.Model + " " + _vozilo.Marka
            };
            var rezervacijaResponse = await _rezervacijaService.Insert<Model.Rezervacija>(request);

            //dodavanje novog racuna
            var requestRacun = new UgovorUpsertRequest()
            {
                UkupnaCijena = rezervacijaResponse.UkupnaCijena,
                NacinPlacanjaId = selectedLokacija.LokacijaId,
                DatumPlacanja = null,
                RezervacijaId = rezervacijaResponse.RezervacijaID,
                UkupanBrojDana = dayDiff,
                Izdano = false
            };
            var modelracun = await _racunService.Insert<Model.Ugovor>(requestRacun);


            //status vozila na zauzeto
            if (_vozilo != null)
            {
                var requestVozilo = new VoziloStatusRequest()
                {
                    Zauzeto = true
                };
                var modelUserUpdated = await _VozilaService.PutActionResponse<Model.Vozilo>("UpdateStatus", _vozilo.VoziloID, requestVozilo);
            }
                     
            if (rezervacijaResponse != null)
            {
                await Application.Current.MainPage.DisplayAlert("Notifikacija", "Rezervacija uspješno kreirana!", "Ok");
               
            }

        }
    }
}
