using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Knjige
{
    public partial class FormKategorijeKnjige : Form
    {
        APIService _kategorijeService = new APIService("Kategorija");
       
        public FormKategorijeKnjige()
        {
            InitializeComponent();
        }

        private async void FormKategorijeKnjige_Load(object sender, EventArgs e)
        {
            var kategorija = await _kategorijeService.get<List<Model.Kategorija>>(null);

            
            listBoxKategorijeKnjige.DisplayMember = "Naziv";
            listBoxKategorijeKnjige.ValueMember = "KategorijaID";

            listBoxKategorijeKnjige.DataSource = kategorija;


        }

        private void buttonDodajKK_Click(object sender, EventArgs e)
        {
            //var t =listBoxKategorijeKnjige.Items typeof  Model.EKnjigaKategorija;
            //foreach (var k in listBoxKategorijeKnjige.Items )
            //{

                
            //    t = k;
            //}

            
        }
    }
}
