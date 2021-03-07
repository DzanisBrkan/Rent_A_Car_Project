using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car.WinUI
{
    public partial class frmVozilaKalendarFINAL : Form
    {

        private readonly APIService _apiService = new APIService("Rezervacija");
        private readonly APIService _apiServiceVozilo = new APIService("Vozilo");

        public frmVozilaKalendarFINAL()
        {
            InitializeComponent();
        }


        public ObservableCollection<Model.Rezervacija> RezervacijaList { get; set; } = new ObservableCollection<Model.Rezervacija>();
        public ObservableCollection<Model.Rezervacija> PronadjeneRezervacijaList { get; set; } = new ObservableCollection<Model.Rezervacija>();

        public ObservableCollection<Model.Vozilo> VozilaList { get; set; } = new ObservableCollection<Model.Vozilo>();
        public ObservableCollection<Model.Vozilo> RezervisanaVozilaList { get; set; } = new ObservableCollection<Model.Vozilo>();

        private async void frmVozilaKalendarFINAL_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Show();
            flowLayoutPanel2.Hide();
            flowLayoutPanel4.Hide();
            flowLayoutPanel5.Hide();
            flowLayoutPanel6.Hide();
            flowLayoutPanel7.Hide();
            flowLayoutPanel8.Hide();
            flowLayoutPanel9.Hide();
            flowLayoutPanel10.Hide();
            flowLayoutPanel11.Hide();
            flowLayoutPanel12.Hide();
            flowLayoutPanel13.Hide();
            flowLayoutPanel14.Hide();
            flowLayoutPanel15.Hide();
            flowLayoutPanel16.Hide();
            flowLayoutPanel17.Hide();
            flowLayoutPanel18.Hide();
            flowLayoutPanel19.Hide();
            flowLayoutPanel20.Hide();
            flowLayoutPanel21.Hide();
            flowLayoutPanel22.Hide();
            flowLayoutPanel23.Hide();
            flowLayoutPanel24.Hide();
            flowLayoutPanel25.Hide();
            flowLayoutPanel26.Hide();
            flowLayoutPanel27.Hide();
            flowLayoutPanel28.Hide();
            flowLayoutPanel29.Hide();
            flowLayoutPanel30.Hide();
            flowLayoutPanel31.Hide();
            flowLayoutPanel32.Hide();

            //----------------------REZERVACIJA-------------------------------------------------------------------------


            var result = await _apiService.Get<List<Model.Rezervacija>>(null);



            //DateTime rezevacije = (DateTime)result.FirstOrDefault().PocetakRezervacije;
            //int DaniRezervacije = rezevacije.Day;
            //int MjeseciRezervacije = rezevacije.Month;
            //listaRezeVacija - ima ih 20
            //proc kroz listu i uzet

            RezervacijaList.Clear();
            foreach (var rez in result)
            {
                RezervacijaList.Add(rez);
            }

            PronadjeneRezervacijaList.Clear();
            for (int i = 0; i < RezervacijaList.Count; i++)
            {
                if (RezervacijaList[i].Status == "U toku")
                {
                    PronadjeneRezervacijaList.Add(RezervacijaList[i]);
                }
            }

            DateTime[] rezevacijePocetak = new DateTime[PronadjeneRezervacijaList.Count()];
            DateTime[] rezevacijeKraj = new DateTime[PronadjeneRezervacijaList.Count()];

            for (int i = 0; i < PronadjeneRezervacijaList.Count; i++)
            {
                rezevacijePocetak[i] = (DateTime)PronadjeneRezervacijaList[i].PocetakRezervacije;
                rezevacijeKraj[i] = (DateTime)PronadjeneRezervacijaList[i].KrajRezervacije;
            }

            //int DaniRezervacije = rezevacije.Day;
            //int MjeseciRezervacije = rezevacije.Month;


            //---------------------VOZILO-------------------------------------------------------------------------


            //var vozilo = await _apiServiceVozilo.Get<Model.Vozilo>(null);
            //listaVozila  - ima ih 30
            //listaVozila.VoziloID
            //proc kroz listu rezervacija i uzet samo ona vozila koja su rezervisana i spremit u listuVozila
            var vozila = await _apiServiceVozilo.Get<List<Model.Vozilo>>(null);



            VozilaList.Clear();
            foreach (var voz in vozila)
            {
                VozilaList.Add(voz);
            }

            RezervisanaVozilaList.Clear();
            for (int i = 0; i < VozilaList.Count; i++)
            {
                for (int j = 0; j < PronadjeneRezervacijaList.Count; j++)
                {
                    if (VozilaList[i].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                    {
                        RezervisanaVozilaList.Add(VozilaList[i]);
                    }
                }

            }


            //----------------------DANI-------------------------------------------------------------------------

            int BrojDana = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            int DayInWeek = (int)DateTime.Now.DayOfWeek;

            int Mjesec = DateTime.Now.Month;
            int Godina = DateTime.Now.Year;


            int num;
            string rezultat = null;
            num = DayInWeek;

            switch (Mjesec)
            {
                case 1:
                    rezultat = "Januar";
                    break;
                case 2:
                    rezultat = "Februar";
                    break;
                case 3:
                    rezultat = "Mart";
                    break;
                case 4:
                    rezultat = "April";
                    break;
                case 5:
                    rezultat = "Maj";
                    break;
                case 6:
                    rezultat = "Juni";
                    break;
                case 7:
                    rezultat = "Juli";
                    break;
                case 8:
                    rezultat = "Avgust";
                    break;

                case 9:
                    rezultat = "Septembar";
                    break;

                case 10:
                    rezultat = "Oktobar";
                    break;

                case 11:
                    rezultat = "Novembar";
                    break;

                case 12:
                    rezultat = "Decembar";
                    break;
                    //default:
                    //    Console.WriteLine("That's not a day..");
                    //    goto label;
            }

            label32.Text = Godina + " , " + rezultat;

            //----------------------KALENDAR-------------------------------------------------------------------------

            if (BrojDana == 28)
            {
                for (int i = 0; i < BrojDana; i++)
                {
                    if (i == 0 || i == 7 || i == 14 || i == 21 || i == 28 || i == 35)
                    {
                        if (i == 0)
                        {
                            label1.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel1.Show();

                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel1.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label2.Text = label2.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }


                        }
                        if (i == 7)
                        {
                            label15.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel8.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel8.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label16.Text = label16.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 14)
                        {
                            label29.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel15.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel15.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label30.Text = label30.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 21)
                        {
                            label44.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel22.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel22.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label45.Text = label45.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 1 || i == 8 || i == 15 || i == 22 || i == 29 || i == 36)
                    {

                        if (i == 1)
                        {
                            label3.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel2.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel2.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label4.Text = label4.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 8)
                        {
                            label17.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel9.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel9.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label18.Text = label18.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 15)
                        {
                            label31.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel16.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel16.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label33.Text = label33.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 22)
                        {
                            label46.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel23.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel23.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label47.Text = label47.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 2 || i == 9 || i == 16 || i == 23 || i == 30 || i == 37)
                    {
                        if (i == 2)
                        {
                            label5.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel3.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel3.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label6.Text = label65.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 9)
                        {
                            label19.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel10.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel10.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label20.Text = label20.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 16)
                        {
                            label34.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel17.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel17.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label35.Text = label35.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 23)
                        {
                            label48.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel24.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel24.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label49.Text = label49.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 3 || i == 10 || i == 17 || i == 24 || i == 31 || i == 38)
                    {
                        if (i == 3)
                        {
                            label7.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel4.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel4.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label8.Text = label8.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 10)
                        {
                            label21.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel11.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel11.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label22.Text = label22.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 17)
                        {
                            label36.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel18.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel18.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label37.Text = label37.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 24)
                        {
                            label50.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel25.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel25.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label51.Text = label51.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 4 || i == 11 || i == 18 || i == 25 || i == 32 || i == 39)
                    {
                        if (i == 4)
                        {
                            label9.Text = "Petak, " + (i + 1);
                            flowLayoutPanel5.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel5.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label10.Text = label10.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 11)
                        {
                            label23.Text = "Petak, " + (i + 1);
                            flowLayoutPanel12.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel12.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label24.Text = label24.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 18)
                        {
                            label38.Text = "Petak, " + (i + 1);
                            flowLayoutPanel19.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel19.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label39.Text = label39.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 25)
                        {
                            label52.Text = "Petak, " + (i + 1);
                            flowLayoutPanel26.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel26.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label53.Text = label53.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 5 || i == 12 || i == 19 || i == 26 || i == 33 || i == 40)
                    {
                        if (i == 5)
                        {
                            label11.Text = "Subota, " + (i + 1);
                            flowLayoutPanel6.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel6.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label12.Text = label12.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 12)
                        {
                            label25.Text = "Subota, " + (i + 1);
                            flowLayoutPanel13.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel13.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label26.Text = label26.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                        if (i == 19)
                        {
                            label40.Text = "Subota, " + (i + 1);
                            flowLayoutPanel20.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel20.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label41.Text = label41.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 26)
                        {
                            label54.Text = "Subota, " + (i + 1);
                            flowLayoutPanel27.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel27.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label55.Text = label55.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 6 || i == 13 || i == 20 || i == 27 || i == 34 || i == 41)
                    {
                        if (i == 6)
                        {
                            label13.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel7.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel7.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label14.Text = label14.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 13)
                        {
                            label27.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel14.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel14.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label28.Text = label28.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                        if (i == 20)
                        {
                            label42.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel21.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel21.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label43.Text = label43.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                        if (i == 27)
                        {
                            label56.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel28.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel28.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label57.Text = label57.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }


            if (BrojDana == 29)
            {
                for (int i = 0; i < BrojDana; i++)
                {
                    if (i == 0 || i == 7 || i == 14 || i == 21 || i == 28 || i == 35)
                    {
                        if (i == 0)
                        {
                            label1.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel1.Show();

                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel1.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label2.Text = label2.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }


                        }

                        if (i == 7)
                        {
                            label15.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel8.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel8.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label16.Text = label16.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 14)
                        {
                            label29.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel15.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel15.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label30.Text = label30.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 21)
                        {
                            label44.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel22.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel22.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label45.Text = label45.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 28)
                        {
                            label58.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel29.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel29.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label59.Text = label59.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (i == 1 || i == 8 || i == 15 || i == 22 || i == 29 || i == 36)
                    {

                        if (i == 1)
                        {
                            label3.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel2.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel2.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label4.Text = label4.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 8)
                        {
                            label17.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel9.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel9.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label18.Text = label18.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 15)
                        {
                            label31.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel16.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel16.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label33.Text = label33.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 22)
                        {
                            label46.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel23.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel23.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label47.Text = label47.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                    }
                    if (i == 2 || i == 9 || i == 16 || i == 23 || i == 30 || i == 37)
                    {
                        if (i == 2)
                        {
                            label5.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel3.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel3.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label6.Text = label65.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 9)
                        {
                            label19.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel10.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel10.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label20.Text = label20.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 16)
                        {
                            label34.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel17.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel17.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label35.Text = label35.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 23)
                        {
                            label48.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel24.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel24.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label49.Text = label49.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }


                    }
                    if (i == 3 || i == 10 || i == 17 || i == 24 || i == 31 || i == 38)
                    {
                        if (i == 3)
                        {
                            label7.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel4.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel4.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label8.Text = label8.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 10)
                        {
                            label21.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel11.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel11.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label22.Text = label22.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 17)
                        {
                            label36.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel18.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel18.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label37.Text = label37.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 24)
                        {
                            label50.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel25.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel25.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label51.Text = label51.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }



                    }
                    if (i == 4 || i == 11 || i == 18 || i == 25 || i == 32 || i == 39)
                    {
                        if (i == 4)
                        {
                            label9.Text = "Petak, " + (i + 1);
                            flowLayoutPanel5.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel5.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label10.Text = label10.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 11)
                        {
                            label23.Text = "Petak, " + (i + 1);
                            flowLayoutPanel12.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel12.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label24.Text = label24.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 18)
                        {
                            label38.Text = "Petak, " + (i + 1);
                            flowLayoutPanel19.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel19.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label39.Text = label39.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 25)
                        {
                            label52.Text = "Petak, " + (i + 1);
                            flowLayoutPanel26.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel26.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label53.Text = label53.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }



                    }
                    if (i == 5 || i == 12 || i == 19 || i == 26 || i == 33 || i == 40)
                    {
                        if (i == 5)
                        {
                            label11.Text = "Subota, " + (i + 1);
                            flowLayoutPanel6.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel6.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label12.Text = label12.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 12)
                        {
                            label25.Text = "Subota, " + (i + 1);
                            flowLayoutPanel13.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel13.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label26.Text = label26.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                        if (i == 19)
                        {
                            label40.Text = "Subota, " + (i + 1);
                            flowLayoutPanel20.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel20.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label41.Text = label41.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 26)
                        {
                            label54.Text = "Subota, " + (i + 1);
                            flowLayoutPanel27.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel27.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label55.Text = label55.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 6 || i == 13 || i == 20 || i == 27 || i == 34 || i == 41)
                    {
                        if (i == 6)
                        {
                            label13.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel7.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel7.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label14.Text = label14.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 13)
                        {
                            label27.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel14.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel14.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label28.Text = label28.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                        if (i == 20)
                        {
                            label42.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel21.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel21.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label43.Text = label43.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }

                        if (i == 27)
                        {
                            label56.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel28.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel28.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label57.Text = label57.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }


            if (BrojDana == 30)
            {
                for (int i = 0; i < BrojDana; i++)
                {
                    if (i == 0 || i == 7 || i == 14 || i == 21 || i == 28 || i == 35)
                    {
                        if (i == 0)
                        {
                            label1.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel1.Show();

                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel1.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label2.Text = label2.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }


                        }

                        if (i == 7)
                        {
                            label15.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel8.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel8.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label16.Text = label16.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 14)
                        {
                            label29.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel15.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel15.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label30.Text = label30.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 21)
                        {
                            label44.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel22.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel22.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label45.Text = label45.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 28)
                        {
                            label58.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel29.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel29.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label59.Text = label59.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (i == 1 || i == 8 || i == 15 || i == 22 || i == 29 || i == 36)
                    {

                        if (i == 1)
                        {
                            label3.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel2.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel2.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label4.Text = label4.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 8)
                        {
                            label17.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel9.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel9.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label18.Text = label18.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 15)
                        {
                            label31.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel16.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel16.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label33.Text = label33.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 22)
                        {
                            label46.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel23.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel23.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label47.Text = label47.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 29)
                        {
                            label60.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel30.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel30.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label61.Text = label61.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 2 || i == 9 || i == 16 || i == 23 || i == 30 || i == 37)
                    {
                        if (i == 2)
                        {
                            label5.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel3.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel3.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label6.Text = label65.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 9)
                        {
                            label19.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel10.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel10.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label20.Text = label20.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 16)
                        {
                            label34.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel17.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel17.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label35.Text = label35.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 23)
                        {
                            label48.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel24.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel24.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label49.Text = label49.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }


                    }
                    if (i == 3 || i == 10 || i == 17 || i == 24 || i == 31 || i == 38)
                    {
                        if (i == 3)
                        {
                            label7.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel4.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel4.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label8.Text = label8.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 10)
                        {
                            label21.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel11.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel11.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label22.Text = label22.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 17)
                        {
                            label36.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel18.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel18.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label37.Text = label37.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 24)
                        {
                            label50.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel25.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel25.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label51.Text = label51.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }



                    }
                    if (i == 4 || i == 11 || i == 18 || i == 25 || i == 32 || i == 39)
                    {
                        if (i == 4)
                        {
                            label9.Text = "Petak, " + (i + 1);
                            flowLayoutPanel5.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel5.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label10.Text = label10.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 11)
                        {
                            label23.Text = "Petak, " + (i + 1);
                            flowLayoutPanel12.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel12.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label24.Text = label24.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 18)
                        {
                            label38.Text = "Petak, " + (i + 1);
                            flowLayoutPanel19.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel19.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label39.Text = label39.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 25)
                        {
                            label52.Text = "Petak, " + (i + 1);
                            flowLayoutPanel26.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel26.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label53.Text = label53.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }



                    }
                    if (i == 5 || i == 12 || i == 19 || i == 26 || i == 33 || i == 40)
                    {
                        if (i == 5)
                        {
                            label11.Text = "Subota, " + (i + 1);
                            flowLayoutPanel6.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel6.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label12.Text = label12.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 12)
                        {
                            label25.Text = "Subota, " + (i + 1);
                            flowLayoutPanel13.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel13.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label26.Text = label26.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                        if (i == 19)
                        {
                            label40.Text = "Subota, " + (i + 1);
                            flowLayoutPanel20.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel20.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label41.Text = label41.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 26)
                        {
                            label54.Text = "Subota, " + (i + 1);
                            flowLayoutPanel27.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel27.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label55.Text = label55.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 6 || i == 13 || i == 20 || i == 27 || i == 34 || i == 41)
                    {
                        if (i == 6)
                        {
                            label13.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel7.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel7.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label14.Text = label14.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 13)
                        {
                            label27.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel14.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel14.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label28.Text = label28.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                        if (i == 20)
                        {
                            label42.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel21.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel21.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label43.Text = label43.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }

                        if (i == 27)
                        {
                            label56.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel28.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel28.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label57.Text = label57.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }


            if (BrojDana == 31)
            {
                for (int i = 0; i < BrojDana; i++)
                {
                    if (i == 0 || i == 7 || i == 14 || i == 21 || i == 28 || i == 35)
                    {
                        if (i == 0)
                        {
                            label1.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel1.Show();

                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel1.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label2.Text = label2.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }


                        }

                        if (i == 7)
                        {
                            label15.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel8.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel8.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label16.Text = label16.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 14)
                        {
                            label29.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel15.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel15.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label30.Text = label30.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 21)
                        {
                            label44.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel22.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel22.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label45.Text = label45.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 28)
                        {
                            label58.Text = "Ponedjeljak, " + (i + 1);
                            flowLayoutPanel29.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel29.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label59.Text = label59.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (i == 1 || i == 8 || i == 15 || i == 22 || i == 29 || i == 36)
                    {

                        if (i == 1)
                        {
                            label3.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel2.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel2.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label4.Text = label4.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 8)
                        {
                            label17.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel9.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel9.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label18.Text = label18.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 15)
                        {
                            label31.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel16.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel16.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label33.Text = label33.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 22)
                        {
                            label46.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel23.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel23.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label47.Text = label47.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 29)
                        {
                            label60.Text = "Utorak, " + (i + 1);
                            flowLayoutPanel30.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel30.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label61.Text = label61.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 2 || i == 9 || i == 16 || i == 23 || i == 30 || i == 37)
                    {
                        if (i == 2)
                        {
                            label5.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel3.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel3.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label6.Text = label65.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 9)
                        {
                            label19.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel10.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel10.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label20.Text = label20.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 16)
                        {
                            label34.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel17.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel17.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label35.Text = label35.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 23)
                        {
                            label48.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel24.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel24.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label49.Text = label49.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 30)
                        {
                            label62.Text = "Srijeda, " + (i + 1);
                            flowLayoutPanel31.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel31.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label63.Text = label63.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 3 || i == 10 || i == 17 || i == 24 || i == 31 || i == 38)
                    {
                        if (i == 3)
                        {
                            label7.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel4.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel4.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label8.Text = label8.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 10)
                        {
                            label21.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel11.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel11.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label22.Text = label22.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 17)
                        {
                            label36.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel18.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel18.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label37.Text = label37.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 24)
                        {
                            label50.Text = "Cetvrtak, " + (i + 1);
                            flowLayoutPanel25.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel25.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label51.Text = label51.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }



                    }
                    if (i == 4 || i == 11 || i == 18 || i == 25 || i == 32 || i == 39)
                    {
                        if (i == 4)
                        {
                            label9.Text = "Petak, " + (i + 1);
                            flowLayoutPanel5.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel5.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label10.Text = label10.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 11)
                        {
                            label23.Text = "Petak, " + (i + 1);
                            flowLayoutPanel12.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel12.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label24.Text = label24.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 18)
                        {
                            label38.Text = "Petak, " + (i + 1);
                            flowLayoutPanel19.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel19.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label39.Text = label39.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 25)
                        {
                            label52.Text = "Petak, " + (i + 1);
                            flowLayoutPanel26.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel26.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label53.Text = label53.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }



                    }
                    if (i == 5 || i == 12 || i == 19 || i == 26 || i == 33 || i == 40)
                    {
                        if (i == 5)
                        {
                            label11.Text = "Subota, " + (i + 1);
                            flowLayoutPanel6.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel6.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label12.Text = label12.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 12)
                        {
                            label25.Text = "Subota, " + (i + 1);
                            flowLayoutPanel13.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel13.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label26.Text = label26.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                        if (i == 19)
                        {
                            label40.Text = "Subota, " + (i + 1);
                            flowLayoutPanel20.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel20.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label41.Text = label41.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 26)
                        {
                            label54.Text = "Subota, " + (i + 1);
                            flowLayoutPanel27.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel27.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label55.Text = label55.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i == 6 || i == 13 || i == 20 || i == 27 || i == 34 || i == 41)
                    {
                        if (i == 6)
                        {
                            label13.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel7.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel7.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label14.Text = label14.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }
                        }

                        if (i == 13)
                        {
                            label27.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel14.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel14.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label28.Text = label28.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                        if (i == 20)
                        {
                            label42.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel21.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel21.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label43.Text = label43.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }

                        if (i == 27)
                        {
                            label56.Text = "Nedelja, " + (i + 1);
                            flowLayoutPanel28.Show();
                            for (int j = 0; j < PronadjeneRezervacijaList.Count(); j++)
                            {
                                if ((i + 1) >= rezevacijePocetak[j].Day && (i + 1) <= rezevacijeKraj[j].Day)
                                {
                                    flowLayoutPanel28.BackColor = Color.LightPink;
                                    for (int k = 0; k < RezervisanaVozilaList.Count(); k++)
                                    {
                                        if (RezervisanaVozilaList[k].VoziloID == PronadjeneRezervacijaList[j].VoziloId)
                                        {
                                            label57.Text = label57.Text + "," + RezervisanaVozilaList[k].Marka;

                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
