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
    public class PrikazVozilaViewModel : BaseViewModel
    {
        private readonly APIService _vozilaService = new APIService("Vozilo");
        private readonly APIService _tipVozilaService = new APIService("Tip");

        public PrikazVozilaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            DetaljiVozilaCommand = new Command(async () => await Detalji());
        }



        public ObservableCollection<Vozilo> VozilaList { get; set; } = new ObservableCollection<Vozilo>();
        public ObservableCollection<Tip> TipVozila { get; set; } = new ObservableCollection<Tip>();

        Tip _selectedTipVozila = null;
        public Tip SelectedTipVozila
        {
            get { return _selectedTipVozila; }
            set
            {
                SetProperty(ref _selectedTipVozila, value);
                if (value != null)
                {
                    InitCommand.Execute(null);

                }
            }
        }


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (TipVozila.Count == 0)
            {
                var tipVozilaList = await _tipVozilaService.Get<List<Tip>>(null);

                foreach (var tipVozila in tipVozilaList)
                {
                    TipVozila.Add(tipVozila);
                }
            }

            if (SelectedTipVozila != null)
            {
                VoziloSearchRequest search = new VoziloSearchRequest();
                search.TipId = SelectedTipVozila.TipId;

                var list = await _vozilaService.Get<IEnumerable<Vozilo>>(search);

                //Promiojenjeno VoziloServices

                int brojac = 0;
                VozilaList.Clear();
                foreach (var vozilo in list)
                {
                    if (list.ElementAt(brojac).Zauzeto != true)
                    {
                        VozilaList.Add(vozilo);

                    }
                    brojac++;

                }

            }
            else
            {
                var list = await _vozilaService.Get<IEnumerable<Vozilo>>(null);

                int brojac = 0;
                VozilaList.Clear();
                foreach (var vozilo in list)
                {

                    if (list.ElementAt(brojac).Zauzeto != true)
                    {
                        VozilaList.Add(vozilo);
                    }
                    brojac++;

                }
            }
        }

        public ICommand DetaljiVozilaCommand { get; set; }

        public async Task Detalji()
        {
            IsBusy = true;
            //DetaljiVozilaCommand.Execute(null);
            await _vozilaService.Get<dynamic>(null);
            //Application.Current.MainPage = new DetaljiVozila();

        }
    }
}
