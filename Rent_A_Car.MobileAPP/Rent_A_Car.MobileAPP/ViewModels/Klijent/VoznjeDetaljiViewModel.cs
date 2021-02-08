using Rent_A_Car.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    public class VoznjeDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _lociranjaServices = new APIService("Lociranja");
        public VoznjeDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public Vozilo Vozilo { get; set; }

        private Model.Lociranje _lociranja;
        public Model.Lociranje Lociranja
        {
            get { return _lociranja; }
            set { SetProperty(ref _lociranja, value); }
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {


            var lociranjaList = await _lociranjaServices.Get<IEnumerable<Model.Lociranje>>(null);
            foreach (var lok in lociranjaList)
            {
                if (lok.VoziloId == Vozilo.VoziloID && lok.KlijentId != 0 && lok.Odogovoreno == false)
                    Lociranja = lok;
                else if (lok.VoziloId == Vozilo.VoziloID && lok.ZaposlenikId != 0 && lok.Odogovoreno == false)
                    Lociranja = lok;
            }


        }
    }
}
