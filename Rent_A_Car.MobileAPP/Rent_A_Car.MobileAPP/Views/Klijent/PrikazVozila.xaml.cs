﻿using Rent_A_Car.MobileAPP.ViewModels.Klijent;
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

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //APIService.UserVoziloID;
            /* APIService.UserVoziloID =((Vozilo)e.SelectedItem).VoziloID;*/
            await Navigation.PushAsync(new NapraviteUgovor(((Vozilo)e.SelectedItem).VoziloID, ((Vozilo)e.SelectedItem).CijenaPoSatu)); // kada vise puta udjem, app pukne 
            //Application.Current.MainPage = new NapraviteUgovor();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new DetaljiVozila());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetaljiVozilaSlikePage());
        }
    }
}