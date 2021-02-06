using LaavorRatingConception;
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
    public partial class OcjenjivanjePage : ContentPage
    {
        OcjenjivanjeViewModel model = null;
        public OcjenjivanjePage(string obj)
        {
            InitializeComponent();
            BindingContext = model = new OcjenjivanjeViewModel(obj);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await model.Ocjeni();
            Application.Current.MainPage = new MainPage();
        }

        private void ratingStar_Voted(object sender, EventArgs e)
        {
            RatingConception rating = (RatingConception)sender;
            int index = rating.IndexVoted;
            int value = rating.Value;

            index_star.Text = index.ToString();
            value_star.Text = value.ToString();

            rating.InitialValue = 1;
            model.Ocjena = value;
        }

    }
}