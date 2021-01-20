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

namespace Rent_A_Car.WinUI.Zaposlenik
{
    public partial class frmZaposlenikDetalji : Form
    {

        private readonly APIService _service = new APIService("Zaposlenik");
        private readonly APIService _korisnickiNalogService = new APIService("KorisnickiNalog");
        private int? _id = null;

        public frmZaposlenikDetalji(int? ZaposlenikId = null)
        {
            InitializeComponent();
            _id = ZaposlenikId;
        }

        private void Adresa_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //treba napraviti da Loaduje odabrani korisnicki nalog za zaposlenika kojem mijenjamo detalje

        private async void frmZaposlenikDetalji_Load(object sender, EventArgs e)
        {
            await LoadKorisnickiNalog();
            //var nalog = await _korisnickiNalogService.Get<List<Model.KorisnickiNalog>>(null);
            //clbRole.DisplayMember = "TipKorisnickogNaloga";
            //clbRole.DataSource = nalog;
            if (_id.HasValue)
            {
                var zaposlenik = await _service.GetById<Model.Zaposlenik>(_id);

                txtIme.Text = zaposlenik.Ime;
                txtPrezime.Text = zaposlenik.Prezime;
                txtEmail.Text = zaposlenik.Email;
                txtTelefon.Text = zaposlenik.KontaktBr;
                txtDatumRodjenja.Text = zaposlenik.DatumRodjenja;
                txtSpol.Text = zaposlenik.Spol;
                //txtGrad.Text = zaposlenik.GradId.ToString();
                txtGrad.Text = zaposlenik.KorisnickiNalog.TipKorisnickogNaloga;
                txtKorisnickoIme.Text = zaposlenik.KorisnickoIme;
            }

        }
        private async Task LoadKorisnickiNalog()
        {
            var result = await _korisnickiNalogService.Get<List<Model.KorisnickiNalog>>(null);
            result.Insert(0, new Model.KorisnickiNalog());
            cmbKorisnickiNalog.DisplayMember = "TipKorisnickogNaloga";
            cmbKorisnickiNalog.ValueMember = "KorisnickiNalogId";
            cmbKorisnickiNalog.DataSource = result;
        }

        //treba napraviti da spasava odabrani korisnicki nalog
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var idObjekta = cmbKorisnickiNalog.SelectedValue;

            if (this.ValidateChildren())
            {

                var request = new ZaposlenikInsertRequest()
                {
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Kontakt_br = txtTelefon.Text,
                    Spol = txtSpol.Text,
                    GradId = Convert.ToInt32(idObjekta),
                    DatumRodjenja = txtDatumRodjenja.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordPotvrda.Text

            };

                var korisnickiNalog = cmbKorisnickiNalog.SelectedValue;

                if (int.TryParse(korisnickiNalog.ToString(), out int korisnickiNalogId))
                {
                    request.KorisnickiNalogId = korisnickiNalogId;
                }

                if (_id.HasValue)
                {
                    await _service.Update<Model.Zaposlenik>(_id, request);
                }
                else
                {
                    await _service.Insert<Model.Zaposlenik>(request);
                }

                MessageBox.Show("Zaposlenik spjesno dodan!");
            }
        }
    }
}
