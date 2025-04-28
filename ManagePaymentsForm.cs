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
    public partial class ManagePaymentsForm: Form
    {
        public ManagePaymentsForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void ManagePaymentsForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadPayments();
        }
        private void LoadMembers()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT MemberID, Name FROM Members";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbMemberList.Items.Add(new ComboBoxItem
                    {
                        Text = reader["Name"].ToString(),
                        Value = Convert.ToInt32(reader["MemberID"])
                    });
                }
            }
        }

        
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
        private void LoadPayments()
        {
            if (cmbMemberList.SelectedItem == null)
            {
                
                return;
            }

            int memberID = ((ComboBoxItem)cmbMemberList.SelectedItem).Value;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT PaymentID, Amount, PaymentDate, PaymentMethod FROM Payments WHERE MemberID = @MemberID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable paymentsTable = new DataTable();
                adapter.Fill(paymentsTable);

                dataGridViewPayments.DataSource = paymentsTable;
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaymentAmount.Text) || string.IsNullOrEmpty(txtPaymentMethod.Text) || cmbMemberList.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields and select a member.");
                return;
            }

            try
            {
                int memberID = ((ComboBoxItem)cmbMemberList.SelectedItem).Value;

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Payments (MemberID, Amount, PaymentDate, PaymentMethod) VALUES (@MemberID, @Amount, @PaymentDate, @PaymentMethod)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@MemberID", memberID);
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtPaymentAmount.Text));
                    cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@PaymentMethod", txtPaymentMethod.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Payment added successfully!");
                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding payment: " + ex.Message);
            }

        }

       

        

        

        private void dataGridViewPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPayments.Rows[e.RowIndex];
                txtPaymentAmount.Text = row.Cells["Amount"].Value.ToString();
                txtPaymentMethod.Text = row.Cells["PaymentMethod"].Value.ToString();
            }

        }

        private void btnViewAllPayments_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Payments";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewPayments.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading payments: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffDashboardForm staffDashboardForm = new StaffDashboardForm();
            staffDashboardForm.Show();


            this.Close();
        }
    }
}
