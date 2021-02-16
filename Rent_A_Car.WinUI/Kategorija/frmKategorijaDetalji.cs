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
    public partial class frmKategorijaDetalji : Form
    {
        private readonly APIService _services = new APIService("Kategorija");
        private int? _id = null;
        public frmKategorijaDetalji(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmKategorijaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var kategorija = await _services.GetById<Model.Kategorija>(_id);

                txtOznaka.Text = kategorija.Oznaka;
                txtOznaka.ReadOnly = true;
                txtNaziv.Text = kategorija.Naziv;
                txtNaziv.ReadOnly = true;
                txtOpis.Text = kategorija.Opis;
                txtOpis.ReadOnly = true;
                txtMinDob.Text = kategorija.MinDob;
                txtMinDob.ReadOnly = true;


            }
        }
    }
}
