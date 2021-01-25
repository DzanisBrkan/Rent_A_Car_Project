using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rent_A_Car.MobileAPP.Services;
using Rent_A_Car.MobileAPP.Views;
using Rent_A_Car.MobileAPP.Views.Klijent;

namespace Rent_A_Car.MobileAPP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new MainPage();

            MainPage = new LoginPage();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
