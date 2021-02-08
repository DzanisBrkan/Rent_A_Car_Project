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

namespace Rent_A_Car.WinUI.Grad
{
    public partial class frmGrad : Form
    {
        private readonly APIService _apiService = new APIService("Grad");

        public frmGrad()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new GradSearchRequest()
            {
                Naziv = txtPretraga.Text 
            };
            var result = await _apiService.Get<List<Model.Grad>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void dgvKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijent.SelectedRows[0].Cells[0].Value;

            frmGradDetalji frm = new frmGradDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmGradDetalji frm = new frmGradDetalji();
            frm.Show();
        }
    }
}
