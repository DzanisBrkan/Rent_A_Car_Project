using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private readonly APIService _specifikacijaService = new APIService("Specifikacija");
        private readonly APIService _tipVozila = new APIService("Tip");

        //private readonly APIService _tipService = new APIService("Tip");
        public frmVozilo()
        {
            InitializeComponent();
        }

        private async void frmVozilo_Load(object sender, EventArgs e)
        {
            //overajdanje eventa
            await LoadKategorija();
            await LoadSpecifikacija();
            await LoadTipVozila();
        }

        private async Task LoadKategorija()
        {
            var result = await _kategorijaService.Get<List<Model.Kategorija>>(null);
            result.Insert(0,new Model.Kategorija());
            cmbKategorija.DisplayMember = "Oznaka";
            cmbKategorija.ValueMember = "KategorijaId";
            cmbKategorija.DataSource = result;
        }
        private async Task LoadSpecifikacija()
        {
            var result = await _specifikacijaService.Get<List<Model.Specifikacija>>(null);
            result.Insert(0, new Model.Specifikacija());
            cmbSpecifikacija.DisplayMember = "EuroNorma";
            cmbSpecifikacija.ValueMember = "SpecifikacijaId";
            cmbSpecifikacija.DataSource = result;
        }

        private async Task LoadTipVozila()
        {
            var result = await _tipVozila.Get<List<Model.Tip>>(null);
            result.Insert(0, new Model.Tip());
            cmbTip.DisplayMember = "Naziv";
            cmbTip.ValueMember = "TipId";
            cmbTip.DataSource = result;
        }

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

        VoziloUpsertRequest request = new VoziloUpsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {

            var idObj = cmbKategorija.SelectedValue;

            if(int.TryParse(idObj.ToString(), out int kategorijaId))
            {
                request.KategorijaId = kategorijaId;
            }
            request.RegistracijskiBroj = txtRegistracijskiBroj.Text;
            request.Model = txtModel.Text;
            request.BrSjedista = txtBrojVrata.Text;
            request.BrSjedista = txtBrojVrata.Text;
            //request.CijenaPoSatu = txtCijenaPoSatu.Text;
            request.Zauzeto = cbIznajmljeno.Checked;

            await _voziloService.Insert<Model.Vozilo>(request);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.SlikaThumb = file;
                txtSlikaInput.Text = fileName;
                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
                //radi
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
