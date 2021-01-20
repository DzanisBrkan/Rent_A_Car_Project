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
    public partial class DojamPage : ContentPage
    {
        DojamViewModel model = null;


        public DojamPage()
        {
            InitializeComponent();
            BindingContext = model = new DojamViewModel();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //await model.Init();
        }
    }
}