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
            ObrisiCommand= new Command<Komentar>(async (komentar) =>await Obrisi(komentar));
            DodajCommand = new Command(async () => await Dodaj());
        }
        public EknjigaMobile EKnjiga { get; set; }
        public ObservableCollection<Komentar> KomentariList { get; set; } = new ObservableCollection<Komentar>();

    


        string _komentar = null;

        public string Komentar
        {
            get { return _komentar; }
            set
            {
                SetProperty(ref _komentar, value);
              

            }
        }


        public ICommand InitCommand { get; set; }
        public ICommand ObrisiCommand { get; set; }

        public ICommand DodajCommand { get; set; }

        public async Task Dodaj()
        {
            KomentarRequest request = new KomentarRequest()
            {
                DatumKomentara = DateTime.Now,
                EKnjigaID = EKnjiga.EKnjigaID,
                KlijentID = APIService.PrijavljeniKorisnik.KlijentID,
                komentar = Komentar
            };

           await _servicekomentari.Insert<Komentar>(request);

            KomentariList.Clear();
            List<Komentar> komentari = await _servicekomentari.get<List<Komentar>>(null);
            Komentar = null;
            await Init();
        }

        public  async Task Obrisi(Komentar k)
        {

            var id = k.KomentarId;
          
        }

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
