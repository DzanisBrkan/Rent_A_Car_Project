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
        public UrediRezervacijuPage(string obj)
        {
            InitializeComponent();
            BindingContext = VM = new UrediRezervacijuViewModel(obj);
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
    }
}