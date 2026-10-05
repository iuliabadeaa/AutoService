using AutoService;
using AutoServiceCuNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceCuNET
{
    public partial class AppointmentWindow : Form
    {
        public static string emailGlobal = StartMenu.email;
        public static string licenseNr = "", color = "", brand = "", transmission = "", time = "", date = "";
        public static int capacity, fabricationYr, hpwr;

        private StartMenu startMenu;

        public AppointmentWindow(StartMenu startMenu)
        {
            InitializeComponent();
            this.startMenu=startMenu;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.startMenu.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string conString = "Data Source=DESKTOP-JFU1JSP\\SQLEXPRESS;Initial Catalog=serviceAuto;Integrated Security=True";

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (LicenseNumber.Text == "" || Color.Text == "" || Brand.Text == "" || Transmission.Text == "" || Capacity.Text == "" || FabricationYear.Text == "" || Hpwr.Text == "")
            {
                MessageBox.Show("Please complete all fields!");
            }
            else
            {
                licenseNr = LicenseNumber.Text;
                color = Color.Text;
                brand = Brand.Text;
                transmission = Transmission.Text;
                capacity = int.Parse(Capacity.Text);
                fabricationYr = int.Parse(FabricationYear.Text);
                hpwr = int.Parse(Hpwr.Text);

                User user = new User(emailGlobal);
                Car car = new Car(licenseNr, color, capacity, fabricationYr, hpwr, brand, transmission);
                foreach (object itemChecked in Time.CheckedItems)
                {
                    time = itemChecked.ToString();
                }
                date = DateAndTime.SelectionRange.Start.ToShortDateString();
                Appointment appointment = new Appointment(user, car, date, time);
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into appointment(licenseNumber,fabricationYear,capacity,color,brand,hpwr,transmission,date,time,email)values('" + appointment.Car.LicenseNumber + "','" + appointment.Car.FabricationYear + "','" + appointment.Car.Capacity + "','" + appointment.Car.Color + "','" + appointment.Car.Brand + "','" + appointment.Car.HorsePower + "','" + appointment.Car.Transmission + "','" + appointment.Date + "','" + appointment.Hour + "','" + appointment.User.Email + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment made successfully!");

                }
                con.Close();
                AptmDetails aptmDetails = new AptmDetails(this);
                aptmDetails.Show();
                this.Hide();
            }
        }
    }
}
