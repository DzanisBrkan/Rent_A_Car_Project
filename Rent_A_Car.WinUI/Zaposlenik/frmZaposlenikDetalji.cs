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
        private int? _id = null;
        public frmZaposlenikDetalji(int? zaposlenikId = null)
        {
            InitializeComponent();
            _id = zaposlenikId;
        }

        private void Adresa_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new ZaposlenikUpsertRequest()
                {
                   
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    KontaktBr = txtTelefon.Text,
                    DatumRodjenja = txtAdresa.Text,
                    Spol = txtAdresa.Text,
                    //Password = txtPassword.Text,
                    //PasswordConfirmation = txtPasswordPotvrda.Text
                };
 
   
                if (_id.HasValue)
                {
                     _service.Update<Model.Zaposlenik>(_id, request);

                }
                //else
                //{
                //    await _service.Insert<Model.Zaposlenik>(request);
                //}

                MessageBox.Show("Uspjesno ste promijenili postavke profila!");
            }
        }
    }
}
