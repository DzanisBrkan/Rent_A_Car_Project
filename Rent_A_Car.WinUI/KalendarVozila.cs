using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car.WinUI
{
    public partial class KalendarVozila : Form
    {
        public KalendarVozila()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void axCalendar1_OnDayClick(object sender, AxCALENDARLib._DCalendarEvents_OnDayClickEvent e)
        {

        }

        private void KalendarVozila_Load(object sender, EventArgs e) 
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
            flowLayoutPanel3.Hide();
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

            int BrojDana = DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month);

            

            if (BrojDana == 31)
            {
                flowLayoutPanel2.Show();
                flowLayoutPanel4.Show();
                flowLayoutPanel5.Show();
                flowLayoutPanel6.Show();
                flowLayoutPanel7.Show();
                flowLayoutPanel8.Show();
                flowLayoutPanel9.Show();
                flowLayoutPanel10.Show();
                flowLayoutPanel3.Show();
                flowLayoutPanel11.Show();
                flowLayoutPanel12.Show();
                flowLayoutPanel13.Show();
                flowLayoutPanel14.Show();
                flowLayoutPanel15.Show();
                flowLayoutPanel16.Show();
                flowLayoutPanel17.Show();
                flowLayoutPanel18.Show();
                flowLayoutPanel19.Show();
                flowLayoutPanel20.Show();
                flowLayoutPanel21.Show();
                flowLayoutPanel22.Show();
                flowLayoutPanel23.Show();
                flowLayoutPanel24.Show();
                flowLayoutPanel25.Show();
                flowLayoutPanel26.Show();
                flowLayoutPanel27.Show();
                flowLayoutPanel28.Show();
                flowLayoutPanel29.Show();
                flowLayoutPanel30.Show();
                flowLayoutPanel31.Show();
                flowLayoutPanel32.Show();

            }
            else if ( BrojDana == 30)
            {
                flowLayoutPanel2.Show();
                flowLayoutPanel4.Show();
                flowLayoutPanel5.Show();
                flowLayoutPanel6.Show();
                flowLayoutPanel7.Show();
                flowLayoutPanel8.Show();
                flowLayoutPanel9.Show();
                flowLayoutPanel10.Show();
                flowLayoutPanel3.Show();
                flowLayoutPanel11.Show();
                flowLayoutPanel12.Show();
                flowLayoutPanel13.Show();
                flowLayoutPanel14.Show();
                flowLayoutPanel15.Show();
                flowLayoutPanel16.Show();
                flowLayoutPanel17.Show();
                flowLayoutPanel18.Show();
                flowLayoutPanel19.Show();
                flowLayoutPanel20.Show();
                flowLayoutPanel21.Show();
                flowLayoutPanel22.Show();
                flowLayoutPanel23.Show();
                flowLayoutPanel24.Show();
                flowLayoutPanel25.Show();
                flowLayoutPanel26.Show();
                flowLayoutPanel27.Show();
                flowLayoutPanel28.Show();
                flowLayoutPanel29.Show();
                flowLayoutPanel30.Show();
                flowLayoutPanel31.Show();
            }
            else if (BrojDana == 28)
            {
                flowLayoutPanel2.Show();
                flowLayoutPanel4.Show();
                flowLayoutPanel5.Show();
                flowLayoutPanel6.Show();
                flowLayoutPanel7.Show();
                flowLayoutPanel8.Show();
                flowLayoutPanel9.Show();
                flowLayoutPanel10.Show();
                flowLayoutPanel3.Show();
                flowLayoutPanel11.Show();
                flowLayoutPanel12.Show();
                flowLayoutPanel13.Show();
                flowLayoutPanel14.Show();
                flowLayoutPanel15.Show();
                flowLayoutPanel16.Show();
                flowLayoutPanel17.Show();
                flowLayoutPanel18.Show();
                flowLayoutPanel19.Show();
                flowLayoutPanel20.Show();
                flowLayoutPanel21.Show();
                flowLayoutPanel22.Show();
                flowLayoutPanel23.Show();
                flowLayoutPanel24.Show();
                flowLayoutPanel25.Show();
                flowLayoutPanel26.Show();
                flowLayoutPanel27.Show();
                flowLayoutPanel28.Show();
                flowLayoutPanel29.Show();
              
            }
        }


       


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {

        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {

        }
    }
}
