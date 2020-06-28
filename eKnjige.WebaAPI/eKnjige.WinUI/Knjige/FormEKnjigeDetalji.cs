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
    public partial class FormEKnjigeDetalji : Form
    {
        private readonly APIService _apiservice = new APIService("eknjiga");

        private int? id = null;
        public FormEKnjigeDetalji(int? knjigeid = null)
        {
            InitializeComponent();
            id = knjigeid;
        }

        private async void FormEKnjigeDetalji_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {


                var knjiga = await _apiservice.getbyId<Model.EKnjiga>(id);
                textNaziv.Text = knjiga.Naziv;
                textCijena.Text = knjiga.Cijena.ToString();
                textOcjena.Text = knjiga.OcjenaKnjige.ToString();
                textOpis.Text = knjiga.Opis;


                //await LoadSpol(klijent.SpolID);
                //await LoadGradovi(klijent.GradID);

            }




        }






    }

}
