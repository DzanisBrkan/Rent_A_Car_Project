using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car.WinUI.Kategorija
{
    public partial class frmKategorija : Form
    {
        private readonly APIService _apiService = new APIService("Kategorija");

        public frmKategorija()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
        }

        private void dgvKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijent.SelectedRows[0].Cells[0].Value;

            frmKategorijaDetalji frm = new frmKategorijaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmKategorija_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Kategorija>>(null);

            dgvKlijent.AutoGenerateColumns = false;
            dgvKlijent.DataSource = result;
        }
    }
}
