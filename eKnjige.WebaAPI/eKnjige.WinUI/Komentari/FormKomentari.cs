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
            dugme();
        }

        private async void btntrazi_Click(object sender, EventArgs e)
        {
           
            var result = await _apiservice.get<List<Model.Komentar>>(null);

            dataGridView1.DataSource = result;
        }
        public async void dugme()
        {
            var result = await _apiservice.get<List<Model.Komentar>>(null);

            dataGridView1.DataSource = result;
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

            deletebutton.FlatStyle = FlatStyle.Popup;

            deletebutton.HeaderText = "Izbrisi";
            deletebutton.Name = "Izbrisi";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Izbrisi";
            

            deletebutton.Width = 70;
           
            if (dataGridView1.Columns.Contains(deletebutton.Name = "Izbrisi"))
            {

            }
            else
            {
                dataGridView1.Columns.Add(deletebutton);
            }

        }
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 3)
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Da li zaista zelite izbrisati komentar", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                   await _apiservice.Remove(id);
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
