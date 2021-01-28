using Rent_A_Car.Model;
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



        public RezervacijaVozilaViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }

        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();
        public ObservableCollection<Rezervacija> _PronadjenaRezervacijaService { get; set; } = new ObservableCollection<Rezervacija>();

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
    }
}
