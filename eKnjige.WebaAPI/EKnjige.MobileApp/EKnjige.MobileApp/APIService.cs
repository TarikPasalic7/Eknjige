﻿using eKnjige.Model;
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

        public async Task<T> get<T>(object search, string actionName = "")
        {


            var url = $"{_apiURL}/{route}";

            if (actionName != null)
            {
                url += "/";
                url += actionName;
            }

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();

            }
           
            if (route == "Grad" || route == "Spol")
            {
                return await url.GetJsonAsync<T>();
            }
            return await url.WithBasicAuth(username, password).GetJsonAsync<T>();

        }


        public async Task<T> getbyId<T>(object id)
        {


            var url = $"{_apiURL}/{route}/{id}";
            T result ;
          
            result = await url.WithBasicAuth(username, password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {


           
            var url = $"{_apiURL}/{route}";

            if(route=="Klijenti")
            {
                return  await url.PostJsonAsync(request).ReceiveJson<T>();
            }

          return  await url.WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();
            
        }

        public async Task<T> Update<T>(object id, object request)
        {


            var url = $"{_apiURL}/{route}/{id}";



            var result = await url.WithBasicAuth(username, password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<bool> Remove(int id, string actionName = null)
        {
            var url = $"{_apiURL}/{route}";

            if (actionName != null)
                url += "/" + actionName;

            url += "/" + id;

            return await url.WithBasicAuth(username, password).DeleteAsync().ReceiveJson<bool>();
        }

    }

}

