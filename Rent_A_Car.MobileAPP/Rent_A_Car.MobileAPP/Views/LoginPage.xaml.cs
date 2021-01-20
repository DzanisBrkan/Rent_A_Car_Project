using Rent_A_Car.MobileAPP.ViewModels;
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
            //DRUGI NACIN POVEZIVANJA NA VIEW MODEL
            //BindingContext = new LoginViewModel();//ako ovako spojimo vm sa vjuom izgubit cemo inteli sense

        }

        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}