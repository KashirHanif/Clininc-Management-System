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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Clinic_Management_System
{
    public partial class showPreview : UserControl

    {
        private string username;
        private string password;
        private string connectionString;
        private int billId;
        private int prescriptionId;


        public showPreview(string username, string password, string connectionString, int billId, int prescripitonId)
        {
            InitializeComponent();
            //button2.Click += button2_Click;
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
            this.billId = billId;
            this.prescriptionId = prescripitonId;


            textBox1.Text = billId.ToString();
            this.Load += showPreview_Load;
            prescriptiondetailgridview.CellClick += prescriptiondetailgridview_CellContentClick;
        }
        private void showPreview_Load(object sender, EventArgs e)
        {
            FetchBillDetails();
            PopulatePrescriptionGridView();

        }

        private void FetchBillDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_get_prescription_summary", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pass billId as a parameter
                        cmd.Parameters.AddWithValue("@bill_id", billId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate textboxes with data from the reader
                                textBox6.Text = reader["patient_name"].ToString(); // Patient Name
                                textBox9.Text = reader["doctor_name"].ToString();  // Doctor Name
                                textBox5.Text = reader["doctor_fee"].ToString();   // Doctor Fee
                            }
                            else
                            {
                                MessageBox.Show("No data found for the provided Bill ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching bill details: " + ex.Message);
            }
        }
        private void PopulatePrescriptionGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT pi.prescription_id, pi.prescription_item_id, i.item_name, pi.item_type" +
                        " FROM tbl_prescription_item pi" +
                        " JOIN tbl_item i ON pi.item_id = i.item_id" +
                        " WHERE pi.prescription_id = @prescription_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@prescription_id", prescriptionId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            prescriptiondetailgridview.DataSource = dataTable;

                            prescriptiondetailgridview.Columns["prescription_id"].HeaderText = "Prescription ID";
                            prescriptiondetailgridview.Columns["item_name"].HeaderText = "Item Name";
                            prescriptiondetailgridview.Columns["item_type"].HeaderText = "Item Type";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching prescription details: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new Printable(username, password, connectionString));
        }

        private void LoadControl(object control)
        {
            // Your logic to handle the control
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (prescriptiondetailgridview.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = prescriptiondetailgridview.SelectedRows[0];

                    // Retrieve values from the selected row
                    int prescriptionId = Convert.ToInt32(selectedRow.Cells["prescription_id"].Value);
                    string itemName = selectedRow.Cells["item_name"].Value.ToString();
                    string itemType = selectedRow.Cells["item_type"].Value.ToString();

                    // Confirm deletion
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this item?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            // Step 1: Retrieve the item_id for the given item_name
                            int itemId = 0;
                            using (SqlCommand cmd = new SqlCommand("SELECT item_id FROM tbl_item WHERE item_name = @item_name", conn))
                            {
                                cmd.Parameters.AddWithValue("@item_name", itemName);
                                object resultItemId = cmd.ExecuteScalar();
                                if (resultItemId != null)
                                {
                                    itemId = Convert.ToInt32(resultItemId);
                                }
                                else
                                {
                                    MessageBox.Show("Item not found in tbl_item.");
                                    return;
                                }
                            }

                            // Step 2: Delete the item from tbl_prescription_item
                            using (SqlCommand deleteCmd = new SqlCommand(
                                "DELETE FROM tbl_prescription_item " +
                                "WHERE prescription_id = @prescription_id AND item_id = @item_id AND item_type = @item_type", conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@prescription_id", prescriptionId);
                                deleteCmd.Parameters.AddWithValue("@item_id", itemId);
                                deleteCmd.Parameters.AddWithValue("@item_type", itemType);

                                deleteCmd.ExecuteNonQuery();
                            }
                        }

                        // Refresh the grid
                        PopulatePrescriptionGridView();
                        MessageBox.Show("Item deleted successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the item: " + ex.Message);
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadControl(new Printable(username, password, connectionString));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void prescriptiondetailgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow selectedRow = prescriptiondetailgridview.Rows[e.RowIndex];

                // Set the values in textBox3 and comboBox1
                textBox3.Text = selectedRow.Cells["item_name"].Value.ToString();
                comboBox1.Text = selectedRow.Cells["item_type"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Dynamically load the controller based on the passed controller name
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string itemName = textBox3.Text.Trim();
            string itemType = comboBox1.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(itemType))
            {
                MessageBox.Show("Please provide both item name and item type.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("add_prescription_item", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("@prescription_id", prescriptionId); // Use prescriptionId from the class
                        cmd.Parameters.AddWithValue("@item_name", itemName);
                        cmd.Parameters.AddWithValue("@item_type", itemType);

                        cmd.ExecuteNonQuery();

                        PopulatePrescriptionGridView();
                        textBox3.Clear();
                        comboBox1.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the item: " + ex.Message);
            }
        

    }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox5.Text.Trim(), out int empFee) || empFee < 0)
            {
                MessageBox.Show("Please enter a valid non-negative value for the employee fee.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Update the emp_fee column for the specified bill_id
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE tbl_billing SET emp_fee = @emp_fee WHERE bill_id = @bill_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@emp_fee", empFee);
                        cmd.Parameters.AddWithValue("@bill_id", billId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee fee updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record found for the provided Bill ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the employee fee: " + ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LoadControl(new addTreatment(username, password, connectionString));
        }

        private void showPreview_Load_1(object sender, EventArgs e)
        {

        }
    }
}