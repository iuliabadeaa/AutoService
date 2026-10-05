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
    public partial class Contact : Form
    {
        private StartMenu startMenu;
        public Contact(StartMenu startMenu)
        {
            InitializeComponent();
            this.startMenu = startMenu;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.startMenu.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
