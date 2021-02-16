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
    public partial class frmVoziloDetalji : Form
    {
        private readonly APIService _servicesVozilo = new APIService("Vozilo");
        private readonly APIService _servicesTip = new APIService("Tip");

        private int? _voziloId = null;

        public frmVoziloDetalji(int? voziloId = null)
        {
            InitializeComponent();
            _voziloId = voziloId;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmVoziloDetalji_Load(object sender, EventArgs e)
        {
            try
            {
                if (_voziloId.HasValue)
                {
                    var vozilo = await _servicesVozilo.GetById<Model.Vozilo>(_voziloId);
                    var tip = await _servicesTip.GetById<Model.Tip>(vozilo.TipId);

                    txtRegBr.Text = vozilo.RegistracijskiBroj;
                    txtRegBr.ReadOnly = true;

                    txtNaziv.Text = vozilo.Model + ", " + vozilo.Marka;
                    txtNaziv.ReadOnly = true;

                    txtTip.Text = tip.Naziv;
                    txtTip.ReadOnly = true;

                    txtCijena.Text = vozilo.CijenaPoSatu.ToString();
                    txtCijena.ReadOnly = true;

                    txtBrSjedista.Text = vozilo.BrSjedista;
                    txtBrSjedista.ReadOnly = true;

                    txtBrVrata.Text= vozilo.BrVrata;
                    txtBrVrata.ReadOnly = true;

                    txtZaprPrtlj.Text = vozilo.ZapreminaPrtljaznika;
                    txtZaprPrtlj.ReadOnly = true;

                    if(vozilo.Zauzeto != true)
                        textZauzeto.Text = "Slobodno";
                    else
                        textZauzeto.Text = "Zauzeto";
      
                    pictureBox1.Image = Image.FromStream(new MemoryStream(vozilo.SlikaThumb));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške!");
                throw;
            }
        }

        private void btnLociraj_Click(object sender, EventArgs e)
        {

            frmLocirajVozilo frm = new frmLocirajVozilo(int.Parse(_voziloId.ToString()));
            //frm.MdiParent = this;
            frm.Show();
        }
    }
}
