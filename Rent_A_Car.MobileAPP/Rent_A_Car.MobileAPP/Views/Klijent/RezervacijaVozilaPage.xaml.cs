using Rent_A_Car.MobileAPP.ViewModels.Klijent;
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


    }
}