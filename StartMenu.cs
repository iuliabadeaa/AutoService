using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoServiceCuNET;

namespace AutoServiceCuNET
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            AppointmentWindow appointmentWindow = new AppointmentWindow(this);
            appointmentWindow.Show();
            this.Hide();
        }

        private void SeeServicesBtn_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm(this);
            serviceForm.Show();
            this.Hide();
        }

        private void ContactDtlBtn_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact(this);
            contact.Show();
            this.Hide();
        }

        public static string email = "";
        private void StartMenu_Load(object sender, EventArgs e)
        {
            if (LogIn.email == "")
            {
                email = SignIn.email;
            }
            else
            {
                email = LogIn.email;
            }
        }
    }
}
