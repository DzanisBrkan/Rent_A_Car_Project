using GMap.NET.MapProviders;
using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        public frmVozilo()
        {
            InitializeComponent();
        }

        private async void frmVozilo_Load(object sender, EventArgs e)
        {
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
        }

        VoziloUpsertRequest request = new VoziloUpsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {

            double x0 = 43.322802;
            double y0 = 17.813955;
            Random random = new Random();

            // Convert radius from meters to degrees
            double radiusInDegrees = 500 / 111000f;

            double u = random.NextDouble();
            double v = random.NextDouble();
            double w = radiusInDegrees * Math.Sqrt(u);
            double t = 2 * Math.PI * v;
            double x = w * Math.Cos(t);
            double y = w * Math.Sin(t);

            // Adjust the x-coordinate for the shrinking of the east-west distances
            //double new_x = x / Math.Cos(Math.ToRadians(y0));
            var rad = (Math.PI / 180) * y0;
            double new_x = x / Math.Cos(rad);

            double foundLongitude = new_x + x0;
            double foundLatitude = y + y0;

            try
            {

                if (this.ValidateChildren())
                {
                    var _kategorijaId = 0;
                    var _tipId = 0;


                    if (cmbKategorija.Text == "A1")
                    {
                        _kategorijaId = 100;
                    }
                    else if(cmbKategorija.Text == "A")
                    {
                        _kategorijaId = 101;
                    }
                    else if(cmbKategorija.Text == "B")
                    {
                        _kategorijaId = 102;
                    }

                    if(cmbTip.Text == "Hečbek")
                    {
                        _tipId = 100;
                    }
                    else if(cmbTip.Text == "Limuzina")
                    {
                        _tipId = 101;
                    }
                    else if (cmbTip.Text == "Karavan")
                    {
                        _tipId = 102;
                    }
                    else if (cmbTip.Text == "Skuter")
                    {
                        _tipId = 103;
                    }
                    else if (cmbTip.Text == "Motor")
                    {
                        _tipId = 104;
                    }

                    //unos specifikacije
                    var specRequest = new SpecifikacijaUpsertRequest()
                    {
                        Gorivo = txtGorivo.Text,
                        EuroNorma = txtEuroNorma.Text,
                        Kubikaza = txtKubikaza.Text,
                        Konjaza = txtKonjaza.Text,
                        Kilowataza = txtKilowataza.Text,
                        Pogon = txtPogon.Text,
                        Potrosnja = txtPotrosnja.Text,
                        Godiste = txtPotrosnja.Text,
                        Mjenjac = txtMjenjac.Text
                    };
                    var specifikacija = await _specifikacijaService.Insert<Model.Specifikacija>(specRequest);

                    //unos vozila
                    var request = new VoziloUpsertRequest()
                    {
                        RegistracijskiBroj = txtRegistracijskiBroj.Text,
                        Model = txtModel.Text,
                        Marka = txtMarka.Text,
                        BrSjedista = txtBrSjedista.Text,
                        BrVrata = txtBrojVrata.Text,
                        ZapreminaPrtljaznika = txtZprPrtljaznika.Text,
                        CijenaPoSatu = Convert.ToDouble(txtCijenaPoSatu.Text),
                        SlikaThumb = file2,
                        Zauzeto = false,
                        LokacijaId = 100,
                        Langitude = foundLongitude,
                        Longitude = foundLatitude,
                        KategorijaId = _kategorijaId,
                        TipId = _tipId,
                        SpecifikacijaId = specifikacija.SpecifikacijaId
                    };

                    
                        await _voziloService.Insert<Model.Vozilo>(request);

                    MessageBox.Show("Uspjesno ste dodali vozilo i njegovu specifikaciju!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Doslo je do greske!");
            }
            this.Close();
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
        private void label12_Click(object sender, EventArgs e)
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
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
        public byte[] file2 = null;
        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "jpg files(*.jpg)|*.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                 file2 = Encoding.ASCII.GetBytes(openFileDialog1.FileName);
                request.SlikaThumb = file2;
                txtSlikaInput.Text = openFileDialog1.FileName;
                Image image = Image.FromFile(openFileDialog1.FileName);
                pictureBox.Image = image;

                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Jpeg);
                file2 = ms.ToArray();
            }

        }
    }
}
