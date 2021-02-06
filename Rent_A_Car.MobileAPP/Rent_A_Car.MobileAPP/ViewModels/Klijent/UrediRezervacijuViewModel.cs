using Rent_A_Car.MobileAPP.Views.Klijent;
using Rent_A_Car.Model;
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

      
        double _pdv = 1.17;
        public Rezervacija _rezervacija = null;

        public UrediRezervacijuViewModel(Rezervacija rezervacija)
        {

            //SaveChangesCommand = new Command(async () => await SaveChanges());
            InitCommand = new Command(async () => await Init());
            //SaveCommand = new Command(async () => await SaveChanges());
            //NazadCommand = new Command(async () => await Nazad());

            _rezervacija = rezervacija;
        }

        public int _RezervacijaId = 0;
        public int RezervacijaId
        {
            get { return _RezervacijaId; }
            set { SetProperty(ref _RezervacijaId, value); }
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

        public ICommand InitCommand { get; set; }

      


        public ObservableCollection<Lokacija> lokacijaList { get; set; } = new ObservableCollection<Lokacija>();
        public ObservableCollection<Osiguranje> osiguranjeList { get; set; } = new ObservableCollection<Osiguranje>();
        public ObservableCollection<Popust> popustList { get; set; } = new ObservableCollection<Popust>();

        public async Task Init()
        {
            var rezervacija = await _rezervacijaService.GetById<Rezervacija>(_rezervacija.RezervacijaID);
            var vozilo = await _vozilaService.GetById<Vozilo>(rezervacija.VoziloId);

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
            Model = vozilo.Model;
            Marka = vozilo.Marka;
        }

        //public ICommand NazadCommand { get; set; }

        //public async Task Nazad()
        //{
        //    await Application.Current.MainPage.Navigation.PushModalAsync(new RezervacijaVozilaPage());
        //}
    }
}
