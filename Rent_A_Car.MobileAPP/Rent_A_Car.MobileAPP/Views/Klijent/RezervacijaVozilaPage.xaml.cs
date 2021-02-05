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
    public partial class RezervacijaVozilaPage : ContentPage
    {
        RezervacijaVozilaViewModel model = null;
        public RezervacijaVozilaPage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaVozilaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }




        //private void Button_Clicked_2(object sender, EventArgs e)
        //{
        //    Application.Current.MainPage = new KreirajRacunPage();
        //}

    }
}