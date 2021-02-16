using Rent_A_Car.Model;
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

namespace Rent_A_Car.WinUI.OcijenaIKomentar
{
    public partial class frmOcijenaIKomentar : Form
    {
        private readonly APIService _apiService = new APIService("DojmoviZahtjevi");

        public frmOcijenaIKomentar()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmOcijenaIKomentar_Load(object sender, EventArgs e)
        {
            //var search = new DojmoviZahtjeviSearchRequest()
            //{
            //    DojmoviZahtjeviId = txtPretraga.Text;
            //};

            var result = await _apiService.Get<List<DojmoviZahtjevi>>(null);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void dgvKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijent.SelectedRows[0].Cells[0].Value;

            frmDetaljiDojmoviZahtjevi frm = new frmDetaljiDojmoviZahtjevi(int.Parse(id.ToString()));
            frm.Show();

        }
    }
}
