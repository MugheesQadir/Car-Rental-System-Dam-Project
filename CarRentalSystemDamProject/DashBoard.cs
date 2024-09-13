using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystemDamProject
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CarRentalSystem;Data Source=DESKTOP-12VGB0H\SQLEXPRESS");

        public void allCars()
        {
            con.Open();
            string query = "exec allCars";            
            SqlCommand cmd = new SqlCommand(query,con);            
            int carCount = (int)cmd.ExecuteScalar();
            label6.Text = carCount.ToString();
            con.Close();
        }
        public void allCsu()
        {
            con.Open();
            string query = "exec allCustomers";
            SqlCommand cmd = new SqlCommand(query, con);
            int carCount = (int)cmd.ExecuteScalar();
            label7.Text = carCount.ToString();
            con.Close();
        }
        public void allRental()
        {
            con.Open();
            string query = "exec allRental";
            SqlCommand cmd = new SqlCommand(query, con);
            int carCount = (int)cmd.ExecuteScalar();
            label8.Text = carCount.ToString();
            con.Close();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            allCars();
            allCsu();
            allRental();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Customer a = new Customer();
            a.ShowDialog();
            this.Hide();
        }
        private void BtnCar_Click(object sender, EventArgs e)
        {
            Car a = new Car();
            a.ShowDialog();
            this.Hide();
        }

        private void BtnRental_Click(object sender, EventArgs e)
        {
            Rental a=new Rental();
            a.ShowDialog();
            this.Hide();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Return a = new Return();
            a.ShowDialog();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.ShowDialog();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Users a = new Users();
            this.Hide();
            a.ShowDialog();
        }
    }
}
