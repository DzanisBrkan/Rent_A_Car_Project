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

namespace Rent_A_Car.WinUI.Ugovor
{
    public partial class frmUgovor : Form
    {
        private readonly APIService _apiService = new APIService("Ugovor");
        public frmUgovor()
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

        private void dgvUgovor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUgovor.SelectedRows[0].Cells[0].Value;

            frmUgovorDetalji frm = new frmUgovorDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmUgovor_Load(object sender, EventArgs e)
        {
  
            var result = await _apiService.Get<List<Model.Ugovor>>(null);

            dgvUgovor.AutoGenerateColumns = false;

            dgvUgovor.DataSource = result;
        }
    }
}
