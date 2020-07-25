using eKnjige.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EKnjige.MobileApp
{
    public class APIService
    {
        public static Klijent PrijavljeniKorisnik { get; set; }
        public static string username { get; set; }
        public static string password { get; set; }
        public static string passwors{ get; set; }


        private readonly string route ;

#if DEBUG

        string _apiURL = "http://localhost:58998/api";
#endif
#if RELEASE

          string _apiURL = "https://website.com/api";
#endif
        public APIService(string _route)
        {

            route = _route;


        }

        public async Task<T> get<T>(object search)
        {


            var url = $"{_apiURL}/{route}";

            //try
            //{
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();

                }
                var result = await url.WithBasicAuth(username, password).GetJsonAsync<T>();
                return result;
            //}
            //catch(FlurlHttpException ex)
            //{
                //if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                //{
                //   await  Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                //}


            //}

         
        }


        public async Task<T> getbyId<T>(object id)
        {


            var url = $"{_apiURL}/{route}/{id}";


            var result = await url.WithBasicAuth(username, password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {


            var url = $"{_apiURL}/{route}";



            var result = await url.WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<T> Update<T>(object id, object request)
        {


            var url = $"{_apiURL}/{route}/{id}";



            var result = await url.WithBasicAuth(username, password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }

}

