using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new ZaposlenikSearchRequest()
            {
                Ime = txtPretraga.Text
            };
            var result = _apiService.Get<List<Model.Zaposlenik>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        //private void dgvKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    var id = dgvZaposlenik.SelectedRows[0].Cells[0].Value;

        //    frmZaposlenikDetalji frm = new frmZaposlenikDetalji(int.Parse(id.ToString()));
        //    frm.Show();
        //}
    }
}
