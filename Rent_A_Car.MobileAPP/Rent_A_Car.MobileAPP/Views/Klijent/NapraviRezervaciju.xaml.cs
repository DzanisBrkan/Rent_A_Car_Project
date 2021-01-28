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
            await VM.Init();


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new NapraviteUgovor());
            Application.Current.MainPage = new NapraviteUgovor();


        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await VM.SaveChanges();
            //await Navigation.PushModalAsync(new MainPage()); // poslije ove await pukne app
            Application.Current.MainPage = new MainPage();

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            //Application.Current.MainPage = new StripePaymentGatwayPage();

        }
    }
}