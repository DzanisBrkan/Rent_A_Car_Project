using Rent_A_Car.MobileAPP.ViewModels.Klijent;
using Rent_A_Car.Model;
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
    public partial class DetaljiVozilaPage : ContentPage
    {
        private DetaljiVozilaViewModel model = null;

        public DetaljiVozilaPage(Vozilo vozilo)
        {
            InitializeComponent();
            BindingContext = model = new DetaljiVozilaViewModel(vozilo);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    //await Navigation.PushAsync(new DetaljiVozilaSlikePage(null));
        //}

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetaljiVozilaSlikePage((Vozilo)(e.SelectedItem)));
        }
    }
}