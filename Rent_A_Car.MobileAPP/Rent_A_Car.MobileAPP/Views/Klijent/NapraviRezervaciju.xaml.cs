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
    public partial class NapraviRezervaciju : ContentPage
    {
        private NapravitiRezervacijuViewModel VM;
        public NapraviRezervaciju()
        {
            InitializeComponent();
            BindingContext = VM = new NapravitiRezervacijuViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NapraviteUgovor());

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await VM.Init();
            await Navigation.PushModalAsync(new MainPage());
        }

    }
}