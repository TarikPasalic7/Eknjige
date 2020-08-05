using eKnjige.Model;
using EKnjige.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EKnjige.MobileApp.ViewModels
{
    class KnjigaDetailViewModel : BaseViewModel
    {
        
        private readonly APIService _servicekomentari = new APIService("Komentar");

        public KnjigaDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public EknjigaMobile EKnjiga { get; set; }
        public ObservableCollection<Komentar> KomentariList { get; set; } = new ObservableCollection<Komentar>();

       



        public ICommand InitCommand { get; set; }

        public async Task Init()

        {
            KomentariList.Clear();
            List<Komentar> komentari= await _servicekomentari.get<List<Komentar>>(null);

            foreach(var k in komentari)
            {

                if(k.EKnjigaID==EKnjiga.EKnjigaID)
                {
                    KomentariList.Add(k);
                }
            }


        }

    }
}
