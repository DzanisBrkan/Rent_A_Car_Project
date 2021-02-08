using Rent_A_Car.MobileAPP.ViewModels.Klijent;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rent_A_Car.MobileAPP.Views.Klijent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocirajVozilaPage : ContentPage
    {
        private readonly APIService _lociranjaServices = new APIService("Lociranja");

        private VoznjeDetaljiViewModel model = null;
        public LocirajVozilaPage()
        {
            InitializeComponent(/*Model.Vozilo vozilo*/);
            BindingContext = model = new VoznjeDetaljiViewModel()
            {
                //Vozilo = vozilo;

            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Provjera();




            // await model.Init();
        }
        public async void Provjera()
        {
            var list = await _lociranjaServices.Get<IEnumerable<Model.Lociranje>>(null);

            bool postojiadmin = false;
            bool postojiklijent = false;
            foreach (var lociranja in list)
            {

                if (lociranja.VoziloId == model.Vozilo.VoziloID && lociranja.Odogovoreno == false && lociranja.ZaposlenikId != null)
                {

                    postojiadmin = true;

                }
                else if (lociranja.VoziloId == model.Vozilo.VoziloID && lociranja.Odogovoreno == false && lociranja.KlijentId != null)
                {

                    postojiklijent = true;
                }
            }
            if (postojiadmin == true || postojiklijent == true)
            {
                Title.IsVisible = true;
                Prihvati.IsVisible = true;
                Odbij.IsVisible = true;
                Poruka.IsVisible = false;
                await model.Init();
            }
            else
            {
                Poruka.Text = "Nema zahtjeva na čekanju!";
                Title.IsVisible = false;
                Prihvati.IsVisible = false;
                Odbij.IsVisible = false;
                Poruka.IsVisible = true;
            }
        }
        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            //await this.model.Voznje;
        }
        public async void GetLocation()
        {
            var list = await _lociranjaServices.Get<IEnumerable<Lociranje>>(null);
            var lokid = 0;
            int? klijentid = null;
            int? adminid = null;
            bool postojiadmin = false;
            bool postojiklijent = false;
            foreach (var lociranja in list)
            {

                if (lociranja.VoziloId == model.Vozilo.VoziloID && lociranja.Odogovoreno == false && lociranja.ZaposlenikId != null)
                {
                    lokid = lociranja.LociranjeId;
                    adminid = lociranja.ZaposlenikId;
                    klijentid = null;
                    postojiadmin = true;

                }
                else if (lociranja.VoziloId == model.Vozilo.VoziloID && lociranja.Odogovoreno == false && lociranja.KlijentId != null)
                {
                    lokid = lociranja.LociranjeId;
                    klijentid = lociranja.KlijentId;
                    adminid = null;
                    postojiklijent = true;
                }

            }

            Location location = await Geolocation.GetLastKnownLocationAsync();
            if (location == null)
            {
                location = await Geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)

                }); ;
            }

            else
            {

                if (postojiklijent == true || postojiadmin == true)
                {


                    var request = new LociranjeUpsertRequest()
                    {
                        KlijentId = klijentid,
                        ZaposlenikId = adminid,
                        Lat = location.Latitude.ToString(),
                        Lng = location.Longitude.ToString(),
                        Odogovoreno = true,
                        Prihvaceno = true,
                        VoziloId = model.Vozilo.VoziloID


                    };

                    await _lociranjaServices.Update<Model.Lociranje>(lokid, request);
                    await Application.Current.MainPage.DisplayAlert("Obavjest", "Zahtjev je prihvaćen!", "OK");

                    //await Navigation.PushAsync(new AktivnaVoznjaPage(model.Voznje));

                }

                else
                {
                    //Title.IsVisible = false;
                    //Prihvati.IsVisible = false;
                    //Odbij.IsVisible = false;
                    //Poruka.Text = "Nema zahtjeva na čekanju!";
                    //Poruka.IsVisible = true;
                }
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            GetLocation();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var list = await _lociranjaServices.Get<IEnumerable<Lociranje>>(null);

            var lokid = 0;
            int? klijentid = null;
            int? adminid = null;
            foreach (var lociranja in list)
            {
                if (lociranja.VoziloId == model.Vozilo.VoziloID)
                {
                    lokid = lociranja.LociranjeId;
                    adminid = lociranja.ZaposlenikId;
                    klijentid = lociranja.KlijentId;
                }
            }
            var request = new LociranjeUpsertRequest()
            {

                KlijentId = klijentid,
                ZaposlenikId = adminid,
                Lat = "string",
                Lng = "string",
                Odogovoreno = true,
                Prihvaceno = false,
                VoziloId = model.Vozilo.VoziloID


            };

            await _lociranjaServices.Update<Model.Lociranje>(lokid, request);
            await Application.Current.MainPage.DisplayAlert("Obavjest", "Zahtjev je odbijen!", "OK");
            //await Navigation.PushAsync(new AktivnaVoznjaPage(model.Voznje));
        }
    }
}