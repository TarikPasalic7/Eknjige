﻿using eKnjige.Model;
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
    public partial class KnjigePage : ContentPage
    {

        KnjigeViewModel model = null;
        public KnjigePage()
        {
            InitializeComponent();
            BindingContext = model = new KnjigeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
          await  model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Kategorija;
            await Navigation.PushAsync(new MainPage());
        }
    }
}