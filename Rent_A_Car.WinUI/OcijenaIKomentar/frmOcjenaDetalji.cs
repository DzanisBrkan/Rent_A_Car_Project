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
    
    public partial class frmOcjenaDetalji : Form
    {
        private readonly APIService _services = new APIService("Ocjena");
        private readonly APIService _servicesVozilo = new APIService("Vozilo");
        private readonly APIService _servicesUgovor = new APIService("Ugovor");
        private readonly APIService _servicesRezervacija = new APIService("Rezervacija");
        private readonly APIService _servicesDojam = new APIService("Rezervacija");
        private int? _id = null;
        public frmOcjenaDetalji(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmOcjenaDetalji_Load(object sender, EventArgs e)
        {
            try
            {
                if (_id.HasValue)
                {
                    var ocjena = await _services.GetById<Model.Ocjena>(_id);

                    var rezervacija = await _servicesRezervacija.GetById<Model.Rezervacija>(ocjena.RezervacijaId);

                    var vozilo = await _servicesVozilo.GetById<Model.Vozilo>(ocjena.VoziloId);



                    txtOcjena.Text = ocjena.Ocjena1.ToString();
                    txtOcjena.ReadOnly = true;
                    txtKomentar.Text = ocjena.Komentar;
                    txtKomentar.ReadOnly = true;

                    txtModel.Text = vozilo.Model;
                    txtModel.ReadOnly = true;

                    txtMarkaa.Text = vozilo.Marka.ToString();
                    txtMarkaa.ReadOnly = true;

                    txtCijena.Text = rezervacija.UkupnaCijena.ToString();
                    txtCijena.ReadOnly = true;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske!");
                throw;
            }
        }

        private void placenlabela_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPlacen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
