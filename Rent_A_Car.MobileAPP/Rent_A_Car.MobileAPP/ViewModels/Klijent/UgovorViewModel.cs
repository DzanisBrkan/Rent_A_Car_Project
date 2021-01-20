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
    class UgovorViewModel
    {
        private readonly APIService _UgovorService = new APIService("Racun");


        public UgovorViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }


        public ObservableCollection<Racun> UgovorList { get; set; } = new ObservableCollection<Racun>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _UgovorService.Get<IEnumerable<Racun>>(null);

            UgovorList.Clear();
            foreach (var ugovor in list)
            {
                UgovorList.Add(ugovor);
            }
        }
    }
}
