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
    public partial class ManageMembersForm: Form
    {
        public ManageMembersForm()
        {
            InitializeComponent();
        }

        private void btnRegisterNew_Click(object sender, EventArgs e)
        {
            RegisterMemberForm registerForm = new RegisterMemberForm();
            registerForm.ShowDialog(); 
            LoadMembers(); 
        }

        private void btnViewMembers_Click(object sender, EventArgs e)
        {
            string memberIDText = txtMemberID.Text.Trim();

            
            if (string.IsNullOrEmpty(memberIDText))
            {
                LoadMembers(); 
            }
            else
            {
                
                if (int.TryParse(memberIDText, out int memberID))
                {
                    LoadMemberDetails(memberID); 
                }
                else
                {
                    MessageBox.Show("Please enter a valid Member ID.");
                }
            }
        }
        private void LoadMembers()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Members";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewMembers.DataSource = dt;
            }
        }
        private void LoadMemberDetails(int memberID)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Members WHERE MemberID = @MemberID"; 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                
                if (dt.Rows.Count > 0)
                {
                    dataGridViewMembers.DataSource = dt; 
                }
                else
                {
                    MessageBox.Show("Member not found.");
                }
            }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberID.Text))
            {
                MessageBox.Show("Please enter a Member ID to delete.");
                return;
            }

            try
            {
                int memberID = Convert.ToInt32(txtMemberID.Text); 

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
                {
                    conn.Open();

                   
                    string deletePaymentsQuery = "DELETE FROM Payments WHERE MemberID = @MemberID";
                    SqlCommand deletePaymentsCmd = new SqlCommand(deletePaymentsQuery, conn);
                    deletePaymentsCmd.Parameters.AddWithValue("@MemberID", memberID);
                    deletePaymentsCmd.ExecuteNonQuery();

                    
                    string deleteAccountQuery = "DELETE FROM Accounts WHERE AccountID = (SELECT AccountID FROM Members WHERE MemberID = @MemberID)";
                    SqlCommand deleteAccountCmd = new SqlCommand(deleteAccountQuery, conn);
                    deleteAccountCmd.Parameters.AddWithValue("@MemberID", memberID);
                    deleteAccountCmd.ExecuteNonQuery();

                    
                    string deleteMemberQuery = "DELETE FROM Members WHERE MemberID = @MemberID";
                    SqlCommand deleteMemberCmd = new SqlCommand(deleteMemberQuery, conn);
                    deleteMemberCmd.Parameters.AddWithValue("@MemberID", memberID);
                    int rows = deleteMemberCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Member and related data deleted successfully.");
                        LoadMembers(); 
                    }
                    else
                    {
                        MessageBox.Show("No member found with that ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting member: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffDashboardForm staffDashboardForm = new StaffDashboardForm();
            staffDashboardForm.Show();


            this.Close();
        }
    }
}
