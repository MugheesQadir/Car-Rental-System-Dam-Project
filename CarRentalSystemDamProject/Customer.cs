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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.ShowDialog();
            this.Hide();
        }
        private void populate()
        {
            con.Open();
            string query = "exec custblAllShow";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];

            con.Close();

        }
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CarRentalSystem;Data Source=DESKTOP-12VGB0H\SQLEXPRESS");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "")
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("ID is Missing");
                }
                else if (txtName.Text == "")
                {
                    MessageBox.Show("Name is Missing");
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Address is Missing");
                }
                else
                {
                    MessageBox.Show("Phone Number is Missing");
                }

            }
            else
            {
                try
                {
                    con.Open();
                    string q = "exec custtblAdd '" + int.Parse(txtId.Text) + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customers Added Successfully");
                    con.Close();
                    populate();

                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "")
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("ID is Missing");
                }
                else if (txtName.Text == "")
                {
                    MessageBox.Show("Name is Missing");
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Address is Missing");
                }
                else
                {
                    MessageBox.Show("Phone Number is Missing");
                }
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "exec custtblupdate '" + int.Parse(txtId.Text) + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "'";


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Custumer Successfully Updated");
                    con.Close();
                    populate();

                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtPhone.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please Enter Custumer ID First");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "exec custtbldelete " + int.Parse(txtId.Text);
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Custumer Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "exec searchCars " + int.Parse(txtsearch.Text);
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            ad.Fill(ds);
            UserDGV.DataSource = null;
            UserDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
