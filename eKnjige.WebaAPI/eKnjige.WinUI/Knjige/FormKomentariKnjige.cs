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
    public partial class FormKomentariKnjige : Form
    {

        private readonly APIService _apiservice = new APIService("komentar");
        private int? id = null;
        public FormKomentariKnjige(int? knjigeId = null)
        {
            InitializeComponent();
           dgvKomentari.AutoGenerateColumns = false;
            id = knjigeId;
            dugme();
        }

        public async void dugme()
        {
            var result = await _apiservice.get<List<Model.Komentar>>(null);

            dgvKomentari.DataSource = result;
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

            deletebutton.FlatStyle = FlatStyle.Popup;

            deletebutton.HeaderText = "Izbrisi";
            deletebutton.Name = "Izbrisi";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Izbrisi";


            deletebutton.Width = 70;

            if (dgvKomentari.Columns.Contains(deletebutton.Name = "Izbrisi"))
            {

            }
            else
            {
                dgvKomentari.Columns.Add(deletebutton);
            }

        }
        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            var result = await _apiservice.get<List<Model.Komentar>>(null);
            List<Model.Komentar> list = new List<Model.Komentar>();
            foreach (var i in result)
            {
                if (i.EKnjigaID==id)
                {
                    list.Add(i);

                }


            }
            dgvKomentari.DataSource = list;
        }

        private async void dgvKomentari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 3)
            {
                id = Convert.ToInt32(dgvKomentari.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Da li zaista zelite izbrisati komentar", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await  _apiservice.Remove(id);
                    dugme();
                    MessageBox.Show("Uspjesno ste izbrisali komentar");
                }
                else if (result == DialogResult.No)
                {
                    return;

                }

            }
        }
    }
}
