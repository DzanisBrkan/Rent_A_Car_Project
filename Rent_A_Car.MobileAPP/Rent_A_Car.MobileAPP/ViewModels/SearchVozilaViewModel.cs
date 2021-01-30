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

        public SearchVozilaViewModel()
        {
            InitCommad = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Vozilo> VoziloList { get; set; } = new ObservableCollection<Model.Vozilo>();

        //public IEnumerable<Vozilo> Vozila { get; set; }

        //komanda koja ucitava proizvode
        public ICommand InitCommad { get; set; }

        //public ICommand SearchCommad { get; set; } 

        //public string SearchVozilo
        //{
        //    get { return _SearchVozilo; }
        //    set
        //    {
        //        SetProperty(ref _SearchVozilo, value);
        //        if (value != null)
        //        {
        //            SearchData(value);
        //        }
        //    }
        //}



        //public async void SearchData(string search)
        //{
        //    //var varijabla = await _voziloService.GetActionResponse<IEnumerable<Vozilo>>("Search", search);

        //    if (!string.IsNullOrEmpty(search))
        //    {
        //        VoziloList.Clear();
        //        var request = new VoziloSearchRequest()
        //        {
        //            Model = search.Trim()
        //        };

        //        var vozila = await _voziloService.Get<IEnumerable<Model.Vozilo>>(request);

        //        foreach (var vozilo in vozila)
        //        {
        //            VoziloList.Add(vozilo);
        //        }
        //    }

        //    //VoziloList.Clear();
        //    //foreach (var vozilo in varijabla)
        //    //{
        //    //    VoziloList.Add(vozilo);
        //    //}
        //}




        //metoda koja ce imati poziv na api i ucitati listu proizvoda i popuniti VoziloList kolekciju
        //public async Task Init()
        //{

        //    var list = await _voziloService.Get<IEnumerable<Vozilo>>(null);

        //    Vozila = list;

        //    VoziloList.Clear();
        //    foreach (var vozilo in list)
        //    {
        //        VoziloList.Add(vozilo);
        //    }
        //}

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
    }
}
