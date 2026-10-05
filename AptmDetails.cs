using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceCuNET
{
    public partial class AptmDetails : Form
    {
        private AppointmentWindow AppointmentWindow;
        public AptmDetails(AppointmentWindow appointmentWindow)
        {
            InitializeComponent();
            this.AppointmentWindow = appointmentWindow;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.AppointmentWindow.Show();
        }

        private void AptmDetails_Load(object sender, EventArgs e)
        {
            EmailLbl.Text = AppointmentWindow.emailGlobal;
            licenselbl.Text = AppointmentWindow.licenseNr;
            fabrYr.Text = AppointmentWindow.fabricationYr.ToString();
            capacity.Text=AppointmentWindow.capacity.ToString();
            color.Text=AppointmentWindow.color;
            brand.Text=AppointmentWindow.brand;
            hpwr.Text=AppointmentWindow.hpwr.ToString();
            transmission.Text=AppointmentWindow.transmission;
            date.Text=AppointmentWindow.date;
            hour.Text = AppointmentWindow.time;
        }
    }
}
