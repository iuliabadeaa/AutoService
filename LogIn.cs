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
using System.Security.Cryptography.X509Certificates;
using AutoService;

namespace AutoServiceCuNET
{
    
    public partial class LogIn : Form
    {
        private StartPage startPage;
        public LogIn(StartPage startPage)
        {
            InitializeComponent();
            this.startPage = startPage;
        }

        public string conString = "Data Source=DESKTOP-JFU1JSP\\SQLEXPRESS;Initial Catalog=serviceAuto;Integrated Security=True";
        public static string email="";
        
        private void loginFinishBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                email=emailtextbox.Text;
                string password=passwordtextbox.Text;
                String querry = "SELECT * FROM users WHERE Email = '" + email + "' AND Password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    User user = new User(email,password);
                    if (user.Email == "office@service.eu" && user.Password=="service12")
                    {
                        Management management= new Management();
                        management.Show();
                        this.Hide();
                    }
                    else
                    {
                        StartMenu startMenu = new StartMenu();
                        startMenu.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                    emailtextbox.Clear();
                    passwordtextbox.Clear();
                    emailtextbox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                con.Close();
            }
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.startPage.Show();
        }
    }
}

