using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceCuNET
{
    public partial class ServicesAdmin : Form
    {
        private Management Management;
        public ServicesAdmin(Management management)
        {
            InitializeComponent();
            this.Management = management;
        }

        private void ServicesAdmin_Load(object sender, EventArgs e)
        {
            this.servicesTableAdapter.Fill(this.serviceAutoDataSet1.services);
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

        public string conString = "Data Source=DESKTOP-JFU1JSP\\SQLEXPRESS;Initial Catalog=serviceAuto;Integrated Security=True";
        public static string prdName="";
        public static int prdPrice=0;
        private void savedata_Click(object sender, EventArgs e)
        {
            prdName=ProductTxtBox.Text;
            prdPrice= int.Parse(PriceTxtBox.Text);
            Product product=new Product(prdName, prdPrice);

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into services(Product,Price)values('" + product.Name + "','" + product.Price + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully!");

            }
            con.Close();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                if(ProductTxtBox.Text=="")
                {
                    prdName = "";
                    prdPrice = int.Parse(PriceTxtBox.Text);
                    Product product = new Product(prdName, prdPrice);
                    string q = "Select * from services where Price=" + product.Price;
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Search finished!");
                    SqlDataAdapter da=new SqlDataAdapter(cmd);
                    DataTable dt= new DataTable();
                    da.Fill(dt);
                    productTable.DataSource = dt;
                }
                else if (PriceTxtBox.Text=="")
                {
                    prdName = ProductTxtBox.Text;
                    prdPrice = 0;
                    Product product = new Product(prdName, prdPrice);
                    string q = "Select * from services where Product='" + product.Name + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Search finished!");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    productTable.DataSource = dt;
                }
                else
                {
                    prdName = ProductTxtBox.Text;
                    prdPrice = int.Parse(PriceTxtBox.Text);
                    Product product = new Product(prdName, prdPrice);
                    string q = "Select * from services where Product='" + product.Name + "' and Price=" + product.Price;
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Search finished!");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    productTable.DataSource = dt;
                }

            }
            con.Close();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            prdName = ProductTxtBox.Text;
            prdPrice = int.Parse(PriceTxtBox.Text);
            Product product = new Product(prdName, prdPrice);

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (ProductTxtBox.Text == "")
                {
                    string q = "Delete from services where Price=" + product.Price;
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Action finished successfully!");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    productTable.DataSource = dt;
                }
                else if (PriceTxtBox.Text == "")
                {
                    string q = "Delete * from services where Product='" + product.Name + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Action finished successfully!");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    productTable.DataSource = dt;
                }
                else
                {
                    string q = "Delete * from services where Product='" + product.Name + "' and Price=" + product.Price;
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Action finished successfully!");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    productTable.DataSource = dt;
                }

            }
            con.Close();

        }

        private void convertEur_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(PriceTxtBox.Text))
            {
                MessageBox.Show("Please enter a price to convert!");
            }
            else
            {
                prdName = ProductTxtBox.Text;
                prdPrice = int.Parse(PriceTxtBox.Text);
                Product product = new Product(prdName, prdPrice);
                priceEur.Text = "Price in €:";
                ValueInEur.Text = product.ConvertToEuro(product.Price).ToString();
            }
            
        }
    }
}
