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

        int? VoziloID = null;
        double? VoziloCijena = null;
        public NapraviteUgovor(int? voziloId = null, double? voziloCijena = null)
        {
            InitializeComponent();
            BindingContext = VM = new NapraviteUgovorViewModel( voziloId, voziloCijena );
            VoziloID = voziloId;
            VoziloCijena = voziloCijena;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await VM.Init();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PrikazVozila());

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await VM.SaveChanges();

            //await Navigation.PushModalAsync(new NapraviRezervaciju());
            Application.Current.MainPage = new NapraviRezervaciju();

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Application.Current.MainPage = new StripePaymentGatwayPage();
        }
    }
}