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
        private readonly APIService _apiservice = new APIService("prijedlogknjige");
        public FormPrijedlozi()
        {
            InitializeComponent();
            dataGridViewPrijedlog.AutoGenerateColumns = false;
        }

        private async void buttonTrazi_Click(object sender, EventArgs e)
        {

            var result = await _apiservice.get<List<Model.PrijedlogKnjiga>>(null);

            dataGridViewPrijedlog.DataSource = result;
        }

       
    }
}
