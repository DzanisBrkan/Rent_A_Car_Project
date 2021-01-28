//using Rent_A_Car.Model;
using Flurl.Http;
using Flurl;
using Rent_A_Car.Model;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace Rent_A_Car.MobileAPP
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        public static int UserID { get; set; }
        public static int UserRacunID { get; set; }
        public static int UserVoziloID { get; set; }
        public static int CijenaVozila { get; set; }

        public static Model.Klijent LogovaniKlijent { get; set; }

        private readonly string _route = null;

        //#endif
        //#if RELEASE 
        //            private string _apiUrl = "https://mywebsite.com/api";


        //    public async Task<T> Get<T>(object search)
        //    {

        //        var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

        //        if (search != null)
        //        {
        //            url += "?";
        //            url += await search.ToQueryString();
        //        }

        //        return await url.GetJsonAsync<T>();
        //    }

        //    // GET BY ID PREMA SERVERU -----------------------
        //    public async Task<T> GetById<T>(object id)
        //    {

        //        var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

        //        return await url.GetJsonAsync<T>();

        //    }

        //    // INSERT PREMA SERVERU -----------------------
        //    public async Task<T> Insert<T>(object request)
        //    {

        //        var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

        //        return await url.PostJsonAsync(request).ReceiveJson<T>();

        //    }


        //    // UPDATE PREMA SERVERU -----------------------
        //    public async Task<T> Update<T>(object id, object request)
        //    {

        //        var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

        //        return await url.PutJsonAsync(request).ReceiveJson<T>();
        //    }


        //    public async Task<T> Get(object search)
        //     {
        //         var url = $"{_apiUrl}/{_route}";


        //     }
        //}

    }



}

