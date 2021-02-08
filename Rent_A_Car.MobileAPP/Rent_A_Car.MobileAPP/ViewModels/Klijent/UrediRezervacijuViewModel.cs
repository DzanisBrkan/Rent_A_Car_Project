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
    public class UrediRezervacijuViewModel : BaseViewModel
    {

        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _vozilaService = new APIService("Vozilo");
        private readonly APIService _lokacijaService = new APIService("Lokacija");
        private readonly APIService _osiguranjeService = new APIService("Osiguranje");
        private readonly APIService _popustService = new APIService("Popust");
        private readonly APIService _racunService = new APIService("Ugovor");


        double _pdv = 1.17;
        public Rezervacija _rezervacija = null;

        public UrediRezervacijuViewModel(Rezervacija rezervacija)
        {

            InitCommand = new Command(async () => await Init());
            SaveCommand = new Command(async () => await SaveChanges());

            _rezervacija = rezervacija;
        }

        public int _RezervacijaId = 0;
        public int RezervacijaId
        {
            get { return _RezervacijaId; }
            set { SetProperty(ref _RezervacijaId, value); }
        }

        public double? _ukupnaCijena = 0;
        public double? ukupnaCijena
        {
            get { return _ukupnaCijena; }
            set
            { SetProperty(ref _ukupnaCijena, value); }
        }
        public byte[] _SlikaThumb = null;
        public byte[] SlikaThumb
        {
            get { return _SlikaThumb; }
            set
            { SetProperty(ref _SlikaThumb, value); }
        }
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

        Lokacija _selectedLokacija = null;
        public Lokacija selectedLokacija
        {
            get { return _selectedLokacija; }
            set
            { SetProperty(ref _selectedLokacija, value); }
        }

        //OsiguranjeId dobijamo iz DROPDOWN
        Osiguranje _selectedOsiguranje = null;
        public Osiguranje selectedOsiguranje
        {
            get { return _selectedOsiguranje; }
            set
            { SetProperty(ref _selectedOsiguranje, value); }
        }

        //PopustId dobijamo iz DROPDOWN
        Popust _selectedPopust = null;
        public Popust selectedPopust
        {
            get { return _selectedPopust; }
            set
            { SetProperty(ref _selectedPopust, value); }
        }

        //KrajRezervacije dobijamo iz prethodnog viewa (prikaz Vozila)
        DateTime? _KrajRezervacije = DateTime.Now;
        public DateTime? krajRezervacije
        {
            get { return _KrajRezervacije; }
            set { SetProperty(ref _KrajRezervacije, value); }
        }

        DateTime? _PocetakRezervacije = DateTime.Now;
        public DateTime? pocetakRezervacije
        {
            get { return _PocetakRezervacije; }
            set { SetProperty(ref _PocetakRezervacije, value); }
        }

    
        public ObservableCollection<Lokacija> lokacijaList { get; set; } = new ObservableCollection<Lokacija>();
        public ObservableCollection<Osiguranje> osiguranjeList { get; set; } = new ObservableCollection<Osiguranje>();
        public ObservableCollection<Popust> popustList { get; set; } = new ObservableCollection<Popust>();

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var rezervacija = await _rezervacijaService.GetById<Rezervacija>(_rezervacija.RezervacijaID);
            var vozilo = await _vozilaService.GetById<Vozilo>(rezervacija.VoziloId);

            var pocetak = _rezervacija.KrajRezervacije.GetValueOrDefault().Hour;
            var kraj = _rezervacija.PocetakRezervacije.GetValueOrDefault().Hour;
            var pocetakD = _rezervacija.KrajRezervacije.GetValueOrDefault().Day;
            var krajD = _rezervacija.PocetakRezervacije.GetValueOrDefault().Day;

            int hrsDiff = (kraj) - (pocetak);
            int dayDiff = krajD - pocetakD;

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

            RezervacijaId = rezervacija.RezervacijaID;
            SlikaThumb = vozilo.SlikaThumb;
            Model = vozilo.Model;
            Marka = vozilo.Marka;
            pocetakRezervacije = rezervacija.PocetakRezervacije;
            krajRezervacije = rezervacija.KrajRezervacije;
            ukupnaCijena = rezervacija.UkupnaCijena;
        }

        public ICommand SaveCommand { get; set; }

        public async Task SaveChanges()
        {
            var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            var vozilo = await _vozilaService.GetById<Model.Vozilo>(_rezervacija.VoziloId);

          
            var hrsDiff = ((krajRezervacije.GetValueOrDefault()) - (pocetakRezervacije.GetValueOrDefault())).TotalHours;
            var dayDiff = ((krajRezervacije.GetValueOrDefault()) - (pocetakRezervacije.GetValueOrDefault())).TotalDays;

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
 

            var request = new RezervacijaUpsertRequest()
            {
                Status = "U toku",
                UkupnaCijena = vozilo.CijenaPoSatu * 1.17 * hrsDiff,
                LokacijaId = selectedLokacija.LokacijaId,
                OsiguranjeId = selectedOsiguranje.OsiguranjeId,
                KlijentId = KlijentModel.KlijentId,
                VoziloId = vozilo.VoziloID,
                PopustId = selectedPopust.PopustId,
                KrajRezervacije = krajRezervacije,
                PocetakRezervacije = pocetakRezervacije,
                Naziv = "Rezerviranje" + " " + vozilo.Model + " " + vozilo.Marka
            };
            var rezervacijaResponse = await _rezervacijaService.Update<Model.Rezervacija>(_rezervacija.RezervacijaID, request);

            //dodavanje novog racuna


            var requestRacun = new UgovorUpsertRequest()
            {
                UkupnaCijena = rezervacijaResponse.UkupnaCijena,
                NacinPlacanjaId = 1,
                DatumPlacanja = null,
                RezervacijaId = rezervacijaResponse.RezervacijaID,
                UkupanBrojDana = dayDiff,
                Izdano = false
            };
            var modelracun = await _racunService.Insert<Model.Ugovor>(requestRacun);


            //status vozila na zauzeto
            if (vozilo != null)
            {
                var requestVozilo = new VoziloStatusRequest()
                {
                    Zauzeto = true
                };
                var modelUserUpdated = await _vozilaService.PutActionResponse<Model.Vozilo>("UpdateStatus", vozilo.VoziloID, requestVozilo);
            }

            if (rezervacijaResponse != null)
            {
                await Application.Current.MainPage.DisplayAlert("Notifikacija", "Rezervacija preuređena!", "Ok");
            }
        }
    }
}
