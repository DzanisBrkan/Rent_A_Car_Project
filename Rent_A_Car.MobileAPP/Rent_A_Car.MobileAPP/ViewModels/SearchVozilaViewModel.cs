using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        private readonly APIService _specifikacijaService = new APIService("Specifikacija");


        public SearchVozilaViewModel()
        {
            InitCommad = new Command(async () => await Init());
            RecommendedCommand = new Command(async () => await Recommended());
        }
        public ObservableCollection<Model.Vozilo> VoziloList { get; set; } = new ObservableCollection<Model.Vozilo>();
        public ObservableCollection<Model.Vozilo> RecommendedVoziloList { get; set; } = new ObservableCollection<Model.Vozilo>();



        public ICommand InitCommad { get; set; }


        public string _searchTerm = string.Empty;
        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                SetProperty(ref _searchTerm, value);
                if (value != null)
                    InitCommad.Execute(null);
            }
        }

        public bool _SearchVisible = true;
        public bool SearchVisible
        {
            get { return _SearchVisible; }
            set { 
                SetProperty(ref _SearchVisible, value);
                RecommendedVisible = !_SearchVisible;
            }
        }


        public bool _RecommendedVisible = false;
        public bool RecommendedVisible
        {
            get { return _RecommendedVisible; }
            set { SetProperty(ref _RecommendedVisible, value); }
        }



        public async Task Init()
        {
            var list = await _voziloService.Get<IEnumerable<Model.Vozilo>>(null);


            VoziloList.Clear();
            foreach (var vozilo in list)
            {
                VoziloList.Add(vozilo);
            }
   

            if (!string.IsNullOrEmpty(SearchTerm))
            {
                VoziloList.Clear();
                var request = new VoziloSearchRequest()
                {
                    Model = _searchTerm.Trim(),
                    Marka = _searchTerm.Trim()
                };

                var vozila = await _voziloService.Get<IEnumerable<Model.Vozilo>>(request);


                foreach (var vozilo in vozila)
                {
                    VoziloList.Add(vozilo);
                   
                }
            }
        }

        public ICommand RecommendedCommand { get; set; }
        public async Task Recommended()
        {
            if(RecommendedVoziloList.Count == 0)
            {
                //var recVozila = await _voziloService.GetActionResponse<IEnumerable<Model.Vozilo>>($"Preporuka/{APIService.UserID}");


                //foreach (var vozilo in recVozila)
                //{
                //    RecommendedVoziloList.Add(vozilo);
                //}
            }

        }

    }
}
