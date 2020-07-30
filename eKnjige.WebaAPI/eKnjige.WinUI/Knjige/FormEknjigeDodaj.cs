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
using System.Windows.Forms.VisualStyles;

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
            dataGridViewAutori.AutoGenerateColumns = false;
            dataGridViewKategorije.AutoGenerateColumns = false;
            id = knjigetId;
        }

        private async void FormEknjigeDodaj_Load(object sender, EventArgs e)
        {

            if (id.HasValue)
            {
                await EknjigeUcitaj();





            }
            buttonKomentari.Hide();
            await LoadAutori();
            await LoadKategorije();

        }


        private async Task LoadKategorije()
        {
            var result = await _Kategorijaapiservice.get<List<Model.Kategorija>>(null);

            if (dataGridViewKategorije.DataSource == null)
            {

                dataGridViewKategorije.DataSource = result;
            }

            

            foreach (DataGridViewRow item in dataGridViewKategorije.Rows)
            {

                if (item.Cells[0].Value == null)
                {
                    item.Cells[0].Value = false;

                }
                

            }


        }

        private async Task LoadAutori()
        {


            var result = await _Autorapiservice.get<List<Model.Autor>>(null);

            if (dataGridViewAutori.DataSource == null)
            {
                dataGridViewAutori.DataSource = result;

            }
            
            foreach(DataGridViewRow item in dataGridViewAutori.Rows)
            {
                if (item.Cells[0].Value == null)
                {
                    item.Cells[0].Value = false;

                }
                

            }

        }

     

        private async Task EknjigeUcitaj()
        {
            var knjiga = await _apiservice.getbyId<Model.EKnjiga>(id);
            var knjigaautori = await _autorKnjigaservice.get<List<Model.EKnjigeAutor>>(null);
            var autori = await _Autorapiservice.get<List<Model.Autor>>(null);
            var knjigakategorije = await _kategorijaKnjigaservice.get<List<Model.EKnjigaKategorija>>(null);
            var kategorije = await _Kategorijaapiservice.get<List<Model.Kategorija>>(null);
            var eknjigetipfajla = await _EknjigaTip.get<List<Model.EKnjigaTip>>(null);

            if (knjiga.MP3Dodan == true)
            {
                checkBoxMP3.Checked=true;
                buttonmp3file.Hide();

            }
            if (knjiga.PDFDodan == true)
            {
                checkBoxPdf.Checked=true;
                buttonpdffile.Hide();

            }

            dataGridViewAutori.DataSource = autori;
            dataGridViewKategorije.DataSource = kategorije;
        

            foreach(DataGridViewRow r in dataGridViewAutori.Rows)
            {
                bool dodan=false;
                foreach(var a in knjigaautori)
                {
                    var v = int.Parse(r.Cells[1].Value.ToString());

                    if (a.EKnjigaID==knjiga.EKnjigaID && a.AutorID==v)
                    {
                        dodan= true;
                    }
                   


                }
                if (dodan == true) {
                    r.Cells[0].Value = true;
                    

                }
                else
                {
                    r.Cells[0].Value = false;

                }


            }
            foreach (DataGridViewRow r in dataGridViewKategorije.Rows)
            {
                bool dodan = false;
                foreach (var k in knjigakategorije)
                {
                    var v = int.Parse(r.Cells[1].Value.ToString());

                    if (k.EKnjigaID == knjiga.EKnjigaID && k.KategorijaID == v)
                    {
                        dodan = true;
                    }



                }
                if (dodan == true)
                {
                    r.Cells[0].Value = true;


                }
                else
                {
                    r.Cells[0].Value = false;

                }


            }

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
                var knjiga = await _apiservice.getbyId<Model.EKnjiga>(id);

                request.Slika = knjiga.Slika;
                if (checkBoxMP3.Checked==true && knjiga.MP3Dodan==false)
                {
                    request.MP3Dodan = true;
                    var tip = new Model.EKnjigaTipRequest
                    {
                        TipFajlaID = 1,
                        EKnjigaID = knjiga.EKnjigaID


                    };
                    
                    await _EknjigaTip.Insert<Model.EKnjigaTip>(tip);
                }
                if (checkBoxPdf.Checked == true && knjiga.PDFDodan == false)
                {
                    request.PDFDodan = true;
                    var tip = new Model.EKnjigaTipRequest
                    {
                        TipFajlaID = 2,
                        EKnjigaID = knjiga.EKnjigaID


                    };

                    await _EknjigaTip.Insert<Model.EKnjigaTip>(tip);
                }
                var knjigaautori = await _autorKnjigaservice.get<List<Model.EKnjigeAutor>>(null);
                foreach (DataGridViewRow item in dataGridViewAutori.Rows)
                {
                    bool tacan = false;

                    foreach(var item2 in  knjigaautori )
                    if (bool.Parse(item.Cells[0].Value.ToString()) && item2.EKnjigaID==knjiga.EKnjigaID && item2.AutorID==int.Parse(item.Cells[1].Value.ToString()))
                    {

                            tacan = true;
                            break;
                    }

                    if (tacan == false && bool.Parse(item.Cells[0].Value.ToString()))
                    {

                        Model.EKnjigeAutorRequest autor = new Model.EKnjigeAutorRequest()
                        {
                            AutorID = int.Parse(item.Cells[1].Value.ToString()),
                            EKnjigaID = knjiga.EKnjigaID
                        };

                        await _autorKnjigaservice.Insert<Model.EKnjigeAutor>(autor);
                    }

                }

                var knjigakategorije = await _kategorijaKnjigaservice.get<List<Model.EKnjigaKategorija>>(null);

                foreach (DataGridViewRow item in dataGridViewKategorije.Rows)
                {
                    bool tacan = false;

                    foreach (var item2 in knjigakategorije)
                        if (bool.Parse(item.Cells[0].Value.ToString()) && item2.EKnjigaID == knjiga.EKnjigaID && item2.KategorijaID == int.Parse(item.Cells[1].Value.ToString()))
                        {

                            tacan = true;
                            break;
                        }

                    if (tacan == false && bool.Parse(item.Cells[0].Value.ToString()))
                    {

                        Model.EKnjigaKategorijaRequest kategorija= new Model.EKnjigaKategorijaRequest()
                        {
                            KategorijaID = int.Parse(item.Cells[1].Value.ToString()),
                            EKnjigaID = knjiga.EKnjigaID
                        };

                        await _kategorijaKnjigaservice.Insert<Model.EKnjigaKategorija>(kategorija);
                    }

                }


                await _apiservice.Update<Model.EKnjiga>(id, request);
            }
            else
            {
                
                if (checkBoxMP3.Checked == true)
                {
                    request.MP3Dodan = true;
                }
                if (checkBoxPdf.Checked == true)
                {
                    request.PDFDodan = true;
                }

                var knjiga =await _apiservice.Insert<Model.EKnjiga>(request);
              
                foreach(DataGridViewRow item in dataGridViewAutori.Rows)
                {
                    if (bool.Parse(item.Cells[0].Value.ToString())){

                        Model.EKnjigeAutorRequest autor = new Model.EKnjigeAutorRequest()
                        {
                            AutorID = int.Parse(item.Cells[1].Value.ToString()),
                            EKnjigaID = knjiga.EKnjigaID
                        };

                        await _autorKnjigaservice.Insert<Model.EKnjigeAutor>(autor);
                    }
                  

                }

                foreach (DataGridViewRow item in dataGridViewKategorije.Rows)
                {
                    if (bool.Parse(item.Cells[0].Value.ToString()))
                    {

                        Model.EKnjigaKategorijaRequest kategorija = new Model.EKnjigaKategorijaRequest()
                        {
                            KategorijaID= int.Parse(item.Cells[1].Value.ToString()),
                            EKnjigaID = knjiga.EKnjigaID
                        };

                        await _kategorijaKnjigaservice.Insert<Model.EKnjigaKategorija>(kategorija);
                    }


                }

                //Model.EKnjigeAutorRequest autor = new Model.EKnjigeAutorRequest()
                //{
                //    AutorID = autorId,
                //    EKnjigaID = knjiga.EKnjigaID
                //};
                //Model.EKnjigaKategorijaRequest kategorija = new Model.EKnjigaKategorijaRequest()
                //{
                //    KategorijaID = kategorijaId,
                //    EKnjigaID = knjiga.EKnjigaID

                //};

               
                if (checkBoxMP3.Checked)
                {
                    
                    var tip = new Model.EKnjigaTipRequest
                    {
                        TipFajlaID = 1,
                        EKnjigaID = knjiga.EKnjigaID


                    };


                    await _EknjigaTip.Insert<Model.EKnjigaTip>(tip);


                }
                if (checkBoxPdf.Checked)
                {
                   
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
                dataGridViewKategorije.DataSource = listKategorija;
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

                var filename = openFileDialogpdf.FileName;
                var file = File.ReadAllBytes(filename);
                request.Pdffile = file;
                checkBoxPdf.Checked = true;

            }

        }

        private async void buttonAutoriDodaj_Click(object sender, EventArgs e)
        {
            FormDodajAutora form = new FormDodajAutora();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var listaautora = await _autorKnjigaservice.get<List<Model.Autor>>(null);
                dataGridViewAutori.DataSource = listaautora;

                foreach (DataGridViewRow item in dataGridViewAutori.Rows)
                {
                    item.Cells[0].Value = false;

                }
            }
        }
    }
}
