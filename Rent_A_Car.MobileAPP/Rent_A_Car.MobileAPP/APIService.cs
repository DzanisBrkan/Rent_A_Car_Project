//using Rent_A_Car.Model;
using Flurl.Http;
using Flurl;
using Rent_A_Car.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;

namespace Rent_A_Car.MobileAPP
{
    public class APIService
    {

        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _route = null;

        public static Model.Klijent LogovaniKlijent { get; set; }


#if DEBUG
        private string _apiUrl = "http://localhost:57723/api"; 
#endif
#if RELEASE
        private string _apiUrl = "https://mywebsite.com/api";
#endif

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                //implementacija autentifikacije
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();


            }
            catch (FlurlHttpException ex)
            {
                if (ex != null)
                    //if (ex.StatusCode.ToString() == System.Net.HttpStatusCode.Unauthorized.ToString())
                    if(ex.Call.HttpResponseMessage.RequestMessage.ToString() == System.Net.HttpStatusCode.Unauthorized.ToString())
                    {

                        await Application.Current.MainPage.DisplayAlert("Greska", "Niste autentificirani", "OK");

                    }
                else if (ex.Call.HttpResponseMessage.RequestMessage.ToString() == "401")
                    {

                        await Application.Current.MainPage.DisplayAlert("Greska", "Niste autentificirani", "OK");

                    }
                throw;
            }
        }

        // GET BY ID PREMA SERVERU -----------------------
        public async Task<T> GetById<T>(object id)
        {

            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

        }

        // INSERT PREMA SERVERU -----------------------
        public async Task<T> Insert<T>(object request)
        {

            var url = $"{_apiUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                //MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await Application.Current.MainPage.DisplayAlert("Greska", "Niste autentificirani", "OK");
                return default(T);
            }


        }


        // UPDATE PREMA SERVERU -----------------------
        public async Task<T> Update<T>(object id, object request)
        {

            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                //MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");

                return default(T);
            }
        }
    }



}

