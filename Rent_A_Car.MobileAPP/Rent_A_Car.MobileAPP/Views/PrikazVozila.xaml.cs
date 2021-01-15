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
    }
}