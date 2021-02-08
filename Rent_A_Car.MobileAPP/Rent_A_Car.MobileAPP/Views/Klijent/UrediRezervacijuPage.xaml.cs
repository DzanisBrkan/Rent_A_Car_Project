using Rent_A_Car.MobileAPP.ViewModels.Klijent;
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
    public partial class UrediRezervacijuPage : ContentPage
    {
        private UrediRezervacijuViewModel VM;
        public UrediRezervacijuPage(Rezervacija rezervacija)
        {
            InitializeComponent();
            BindingContext = VM = new UrediRezervacijuViewModel(rezervacija);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await VM.Init();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}