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
        }
        public EknjigaMobile EKnjiga { get; set; }
        public ObservableCollection<Komentar> KomentariList { get; set; } = new ObservableCollection<Komentar>();

        int komentarId;
        public int  KomentarId
        {
            get { return komentarId; }
            set { SetProperty(ref komentarId, value); }
        }


        Komentar _selectedKomentar = null;

        public Komentar SelectedKomentar
        {
            get { return _selectedKomentar; }
            set
            {
                SetProperty(ref _selectedKomentar, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }


        public ICommand InitCommand { get; set; }
        public ICommand ObrisiCommand { get; set; }

        public  async Task Obrisi(Komentar k)
        {

            var id = k.KomentarId;
            List<Komentar> komentari = await _servicekomentari.get<List<Komentar>>(null);
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
