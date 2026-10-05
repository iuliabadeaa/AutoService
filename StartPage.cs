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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        
        private void loginbtnstart_Click_1(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn(this);
            logIn.Show();
            this.Hide();
        }

        private void signinbtnstart_Click_1(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn(this);
            signIn.Show();
            this.Hide();
        }
    }
}
