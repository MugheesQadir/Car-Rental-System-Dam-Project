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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            txtUserId.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CarRentalSystem;Data Source=DESKTOP-12VGB0H\SQLEXPRESS");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "exec usertblLogin "+int.Parse(txtUserId.Text)+","+TxtPassword.Text;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                DashBoard a=new DashBoard();
                this.Hide();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong User_ID and Password");
            }
            con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
