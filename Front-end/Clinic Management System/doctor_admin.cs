using System;
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
    public partial class doctor_admin : UserControl
    {
        private string username;
        private string password;
        private string connectionString;
        public doctor_admin(string username, string password, string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
            this.addPatientGridView.CellClick += new DataGridViewCellEventHandler(this.addPatientGridView_CellContentClick_1);
        }

        private void doctor_admin_Load(object sender, EventArgs e)
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
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT e.emp_id, e.designation, e.f_name, e.l_name, d.department, e.father_name, e.date_of_birth, e.date_of_joining, 
                e.street, e.city, e.block, e.house_no, e.ph_country_code, e.phone_number, e.gender, e.institution, e.cnic, 
                wh.emp_status, wh.start_duty, wh.end_duty, lt.username, lt.password, e.date_of_lefting
                FROM tbl_employee e 
                INNER JOIN tbl_department d ON e.emp_id = d.emp_id 
                INNER JOIN tbl_emp_working_hours wh ON e.emp_id = wh.emp_id 
                LEFT JOIN login_table lt ON e.emp_id = lt.emp_id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        addPatientGridView.DataSource = dataTable;

                        // Set headers for DataGridView columns
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
                        addPatientGridView.Columns["username"].HeaderText = "Username";
                        addPatientGridView.Columns["password"].HeaderText = "Password";
                        addPatientGridView.Columns["date_of_lefting"].HeaderText = "Date of Leaving";  // Add the column header for Date of Leaving
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
            LoadControl(new adminMenu(username, password, connectionString));
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

                // Set username and password into respective TextBoxes
                textBox12.Text = selectedRow.Cells["username"].Value?.ToString(); // Username TextBox
                textBox13.Text = selectedRow.Cells["password"].Value?.ToString(); // Password TextBox
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
                string updatedFirstName = pfirstNameTB.Text.Trim();
                string updatedLastName = textBox7.Text.Trim();
                string updatedFatherName = textBox3.Text.Trim();
                DateTime updatedDOB = dateTimePicker1.Value;
                DateTime updatedDOJ = dateTimePicker2.Value;
                string updatedGender = comboBox1.Text.Trim();
                string updatedInstitution = textBox4.Text.Trim();
                string updatedStreet = textBox6.Text.Trim();
                string updatedHouseNo = textBox9.Text.Trim();
                string updatedCity = textBox5.Text.Trim();
                string updatedPhoneNumber = textBox2.Text.Trim();
                string updatedBlock = textBox8.Text.Trim();
                string updatedCNIC = textBox1.Text.Trim();
                string updatedDepartment = comboBox2.Text.Trim();
                string updatedDesignation = textBox11.Text.Trim();
                string updatedStatus = comboBox4.Text.Trim();
                TimeSpan updatedStartDuty = dateTimePicker4.Value.TimeOfDay;
                TimeSpan updatedEndDuty = dateTimePicker3.Value.TimeOfDay;

                // Retrieve Username and Password
                string updatedUsername = textBox12.Text.Trim();
                string updatedPassword = textBox13.Text.Trim();

                // Get the value from dateTimePicker5 for date_of_lefting, if provided


                // Retrieve the date_of_lefting value if available
                DateTime? updatedDateOfLeaving = null;
                if (updatedStatus == "Resigned")
                {
                    // Only set date_of_lefting if the status is Resigned
                    if (dateTimePicker5.Value != null && dateTimePicker5.Value != DateTime.MinValue)
                    {
                        updatedDateOfLeaving = dateTimePicker5.Value;
                    }
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Update employee details
                        string query = @"
        UPDATE tbl_employee 
        SET designation = @Designation, f_name = @FirstName, l_name = @LastName, 
            father_name = @FatherName, date_of_birth = @DOB, date_of_joining = @DOJ, 
            street = @Street, city = @City, block = @Block, house_no = @HouseNo, 
            phone_number = @PhoneNumber, gender = @Gender, institution = @Institution, 
            cnic = @CNIC";

                        // Conditionally add the date_of_lefting update if it is provided
                        if (updatedDateOfLeaving.HasValue)
                        {
                            query += ", date_of_lefting = @DateOfLeaving";
                        }

                        query += " WHERE emp_id = @EmployeeId";

                        query += @"
            UPDATE tbl_department 
            SET department = @Department 
            WHERE emp_id = @EmployeeId;

            UPDATE tbl_emp_working_hours 
            SET emp_status = @Status, start_duty = @StartDuty, end_duty = @EndDuty 
            WHERE emp_id = @EmployeeId;

            UPDATE login_table 
            SET username = @Username, password = @Password 
            WHERE emp_id = @EmployeeId;";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Add parameters
                            cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                            cmd.Parameters.AddWithValue("@Designation", updatedDesignation);
                            cmd.Parameters.AddWithValue("@FirstName", updatedFirstName);
                            cmd.Parameters.AddWithValue("@LastName", updatedLastName);
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
                            cmd.Parameters.AddWithValue("@Department", updatedDepartment);
                            cmd.Parameters.AddWithValue("@Status", updatedStatus);
                            cmd.Parameters.AddWithValue("@StartDuty", updatedStartDuty);
                            cmd.Parameters.AddWithValue("@EndDuty", updatedEndDuty);
                            cmd.Parameters.AddWithValue("@Username", updatedUsername);
                            cmd.Parameters.AddWithValue("@Password", updatedPassword);

                            // Add the DateOfLeaving parameter only if it has a value
                            if (updatedDateOfLeaving.HasValue)
                            {
                                cmd.Parameters.AddWithValue("@DateOfLeaving", updatedDateOfLeaving.Value);
                            }

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee record and login details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

            // Define the base SQL query with username and password included
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
        wh.end_duty,
        lt.username,
        lt.password
    FROM tbl_employee e
    INNER JOIN tbl_department d
        ON e.emp_id = d.emp_id
    INNER JOIN tbl_emp_working_hours wh
        ON e.emp_id = wh.emp_id
    LEFT JOIN login_table lt
        ON e.emp_id = lt.emp_id";  // Join with login_table to get username and password

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
                        addPatientGridView.Columns["username"].HeaderText = "Username";  // Display Username
                        addPatientGridView.Columns["password"].HeaderText = "Password";  // Display Password
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

            // Define the SQL query with a filter using CONCAT for full name match and join with login_table
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
            wh.end_duty,
            lt.username,
            lt.password
        FROM tbl_employee e
        INNER JOIN tbl_department d
            ON e.emp_id = d.emp_id
        INNER JOIN tbl_emp_working_hours wh
            ON e.emp_id = wh.emp_id
        Left JOIN login_table lt
            ON e.emp_id = lt.emp_id
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
                        addPatientGridView.Columns["username"].HeaderText = "Username";  // Display Username
                        addPatientGridView.Columns["password"].HeaderText = "Password";  // Display Password
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

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            string firstName = pfirstNameTB.Text.Trim();
            string lastName = textBox7.Text.Trim();
            string fatherName = textBox3.Text.Trim();
            DateTime dob = dateTimePicker1.Value;
            DateTime doj = dateTimePicker2.Value;
            string gender = comboBox1.Text.Trim();
            string institution = string.IsNullOrEmpty(textBox4.Text.Trim()) ? null : textBox4.Text.Trim();
            string street = textBox6.Text.Trim();
            string houseNo = textBox9.Text.Trim();
            string city = textBox5.Text.Trim();
            string phoneNumber = textBox2.Text.Trim();
            string block = textBox8.Text.Trim();
            string cnic = textBox1.Text.Trim();
            string department = comboBox2.Text.Trim();
            string designation = textBox11.Text.Trim();
            string status = comboBox4.Text.Trim();
            TimeSpan startDuty = dateTimePicker4.Value.TimeOfDay;
            TimeSpan endDuty = dateTimePicker3.Value.TimeOfDay;
            string username = string.IsNullOrEmpty(textBox12.Text.Trim()) ? null : textBox12.Text.Trim();
            string password = string.IsNullOrEmpty(textBox13.Text.Trim()) ? null : textBox13.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Add employee record
                    string query = @"
                INSERT INTO tbl_employee 
                (designation, f_name, l_name, father_name, date_of_birth, date_of_joining, street, 
                city, block, house_no, phone_number, gender, institution, cnic) 
                VALUES 
                (@Designation, @FirstName, @LastName, @FatherName, @DOB, @DOJ, @Street, 
                @City, @Block, @HouseNo, @PhoneNumber, @Gender, @Institution, @CNIC);

                DECLARE @EmployeeId INT = SCOPE_IDENTITY();

                INSERT INTO tbl_department (emp_id, department) 
                VALUES (@EmployeeId, @Department);

                INSERT INTO tbl_emp_working_hours (emp_id, emp_status, start_duty, end_duty) 
                VALUES (@EmployeeId, @Status, @StartDuty, @EndDuty);

                IF (@Username IS NOT NULL AND @Password IS NOT NULL)
                BEGIN
                    INSERT INTO login_table (emp_id, username, password) 
                    VALUES (@EmployeeId, @Username, @Password);
                END;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Designation", designation);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@FatherName", fatherName);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@DOJ", doj);
                        cmd.Parameters.AddWithValue("@Street", street);
                        cmd.Parameters.AddWithValue("@City", city);
                        cmd.Parameters.AddWithValue("@Block", block);
                        cmd.Parameters.AddWithValue("@HouseNo", houseNo);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Institution", (object)institution ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CNIC", cnic);
                        cmd.Parameters.AddWithValue("@Department", department);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@StartDuty", startDuty);
                        cmd.Parameters.AddWithValue("@EndDuty", endDuty);
                        cmd.Parameters.AddWithValue("@Username", (object)username ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Password", (object)password ?? DBNull.Value);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New employee record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PopulateDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No record was added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (addPatientGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = addPatientGridView.SelectedRows[0];
                int employeeId = Convert.ToInt32(selectedRow.Cells["emp_id"].Value);

                // Confirm deletion with the user
                var confirmResult = MessageBox.Show($"Are you sure you want to delete the employee with ID {employeeId}?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            // Delete employee and related records from other tables
                            string query = @"DELETE FROM login_table WHERE emp_id = @EmployeeId;
                                     DELETE FROM tbl_emp_working_hours WHERE emp_id = @EmployeeId;
                                     DELETE FROM tbl_department WHERE emp_id = @EmployeeId;
                                     DELETE FROM tbl_employee WHERE emp_id = @EmployeeId;";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                // Add parameter for employee ID
                                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                                // Execute the delete command
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Employee record and related details deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    PopulateDataGridView(); // Refresh the DataGridView to reflect changes
                                }
                                else
                                {
                                    MessageBox.Show("No record found with the specified Employee ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}