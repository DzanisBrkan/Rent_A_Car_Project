using GalaSoft.MvvmLight.Command;
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
    public class ZavrsenaRezervacijaViewModel : BaseViewModel
    {
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _UgovorService = new APIService("Ugovor");
        private readonly APIService _voziloService = new APIService("Vozilo");

        public ZavrsenaRezervacijaViewModel()
        {
            InitCommand = new Command(async () => await Init());

            OcjeniCommand = new RelayCommand<string>(async (sender) => await Ocjeni(sender));

        }

        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();
        public ObservableCollection<Rezervacija> _PronadjenaRezervacijaService { get; set; } = new ObservableCollection<Rezervacija>();
        public Rezervacija PronadjenaRezervacija { get; set; } = new Rezervacija();

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
                if (RezervacijeList[i].KlijentId == APIService.UserID && RezervacijeList[i].Status == "Zavrseno")
                {
                    _PronadjenaRezervacijaService.Add(RezervacijeList[i]);
                    var vozilo = await _voziloService.GetById<Vozilo>(RezervacijeList[i].VoziloId);
                }
            }

        }


        public RelayCommand<string> OcjeniCommand { get; set; }
        public async Task Ocjeni(string sender)
        {
            //Application.Current.MainPage = new OcijenivanjeIKomentarisanje(sender);
            Application.Current.MainPage = new OcjenjivanjePage(sender);
        }
    }
}
