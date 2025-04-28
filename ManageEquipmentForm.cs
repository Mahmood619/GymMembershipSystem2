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
    public partial class ManageEquipmentForm : Form
    {
        public ManageEquipmentForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEquipmentName.Text) || string.IsNullOrEmpty(txtEquipmentCategory.Text) || dtpLastServiced.Value == default(DateTime))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Equipment (EquipmentName, Category, Quantity, LastServiced) VALUES (@EquipmentName, @Category, @Quantity, @LastServiced)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@EquipmentName", txtEquipmentName.Text);
                    cmd.Parameters.AddWithValue("@Category", txtEquipmentCategory.Text);
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtEquipmentQuantity.Text));
                    cmd.Parameters.AddWithValue("@LastServiced", dtpLastServiced.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Equipment added successfully!");
                LoadEquipment(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding equipment: " + ex.Message);
            }
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an equipment item to update.");
                return; 
            }

            
            int equipmentID = Convert.ToInt32(dataGridViewEquipment.SelectedRows[0].Cells["EquipmentID"].Value);

           
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                conn.Open();

                
                string updateQuery = "UPDATE Equipment SET ";

                
                bool firstField = true;

                
                if (!string.IsNullOrEmpty(txtEquipmentName.Text))
                {
                    if (!firstField) updateQuery += ", ";
                    updateQuery += "EquipmentName = @EquipmentName";
                    firstField = false;
                }

                
                if (!string.IsNullOrEmpty(txtEquipmentCategory.Text))
                {
                    if (!firstField) updateQuery += ", ";
                    updateQuery += "Category = @Category";
                    firstField = false;
                }

                
                if (!string.IsNullOrEmpty(txtEquipmentQuantity.Text))
                {
                    if (!firstField) updateQuery += ", ";
                    updateQuery += "Quantity = @Quantity";
                    firstField = false;
                }

               
                if (dtpLastServiced.Value != null && dtpLastServiced.Value != DateTime.MinValue)
                {
                    if (!firstField) updateQuery += ", ";
                    updateQuery += "LastServiced = @LastServiced";
                    firstField = false;
                }

                
                updateQuery += " WHERE EquipmentID = @EquipmentID";

                try
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);

                    
                    if (!string.IsNullOrEmpty(txtEquipmentName.Text))
                        cmd.Parameters.AddWithValue("@EquipmentName", txtEquipmentName.Text);
                    if (!string.IsNullOrEmpty(txtEquipmentCategory.Text))
                        cmd.Parameters.AddWithValue("@Category", txtEquipmentCategory.Text);
                    if (!string.IsNullOrEmpty(txtEquipmentQuantity.Text))
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtEquipmentQuantity.Text));

                    
                    if (dtpLastServiced.Value != DateTime.MinValue)
                        cmd.Parameters.AddWithValue("@LastServiced", dtpLastServiced.Value);

                    cmd.Parameters.AddWithValue("@EquipmentID", equipmentID); 

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating equipment: " + ex.Message);
                }
            }

            MessageBox.Show("Equipment updated successfully!");
            LoadEquipment();
        }

        private void btnRemoveEquipment_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an equipment item to remove.");
                return;
            }

            try
            {
                int equipmentID = Convert.ToInt32(dataGridViewEquipment.SelectedRows[0].Cells["EquipmentID"].Value);

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Equipment WHERE EquipmentID = @EquipmentID";
                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@EquipmentID", equipmentID);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Equipment removed successfully!");
                LoadEquipment(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing equipment: " + ex.Message);
            }
        }

        private void btnViewEquipment_Click(object sender, EventArgs e)
        {
            LoadEquipment();
        }
    private void LoadEquipment()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB1ConnectionString"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT EquipmentID, EquipmentName, Category, Quantity, LastServiced FROM Equipment";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable equipmentTable = new DataTable();
                adapter.Fill(equipmentTable);

                dataGridViewEquipment.DataSource = equipmentTable;
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