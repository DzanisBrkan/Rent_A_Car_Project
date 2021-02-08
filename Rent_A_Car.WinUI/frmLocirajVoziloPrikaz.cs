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

namespace Rent_A_Car.WinUI
{
    public partial class frmLocirajVoziloPrikaz : Form
    {
        private readonly APIService _apiService = new APIService("Lociranje");

        public frmLocirajVoziloPrikaz()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new LociranjeSearchRequest()
            {
                search = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Lociranje>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void btnLociraj_Click(object sender, EventArgs e)
        {
            frmLocirajVozilo frm = new frmLocirajVozilo();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void dgvKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijent.SelectedRows[0].Cells[0].Value;

            frmLocirajVoziloDetalji frm = new frmLocirajVoziloDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
