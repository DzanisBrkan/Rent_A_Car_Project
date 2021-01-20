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
    class RezervacijaVozilaViewModel : BaseViewModel
    {

        private readonly APIService _rezervacijeService = new APIService("Rezervacija");


        public RezervacijaVozilaViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }

        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _rezervacijeService.Get<IEnumerable<Rezervacija>>(null);

            RezervacijeList.Clear();
            foreach (var rezervacije in list)
            {
                RezervacijeList.Add(rezervacije);
            }
        }

    }
}
