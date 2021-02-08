using Acr.UserDialogs;
using Rent_A_Car.MobileAPP.Views;
using Rent_A_Car.Model;
using Rent_A_Car.Model.PaymentGatway;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

//using Acr.UserDialogs;
//using Nonco.Model.PaymentGatway;
//using Nonco.Views.InfoPage;
//using Prism.Commands;
//using Prism.Mvvm;
//using Prism.Navigation;
//using Stripe;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;
//using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP.ViewModels.Klijent
{
    public class PaymentGatwayPageViewModel : BaseViewModel
    //: BindableBase
    {
        //#region Variable

        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _rezervacijeService = new APIService("Rezervacija");


        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        private string Ime;
        private string Prezime;
        private string BrojTelefona;
        private string Email;
        private string Adresa;
        private string DatumRodjenja;
        private double UkupnaCijena;


        //#endregion Variable

        //#region Public Property



        private string StripeTestApiKey = "pk_test_51IEP1fEp1VDy0D0vQebZd8Nxfs1uKPbHMVSvPgh7wMi985vk9tdHwjk4HkDjonyFNm9FbEj1S6aFD41wSBIuZrHp00XMcuvrik";

        private string StripeSecreatApiKey = "sk_test_51IEP1fEp1VDy0D0vaNCmHHS1GaMVriKyulHFjHGg4QLS135U3acIR2MI5Tsb6lwPqbetxln70UPk21k8FwWVZfLy001i8hFNMg";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        //#endregion Public Property

        //#region Constructor

        public Rezervacija _rezervacija = null;
        public PaymentGatwayPageViewModel(Rezervacija rezervacija)
        {
            CreditCardModel = new CreditCardModel();
            _rezervacija = rezervacija;
            Title = "Card Details";
            SubmitCommand = new Command(async () => await DelegateCommand());
        }

        //#endregion Constructor

        //#region Command



        public ICommand SubmitCommand { get; set; }


        public async Task DelegateCommand()
        {
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async () =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransectionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gatway" + ex.Message);
            }
            finally
            {
                if (IsTransectionSuccess)
                {
                    Console.Write("Payment Gateway" + "Payment Successful ");

                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Uplata uspješno izvršena!","Notifikacija","Ok");
                    //Xamarin.Forms.Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
                    
                }
                else
                {

                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                    Console.Write("Payment Gateway" + "Payment Failure ");
                }
            }

        }

        //#endregion Command

        //#region Method

        public async Task GetKlijent()
        {
            var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            //ne treba jer smo primili gore
            //var RezervacijaModel = await _rezervacijeService.GetActionResponse($"GetRezByUserID/{APIService.UserID}");


            Ime = KlijentModel.Ime;
            Prezime = KlijentModel.Prezime;
            BrojTelefona = KlijentModel.BrojTel;
            Email = KlijentModel.Email;
            Adresa = KlijentModel.Adresa;
            DatumRodjenja = KlijentModel.DatumRodjenja;
            UkupnaCijena = _rezervacija.UkupnaCijena;
        }


        private string CreateToken()
        {

            try
            {
                StripeConfiguration.SetApiKey(StripeTestApiKey);
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = Ime + " " + Prezime,
                        AddressLine1 = Email,
                        AddressLine2 = BrojTelefona,
                        AddressCity = Adresa,
                        AddressZip = "284005",
                        AddressState = "BiH",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "inr",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeSecreatApiKey);
                var options = new ChargeCreateOptions
                {
                    //Amount = (long)float.Parse("20000"),
                    Amount = ((int)(UkupnaCijena * 100)),
                    Currency = "bam",
                    Description = "Charge for Jon.rosen@example.com",
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "Rent_A_Car@gmail.com",
                    
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
            }
            return true;
        }

        //#endregion Method


    }

}
