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
    public partial class PocetnaPage : ContentPage
    {
        private PocetnaViewModel model = null;

        public PocetnaPage()
        {
            InitializeComponent();
            BindingContext = model = new PocetnaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

       



        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    //var Zahtjev = e.SelectedItem as Zahtjevi;
        //    //Navigation.PushAsync(new DodajZahtjevPage(Zahtjev));
        //}

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await model.Init();
        //}
    }
}