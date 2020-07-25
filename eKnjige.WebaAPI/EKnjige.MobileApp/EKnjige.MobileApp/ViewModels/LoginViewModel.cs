using eKnjige.Model;
using EKnjige.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Windows.Input;
using Xamarin.Forms;

namespace EKnjige.MobileApp.ViewModels
{
    public class LoginViewModel :BaseViewModel
    {

        private readonly APIService _service = new APIService("Klijenti");
        public LoginViewModel()
        {
            LoginCommand = new Command(async() =>
              {
                  await Login();

              });
        }

        string korisnickoime= string.Empty;
        public string KorisnickoIme
        {
            get { return korisnickoime; }
            set { SetProperty(ref korisnickoime, value); }
        }

        string lozinka = string.Empty;
        public string Lozinka
        {
            get { return lozinka; }
            set { SetProperty(ref lozinka, value); }
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            APIService.username = KorisnickoIme;
            APIService.password = Lozinka;
            try
            {

                APIService.PrijavljeniKorisnik = await _service.get<Klijent>(null);
                   if (APIService.PrijavljeniKorisnik.Uloga.Naziv == "Korisnik")
                {
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    throw new Exception("Unos nije ispravan");
                }
                
            }
            catch(Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message, "Authentikacija", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
