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
    public partial class frmVozilo : Form
    {
        private readonly APIService _voziloService = new APIService("Vozilo");
        private readonly APIService _kategorijaService = new APIService("Kategorija");
        //private readonly APIService _specifikacijaService = new APIService("Specifikacija");
        public frmVozilo()
        {
            InitializeComponent();
        }

        private async void frmVozilo_Load(object sender, EventArgs e)
        {
            //overajdanje eventa
            await LoadKategorija();
            //await LoadSpecifikacija();
        }

        private async Task LoadKategorija()
        {
            var result = await _kategorijaService.Get<List<Model.Kategorija>>(null);
            result.Insert(0,new Model.Kategorija());
            cmbKategorija.DisplayMember = "Oznaka";
            cmbKategorija.ValueMember = "KategorijaId";
            cmbKategorija.DataSource = result;
        }
        //private async Task LoadSpecifikacija()
        //{
        //    var result = await _specifikacijaService.Get<List<Model.Specifikacija>>(null);
        //    result.Insert(0, new Model.Specifikacija());
        //    cmbSpecifikacija.DisplayMember = "EuroNorma";
        //    cmbSpecifikacija.ValueMember = "SpecifikacijaId";
        //    cmbSpecifikacija.DataSource = result;
        //}

        private async void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKategorija.SelectedValue;

            if(int.TryParse(idObj.ToString(), out int id))
            {
                await LoadVozila(id);
            }
        }

        private async Task LoadVozila(int kategorijaId)
        {
            var result = await _voziloService.Get<List<Model.Vozilo>>(new VoziloSearchRequest()
            {
                KategorijaId = kategorijaId
            });

            VoziloGrid.DataSource = result;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            VoziloUpsertRequest request = new VoziloUpsertRequest();

            var idObj = cmbKategorija.SelectedValue;

            if(int.TryParse(idObj.ToString(), out int kategorijaId))
            {
                request.KategorijaId = kategorijaId;
            }
            //request.RegistracijskiBroj = txtReg;
            //request.Model = txtModel;
        }
    }
}
