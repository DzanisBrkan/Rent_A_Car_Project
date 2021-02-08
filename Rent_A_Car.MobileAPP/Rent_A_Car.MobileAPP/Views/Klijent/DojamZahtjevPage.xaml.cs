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
    public partial class DojamZahtjevPage : ContentPage
    {
        DojamZahtjevViewModel model = null;

        public DojamZahtjevPage()
        {
            InitializeComponent();
            BindingContext = model = new DojamZahtjevViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await model.Ostavi();
        }
    }
}