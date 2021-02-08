using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Rent_A_Car.MobileAPP.Models;
using Rent_A_Car.MobileAPP.Views;
using Rent_A_Car.MobileAPP.ViewModels;
using Rent_A_Car.MobileAPP.Views.Klijent;
using Rent_A_Car.Model;

namespace Rent_A_Car.MobileAPP.Views
{
   
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        private SearchVozilaViewModel model = null;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = model = new SearchVozilaViewModel();
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Vozilo;
            await Navigation.PushAsync(new DetaljiVozilaPage((Vozilo)(e.SelectedItem))); 
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (model.ButtonTextPreporuceno == "Preporučena vozila")
            {
                model.ButtonTextPreporuceno = "Pretražite vozila";
            }
            else
                model.ButtonTextPreporuceno = "Preporučena vozila";
            model.SearchVisible = !model.SearchVisible;
            await model.Recommended();
        }
    }
}