using Rent_A_Car.MobileAPP.ViewModels.Klijent;
using Rent_A_Car.MobileAPP.Views.Klijent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rent_A_Car.MobileAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrikazVozila : ContentPage
    {
        PrikazVozilaViewModel model = null;

        public PrikazVozila()
        {
            InitializeComponent();
            BindingContext = model = new PrikazVozilaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
           await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new UgovorPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetaljiVozilaPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}