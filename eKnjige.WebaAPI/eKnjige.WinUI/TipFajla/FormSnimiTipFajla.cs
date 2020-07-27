using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.TipFajla
{
    public partial class FormSnimiTipFajla : Form
    {

        private readonly APIService tipfajlaService = new APIService("TipFajla");
        public FormSnimiTipFajla()
        {
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var insert = new Model.TipFajlaSearchRequest
            {
                Naziv = txtTipFajlaNaziv.Text

            };

            await tipfajlaService.Insert<Model.TipFajla>(insert);

            MessageBox.Show("Operacija uspjesna");
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
