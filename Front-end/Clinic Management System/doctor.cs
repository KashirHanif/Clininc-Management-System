﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Clinic_Management_System
{
    public partial class doctor : UserControl
    {
        private string username;
        private string password;
        private string connectionString;
        public doctor(string username, string password, string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
            this.addPatientGridView.CellClick += new DataGridViewCellEventHandler(this.addPatientGridView_CellContentClick_1);
        }

        private void doctor_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void N_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadControl(new cancelAppointment(username, password, connectionString));
        }

        private void pGender2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pfirstNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pCityTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pPhonenumTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void plastNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pCountryTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pCountryCodeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pAgeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pfatherNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pDOBTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pstreetTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pBlockTB_TextChanged(object sender, EventArgs e)
        {

        }


        private void addPatientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
            // Query to fetch data from tbl_employee
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command to execute the stored procedure
                    using (SqlCommand command = new SqlCommand("GetEmployeeDetails", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Create a data adapter to fill the DataTable
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        addPatientGridView.DataSource = dataTable;

                        // Optional: Set DataGridView column headers
                        addPatientGridView.Columns["emp_id"].HeaderText = "Employee ID";
                        addPatientGridView.Columns["designation"].HeaderText = "Designation";
                        addPatientGridView.Columns["f_name"].HeaderText = "First Name";
                        addPatientGridView.Columns["l_name"].HeaderText = "Last Name";
                        addPatientGridView.Columns["department"].HeaderText = "Department";
                        addPatientGridView.Columns["father_name"].HeaderText = "Father's Name";
                        addPatientGridView.Columns["date_of_birth"].HeaderText = "Date of Birth";
                        addPatientGridView.Columns["date_of_joining"].HeaderText = "Date of Joining";
                        addPatientGridView.Columns["street"].HeaderText = "Street";
                        addPatientGridView.Columns["city"].HeaderText = "City";
                        addPatientGridView.Columns["block"].HeaderText = "Block";
                        addPatientGridView.Columns["house_no"].HeaderText = "House No";
                        addPatientGridView.Columns["ph_country_code"].HeaderText = "Country Code";
                        addPatientGridView.Columns["phone_number"].HeaderText = "Phone Number";
                        addPatientGridView.Columns["gender"].HeaderText = "Gender";
                        addPatientGridView.Columns["institution"].HeaderText = "Institution";
                        addPatientGridView.Columns["cnic"].HeaderText = "CNIC";
                        addPatientGridView.Columns["emp_status"].HeaderText = "Employee Status";

                        // Add headers for new columns
                        addPatientGridView.Columns["start_duty"].HeaderText = "Start Duty";
                        addPatientGridView.Columns["end_duty"].HeaderText = "End Duty";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            LoadControl(new updatePatientUserCotroller(username, password, connectionString));
        }

        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       // Clear any existing controls on Form2
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {

        }

        private void pfirstNameTB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void plastNameTB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
            //string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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
                        label16.Text = " ";
                        string employeeName = result.ToString();
                        label16.Text = "Incharge: " + employeeName;
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching employee name: " + ex.Message);
            }
        }

        private void viewPatientButton_Click(object sender, EventArgs e)
        {
            LoadControl(new viewPatient(username, password, connectionString));
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            LoadControl(new addAppointmentController(username, password, connectionString));
        }

        private void viewAppointmentButton_Click(object sender, EventArgs e)
        {
            LoadControl(new viewAppointment(username, password, connectionString));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoadControl(new PatientUserControl(username, password, connectionString));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void addPatientGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            addPatientGridView.ScrollBars = ScrollBars.Both;

            // Ensure a valid row is selected (ignore header row clicks)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = addPatientGridView.Rows[e.RowIndex];

                // Populate the fields with values from the selected row
                pfirstNameTB.Text = selectedRow.Cells["f_name"].Value?.ToString();
                textBox7.Text = selectedRow.Cells["l_name"].Value?.ToString();
                textBox3.Text = selectedRow.Cells["father_name"].Value?.ToString();

                if (DateTime.TryParse(selectedRow.Cells["date_of_birth"].Value?.ToString(), out DateTime dob))
                {
                    dateTimePicker1.Value = dob;
                }

                if (DateTime.TryParse(selectedRow.Cells["date_of_joining"].Value?.ToString(), out DateTime doj))
                {
                    dateTimePicker2.Value = doj;
                }

                comboBox1.Text = selectedRow.Cells["gender"].Value?.ToString();
                textBox4.Text = selectedRow.Cells["institution"].Value?.ToString();
                textBox6.Text = selectedRow.Cells["street"].Value?.ToString();
                textBox9.Text = selectedRow.Cells["house_no"].Value?.ToString();
                textBox5.Text = selectedRow.Cells["city"].Value?.ToString();
                textBox2.Text = selectedRow.Cells["phone_number"].Value?.ToString();
                textBox8.Text = selectedRow.Cells["block"].Value?.ToString();
                textBox1.Text = selectedRow.Cells["cnic"].Value?.ToString();
                comboBox2.Text = selectedRow.Cells["department"].Value?.ToString();

                // Populate the additional fields (designation and status)
                textBox11.Text = selectedRow.Cells["designation"].Value?.ToString(); // Designation TextBox
                comboBox4.Text = selectedRow.Cells["emp_status"].Value?.ToString();  // Status ComboBox

                // Populate Start Duty and End Duty into DateTimePickers
                if (DateTime.TryParse(selectedRow.Cells["start_duty"].Value?.ToString(), out DateTime startDuty))
                {
                    dateTimePicker4.Value = startDuty;
                }

                if (DateTime.TryParse(selectedRow.Cells["end_duty"].Value?.ToString(), out DateTime endDuty))
                {
                    dateTimePicker3.Value = endDuty;
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected in the DataGridView
            if (addPatientGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = addPatientGridView.SelectedRows[0];
                int employeeId = Convert.ToInt32(selectedRow.Cells["emp_id"].Value);

                // Retrieve updated values from textboxes, comboboxes, and date pickers
                string updatedFirstName = pfirstNameTB.Text.Trim();  // First Name TextBox
                string updatedLastName = textBox7.Text.Trim();        // Last Name TextBox
                string updatedFatherName = textBox3.Text.Trim();      // Father Name TextBox

                DateTime updatedDOB = DateTime.TryParse(selectedRow.Cells["date_of_birth"].Value?.ToString(), out DateTime dob) ? dob : dateTimePicker1.Value; // Date of Birth
                DateTime updatedDOJ = DateTime.TryParse(selectedRow.Cells["date_of_joining"].Value?.ToString(), out DateTime doj) ? doj : dateTimePicker2.Value; // Date of Joining
                string updatedGender = comboBox1.Text.Trim();         // Gender ComboBox
                string updatedInstitution = textBox4.Text.Trim();     // Institution TextBox
                string updatedStreet = textBox6.Text.Trim();          // Street TextBox
                string updatedHouseNo = textBox9.Text.Trim();         // House Number TextBox
                string updatedCity = textBox5.Text.Trim();            // City TextBox
                string updatedPhoneNumber = textBox2.Text.Trim();     // Phone Number TextBox
                string updatedBlock = textBox8.Text.Trim();           // Block TextBox
                string updatedCNIC = textBox1.Text.Trim();            // CNIC TextBox
                string updatedDepartment = comboBox2.Text.Trim();     // Department ComboBox

                // Retrieve Designation, Status, Start Duty, and End Duty from controls
                string updatedDesignation = textBox11.Text.Trim();    // Designation TextBox
                string updatedStatus = comboBox4.Text.Trim();         // Status ComboBox
                TimeSpan updatedStartDuty = dateTimePicker4.Value.TimeOfDay; // Start Duty
                TimeSpan updatedEndDuty = dateTimePicker3.Value.TimeOfDay;   // End Duty

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        // Open the database connection
                        conn.Open();

                        // Create the SQL command to execute the stored procedure
                        using (SqlCommand cmd = new SqlCommand("UpdateEmployeeDetails", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Add parameters for the stored procedure
                            cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                            cmd.Parameters.AddWithValue("@Designation", updatedDesignation);
                            cmd.Parameters.AddWithValue("@FirstName", updatedFirstName);
                            cmd.Parameters.AddWithValue("@LastName", updatedLastName);
                            cmd.Parameters.AddWithValue("@Department", updatedDepartment);
                            cmd.Parameters.AddWithValue("@FatherName", updatedFatherName);
                            cmd.Parameters.AddWithValue("@DOB", updatedDOB);
                            cmd.Parameters.AddWithValue("@DOJ", updatedDOJ);
                            cmd.Parameters.AddWithValue("@Street", updatedStreet);
                            cmd.Parameters.AddWithValue("@City", updatedCity);
                            cmd.Parameters.AddWithValue("@Block", updatedBlock);
                            cmd.Parameters.AddWithValue("@HouseNo", updatedHouseNo);
                            cmd.Parameters.AddWithValue("@PhoneNumber", updatedPhoneNumber);
                            cmd.Parameters.AddWithValue("@Gender", updatedGender);
                            cmd.Parameters.AddWithValue("@Institution", updatedInstitution);
                            cmd.Parameters.AddWithValue("@CNIC", updatedCNIC);
                            cmd.Parameters.AddWithValue("@Status", updatedStatus);
                            cmd.Parameters.AddWithValue("@StartDuty", updatedStartDuty);
                            cmd.Parameters.AddWithValue("@EndDuty", updatedEndDuty);

                            // Execute the stored procedure
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Confirm success
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the DataGridView
                                PopulateDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Inform the user to select a row
                MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected availability status from comboBox3
           
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                string availabilityStatus = comboBox3.SelectedItem?.ToString();

                // Define the base SQL query
                string query = @"
                    SELECT 
                        e.emp_id, 
                        e.designation, 
                        e.f_name,  
                        e.l_name, 
                        d.department, 
                        e.father_name, 
                        e.date_of_birth, 
                        e.date_of_joining, 
                        e.street, 
                        e.city, 
                        e.block,
                        e.house_no,
                        e.ph_country_code, 
                        e.phone_number, 
                        e.gender, 
                        e.institution, 
                        e.cnic,
                        wh.emp_status,
                        wh.start_duty,
                        wh.end_duty
                    FROM tbl_employee e
                    INNER JOIN tbl_department d
                        ON e.emp_id = d.emp_id
                    INNER JOIN tbl_emp_working_hours wh
                        ON e.emp_id = wh.emp_id";

                // Modify the query based on the availability status selected in comboBox3
                if (availabilityStatus == "Available")
                {
                    query += " WHERE wh.emp_status = 'Available'";  // Only available employees
                }
                else if (availabilityStatus == "On Leave")
                {
                    query += " WHERE wh.emp_status = 'On Leave'";  // Only employees on leave
                }
                else if (availabilityStatus == "Resigned")
                {
                    query += " WHERE wh.emp_status = 'Resigned'";  // Only resigned employees
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open(); // Open the connection

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Execute the query and fetch the data
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            // Bind the data to the DataGridView
                            addPatientGridView.DataSource = dataTable;

                            // Optional: Set column headers if needed
                            addPatientGridView.Columns["emp_id"].HeaderText = "Employee ID";
                            addPatientGridView.Columns["designation"].HeaderText = "Designation";
                            addPatientGridView.Columns["f_name"].HeaderText = "First Name";
                            addPatientGridView.Columns["l_name"].HeaderText = "Last Name";
                            addPatientGridView.Columns["department"].HeaderText = "Department";
                            addPatientGridView.Columns["father_name"].HeaderText = "Father's Name";
                            addPatientGridView.Columns["date_of_birth"].HeaderText = "Date of Birth";
                            addPatientGridView.Columns["date_of_joining"].HeaderText = "Date of Joining";
                            addPatientGridView.Columns["street"].HeaderText = "Street";
                            addPatientGridView.Columns["city"].HeaderText = "City";
                            addPatientGridView.Columns["block"].HeaderText = "Block";
                            addPatientGridView.Columns["house_no"].HeaderText = "House No";
                            addPatientGridView.Columns["ph_country_code"].HeaderText = "Country Code";
                            addPatientGridView.Columns["phone_number"].HeaderText = "Phone Number";
                            addPatientGridView.Columns["gender"].HeaderText = "Gender";
                            addPatientGridView.Columns["institution"].HeaderText = "Institution";
                            addPatientGridView.Columns["cnic"].HeaderText = "CNIC";
                            addPatientGridView.Columns["emp_status"].HeaderText = "Employee Status";
                            addPatientGridView.Columns["start_duty"].HeaderText = "Start Duty";
                            addPatientGridView.Columns["end_duty"].HeaderText = "End Duty";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        
            private void button3_Click_2(object sender, EventArgs e)
        {
            string doctorName = textBox10.Text.Trim(); // Get the name entered in the textbox

            // Define the SQL query with a filter using CONCAT for full name match
            string query = @"
                SELECT 
                    e.emp_id, 
                    e.designation, 
                    e.f_name,  
                    e.l_name, 
                    d.department, 
                    e.father_name, 
                    e.date_of_birth, 
                    e.date_of_joining, 
                    e.street, 
                    e.city, 
                    e.block,
                    e.house_no,
                    e.ph_country_code, 
                    e.phone_number, 
                    e.gender, 
                    e.institution, 
                    e.cnic,
                    wh.emp_status,
                    wh.start_duty,
                    wh.end_duty
                FROM tbl_employee e
                INNER JOIN tbl_department d
                    ON e.emp_id = d.emp_id
                INNER JOIN tbl_emp_working_hours wh
                    ON e.emp_id = wh.emp_id
                WHERE CONCAT(e.f_name, ' ', e.l_name) LIKE '%' + @doctorName + '%'";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter for doctorName
                        command.Parameters.AddWithValue("@doctorName", doctorName);

                        // Create a data adapter to fill the DataTable
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        addPatientGridView.DataSource = dataTable;

                        // Optional: Set DataGridView column headers
                        addPatientGridView.Columns["emp_id"].HeaderText = "Employee ID";
                        addPatientGridView.Columns["designation"].HeaderText = "Designation";
                        addPatientGridView.Columns["f_name"].HeaderText = "First Name";
                        addPatientGridView.Columns["l_name"].HeaderText = "Last Name";
                        addPatientGridView.Columns["department"].HeaderText = "Department";
                        addPatientGridView.Columns["father_name"].HeaderText = "Father's Name";
                        addPatientGridView.Columns["date_of_birth"].HeaderText = "Date of Birth";
                        addPatientGridView.Columns["date_of_joining"].HeaderText = "Date of Joining";
                        addPatientGridView.Columns["street"].HeaderText = "Street";
                        addPatientGridView.Columns["city"].HeaderText = "City";
                        addPatientGridView.Columns["block"].HeaderText = "Block";
                        addPatientGridView.Columns["house_no"].HeaderText = "House No";
                        addPatientGridView.Columns["ph_country_code"].HeaderText = "Country Code";
                        addPatientGridView.Columns["phone_number"].HeaderText = "Phone Number";
                        addPatientGridView.Columns["gender"].HeaderText = "Gender";
                        addPatientGridView.Columns["institution"].HeaderText = "Institution";
                        addPatientGridView.Columns["cnic"].HeaderText = "CNIC";
                        addPatientGridView.Columns["emp_status"].HeaderText = "Employee Status";
                        addPatientGridView.Columns["start_duty"].HeaderText = "Start Duty";
                        addPatientGridView.Columns["end_duty"].HeaderText = "End Duty";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadControl(new presciption(username, password, connectionString));
        }
    }
}