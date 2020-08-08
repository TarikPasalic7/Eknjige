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
    public partial class ProfilKnjigaPage : ContentPage
    {

        private ProfilKnjigaViewModel model = null;
        public ProfilKnjigaPage(EknjigaMobile eknjiga)
        {
            InitializeComponent();
            BindingContext = model = new ProfilKnjigaViewModel()
            {
                EKnjiga = eknjiga

            };
        }
    }
}