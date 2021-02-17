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

namespace Rent_A_Car.WinUI.Klijent
{
    public partial class frmKlijentDetalji : Form
    {
        private readonly APIService _service = new APIService("klijent");
        private int? _id = null;
        public frmKlijentDetalji(int? klijentId = null)
        {
            InitializeComponent();
            _id = klijentId;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                var request = new KlijentInsertRequest()
                {
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    BrojTel = txtTelefon.Text,
                    Adresa = txtAdresa.Text,
                    DatumRodjenja = txtAdresa.Text,
                    //Password = txtPassword.Text,
                    //PasswordConfirmation = txtPasswordPotvrda.Text
                };

                if (_id.HasValue)
                {
                    await _service.Update<Model.Klijent>(_id, request);
                }
                else
                {
                    await _service.Insert<Model.Klijent>(request);
                }

                MessageBox.Show("Uspjesno ste dodali klijenta");
            }
        }

        private async void frmKlijentDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var klijent = await _service.GetById<Model.Klijent>(_id);

                txtKorisnickoIme.Text = klijent.KorisnickoIme;
                txtKorisnickoIme.ReadOnly = true;
                txtIme.Text = klijent.Ime;
                txtIme.ReadOnly = true;
                txtPrezime.Text = klijent.Prezime;
                txtPrezime.ReadOnly = true;
                txtEmail.Text = klijent.Email;
                txtEmail.ReadOnly = true;
                txtAdresa.Text = klijent.Adresa;
                txtAdresa.ReadOnly = true;
                txtTelefon.Text = klijent.BrojTel;
                txtTelefon.ReadOnly = true;
                txtDatumRodjenja.Text = klijent.DatumRodjenja;
                txtDatumRodjenja.ReadOnly = true;
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtKorisnickoIme.Text.Length < 3)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validacija_ObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validacija_ObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validacija_ObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validacija_ObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validacija_ObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider.SetError(txtAdresa, Properties.Resources.Validacija_ObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAdresa, null);
            }
        }

        private void txtDatumRodjenja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDatumRodjenja.Text))
            {
                errorProvider.SetError(txtDatumRodjenja, Properties.Resources.Validacija_ObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDatumRodjenja, null);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
