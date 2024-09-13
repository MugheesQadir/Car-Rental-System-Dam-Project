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
    public partial class Car : Form
    {
        
        public Car()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            con.Open();
            string query = "exec cartblAllShow";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
   
            var ds = new DataSet();
            ad.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];

            con.Close();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.ShowDialog();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CarRentalSystem;Data Source=DESKTOP-12VGB0H\SQLEXPRESS");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "" || txtBrand.Text == "" || cmbxavail.Text == "" || txtPrice.Text == "" || cmbxAvailable.Text== "")
            {
                if(txtRegNo.Text == "")
                {
                    MessageBox.Show("RegNo is Missing");
                }
                else if (txtBrand.Text == "")
                {
                    MessageBox.Show("Brand is Missing");
                }
                else if (cmbxavail.Text == "")
                {
                    MessageBox.Show("Model is Missing");
                }
                else if (cmbxAvailable.Text == "")
                {
                    MessageBox.Show("Available is Missing");
                }
                else
                {
                    MessageBox.Show("Price is Missing");
                }

            }
            else
            {
                try
                {
                    con.Open();
                    string q = "exec cartblADD '" + txtRegNo.Text + "','" + txtBrand.Text + "','" + cmbxAvailable.Text + "','" + cmbxavail.Text + "','" + txtPrice.Text + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cars Added Successfully");
                    con.Close();
                    populate();

                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }             
                       
        }
        string[] itm = { "Yes" };
        string[] items = { "Honda", "Corolla", "Mehran" };
        private void Car_Load(object sender, EventArgs e)
        {
            cmbxAvailable.Items.AddRange(items);
            cmbxavail.Items.AddRange(itm);
            populate();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "" || txtBrand.Text == "" || cmbxavail.Text == "" || txtPrice.Text == "" || cmbxAvailable.Text == "")
            {
                if (txtRegNo.Text == "")
                {
                    MessageBox.Show("RegNo is Missing");
                }
                else if (txtBrand.Text == "")
                {
                    MessageBox.Show("Brand is Missing");
                }
                else if (cmbxavail.Text == "")
                {
                    MessageBox.Show("Model is Missing, Please Select Again");
                }
                else if (cmbxAvailable.Text == "")
                {
                    MessageBox.Show("Available is Missing, Please Select Again");
                }
                else
                {
                    MessageBox.Show("Price is Missing");
                }

            }
            else
            {
                try
                {
                    con.Open();
                    string query = "exec cartblUpdate " + txtRegNo.Text + ",'" + txtBrand.Text + "','" + cmbxAvailable.Text + "','"+cmbxavail.Text+"','"+txtPrice.Text+"'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CAR Successfully Updated");
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
            txtRegNo.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtBrand.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            cmbxAvailable.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            cmbxavail.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtPrice.Text = UserDGV.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "")
            {
                MessageBox.Show("Please Enter Car RegNo First");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "exec cartblDelete " + int.Parse(txtRegNo.Text);
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Car Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void search(int id)
        {
            con.Open();
            string query = "exec searchCars " + id;
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            ad.Fill(ds);
            UserDGV.DataSource = null;
            UserDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            search(int.Parse(txtsearch.Text));          
                     
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
