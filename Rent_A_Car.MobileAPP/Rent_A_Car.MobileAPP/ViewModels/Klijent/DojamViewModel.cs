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
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");


        public DojamViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }


        string _Komentar = string.Empty;
        public string Komentarr
        {
            get { return _Komentar; }
            set { SetProperty(ref _Komentar, value); }
        }


        int _Ocjena = 0;
        public int Ocjenaa
        {
            get { return _Ocjena; }
            set { SetProperty(ref _Ocjena, value); }
        }

        //public string _Komentar { get; set; } = null;
        //public string _Ocjena { get; set; } = null;


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




                if (string.IsNullOrWhiteSpace(Komentarr))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti komentar", "Ok");
                    return;


                }

                if (Ocjenaa < 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti ocjenu", "Ok");
                    return;


                }





                var request = new OcjenaUpsertRequest()
                {
                    Ocjena1 = Ocjenaa,
                    Komentar = Komentarr,
                    RezervacijaId = 3

                };


                var modelDojam = _komentariIOcijeneService.Insert<Model.Ocjena>(request);


                
                    
                        await Application.Current.MainPage.DisplayAlert("Notifikacija", "Uspješno ste ostavili dojam.", "Ok");
                        //await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
                   
               


            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Doslo je do greske!.", "Ok");

                throw;
            }



        }


    }
}
