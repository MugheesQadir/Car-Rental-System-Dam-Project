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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRentalSystemDamProject
{
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }
        private void populate()
        {
            con.Open();
            string query = "exec RentalTblAllShow";
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
            if (txtId.Text == "" || cmbxCarReg.Text == "" || cmbxCustId.Text == "" || 
                txtName.Text == "" || RentalDate.Text == "" || ReturnDate.Text == "" || txtFee.Text == "")
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("ID is Missing");
                }
                else if (cmbxModel.Text == "")
                {
                    MessageBox.Show("Car Reg Num is Missing, Please Select Again");
                }
                else if (txtName.Text == "")
                {
                    MessageBox.Show("Cust Id is Missing, Please Select Again");
                }
                else
                {
                    MessageBox.Show("Fee is Missing");
                }

            }
            else
            {
                try
                {
                    con.Open();
                    string q1 = "select Available from CarTbl Where RegNum =" + int.Parse(cmbxCarReg.Text) + "";
                    SqlCommand cmdd = new SqlCommand(q1, con);
                    SqlDataReader sdr = cmdd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Available", typeof(string));
                    dt.Load(sdr);

                    if ((dt.Rows[0]["Available"].ToString()).Contains("Yes"))
                    {
                        string q = "exec RentalTblAdd " + int.Parse(txtId.Text) + ",'" + cmbxCarReg.Text + "','" + cmbxModel.Text + "'," + int.Parse(txtPrice.Text) + ",'" + txtName.Text + "','" + DateTime.Parse(RentalDate.Text).ToString("yyyy-MM-dd") + "','" + DateTime.Parse(ReturnDate.Text).ToString("yyyy-MM-dd") + "'," + int.Parse(txtFee.Text) + "";
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Rental Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Car Not Available");
                    }
                    con.Close();
                    populate();

                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void loadCmbxRegNo()
        {
            con.Open();
            string q1 = "select Distinct Model from CarTbl Where Available = 'Yes'";
            SqlCommand cmd = new SqlCommand(q1, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Model", typeof(string));
            dt.Load(sdr);

            cmbxModel.ValueMember = "Model";
            cmbxModel.DataSource=dt;

            cmbxCarReg.Text = string.Empty;
            con.Close();
        }
        public void loadCmbxCustID()
        {
            
            con.Open();
            string q1 = "select CustId from CustomerTbl ";
            SqlCommand cmd = new SqlCommand(q1, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(string));
            dt.Load(sdr);
            cmbxCustId.ValueMember = "CustId";
            cmbxCustId.DataSource = dt;
            con.Close();
        }
        public void FetchCustName()
        {
            con.Open();
            string q1 = "select * from CustomerTbl where custId = " +cmbxCustId.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(q1, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            foreach(DataRow data in dt.Rows)
            {
                txtName.Text = data["CustName"].ToString();
            }
            con.Close();
        }
        public void FetchCarDetail()
        {
            con.Open();
            cmbxCarReg.Items.Clear();
            string q1 = "select * from CarTbl where Model = '" +cmbxModel.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(q1, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            

            int a=0,b=0;
            foreach (DataRow data in dt.Rows)
            {
                string q2 = "select count(CarReg) from RentalTbl where CarReg ='"+int.Parse(data["RegNum"].ToString())+"'";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                int carCount = (int)cmd2.ExecuteScalar();
                if (carCount == 0)
                {
                    cmbxCarReg.Items.Add(data["RegNum"].ToString());
                }

            }
            con.Close();
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            loadCmbxRegNo();
            loadCmbxCustID();
            populate();
        }

        public void FetchCarReg()
        {
            con.Open();
            string q1 = "select * from CarTbl where RegNum = " + int.Parse(cmbxCarReg.Text) + "";
            SqlCommand cmd = new SqlCommand(q1, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            foreach (DataRow data in dt.Rows)
            {
                txtbrand.Text = data["Brand"].ToString();
                txtPrice.Text = data["Price"].ToString();
            }
            con.Close();
        }

        private void cmbxCarReg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchCarReg();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbxCustId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchCustName();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || cmbxCarReg.Text == "" || cmbxCustId.Text == "" || txtName.Text == "" || RentalDate.Text == "" || ReturnDate.Text == "" || txtFee.Text == "" || cmbxCarReg.Text=="")
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("ID is Missing");
                }
                else if (cmbxModel.Text == "")
                {
                    MessageBox.Show("Car Reg Num is Missing, Please Select Again");
                }
                else if (txtName.Text == "")
                {
                    MessageBox.Show("Cust Id is Missing, Please Select Again");
                }
                else if(txtFee.Text =="")
                {
                    MessageBox.Show("Fee is Missing");
                }
                else
                {
                    MessageBox.Show("Data is Missing");
                }
            }
            else
            {
                try
                {
                    con.Open();
                    string q1 = "select Available from CarTbl Where RegNum =" + int.Parse(cmbxCarReg.Text) + "";
                    SqlCommand cmdd = new SqlCommand(q1, con);
                    SqlDataReader sdr = cmdd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Available", typeof(string));
                    dt.Load(sdr);
                    if ((dt.Rows[0]["Available"].ToString()).Contains("Yes"))
                    {
                        string q = "exec RentalTblUpdatee " + int.Parse(txtId.Text) + ",'" + cmbxCarReg.Text + "','" + cmbxModel.Text + "'," + int.Parse(txtPrice.Text) + ",'" + txtName.Text + "','" + DateTime.Parse(RentalDate.Text).ToString("yyyy-MM-dd") + "','" + DateTime.Parse(ReturnDate.Text).ToString("yyyy-MM-dd") + "'," + int.Parse(txtFee.Text) + "";
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Rental Updated Successfully");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Car Not Available");
                    }
                    populate();

                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void custid(string name)
        {
            con.Open();
            string q1 = "select * from CustomerTbl where custName = '" + name + "'";
            SqlCommand cmd = new SqlCommand(q1, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            foreach (DataRow data in dt.Rows)
            {
                cmbxCustId.Text = data["Custid"].ToString();
            }
            con.Close();
        }
        
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadCmbxRegNo();
            loadCmbxCustID();

            txtId.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            cmbxCarReg.Text =  UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            cmbxModel.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            custid(UserDGV.SelectedRows[0].Cells[4].Value.ToString());
            txtName.Text = UserDGV.SelectedRows[0].Cells[4].Value.ToString();
            RentalDate.Text = UserDGV.SelectedRows[0].Cells[5].Value.ToString();
            ReturnDate.Text = UserDGV.SelectedRows[0].Cells[6].Value.ToString();
            txtFee.Text = UserDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please Enter Rental ID First");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "exec RentalTblDelete " + int.Parse(txtId.Text);
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Deleted Successfully");
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
            DashBoard a=new DashBoard();
            this.Hide();
            a.ShowDialog();
        }

        private void cmbxCarReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbxCustId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "exec searchRental " + int.Parse(txtsearch.Text) ;
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

        private void cmbxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbxModel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchCarDetail();
        }
    }
}
