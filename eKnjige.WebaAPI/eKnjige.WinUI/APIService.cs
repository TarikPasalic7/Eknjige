using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using eKnjige.Model;
namespace eKnjige.WinUI
{
   public class APIService
    {
        public static string username { get; set; }
    public static string password{ get; set; }
private string route = null;
        public APIService( string _route)
        {

            route = _route;


        }

        public async Task<T> get<T>(object search)
        {
           
            
            var url =  $"{Properties.Settings.Default.APIurl}/{route}";

            if(search != null)
            {
                url += "?";
                url += await search.ToQueryString();

            }
            var result = await url.WithBasicAuth(username,password).GetJsonAsync<T>();
            return result;
        }


        public async Task<T> getbyId<T>(object id)
        {


            var url = $"{Properties.Settings.Default.APIurl}/{route}/{id}";

           
            var result = await url.WithBasicAuth(username, password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {


            var url = $"{Properties.Settings.Default.APIurl}/{route}";

          
            
            var result = await url.WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<T> Update<T>(object id,object request)
        {


            var url = $"{Properties.Settings.Default.APIurl}/{route}/{id}";



            var result = await url.WithBasicAuth(username, password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
