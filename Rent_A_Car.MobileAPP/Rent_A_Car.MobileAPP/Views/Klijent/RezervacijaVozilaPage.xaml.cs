﻿using Rent_A_Car.MobileAPP.ViewModels.Klijent;
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UgovorPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new DojamPage();

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await model.SaveChanges();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Application.Current.MainPage = new StripePaymentGatwayPage();

        }
    }
}