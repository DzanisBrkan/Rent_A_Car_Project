using Rent_A_Car.MobileAPP.ViewModels;
using Rent_A_Car.MobileAPP.ViewModels.Klijent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rent_A_Car.MobileAPP.Views.Klijent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KorisnickiPodaci : ContentPage
    {
        KorisnickiPodaciViewModel model = null;
        public KorisnickiPodaci()
        {
            InitializeComponent();
            BindingContext = model = new KorisnickiPodaciViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //await Navigation.PushAsync(new LoginPage());
            //Application.Current.MainPage = new LoginPage();
        }
    }
}