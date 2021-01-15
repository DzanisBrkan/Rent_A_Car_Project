using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using Rent_A_Car.Model.Requests;

namespace Rent_A_Car.WinUI.Klijent
{
    public partial class frmKlijent : Form
    {
        private readonly APIService _apiService = new APIService("Klijent");
        public frmKlijent()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KlijentSearchRequest()
            {
                Ime = txtPretraga.Text
            };
            var result = await _apiService.Get <List<Model.Klijent>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;

        }

        private void dgvKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijent.SelectedRows[0].Cells[0].Value;

            frmKlijentDetalji frm = new frmKlijentDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
