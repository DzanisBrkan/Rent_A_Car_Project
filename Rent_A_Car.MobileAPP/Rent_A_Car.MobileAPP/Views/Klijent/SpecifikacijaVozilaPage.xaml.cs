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
    public partial class SpecifikacijaVozilaPage : ContentPage
    {
        private readonly APIService _voziloService = new APIService("Vozilo");
        private SpecifikacijaVozilaViewModel model = null;
        public SpecifikacijaVozilaPage(int voziloId)
        {
            InitializeComponent();
            BindingContext = model = new SpecifikacijaVozilaViewModel(voziloId);
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }


        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();

        }
    }
}