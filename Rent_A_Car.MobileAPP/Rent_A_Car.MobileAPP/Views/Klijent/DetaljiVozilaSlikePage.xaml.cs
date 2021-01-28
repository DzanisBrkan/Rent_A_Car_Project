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
<<<<<<< HEAD:Rent_A_Car.MobileAPP/Rent_A_Car.MobileAPP/Views/Klijent/UgovorPage.xaml.cs
    public partial class UgovorPage : ContentPage
    {
         UgovorViewModel model = null;
        public UgovorPage()
        {
            InitializeComponent();
            BindingContext = model = new UgovorViewModel();

=======
    public partial class DetaljiVozilaSlikePage : ContentPage
    {
        private DetaljiVozilaViewModel model = null;
        public DetaljiVozilaSlikePage()
        {
            InitializeComponent();
            BindingContext = model = new DetaljiVozilaViewModel();
>>>>>>> backup_login:Rent_A_Car.MobileAPP/Rent_A_Car.MobileAPP/Views/Klijent/DetaljiVozilaSlikePage.xaml.cs
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}