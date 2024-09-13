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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        private void populate()
        {
            con.Open();
            string query = "exec ReturnTblAll";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            returnDVG.DataSource = ds.Tables[0];

            con.Close();

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CarRentalSystem;Data Source=DESKTOP-12VGB0H\SQLEXPRESS");

        private void populate1()
        {
            con.Open();
            string query = "exec RentalTblAllShow";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            RentDVG.DataSource = ds.Tables[0];

            con.Close();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtRegNo.Text == "" )
            {
                if(txtId.Text == "")
                {
                    MessageBox.Show("Please Enter Returned ID");
                }
                else
                {
                    MessageBox.Show("Please Select Data from DataGridView ( Cars on Rent )");
                }
            }
            else
            {
                try
                {
                    con.Open();
                    string q = "exec ReturnTblAdd " + int.Parse(txtId.Text) + ",'" + txtRegNo.Text + "','"
                        + txtName.Text + "','" + DateTime.Parse(ReturnDate.Text).ToString("yyyy-MM-dd") + 
                        "'," + int.Parse(txtfine.Text) + "";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Return Added Successfully");
                    con.Close();
                    populate1();
                    populate();

                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Return_Load(object sender, EventArgs e)
        {
            populate1();
            populate();
        }
        public void delay(string id, string fine)
        {
            int idd = int.Parse(id);
            int fee = int.Parse(fine);
            con.Open();
            string query = "exec CalculateDelays " + idd + "," + fee + "";
            SqlCommand command = new SqlCommand(query, con);

            SqlParameter returnValue = new SqlParameter();
            returnValue.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(returnValue);

            command.ExecuteNonQuery();

            int delayDays = (int)command.Parameters[returnValue.ParameterName].Value;
            txtDelay.Text = delayDays.ToString();

            con.Close();
        }
        public void Fine(string id,string fine)
        {
            int idd= int.Parse(id);
            int fee= int.Parse(fine);
            con.Open();
            string query = "exec CalculateDelays "+idd+","+fee+"";
            SqlCommand command = new SqlCommand(query, con);

            SqlParameter returnValue = new SqlParameter();
            returnValue.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(returnValue);

            command.ExecuteNonQuery();

            int finee = (int)command.Parameters[returnValue.ParameterName].Value;
            txtfine.Text = finee.ToString();

            con.Close();
        }
        private void RentDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtId.Text = RentDVG.SelectedRows[0].Cells[0].Value.ToString();
            txtRegNo.Text = RentDVG.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = RentDVG.SelectedRows[0].Cells[4].Value.ToString();
            ReturnDate.Text = RentDVG.SelectedRows[0].Cells[6].Value.ToString();
            string id = RentDVG.SelectedRows[0].Cells[0].Value.ToString();
            string rantfee = RentDVG.SelectedRows[0].Cells[7].Value.ToString();
            delay(id,rantfee);
            Fine(id,rantfee);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please Enter Return id First");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "exec ReturnTblDelete " + int.Parse(txtId.Text);
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Return Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void returnDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = returnDVG.SelectedRows[0].Cells[0].Value.ToString();
            txtRegNo.Text = returnDVG.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = returnDVG.SelectedRows[0].Cells[2].Value.ToString();
            ReturnDate.Text = returnDVG.SelectedRows[0].Cells[3].Value.ToString();
            txtfine.Text = returnDVG.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "exec searchRental " + int.Parse(txttSearcERent.Text);
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            ad.Fill(ds);
            RentDVG.DataSource = null;
            RentDVG.DataSource = ds.Tables[0];
            con.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            populate1();
            populate();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            populate1();
            populate();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "exec searchReturn " + int.Parse(txtsearch.Text);
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            ad.Fill(ds);
            returnDVG.DataSource = null;
            returnDVG.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
