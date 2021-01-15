using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    class OcijenivanjeIKomentarisanjeViewModel : BaseViewModel
    {
        string _komentar = string.Empty;
        public string Komentar
        {
            get { return _komentar; }
            set { SetProperty(ref _komentar, value); }
        }


        string _ocijena = string.Empty;
        public string Ocijena
        {
            get { return _ocijena; }
            set { SetProperty(ref _ocijena, value); }
        }
    }
}
