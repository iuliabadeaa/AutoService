using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AutoServiceCuNET;
using AutoService;

namespace AutoServiceCuNET
{
    public partial class SignIn : Form
    {
        private StartPage startPage;
        public SignIn(StartPage startPage)
        {
            InitializeComponent();
            this.startPage = startPage;
        }

        public string conString = "Data Source=DESKTOP-JFU1JSP\\SQLEXPRESS;Initial Catalog=serviceAuto;Integrated Security=True";
        public static string email = "";

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            email=EmailTextBox.Text;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            User user = new User(NameTextBox.Text,SurnameTextBox.Text,email,PasswordTextBox.Text);
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into users(Name,Surname,Email,Password)values('" + user.Name + "','" + user.Surname + "','" + user.Email + "','" + user.Password + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connected successfully!");
                StartMenu startMenu = new StartMenu();
                startMenu.Show();
                this.Hide();
            }
            con.Close();
        }


        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.startPage.Show();
        }

    }
}
