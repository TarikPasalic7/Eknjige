using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Prijedlozi
{
    public partial class FormPrijedlozi : Form

    {
        private readonly APIService _apiservicek = new APIService("komentar");
        
        private readonly APIService _apiservice = new APIService("prijedlogknjige");
        public FormPrijedlozi()
        {
            InitializeComponent();
            dgvPrijedlozi.AutoGenerateColumns = false;
           
        }


        public async void dugme()
        {
            var result = await _apiservice.get<List<Model.PrijedlogKnjiga>>(null);

            dgvPrijedlozi.DataSource = result;
            DataGridViewButtonColumn Uredibutton = new DataGridViewButtonColumn();

            Uredibutton.FlatStyle = FlatStyle.Popup;

            Uredibutton.HeaderText = "Uredi";
            Uredibutton.Name = "Uredi";
            Uredibutton.UseColumnTextForButtonValue = true;
            Uredibutton.Text = "Uredi";


            Uredibutton.Width = 70;

            if (dgvPrijedlozi.Columns.Contains(Uredibutton.Name = "Uredi"))
            {

            }
            else
            {
                dgvPrijedlozi.Columns.Add(Uredibutton);
            }

        }

        private async void buttonTrazi_Click(object sender, EventArgs e)
        {
            var r = await _apiservicek.get<List<Model.Komentar>>(null);
            var result = await _apiservice.get<List<Model.PrijedlogKnjiga>>(null);
          
            dgvPrijedlozi.DataSource = result;
        }

        private async void dgvPrijedlozi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 6)
            {
                id = Convert.ToInt32(dgvPrijedlozi.Rows[e.RowIndex].Cells[0].Value.ToString());
                 var odobren = dgvPrijedlozi.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (odobren == "1")
                {

                    var request = await _apiservice.getbyId<Model.PrijedlogKnjiga>(id);
                    request.Odgovoren = true;
                    request.Opis= dgvPrijedlozi.Rows[e.RowIndex].Cells[4].Value.ToString();
                    await _apiservice.Remove(id);
                    dugme();
                    MessageBox.Show("Polsana je notifikacija korisniku");
                }

                
                  
             

            }
        }
    }
}
