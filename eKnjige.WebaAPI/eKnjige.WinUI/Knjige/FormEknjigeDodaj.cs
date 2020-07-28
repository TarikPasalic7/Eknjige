using eKnjige.WinUI.Autori;
using eKnjige.WinUI.Drzave;
using eKnjige.WinUI.Kategorije;
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
        private readonly APIService _Kategorijaapiservice = new APIService("kategorija");
        private readonly APIService _Autorapiservice = new APIService("autor");
        private readonly  APIService _kategorijaKnjigaservice = new APIService("eknjigakategorija");
        private readonly APIService _autorKnjigaservice = new APIService("eknjigaautor");
        private readonly APIService _EknjigaTip = new APIService("eknjigatipfajla");

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

            await LoadAutori();
            await LoadKategorije();

        }


        private async Task LoadKategorije()
        {
            var result = await _Kategorijaapiservice.get<List<Model.Kategorija>>(null);

            comboBoxKategorije.DisplayMember = "Naziv";
            comboBoxKategorije.ValueMember = "KategorijaID";
            comboBoxKategorije.DataSource = result;




        }

        private async Task LoadAutori()
        {


            var result = await _Autorapiservice.get<List<Model.Autor>>(null);
            
            comboBoxAutori.DisplayMember = "Ime";
            comboBoxAutori.ValueMember = "AutorID";
            comboBoxAutori.DataSource = result;

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

                var knjiga =await _apiservice.Insert<Model.EKnjiga>(request);
                var autorId = (comboBoxAutori.SelectedItem as Model.Autor).AutorID;
                var kategorijaId = (comboBoxKategorije.SelectedItem as Model.Kategorija).KategorijaID;
                Model.EKnjigeAutorRequest autor = new Model.EKnjigeAutorRequest()
                {
                    AutorID = autorId,
                    EKnjigaID = knjiga.EKnjigaID
                };
                Model.EKnjigaKategorijaRequest kategorija = new Model.EKnjigaKategorijaRequest()
                {
                    KategorijaID = kategorijaId,
                    EKnjigaID = knjiga.EKnjigaID

                };
                await _autorKnjigaservice.Insert<Model.EKnjigeAutor>(autor);
                await _kategorijaKnjigaservice.Insert<Model.EKnjigaKategorija>(kategorija);
                if (checkBoxMP3.Checked)
                {
                    request.MP3Dodan= true;
                    var tip = new Model.EKnjigaTipRequest
                    {
                        TipFajlaID = 1,
                        EKnjigaID = knjiga.EKnjigaID


                    };


                    await _EknjigaTip.Insert<Model.EKnjigaTip>(tip);


                }
                if (checkBoxPdf.Checked)
                {
                    request.PDFDodan = true;
                    var tip = new Model.EKnjigaTipRequest
                    {
                        TipFajlaID = 2,
                        EKnjigaID = knjiga.EKnjigaID
                        


                    };


                    await _EknjigaTip.Insert<Model.EKnjigaTip>(tip);


                }


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

        private async void buttonKategorijeKnjige_Click(object sender, EventArgs e)
        {
            FormDodajKategoriju form = new FormDodajKategoriju();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var listKategorija = await _Kategorijaapiservice.get<List<Model.Kategorija>>(null);
                comboBoxKategorije.DataSource = listKategorija;
            }
          
        }

        private async void buttonEknnjigeAutori_Click(object sender, EventArgs e)
        {
            FormDodajAutora form = new FormDodajAutora();
            if(form.ShowDialog() == DialogResult.OK)
            {
                var listaautora = await _autorKnjigaservice.get<List<Model.Autor>>(null);
                comboBoxAutori.DataSource = listaautora;

            }
        }

        private void buttonmp3file_Click(object sender, EventArgs e)
        {
            var result = openFileDialogmp3.ShowDialog();
            if (result == DialogResult.OK)
            {

                var filename = openFileDialogmp3.FileName;
                var file = File.ReadAllBytes(filename);
                request.Mp3file= file;
                checkBoxMP3.Checked = true;

            }
        }

        private void buttonpdffile_Click(object sender, EventArgs e)
        {

            var result = openFileDialogpdf.ShowDialog();
            if (result == DialogResult.OK)
            {

                var filename = openFileDialogmp3.FileName;
                var file = File.ReadAllBytes(filename);
                request.Pdffile = file;
                checkBoxPdf.Checked = true;

            }

        }
    }
}
