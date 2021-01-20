using Rent_A_Car.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    class OcijenivanjeIKomentarisanjeViewModel : BaseViewModel
    {
        private readonly APIService _komentariIOcijeneService = new APIService("Ocjena");

        public OcijenivanjeIKomentarisanjeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            
        }

        public ObservableCollection<Ocjena> OcijeneList { get; set; } = new ObservableCollection<Ocjena>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _komentariIOcijeneService.Get<IEnumerable<Ocjena>>(null);

            OcijeneList.Clear();
            foreach (var ocijene in list)
            {
                OcijeneList.Add(ocijene);
            }
        }



       




    }
}
