//using Rent_A_Car.Model;
using Flurl.Http;
using Rent_A_Car.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Rent_A_Car.MobileAPP
{
    public class APIService
    {


        //        public class APIService 
        //        {

        //#if DEBUG
        //            private string _apiUrl = "http://localhost:57723/api";

        //#endif
        //#if RELEASE 
        //            private string _apiUrl = "https://mywebsite.com/api";

        //#endif
        //    private readonly string _route = null;
        //    public APIService(string route)
        //    {
        //        _route = route;
        //    }

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

        //        try
        //        {
        //            if(search != null)
        //            {
        //                url += "?";
        //                url += await search.ToQueryString();
        //            }
        //        }
        //        catch(FlurlHttpException)
        //        {
        //            if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
        //            {
        //               await Application.Current.MainPage.DisplayAlert("Greska", "Niste autentificirani", "OK");
        //            }
        //            throw;
        //        }

        //     }
        //}

    }
}
