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
    public class DojamZahtjevViewModel : BaseViewModel
    {
        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _voziloService = new APIService("Vozilo");
        private readonly APIService _dojamZahtjevService = new APIService("DojmoviZahtjevi");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");

        public DojamZahtjevViewModel()
        {
            InitCommand = new Command(async () => await Init());
            OstaviCommand = new Command(async () => await Ostavi());
        }
        string _Zahtjev = string.Empty;
        public string EntryZahtjev
        {
            get { return _Zahtjev; }
            set { SetProperty(ref _Zahtjev, value); }
        }

        string _Dojam = string.Empty;
        public string EntryDojam
        {
            get { return _Dojam; }
            set { SetProperty(ref _Dojam, value); }
        }


        public ObservableCollection<Model.DojmoviZahtjevi> _PronadjeniDojmoviZahtjevi { get; set; } = new ObservableCollection<Model.DojmoviZahtjevi>();
        public ObservableCollection<Model.DojmoviZahtjevi> DojmoviZahtjeviList { get; set; } = new ObservableCollection<Model.DojmoviZahtjevi>();

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _dojamZahtjevService.Get<IEnumerable<DojmoviZahtjevi>>(null);
            var rezervacija = await _rezervacijaService.GetActionResponse<Rezervacija>($"GetRezByUserID/{APIService.UserID}");

            DojmoviZahtjeviList.Clear();
            _PronadjeniDojmoviZahtjevi.Clear();
            foreach (var dojam in list)
            {
                DojmoviZahtjeviList.Add(dojam);
            }

            for (int i = 0; i < DojmoviZahtjeviList.Count; i++)
            {
                if (DojmoviZahtjeviList[i].KlijentId == APIService.UserID && DojmoviZahtjeviList[i].RezervacijaId == rezervacija.RezervacijaID)
                {
                    if (DojmoviZahtjeviList[i].ZaposlenikId != null)
                        DojmoviZahtjeviList[i].visible = true;
                    _PronadjeniDojmoviZahtjevi.Add(DojmoviZahtjeviList[i]);
                }
            }

        }


        public ICommand OstaviCommand { get; set; }
        public async Task Ostavi()
        {
            if (EntryZahtjev == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Unesite naziv zahtjeva!", "Ok");
                return;
            }
            if (EntryDojam == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Unesite dojam!", "Ok");
                return;
            }

            var klijent = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            var rezervacija = await _rezervacijaService.GetActionResponse<Rezervacija>($"GetRezByUserID/{APIService.UserID}");

            var request = new DojmoviZahtjeviUpsertRequest()
            {
                KlijentId = klijent.KlijentId,
                KlijentKorisnickoIme = klijent.KorisnickoIme,
                KlijentSlikaThumb = klijent.SlikaThumb,
                Dojam = EntryDojam,
                NazivZahtjeva = EntryZahtjev,
                RezervacijaId = rezervacija.RezervacijaID
                
            };

            var ugovorResponse = await _dojamZahtjevService.Insert<Model.DojmoviZahtjevi>(request);
            if (ugovorResponse != null)
            {
                await Application.Current.MainPage.DisplayAlert("Notifikacija", "Postavljanje uspješno!", "Ok");

            }
        }

    }
}
