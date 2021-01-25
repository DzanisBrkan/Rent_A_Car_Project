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
    public partial class RegistracijaPage : ContentPage
    {
        private RegistracijaViewModel VM;
        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = VM = new RegistracijaViewModel();
        }

        private void LoginLabel_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await VM.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new LoginPage());

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());

        }
    }
}