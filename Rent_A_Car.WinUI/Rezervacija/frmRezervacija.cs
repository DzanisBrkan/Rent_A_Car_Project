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

namespace Rent_A_Car.WinUI.Rezervacija
{
    public partial class frmRezervacija : Form
    {
        private readonly APIService _apiService = new APIService("Rezervacija");
        public frmRezervacija()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            //var search = new RezervacijaSearchRequest()
            //{
            //    Status = txtPretraga.Text
            //};
            //var result = await _apiService.Get<List<Model.Rezervacija>>(search);

            //dgvKlijent.AutoGenerateColumns = false;

            //dgvKlijent.DataSource = result;
        }

        private void dgvKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijent.SelectedRows[0].Cells[0].Value;

            frmRezervacjiaDetalji frm = new frmRezervacjiaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmRezervacija_Load(object sender, EventArgs e)
        {
           
            var result = await _apiService.Get<List<Model.Rezervacija>>(null);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }
    }
}
