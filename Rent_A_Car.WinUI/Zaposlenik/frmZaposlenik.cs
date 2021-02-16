using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using Rent_A_Car.Model.Requests;
//ovo se mora rucno dodati

namespace Rent_A_Car.WinUI.Zaposlenik
{
    public partial class frmZaposlenik : Form
    {
        private readonly APIService _apiService = new APIService("Zaposlenik");
        public frmZaposlenik()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new ZaposlenikSearchRequest()
            {
                Ime = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Zaposlenik>>(search);

            dgvZaposlenik.AutoGenerateColumns = false;

            dgvZaposlenik.DataSource = result;
        }

        private void dgvZaposlenik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmZaposlenikDetalji frm = new frmZaposlenikDetalji();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void dgvZaposlenik_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvZaposlenik.SelectedRows[0].Cells[0].Value;

            frmZaposlenikDetalji frm = new frmZaposlenikDetalji(int.Parse(id.ToString()));
            //frm.MdiParent = this;//provjeri ovo
            frm.Show();
            //frmZaposlenikDetalji frm = new frmZaposlenikDetalji();
            //frm.MdiParent = this;
            //frm.Show();
        }
    }
}
