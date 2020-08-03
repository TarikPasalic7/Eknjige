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
    public partial class KlijentiPage : ContentPage
    {
        private KlijentiViewModel klijentivm = null;
        public KlijentiPage()
        {
            InitializeComponent();
            BindingContext = klijentivm = new KlijentiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await klijentivm.Init();
        }

        //private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as Klijent;
        //    await Navigation.PushAsync(new RegistracijaPag(item));
        //}
    }
}