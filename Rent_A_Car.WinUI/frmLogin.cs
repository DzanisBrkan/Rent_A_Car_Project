using Rent_A_Car.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car.WinUI
{
    public partial class frmLogin : Form
    {

        APIService _service = new APIService("Zaposlenik"); //ovdje moze stajati sta god


        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Obavezno unesite korisničko ime i lozinku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;


                await _service.Get<dynamic>(null);

                var request = new ZaposlenikSearchRequest()
                {
                    KorisnickoIme = txtUsername.Text
                };


                var user = await _service.Get<List<Model.Zaposlenik>>(request);

                for (int i = 0; i < user.Count; i++)
                {
                    if (txtUsername.Text == user[i].KorisnickoIme)
                    {
                        var id = user[i].ZaposlenikId;
                        APIService.UserID = id;
                    }
                }

                



                //OVO DOLE ZA ROLE 


                //var obj = user.First();
                //if (obj.RoleID == 2)
                //{
                //    MessageBox.Show("Administrator sa unesenim kredencijalima ne postoji!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                //else
                //{
                //    MessageBox.Show("Uspješno ste se logovali!", "Uspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}




                //frmIndex frm = new frmIndex();
                FormAdmin frm = new FormAdmin(APIService.UserID);
                frm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
