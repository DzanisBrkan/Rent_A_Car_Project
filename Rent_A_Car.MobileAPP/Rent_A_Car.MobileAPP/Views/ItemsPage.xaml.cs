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

namespace Rent_A_Car.MobileAPP.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        //ItemsViewModel viewModel;
        private SearchVozilaViewModel model = null;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = model = new SearchVozilaViewModel();
            //BindingContext = viewModel = new ItemsViewModel();
        }

        //async void OnItemSelected(object sender, EventArgs args)
        //{
        //    var layout = (BindableObject)sender;
        //    var item = (Item)layout.BindingContext;
        //    await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
        //}
        //async void AddItem_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        //}
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    if (viewModel.Items.Count == 0)
        //        viewModel.IsBusy = true;
        //}


        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

    }
}