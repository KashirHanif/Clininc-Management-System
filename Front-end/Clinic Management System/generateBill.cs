using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class generateBill : UserControl
    {
        // Connection string to your database
      //  string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
       string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";

        private string username;
        private string password;
        private int selectedItemId = -1;
        public generateBill(string username,string password)
        {
            InitializeComponent();
            this.patientGridView.CellClick += new DataGridViewCellEventHandler(this.patientGridView_CellContentClick);
            this.username = username;
            this.password = password;
        }

        // Populate the DataGridView with patient data
        private void PopulateDataGridView()
        {
            try
            {
                // string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";

                // Update statuses for expired and near-expiry items
                string updateQuery = @"
                    UPDATE tbl_inventory 
                    SET item_status = 
                        CASE 
                            WHEN expiration_date <= GETDATE() THEN 'Expired' 
                            WHEN expiration_date > GETDATE() AND expiration_date <= DATEADD(MONTH, 3, GETDATE()) THEN 'Near Expiry'
                            ELSE item_status 
                        END
                    WHERE item_status NOT IN ('Expired', 'Near Expiry')";

                // Base query to fetch data
                string selectQuery = @"
                    SELECT item_id, item_name, category, quantity, unit_of_measurement, 
                           purchase_price, selling_price, expiration_date, date_of_purchase, 
                           item_status, batch_no 
                    FROM tbl_inventory";

                // Apply filters based on comboBox3 selection
                string filter = comboBox3.SelectedItem?.ToString();
                if (filter == "Out of Stock")
                {
                    selectQuery += " WHERE quantity <= 0"; // Filter for out-of-stock items
                }
                else if (filter == "Expired")
                {
                    selectQuery += " WHERE item_status = 'Expired'"; // Filter for expired items
                }
                else if (filter == "Near Expiry")
                {
                    selectQuery += " WHERE item_status = 'Near Expiry'"; // Filter for near-expiry items
                }
                // If "All" or any other value, no additional filtering is needed

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Execute the update query to set statuses
                    SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                    connection.Open();
                    updateCmd.ExecuteNonQuery();

                    // Fetch and display data in the DataGridView
                    SqlCommand selectCmd = new SqlCommand(selectQuery, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCmd);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    patientGridView.DataSource = dataTable;

                    // Set user-friendly column names
                    patientGridView.Columns["item_id"].HeaderText = "Item ID";
                    patientGridView.Columns["item_name"].HeaderText = "Item Name";
                    patientGridView.Columns["category"].HeaderText = "Category";
                    patientGridView.Columns["quantity"].HeaderText = "Quantity";
                    patientGridView.Columns["unit_of_measurement"].HeaderText = "Unit of Measurement";
                    patientGridView.Columns["purchase_price"].HeaderText = "Purchase Price";
                    patientGridView.Columns["selling_price"].HeaderText = "Selling Price";
                    patientGridView.Columns["expiration_date"].HeaderText = "Expiration Date";
                    patientGridView.Columns["date_of_purchase"].HeaderText = "Date of Purchase";
                    patientGridView.Columns["item_status"].HeaderText = "Item Status";
                    patientGridView.Columns["batch_no"].HeaderText = "Batch No";

                    // Adjust column widths for better display
                    patientGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       // Clear any existing controls on Form2
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }
        // Event handler to handle Add Patient
        private void addPatientButton_Click(object sender, EventArgs e)
        {
            // Code to open Add Patient form or logic to add a patient
            LoadControl(new addInventory(username,password));
        }

        // Event handler to handle Update Patient
        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            // Code to open Update Patient form or logic to update patient
            LoadControl(new updatePatientUserCotroller(username,password));
        }

        // Event handler to handle View Patient
        private void viewPatientButton_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
            LoadControl(new viewPatient(username,password));
        }

        // Event handler to handle Add Appointment
        // Event handler to handle Add Appointment
        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            // Load the Add Appointment screen
            LoadControl(new addAppointmentController(username,password));
        }


        // Event handler to handle Cancel Appointment
        private void cancelAppointmentButton_Click(object sender, EventArgs e)
        {
            // Code to cancel appointment functionality
            LoadControl(new cancelAppointment(username, password));
        }

        // Event handler to handle View Appointments
        private void viewAppointmentsButton_Click(object sender, EventArgs e)
        {
            // Code to view appointments
            LoadControl(new viewAppointment(username,password));

        }

        // Event handler to load the user control
        private void generateBill_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            int outOfStockCount = GetOutOfStockCount();
            int nearExpiryCount = GetNearExpiryCount();
            int expiredCount = GetExpiredCount();

            // Display the count in label12
            label12.Text = $"Out of Stock: {outOfStockCount}";
            label15.Text = $"Near Expiry: {nearExpiryCount}";
            label14.Text = $"Expired: {expiredCount}";

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void patientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row or an invalid row
            if (e.RowIndex >= 0 && patientGridView.Rows[e.RowIndex].Cells["item_id"].Value != null)
            {
                selectedItemId = Convert.ToInt32(patientGridView.Rows[e.RowIndex].Cells["item_id"].Value);

                textBox1.Text = patientGridView.Rows[e.RowIndex].Cells["item_name"].Value?.ToString();
                comboBox1.SelectedItem = patientGridView.Rows[e.RowIndex].Cells["category"].Value?.ToString();
                textBox2.Text = patientGridView.Rows[e.RowIndex].Cells["quantity"].Value?.ToString();
                textBox6.Text = patientGridView.Rows[e.RowIndex].Cells["unit_of_measurement"].Value?.ToString();
                textBox3.Text = patientGridView.Rows[e.RowIndex].Cells["purchase_price"].Value?.ToString();
                textBox5.Text = patientGridView.Rows[e.RowIndex].Cells["selling_price"].Value?.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(patientGridView.Rows[e.RowIndex].Cells["date_of_purchase"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(patientGridView.Rows[e.RowIndex].Cells["expiration_date"].Value);
                comboBox2.SelectedItem = patientGridView.Rows[e.RowIndex].Cells["item_status"].Value?.ToString();
                textBox4.Text = patientGridView.Rows[e.RowIndex].Cells["batch_no"].Value?.ToString();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
            string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";

            try
            {
                string query = @"
                SELECT CONCAT(f_name, ' ', l_name)
                FROM tbl_employee
                WHERE emp_id IN (
                    SELECT emp_id FROM login_table
                    WHERE username = @username AND password = @password
                )";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string employeeName = result.ToString();
                        label16.Text = "Incharge: " + employeeName;
                    }
                    else
                    {
                        label16.Text = "Incharge: Not Found";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching employee name: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadControl(new menu(username, password));
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        
    


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new addTreatment(username, password));
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string filterItemName = textBox7.Text.Trim(); // Get item name from the TextBox

            if (string.IsNullOrEmpty(filterItemName))
            {
                MessageBox.Show("Please enter an item name to filter.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // SQL query to fetch filtered data with exact match
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM tbl_inventory WHERE item_name = @item_name";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@item_name", filterItemName); 

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable filteredTable = new DataTable();
                        adapter.Fill(filteredTable);

                        if (filteredTable.Rows.Count > 0)
                        {
                            patientGridView.DataSource = filteredTable; 
                        }
                        else
                        {
                            MessageBox.Show("No items found with the specified name.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Retrieve data from the input fields
            string itemName = textBox1.Text.Trim();
            string category = comboBox1.SelectedItem?.ToString();
            string quantityText = textBox2.Text.Trim();
            string status = comboBox2.SelectedItem?.ToString();
            DateTime dateOfPurchase = dateTimePicker1.Value;
            string purchasePriceText = textBox3.Text.Trim();
            string sellingPriceText = textBox5.Text.Trim();
            DateTime expirationDate = dateTimePicker2.Value;
            string batchNo = textBox4.Text.Trim();
            string unitOfMeasurement = textBox6.Text.Trim();

            // Validate input fields
            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(quantityText) ||
                string.IsNullOrEmpty(status) || string.IsNullOrEmpty(purchasePriceText) || string.IsNullOrEmpty(sellingPriceText) ||
                string.IsNullOrEmpty(batchNo) || string.IsNullOrEmpty(unitOfMeasurement))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(quantityText, out decimal quantity) || !decimal.TryParse(purchasePriceText, out decimal purchasePrice) ||
                !decimal.TryParse(sellingPriceText, out decimal sellingPrice))
            {
                MessageBox.Show("Please enter valid numeric values for quantity, purchase price, and selling price.");
                return;
            }

            try
            {
                // Insert data into the tbl_inventory table
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                        INSERT INTO tbl_inventory (item_name, category, quantity, unit_of_measurement, 
                                                   purchase_price, selling_price, expiration_date, date_of_purchase, 
                                                   item_status, batch_no)
                        VALUES (@item_name, @category, @quantity, @unit_of_measurement, 
                                @purchase_price, @selling_price, @expiration_date, @date_of_purchase, 
                                @item_status, @batch_no)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@item_name", itemName);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@unit_of_measurement", unitOfMeasurement);
                        cmd.Parameters.AddWithValue("@purchase_price", purchasePrice);
                        cmd.Parameters.AddWithValue("@selling_price", sellingPrice);
                        cmd.Parameters.AddWithValue("@expiration_date", expirationDate);
                        cmd.Parameters.AddWithValue("@date_of_purchase", dateOfPurchase);
                        cmd.Parameters.AddWithValue("@item_status", status);
                        cmd.Parameters.AddWithValue("@batch_no", batchNo);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item successfully added to inventory.");
                            PopulateDataGridView();
                            // Optionally, clear the input fields for the next entry
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add item to inventory.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Method to clear input fields after successful insertion
        private void ClearInputFields()
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            comboBox2.SelectedIndex = -1;
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox6.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedItemId == -1)
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }

            // Retrieve data from the input fields
            string itemName = textBox1.Text.Trim();
            string category = comboBox1.SelectedItem?.ToString();
            string quantityText = textBox2.Text.Trim();
            string status = comboBox2.SelectedItem?.ToString();
            DateTime dateOfPurchase = dateTimePicker1.Value;
            string purchasePriceText = textBox3.Text.Trim();
            string sellingPriceText = textBox5.Text.Trim();
            DateTime expirationDate = dateTimePicker2.Value;
            string batchNo = textBox4.Text.Trim();
            string unitOfMeasurement = textBox6.Text.Trim();

            // Validate input fields
            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(quantityText) ||
                string.IsNullOrEmpty(status) || string.IsNullOrEmpty(purchasePriceText) || string.IsNullOrEmpty(sellingPriceText) ||
                string.IsNullOrEmpty(batchNo) || string.IsNullOrEmpty(unitOfMeasurement))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(quantityText, out decimal quantity) || !decimal.TryParse(purchasePriceText, out decimal purchasePrice) ||
                !decimal.TryParse(sellingPriceText, out decimal sellingPrice))
            {
                MessageBox.Show("Please enter valid numeric values for quantity, purchase price, and selling price.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                        UPDATE tbl_inventory
                        SET item_name = @item_name, category = @category, quantity = @quantity, 
                            unit_of_measurement = @unit_of_measurement, purchase_price = @purchase_price, 
                            selling_price = @selling_price, expiration_date = @expiration_date, 
                            date_of_purchase = @date_of_purchase, item_status = @item_status, batch_no = @batch_no
                        WHERE item_id = @item_id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@item_id", selectedItemId);
                        cmd.Parameters.AddWithValue("@item_name", itemName);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@unit_of_measurement", unitOfMeasurement);
                        cmd.Parameters.AddWithValue("@purchase_price", purchasePrice);
                        cmd.Parameters.AddWithValue("@selling_price", sellingPrice);
                        cmd.Parameters.AddWithValue("@expiration_date", expirationDate);
                        cmd.Parameters.AddWithValue("@date_of_purchase", dateOfPurchase);
                        cmd.Parameters.AddWithValue("@item_status", status);
                        cmd.Parameters.AddWithValue("@batch_no", batchNo);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item successfully updated.");
                            PopulateDataGridView(); // Refresh the grid
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update item.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (patientGridView.SelectedRows.Count > 0)
            {
                // Get the selected row's Item ID
                int itemId = Convert.ToInt32(patientGridView.SelectedRows[0].Cells["item_id"].Value);

                // Confirm deletion
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete this item?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Perform delete operation
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "DELETE FROM tbl_inventory WHERE item_id = @item_id";

                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                // Add parameter to prevent SQL injection
                                cmd.Parameters.AddWithValue("@item_id", itemId);

                                connection.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Item successfully deleted from inventory.");
                                    // Refresh the DataGridView
                                    ClearInputFields();
                                    PopulateDataGridView();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to delete the item. Please try again.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        private int GetOutOfStockCount()
        {
            int outOfStockCount = 0;

            try
            {
                // string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";

                string query = "SELECT COUNT(*) FROM tbl_inventory WHERE quantity <= 0";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    outOfStockCount = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching out-of-stock count: " + ex.Message);
            }

            return outOfStockCount;
        }
        private int GetNearExpiryCount()
        {
            int nearExpiryCount = 0;
            try
            {
                //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                string query = "SELECT COUNT(*) FROM tbl_inventory WHERE DATEDIFF(day, GETDATE(), expiration_date) <= 90 AND expiration_date > GETDATE()";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    nearExpiryCount = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching near-expiry count: " + ex.Message);
            }
            return nearExpiryCount;
        }

        private int GetExpiredCount()
        {
            int expiredCount = 0;
            try
            {
                //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                string query = "SELECT COUNT(*) FROM tbl_inventory WHERE expiration_date <= GETDATE()";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    expiredCount = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching expired count: " + ex.Message);
            }
            return expiredCount;
        }

    }
}
