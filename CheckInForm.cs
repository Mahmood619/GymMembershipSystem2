using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymMembershipSystem2
{
    public partial class CheckInForm : Form
    {
        public CheckInForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)

        {
            string code = txtCode.Text.Trim(); 

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                conn.Open();

               
                string checkQuery = "SELECT COUNT(*) FROM Members WHERE UniqueCode = @code";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@code", code);

                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    
                    string expiryQuery = @"SELECT me.ExpiryDate FROM Members m
                                   JOIN Accounts a ON m.AccountID = a.AccountID
                                   JOIN Memberships me ON a.MembershipID = me.MembershipID
                                   WHERE m.UniqueCode = @code";
                    SqlCommand expiryCmd = new SqlCommand(expiryQuery, conn);
                    expiryCmd.Parameters.AddWithValue("@code", code);

                    SqlDataReader reader = expiryCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        DateTime expiryDate = Convert.ToDateTime(reader["ExpiryDate"]);

                        if (expiryDate < DateTime.Now)
                        {
                            reader.Close();
                            DialogResult result = MessageBox.Show("Membership expired. Renew?", "Renewal", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                RenewMembership(code);
                            }
                            else
                            {
                                MessageBox.Show("Cannot check-in. Please renew.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Checked in successfully!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error fetching expiry date.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Unique Code! No member found.");
                }
            }
        }
        private void RenewMembership(string code)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                conn.Open();
                string updateQuery = @"UPDATE Memberships
                               SET ExpiryDate = DATEADD(MONTH, 1, GETDATE())
                               WHERE MembershipID IN (
                                   SELECT a.MembershipID FROM Members m 
                                   JOIN Accounts a ON m.AccountID = a.AccountID
                                   WHERE m.UniqueCode = @code
                               )";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Membership renewed! Checked in successfully.");
            }


        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainMenu = new MainForm();
            mainMenu.Show();

            
            this.Close();
        }
    }
}