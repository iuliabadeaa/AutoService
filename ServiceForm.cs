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
    
    public partial class ServiceForm : Form
    {
        private StartMenu startMenu;
        public ServiceForm(StartMenu startMenu)
        {
            InitializeComponent();
            this.startMenu = startMenu;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.startMenu.Show();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            this.servicesTableAdapter.Fill(this.serviceAutoDataSet.services);
        }
    }
}
