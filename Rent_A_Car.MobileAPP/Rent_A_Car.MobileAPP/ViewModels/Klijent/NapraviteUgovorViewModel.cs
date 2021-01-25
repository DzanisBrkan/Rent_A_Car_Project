using Rent_A_Car.MobileAPP.Views.Klijent;
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
    public class NapraviteUgovorViewModel 
    {
        private readonly APIService _UgovorService = new APIService("Ugovor");


        public NapraviteUgovorViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }


        public string _Datum { get; set; }
        public string _UkupnaCijena { get; set; }
        public string _UkupnaKolicina { get; set; }
        public string _NacinPlacanja { get; set; }
        public string _Placen { get; set; }



        public ObservableCollection<Ugovor> UgovorList { get; set; } = new ObservableCollection<Ugovor>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            try
            {




                if (string.IsNullOrWhiteSpace(_Datum))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti datum", "Ok");
                    return;


                }

                if (string.IsNullOrWhiteSpace(_UkupnaCijena))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti cjenu", "Ok");
                    return;


                }

                if (string.IsNullOrWhiteSpace(_UkupnaKolicina))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti kolicinu", "Ok");
                    return;


                }
                if (string.IsNullOrWhiteSpace(_NacinPlacanja))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti nacin placanja", "Ok");
                    return;


                }

                if (string.IsNullOrWhiteSpace(_Placen))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Da li je placen?", "Ok");
                    return;


                }




                var request = new UgovorUpsertRequest()
                {
                    Datum = _Datum,
                    UkupnaCijena = _UkupnaCijena,
                    UkupnaKolicina = _UkupnaKolicina,
                    NacinPlacanjaId = _NacinPlacanja,
                    Placen = _Placen

                };


                var modelDojam = _UgovorService.Insert<Model.Ugovor>(request);


                if (modelDojam != null)
                {
                    if (modelDojam.Status.ToString() != "Faulted")
                    {
                        await Application.Current.MainPage.DisplayAlert("Notifikacija", "Uspješno ste kreirali ugovor.", "Ok");
                        await Application.Current.MainPage.Navigation.PushModalAsync(new NapraviRezervaciju());
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
