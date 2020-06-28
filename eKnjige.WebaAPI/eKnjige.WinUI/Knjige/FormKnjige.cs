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
    public partial class FormKnjige : Form
    {
        private readonly APIService _apiservice = new APIService("eknjiga");
        public FormKnjige()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void buttonPrikazi_Click(object sender, EventArgs e)
        {
            var search = new Model.Requests.eKnjigeSearchRequest();
            search.Naziv = textPrikazi.Text;
            var result = await _apiservice.get<List<Model.EKnjiga>>(search);

            dgveknjige.DataSource= result;
        }

        private void dgveknjige_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgveknjige.SelectedRows[0].Cells[0].Value;
             
        FormEKnjigeDetalji form = new FormEKnjigeDetalji(int.Parse(id.ToString()));
            form.Show();
        }
    }
}
