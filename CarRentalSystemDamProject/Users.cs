using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace CarRentalSystemDamProject
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CarRentalSystem;Data Source=DESKTOP-12VGB0H\SQLEXPRESS");
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            con.Open();
            string query = "exec usertblAllshow";
            SqlDataAdapter ad = new SqlDataAdapter(query , con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
                        
            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtUserId.Text == "" || txtUserName.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    con.Open();
                    string query = "exec usertblAllInsert "+int.Parse(txtUserId.Text)+","+txtUserName.Text+","+TxtPassword.Text;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added");
                    con.Close();
                    populate();

                }
                catch (Exception ex)
                
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtUserId.Text == "")
            {
                MessageBox.Show("Please Enter User ID First");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "exec usertblDelete " + int.Parse(txtUserId.Text) ;
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected User Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserId.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtUserName.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            TxtPassword.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "" || txtUserName.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    con.Open();
                    string query = "exec usertblUpdate "+int.Parse(txtUserId.Text)+",'"+txtUserName.Text+"','"+TxtPassword.Text+"'";
                        

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                    con.Close();
                    populate();

                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard d=new DashBoard();
            d.ShowDialog();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "exec searchUser " + int.Parse(txttSearcERent.Text);
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            ad.Fill(ds);
            UserDGV.DataSource = null;
            UserDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
