using System;
using System.Collections.Generic;
using System.Text;

namespace EKnjige.MobileApp.ViewModels
{
    class KnjigeViewModel :BaseViewModel
    {

        private readonly APIService _serviceknjige= new APIService("Knjiga");
        private readonly APIService _serviceKategorije = new APIService("EKnjigaKategorija");
        private readonly APIService _serviceAutor = new APIService("EKnjigaAutor");

        public KnjigeViewModel()
        {

        }


    }
}
