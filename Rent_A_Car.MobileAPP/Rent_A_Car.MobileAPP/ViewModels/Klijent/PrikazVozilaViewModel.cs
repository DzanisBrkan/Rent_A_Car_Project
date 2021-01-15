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
    public class PrikazVozilaViewModel
    {
        //private readonly APIService _vozilaService = new APIService("Vozilo"); 
        public PrikazVozilaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }



        public ObservableCollection<Vozilo> VozilaList { get; set; } = new ObservableCollection<Vozilo>();

        public ICommand InitCommand { get; set; }


        public async Task Init()
        {
            //var list = await _vozilaService.Get<IEnumerable<Vozilo>>(null);


            //VozilaList.Clear();
            //foreach (var vozilo in list)
            //{
            //    VozilaList.Add(vozilo);
            //}
        }

    }
}
