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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SeeProducts_Click(object sender, EventArgs e)
        {
            ServicesAdmin servicesAdmin=new ServicesAdmin(this);
            servicesAdmin.Show();
            this.Hide();
        }

        private void seeAppointments_Click(object sender, EventArgs e)
        {
            AptmListAdmin aptmListAdmin = new AptmListAdmin(this);
            aptmListAdmin.Show();
            this.Hide();
        }

        private void seeClients_Click(object sender, EventArgs e)
        {
            ClientsAdmin clientsAdmin=new ClientsAdmin(this);
            clientsAdmin.Show();
            this.Hide();
        }
    }
}
