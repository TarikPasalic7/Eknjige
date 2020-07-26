using eKnjige.Model;
using eKnjige.WinUI.Gradovi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Klijenti
{
    public partial class FormKlijentiDetalji : Form
    {

        private readonly APIService service=new APIService("Klijenti");
        private readonly APIService servicegrad = new APIService("Grad");
        private readonly APIService serviceSpol = new APIService("Spol");
        private readonly APIService serviceUloga = new APIService("Uloga");

        private int? id = null;
        public FormKlijentiDetalji(int? klijentId =null)
        {
            InitializeComponent();

            id = klijentId;
        }

       

        private async void btnSnimi_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {

                var request = new KlijentInsertRequest();

                request.Ime = textIme.Text;
                request.Prezime = textPrezime.Text;
                request.KorisnickoIme = textKorisnickoIme.Text;
                request.Email = textEmail.Text;
                //request.DatumRodenja = DateTime.Now;
                request.LozinkaHash = textPassword.Text;
                request.LozinkaProvjera = textPasswordPotvrda.Text;
                request.DatumRodenja = dateDatum.Value;
                request.Jmbg=textJmbg.Text;
                request.GradID = (cmbGradovi.SelectedItem as Model.Grad).Id;
                request.SpolID = (cmbSpol.SelectedItem as Model.Spol).SpolID;
                request.UlogaId = (cmbUloga.SelectedItem as Model.Uloga).UlogaId;
                //    var idObj = cmbGradovi.SelectedValue;
              
                //if (int.TryParse(idObj.ToString(), out int GradID))
                //{
                //    request.GradID=GradID;
                //}

                //var idObj2 = cmbSpol.SelectedValue;
                //if (int.TryParse(idObj2.ToString(), out int SpolID))
                //{
                //    request.SpolID = SpolID;
                //}
                //var idObj3 = cmbUloga.SelectedValue;
                
                //if (int.TryParse(idObj3.ToString(), out int UlogaId))
                //{
                //    request.UlogaId = UlogaId;
                //}




                if (id.HasValue)
                {
                    await service.Update<Model.Klijent>(id, request);

                }
                else
                {

                    await service.Insert<Model.Klijent>(request);
                }
                MessageBox.Show("Operacija uspjesna");
            }

          
          

        }
        private async void FormKlijentiDetalji_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {


                var klijent = await service.getbyId<Model.Klijent>(id);
                textKorisnickoIme.Text = klijent.KorisnickoIme;
                textIme.Text = klijent.Ime;
                textPrezime.Text = klijent.Prezime;
                textJmbg.Text = klijent.Jmbg;
                textEmail.Text = klijent.Email;

                // var result =await servicegrad.get<List<Model.Grad>>(null);
                //cmbGradovi.SelectedItem = klijent.GradID;
                ////dateDatum.Value = klijent.DatumRodjenja;
                //cmbGradovi.SelectedValue = klijent.GradID;
                //await LoadSpol(klijent.SpolID);
                //await LoadGradovi(klijent.GradID);
                await LoadSpol();
                await LoadGradovi();
                await LoadUloga();

                foreach (Model.Grad item in cmbGradovi.Items)
                {
                    if (item.Id == klijent.GradID)
                        cmbGradovi.SelectedItem = item;

                }
                foreach (Model.Uloga item in cmbUloga.Items)
                {
                    if (item.UlogaId == klijent.UlogaId)
                        cmbUloga.SelectedItem = item;

                }
                foreach (Model.Spol item in cmbSpol.Items)
                {
                    if (item.SpolID == klijent.SpolID)
                        cmbSpol.SelectedItem = item;

                }

            }
            else
            {

                await LoadSpol();
                await LoadGradovi();
                await LoadUloga();



            }





        }

        private async Task LoadGradovi()
        {

            
            var result = await servicegrad.get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "Id";
            cmbGradovi.DataSource = result;
            
        }




    

        private async Task LoadSpol()
        {


            var result = await serviceSpol.get<List<Model.Spol>>(null);
            result.Insert(0, new Model.Spol());
            cmbSpol.DisplayMember = "Tip";
            cmbSpol.ValueMember = "SpolID ";

            cmbSpol.DataSource = result;
        }

        private async Task LoadUloga()
        {


            var result = await serviceUloga.get<List<Model.Uloga>>(null);
            result.Insert(0, new Model.Uloga());
            cmbUloga.DisplayMember = "Naziv";
            cmbUloga.ValueMember = "UlogaId ";

            cmbUloga.DataSource = result;
        }


        private void textIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textIme.Text))
            {

                errorProvider.SetError(textIme, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textIme, null);
            }
        }

        private void textPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrezime_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textPrezime.Text))
            {

                errorProvider.SetError(textPrezime, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textPrezime, null);
            }

        }

        private void textKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textKorisnickoIme.Text))
            {

                errorProvider.SetError(textKorisnickoIme, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textKorisnickoIme, null);
            }
        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textJmbg.Text))
            {

                errorProvider.SetError(textJmbg, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textJmbg, null);
            }
        }

        private void buttonGrad_Click(object sender, EventArgs e)
        {
            FormDodajGrad form = new FormDodajGrad();
            form.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbUloga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
