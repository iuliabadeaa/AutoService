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
    public partial class AptmListAdmin : Form
    {
        private Management Management;
        public AptmListAdmin(Management management)
        {
            InitializeComponent();
            this.Management = management;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Management.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AptmListAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceAutoDataSet2.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.serviceAutoDataSet2.appointment);

        }
    }
}
