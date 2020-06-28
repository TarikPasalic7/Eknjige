using eKnjige.Model;
using EKnjige.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EKnjige.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KorisnikPage : ContentPage
    {
        private KlijentDetailViewModel model = null;
        public KorisnikPage(Klijent klijent)
        {
            InitializeComponent();
            BindingContext = model = new KlijentDetailViewModel()
            {
                Klijent = klijent

            };
        }

    }
}