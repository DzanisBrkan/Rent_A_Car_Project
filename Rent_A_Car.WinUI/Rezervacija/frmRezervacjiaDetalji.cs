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
    public partial class frmRezervacjiaDetalji : Form
    {
        private readonly APIService _services = new APIService("Rezervacija");
        private readonly APIService _servicesVozilo = new APIService("Vozilo");
        private int? _id = null;
        public frmRezervacjiaDetalji(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void frmRezervacjiaDetalji_Load(object sender, EventArgs e)
        {
            try
            {
                if (_id.HasValue)
                {
                    var rezervacija = await _services.GetById<Model.Rezervacija>(_id);

                    var request = new VoziloSearchRequest()
                    {
                        VoziloId = rezervacija.VoziloId
                    };

                    var vozilo = await _servicesVozilo.GetById<Model.Vozilo>(rezervacija.VoziloId);

                    txtPocetak.Text = rezervacija.KrajRezervacije.ToString();
                    txtStatus.Text = rezervacija.Status;
                    txtCijena.Text = rezervacija.UkupnaCijena.ToString();
                    txtModel.Text = vozilo.Model;
                    txtMarka.Text = vozilo.Marka;
                    txtModel.Text = vozilo.Model;
                    if (vozilo.Zauzeto == true)
                    {
                        checkBoxZauzeto.Checked = true;
                    }
                    else
                    {
                        checkBoxZauzeto.Checked = false;
                    }
                    txtPocetak.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske!");
                throw;
            }
        }
    }
}
