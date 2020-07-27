using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Knjige
{
    public partial class FormEknjigeDodaj : Form
    {
        private readonly APIService _apiservice = new APIService("eknjiga");

        private int? id = null;
        public FormEknjigeDodaj(int? knjigetId = null)
        {
            InitializeComponent();
            id = knjigetId;
        }

        private async void FormEknjigeDodaj_Load(object sender, EventArgs e)
        {

            if (id.HasValue)
            {
                await EknjigeUcitaj();




                //await LoadSpol(klijent.SpolID);
                //await LoadGradovi(klijent.GradID);

            }

        }

        private async Task EknjigeUcitaj()
        {
            var knjiga = await _apiservice.getbyId<Model.EKnjiga>(id);
            textNaziv.Text = knjiga.Naziv;
            textCijena.Text = knjiga.Cijena.ToString();
            textOcjena.Text = knjiga.OcjenaKnjige.ToString();
            textOpis.Text = knjiga.Opis;

            byte[] image = knjiga.Slika;
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);





        }
        Model.Requests.EKnjigaInsertRequest request = new Model.Requests.EKnjigaInsertRequest();

        private async void btnSnimi_Click(object sender, EventArgs e)
        {





            request.Naziv = textNaziv.Text;
                request.Cijena = float.Parse(textCijena.Text);
                request.OcjenaKnjige = float.Parse(textOcjena.Text);
                request.AdministratorID = APIService.PrijavljeniKorisnik.KlijentID;
                request.Opis = textOpis.Text;


           

            if (id.HasValue)
            {
                await _apiservice.Update<Model.EKnjiga>(id,request);

            }
            else
            {

                await _apiservice.Insert<Model.EKnjiga>(request);
            }
            MessageBox.Show("Operacija uspjesna");
            DialogResult = DialogResult.OK;
            Close();

            


    }

        private  void btnSlika_Click(object sender, EventArgs e)
        {

            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                var filename = openFileDialog1.FileName;
                var file = File.ReadAllBytes(filename);
                request.Slika = file;
                txtSlikaInput.Text = filename;
                Image image = Image.FromFile(filename);
                pictureBox1.Image = image;

            }

        }
    }
}
