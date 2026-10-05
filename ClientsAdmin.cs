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
    public partial class ClientsAdmin : Form
    {
        private Management Management;
        public ClientsAdmin(Management management)
        {
            InitializeComponent();
            this.Management = management;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Management.Show();
        }

        private void ClientsAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceAutoDataSet3.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.serviceAutoDataSet3.users);

        }
    }
}
