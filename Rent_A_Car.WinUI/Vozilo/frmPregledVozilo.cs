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

namespace Rent_A_Car.WinUI.Vozilo
{
    public partial class frmPregledVozilo : Form
    {
        private readonly APIService _apiService = new APIService("Vozilo");
        public frmPregledVozilo()
        {
            InitializeComponent(); 
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new VoziloSearchRequest()
            {
                Model = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Vozilo>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKalendar_Click(object sender, EventArgs e)
        {
            KalendarVozila frm = new KalendarVozila();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void btnLociraj_Click(object sender, EventArgs e)
        {

            //frmLocirajVoziloPrikaz frm = new frmLocirajVoziloPrikaz();
            ////frm.MdiParent = this;
            //frm.Show();
        }

        private void btnLocirajVozilo_Click(object sender, EventArgs e)
        {
            frmLocirajVoziloPrikaz frm = new frmLocirajVoziloPrikaz();
            //frm.MdiParent = this;
            frm.Show();
        }
    }
}
