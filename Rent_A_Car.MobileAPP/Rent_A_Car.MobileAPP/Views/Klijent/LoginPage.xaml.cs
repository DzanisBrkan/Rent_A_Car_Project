using Rent_A_Car.MobileAPP.ViewModels;
using Rent_A_Car.MobileAPP.Views.Klijent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rent_A_Car.MobileAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //BindingContext = new LoginViewModel();//ako ovako spojimo vm sa vjuom izgubit cemo inteli sense

        }

        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // ----------------JEROVATNO KADA KLIKNE DA SE REGISTRUJE PA GA ODVEDE NA REGISTRACIJSKI PAGE
        //-----------------------------------------------------------------------------------------------

        private void RegisterLabel_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegistracijaPage();
            //await Navigation.PushAsync(new RegistracijaPage()); // ovo ima back tipku
                                                                  // ali ne moze jer udje u loop i pukne

        }

    }
}