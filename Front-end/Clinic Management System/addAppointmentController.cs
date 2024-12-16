using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic_Management_System
{
    public partial class addAppointmentController : UserControl
    {
        private string username;
        private string password;
        private string connectionString;

        public addAppointmentController(string username, string password, string connectionString)
        {
            InitializeComponent();
            this.addPatientGridView.CellClick += new DataGridViewCellEventHandler(this.addPatientGridView_CellContentClick);

            this.comboBox2.DropDown += comboBox2_DropDown;
            this.comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

            this.comboBox1.DropDown += comboBox1_DropDown;
            this.comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            this.username = username;
            this.password = password;
            this.connectionString = connectionString;

            ConfigureDatePicker(); // Configure the date picker during initialization
        }

        private void ConfigureDatePicker()
        {
            aptDate.MinDate = DateTime.Now.Date; // Set the minimum selectable date to today's date
            aptDate.Value = DateTime.Now.Date;  // Default to today's date
        }

        private void addAppointmentController_Load(object sender, EventArgs e)
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

        private void addButton_Click(object sender, EventArgs e)
        {

        }


        private void addPatientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateDataGridView();


            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = addPatientGridView.Rows[e.RowIndex];

                // Populate textboxes with data from the selected row
                if (addPatientGridView.Columns.Contains("patient_id") && addPatientGridView.Columns.Contains("phone_number"))
                {
                    // Get patient_id and phone_number values
                    string patientId = selectedRow.Cells["patient_id"].Value?.ToString();
                    string phoneNumber = selectedRow.Cells["phone_number"].Value?.ToString();

                    // Assign the values to the respective textboxes
                    patientIdTextBox.Text = patientId;
                    aptPhonenum.Text = phoneNumber;
                }
                else
                {
                    MessageBox.Show("Required columns are not available in the DataGridView.");
                }
            }
            else
            {
                MessageBox.Show("Invalid row selected.");
            }


        }
        private void PopulateDataGridView()
        {
            try
            {
                //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
               // string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                string query = "SELECT patient_id, p_f_name, p_l_name, father_name, date_of_birth,street,block,city, country,ph_country_code, phone_number, gender, age,CNIC FROM tbl_patient";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    addPatientGridView.DataSource = dataTable;

                    // Set user-friendly column names
                    addPatientGridView.Columns["patient_id"].HeaderText = "Patient ID";
                    addPatientGridView.Columns["p_f_name"].HeaderText = "First Name";
                    addPatientGridView.Columns["p_l_name"].HeaderText = "Last Name";
                    addPatientGridView.Columns["father_name"].HeaderText = "Father's Name";
                    addPatientGridView.Columns["date_of_birth"].HeaderText = "Date of Birth";
                    addPatientGridView.Columns["street"].HeaderText = "Street";
                    addPatientGridView.Columns["block"].HeaderText = "Block";
                    addPatientGridView.Columns["city"].HeaderText = "City";
                    addPatientGridView.Columns["country"].HeaderText = "Country";
                    addPatientGridView.Columns["ph_country_code"].HeaderText = "Phone Country Code";
                    addPatientGridView.Columns["phone_number"].HeaderText = "Phone Number";
                    addPatientGridView.Columns["gender"].HeaderText = "Gender";
                    addPatientGridView.Columns["age"].HeaderText = "Age";

                    addPatientGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
               // string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                // Validate selected items in combo boxes
                string bookedForName = comboBox2.SelectedItem?.ToString();
                string bookedByName = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(bookedByName) || string.IsNullOrEmpty(bookedForName))
                {
                    MessageBox.Show("Please select valid names for both 'Booked By' and 'Booked For' fields.", "Validation Error");
                    return;
                }
                DateTime appointmentDate = aptDate.Value;
                string appointmentTime = aptTime.Text.ToString();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("add_appointment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@booked_by_name", bookedByName);
                        cmd.Parameters.AddWithValue("@booked_for_name", bookedForName);
                        cmd.Parameters.AddWithValue("@appointment_date", appointmentDate);
                        cmd.Parameters.AddWithValue("@appointment_time", appointmentTime);
                        cmd.Parameters.AddWithValue("@appointment_type", AptTypeComboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@appointment_status", statusComboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@patient_id", int.Parse(patientIdTextBox.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Appointment added successfully.", "Success");
                PopulateDataGridView();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }


        }


        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            LoadControl(new updatePatientUserCotroller(username,password, connectionString));
        }

        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       // Clear any existing controls on Form2
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new addPatientUserCotroller(username,password, connectionString));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pDOBTB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pCityTB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pfirstNameTB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void patientIdTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            PopulateDoctorsComboBox();
        }

        private void PopulateDoctorsComboBox()
        {
            try
            {
                //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                //string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                string query = @"SELECT CONCAT(f_name, ' ', l_name) AS DoctorName
                         FROM tbl_employee
                         WHERE designation = 'Doctor' 
                         AND emp_id IN (
                             SELECT emp_id 
                             FROM tbl_emp_working_hours 
                             WHERE emp_status = 'Available'
                         )";

                comboBox2.Items.Clear(); // Clear existing items before adding new ones

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string doctorName = reader["DoctorName"].ToString();
                                comboBox2.Items.Add(doctorName); // Add each doctor name to the ComboBox
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            PopulateEmployeeComboBox(username,password);
        }

        private void PopulateEmployeeComboBox(string username, string password)
        {
            try
            {
                // Query to fetch the full name of employees
                string query = @"
                    SELECT CONCAT(f_name, ' ', l_name) AS EmployeeName
                    FROM tbl_employee
                    WHERE emp_id IN (
                        SELECT emp_id FROM login_table
                        WHERE username = @username AND password = @password
                    )";

                // Clear existing items in comboBox1
                comboBox1.Items.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Execute the query and get the data
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Loop through the data and add each employee name to the comboBox1
                            while (reader.Read())
                            {
                                string employeeName = reader["EmployeeName"].ToString();
                                comboBox1.Items.Add(employeeName);
                            }
                        }
                    }
                }

                // Optionally, you can set the default selected item
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0; // Set the first item as selected by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee names: " + ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call the method to fetch and display the next appointment time
            GetNextAppointmentTime();
        }

        private void GetNextAppointmentTime()
        {
            try
            {
                string selectedDoctor = comboBox2.SelectedItem?.ToString();
                DateTime selectedDate = aptDate.Value.Date;

                if (string.IsNullOrEmpty(selectedDoctor))
                {
                    MessageBox.Show("Please select a doctor from the list.");
                    return;
                }

                string nextAppointmentTime;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("get_next_appointment_time", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@doctor_name", selectedDoctor);
                        cmd.Parameters.AddWithValue("@appointment_date", selectedDate);

                        SqlParameter nextTimeParam = new SqlParameter("@next_time", SqlDbType.Time)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(nextTimeParam);

                        cmd.ExecuteNonQuery();

                        nextAppointmentTime = nextTimeParam.Value?.ToString();
                        aptTime.Text = nextAppointmentTime ?? "error fetching time.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching appointment time: " + ex.Message);
            }
        }

        private void searchPatient_Click(object sender, EventArgs e)
        {
            string phoneNumber = aptSearch.Text.Trim(); // Get the phone number from the text box

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                // Your connection string
                //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
               // string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                // SQL query to filter patients by phone number
                string query = "SELECT patient_id, p_f_name, p_l_name, father_name, date_of_birth, street, block, city, country, ph_country_code, phone_number, gender, age, CNIC FROM tbl_patient WHERE phone_number = @PhoneNumber";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            // Add the phone number parameter to prevent SQL injection
                            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                            // Set up the DataAdapter to fill the DataTable with the query results
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            // Bind the result to the DataGridView
                            addPatientGridView.DataSource = dataTable;

                            // Set user-friendly column names
                            addPatientGridView.Columns["patient_id"].HeaderText = "Patient ID";
                            addPatientGridView.Columns["p_f_name"].HeaderText = "First Name";
                            addPatientGridView.Columns["p_l_name"].HeaderText = "Last Name";
                            addPatientGridView.Columns["father_name"].HeaderText = "Father's Name";
                            addPatientGridView.Columns["date_of_birth"].HeaderText = "Date of Birth";
                            addPatientGridView.Columns["street"].HeaderText = "Street";
                            addPatientGridView.Columns["block"].HeaderText = "Block";
                            addPatientGridView.Columns["city"].HeaderText = "City";
                            addPatientGridView.Columns["country"].HeaderText = "Country";
                            addPatientGridView.Columns["ph_country_code"].HeaderText = "Phone Country Code";
                            addPatientGridView.Columns["phone_number"].HeaderText = "Phone Number";
                            addPatientGridView.Columns["gender"].HeaderText = "Gender";
                            addPatientGridView.Columns["age"].HeaderText = "Age";
                            addPatientGridView.Columns["CNIC"].HeaderText = "CNIC";
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
                MessageBox.Show("Please enter a phone number to search.");
            }
        }
        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            LoadControl(new addAppointmentController(username, password, connectionString));
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
           // string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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
                        label5.Text = "Incharge: " + employeeName;
                    }
                    else
                    {
                        label5.Text = "Incharge: Not Found";
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

        private void viewAppointmentButton_Click(object sender, EventArgs e)
        {
            LoadControl(new viewAppointment(username, password, connectionString));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoadControl(new PatientUserControl(username, password,connectionString));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new addTreatment(username, password, connectionString));
        }

        private void aptDate_ValueChanged(object sender, EventArgs e)
        {
            if (aptDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Appointments cannot be scheduled for past dates. Please select a valid date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                aptDate.Value = DateTime.Now.Date; // Reset to today's date
            }
        }

        private void addPatientGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}