﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Rent_A_Car.WinUI.Ugovor
{
    public partial class frmUgovorDetalji : Form
    {
        private readonly APIService _services = new APIService("Ugovor");
        private int? _id = null;
        public frmUgovorDetalji(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmUgovorDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var ugovor = await _services.GetById<Model.Ugovor>(_id);

                txtDatum.Text = ugovor.Datum;
                txtUkupnaCijena.Text = ugovor.UkupnaCijena;
                txtUkupnaKolicina.Text = ugovor.UkupnaKolicina.ToString();
                if (ugovor.Placen == 1)
                {
                    cbPlacen.Checked = true;
                }
                else
                {
                    cbPlacen.Checked = false;
                }
            }
        }
    }
}
