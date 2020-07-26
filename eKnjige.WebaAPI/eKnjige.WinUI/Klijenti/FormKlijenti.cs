using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKnjige.Model.Requests;
using Flurl;
using Flurl.Http;

namespace eKnjige.WinUI.Klijenti
{
    public partial class FormKlijenti : Form
    {

        private readonly APIService _apiservice = new APIService("klijenti");
        public FormKlijenti()
        {
            InitializeComponent();
            dgvKlijenti.AutoGenerateColumns = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var search = new KlijentiSearchRequest();
            search.Ime = txtPretraga.Text;
            var result = await _apiservice.get<List<Model.Klijent>>(search);

            dgvKlijenti.DataSource = result;
        }

        private void dgvKlijenti_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvKlijenti.SelectedRows[0].Cells[0].Value;

            FormKlijentiDetalji form = new FormKlijentiDetalji(int.Parse(id.ToString()));
            form.Show();
        }
    }
}
