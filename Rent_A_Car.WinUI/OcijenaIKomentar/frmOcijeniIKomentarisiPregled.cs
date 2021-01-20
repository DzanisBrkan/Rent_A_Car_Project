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
    public partial class frmOcijeniIKomentarisiPregled : Form
    {
        private readonly APIService _apiService = new APIService("Ocjena");
        public frmOcijeniIKomentarisiPregled()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new OcijenaSearchRequest()
            {

                OcjenaId = Convert.ToInt32(txtPretraga.Text)
            };
            var result = await _apiService.Get<List<Model.Ocjena>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }
    }
}
