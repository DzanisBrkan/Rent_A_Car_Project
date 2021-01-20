using Rent_A_Car.MobileAPP.ViewModels.Klijent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_Car.MobileAPP;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rent_A_Car.MobileAPP.Views.Klijent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistracijaPage : ContentPage
    {
        APIService service = new APIService("Klijent");
        private RegistracijaViewModel VM;
        

        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = VM = new RegistracijaViewModel();
        }

        private void LoginLabel_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await VM.Init();
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(imeEntry.text) || string.IsNullOrWhiteSpace(prezimeEntry.text))
        //    {
        //       await DisplayAlert("Unesite podatke", "Popunite podatke", "OK");
        //    }


        //    bool response = await service.RegisterUserAsynic(imeEntry, prezimeEntry, mailEntry, brojEntry, adresaEntry, datumRodjenjaEntry, brojEntry, korisnickoImeEntry);

        //    if (response)
        //    {
        //        await DisplayAlert("Alert", "Uspjesno ste se logirali", "OK");
        //        await Navigation.PushAsync(new LoginPage());
        //    }
        //    else
        //    {
        //        await DisplayAlert("Alert", "Username vec postoji!", "OK");

        //    }
        //}
    }
}