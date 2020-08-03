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
    public partial class RegistracijaPage : ContentPage
    {
        private RegistracijaViewModel registracija= null;
        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = registracija = new RegistracijaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await registracija.Init();
        }
    }
}