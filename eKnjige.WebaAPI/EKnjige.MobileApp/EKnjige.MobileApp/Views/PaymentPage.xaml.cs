using EKnjige.MobileApp.Models;
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
    public partial class PaymentPage : ContentPage
    {
        private INavigation navigation;
        private PaymentViewModel model = null;
        public PaymentPage(EknjigaMobile eknjiga)
        {
            InitializeComponent();
            var nav = new NavigationPage(new KnjigePage());
            navigation = nav.Navigation;


            BindingContext = model = new PaymentViewModel(navigation)
            {
                EKnjiga = eknjiga
            };
        }
      
    }
}