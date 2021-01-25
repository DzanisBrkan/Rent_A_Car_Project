using Rent_A_Car.MobileAPP.Views;
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
    public class DojamViewModel : BaseViewModel
    {
        private readonly APIService _komentariIOcijeneService = new APIService("Ocjena");

        public DojamViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }


        //string _komentar = string.Empty;
        //public string Komentar
        //{
        //    get { return _komentar; }
        //    set { SetProperty(ref _komentar, value); }
        //}


        //string _ocijena = string.Empty;
        //public string Ocijena
        //{
        //    get { return _ocijena; }
        //    set { SetProperty(ref _ocijena, value); }
        //}

        public string _Komentar { get; set; } = null;
        public string _Ocjena { get; set; } = null;


        public ObservableCollection<Ocjena> OcijeneList { get; set; } = new ObservableCollection<Ocjena>();

        public ICommand InitCommand { get; set; }

        //public async Task Init()
        //{
        //    var list = await _komentariIOcijeneService.Get<IEnumerable<Ocjena>>(null);

        //    OcijeneList.Clear();
        //    foreach (var ocijene in list)
        //    {
        //        OcijeneList.Add(ocijene);
        //    }
        //}


        public async Task Init()
        {


            try
            {




                if (string.IsNullOrWhiteSpace(_Komentar))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti komentar", "Ok");
                    return;


                }

                if (string.IsNullOrWhiteSpace(_Ocjena))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti ocjenu", "Ok");
                    return;


                }





                var request = new OcijenaInsertRequest()
                {
                    Ocjena = _Ocjena,
                    Komentar = _Komentar

                };


                var modelDojam = _komentariIOcijeneService.Insert<Model.Ocjena>(request);


                if (modelDojam != null)
                {
                    if (modelDojam.Status.ToString() != "Faulted")
                    {
                        await Application.Current.MainPage.DisplayAlert("Notifikacija", "Uspješno ste ostavili dojam.", "Ok");
                        await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
                    }
                    //await Application.Current.MainPage.DisplayAlert("Error.", "Doslo je do greske.", "Ok");
                }


            }
            catch (Exception ex)
            {

                throw;
            }



        }


    }
}
