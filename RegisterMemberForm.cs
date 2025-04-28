using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymMembershipSystem2
{
    public partial class RegisterMemberForm : Form
    {
        public RegisterMemberForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); 

                try
                {
                    
                    string insertAccountQuery = "INSERT INTO Accounts (MembershipID) OUTPUT INSERTED.AccountID VALUES (1)"; 
                    SqlCommand accountCmd = new SqlCommand(insertAccountQuery, conn, transaction);
                    int accountId = (int)accountCmd.ExecuteScalar(); 

                    
                    string insertMemberQuery = "INSERT INTO Members (Name, UniqueCode, PhoneNumber, AccountID) VALUES (@Name, @UniqueCode, @PhoneNumber, @AccountID)";
                    SqlCommand memberCmd = new SqlCommand(insertMemberQuery, conn, transaction);
                    memberCmd.Parameters.AddWithValue("@Name", txtName.Text);
                    memberCmd.Parameters.AddWithValue("@UniqueCode", txtCode.Text); 
                    memberCmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    memberCmd.Parameters.AddWithValue("@AccountID", accountId);

                    
                    memberCmd.ExecuteNonQuery();

                    
                    transaction.Commit();

                    
                    MessageBox.Show("Member registered successfully!");
                    this.Close(); 
                }
                catch (Exception ex)
                {
                    
                    transaction.Rollback();
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            txtCode.Text = GenerateUniqueCode();
        }

        private string GenerateUniqueCode()
        {
           
            Random random = new Random();
            string uniqueCode = random.Next(1000, 9999).ToString(); 
            return uniqueCode;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
