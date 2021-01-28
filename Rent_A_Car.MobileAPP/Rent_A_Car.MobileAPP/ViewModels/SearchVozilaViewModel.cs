using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels
{
    public class SearchVozilaViewModel : BaseViewModel
    {
        //servis
        private readonly APIService _voziloService = new APIService("Vozilo");
        private readonly APIService _voziloTip = new APIService("Tip");

        public SearchVozilaViewModel()
        {
            InitCommad = new Command(async () => await Init());
        }
        public ObservableCollection<Vozilo> VoziloList { get; set; } = new ObservableCollection<Vozilo>();
        public ObservableCollection<Tip> TipList { get; set; } = new ObservableCollection<Tip>();


        //properti za opadajucu listu picker
        Tip _SelectedTipVozila = null;
        public Tip SelectedTipVozila
        {
            get { return _SelectedTipVozila; }
            set { SetProperty(ref _SelectedTipVozila, value);
                if(value != null)
                {
                    InitCommad.Execute(null);
                }
            }
        }

        //komanda koja ucitava proizvode
        public ICommand InitCommad { get; set; }

        //metoda koja ce imati poziv na api i ucitati listu proizvoda i popuniti VoziloList kolekciju
        public async Task Init()
        {
            if(TipList.Count == 0)
            {
                var tipList = await _voziloTip.Get<List<Tip>>(null);

                foreach (var tip in tipList)
                {
                    TipList.Add(tip);
                }
            }
            
            if(SelectedTipVozila != null)
            {
                VoziloSearchRequest search = new VoziloSearchRequest();
                search.TipId = SelectedTipVozila.TipId;

                //ja treba da proslijedim text umjesto nulla
                var list = await _voziloService.Get<IEnumerable<Vozilo>>(search);

                VoziloList.Clear();
                foreach (var vozilo in list)
                {
                    VoziloList.Add(vozilo);
                }
            }
            else
            {
                var list = await _voziloService.Get<IEnumerable<Vozilo>>(null);

                VoziloList.Clear();
                foreach (var vozilo in list)
                {
                    VoziloList.Add(vozilo);
                }
            }

           
        }
    }
}
