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
    public partial class NapraviteUgovor : ContentPage
    {
        private NapraviteUgovorViewModel VM;
        public NapraviteUgovor()
        {
            InitializeComponent();
            BindingContext = VM = new NapraviteUgovorViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PrikazVozila());

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await VM.Init();
            await Navigation.PushModalAsync(new NapraviRezervaciju());
        }
    }
}