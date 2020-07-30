using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Komentari
{
    public partial class FormKomentari : Form
    {

        private readonly APIService _apiservice = new APIService("komentar");
        public FormKomentari()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
        }

        private async void btntrazi_Click(object sender, EventArgs e)
        {
           
            var result = await _apiservice.get<List<Model.Komentar>>(null);

            dataGridView1.DataSource = result;
        }
    }
}
