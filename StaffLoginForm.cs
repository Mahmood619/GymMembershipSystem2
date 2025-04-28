using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembershipSystem2
{
    public partial class StaffLoginForm : Form
    {
        public StaffLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Staff WHERE Username=@Username AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {
                    MessageBox.Show("Login successful");
                    StaffDashboardForm dashboard = new StaffDashboardForm();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainMenu = new MainForm();
            mainMenu.Show();


            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
