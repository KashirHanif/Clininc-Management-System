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
        public addAppointmentController(string username,string password)
        {
            InitializeComponent();
            this.addPatientGridView.CellClick += new DataGridViewCellEventHandler(this.addPatientGridView_CellContentClick);

            this.comboBox2.DropDown += comboBox2_DropDown;
            this.comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

            this.comboBox1.DropDown += comboBox1_DropDown;
            this.comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            this.username = username;
            this.password = password;
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
            LoadControl(new cancelAppointment(username, password));
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
                string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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
                string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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

                    // Queries to retrieve emp_id based on names
                    string getEmpIdQuery = "SELECT emp_id FROM tbl_employee WHERE CONCAT(f_name, ' ', l_name) = @EmployeeName";

                    // Get emp_id for Booked By
                    SqlCommand getBookedByEmpIdCmd = new SqlCommand(getEmpIdQuery, conn);
                    getBookedByEmpIdCmd.Parameters.AddWithValue("@EmployeeName", bookedByName);
                    object bookedByEmpIdResult = getBookedByEmpIdCmd.ExecuteScalar();

                    if (bookedByEmpIdResult == null)
                    {
                        MessageBox.Show($"Could not find an employee with the name '{bookedByName}'.", "Error");
                        return;
                    }
                    int bookedByEmpId = Convert.ToInt32(bookedByEmpIdResult);

                    // Get emp_id for Booked For
                    SqlCommand getBookedForEmpIdCmd = new SqlCommand(getEmpIdQuery, conn);
                    getBookedForEmpIdCmd.Parameters.AddWithValue("@EmployeeName", bookedForName);
                    object bookedForEmpIdResult = getBookedForEmpIdCmd.ExecuteScalar();

                    if (bookedForEmpIdResult == null)
                    {
                        MessageBox.Show($"Could not find an employee with the name '{bookedForName}'.", "Error");
                        return;
                    }
                    int bookedForEmpId = Convert.ToInt32(bookedForEmpIdResult);

                    // Insert query for appointment
                    string insertQuery = @"
                    INSERT INTO tbl_appointment 
                    (date_of_appointment, time_of_appointment, booked_by_emp_id, booked_for_emp_id, appointment_type, appointment_status, patient_id)
                    VALUES 
                    (@DateOfAppointment, @TimeOfAppointment, @BookedByEmpId, @BookedForEmpId, @AppointmentType, @AppointmentStatus,  @PatientId)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                    // Add parameters to the insert query
                    insertCmd.Parameters.AddWithValue("@DateOfAppointment", appointmentDate);
                    insertCmd.Parameters.AddWithValue("@TimeOfAppointment", appointmentTime);
                    insertCmd.Parameters.AddWithValue("@BookedByEmpId", bookedByEmpId);
                    insertCmd.Parameters.AddWithValue("@BookedForEmpId", bookedForEmpId);
                    insertCmd.Parameters.AddWithValue("@AppointmentType", AptTypeComboBox.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@AppointmentStatus", statusComboBox.SelectedItem.ToString());

                    insertCmd.Parameters.AddWithValue("@PatientId", int.Parse(patientIdTextBox.Text));

                    // Execute the insert command
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Appointment added successfully.", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }


        }


        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            LoadControl(new updatePatientUserCotroller(username,password));
        }

        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       // Clear any existing controls on Form2
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new addPatientUserCotroller(username,password));
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
                string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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
            PopulateEmployeeComboBox();
        }

        private void PopulateEmployeeComboBox()
        {
            try
            {
               // string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
               string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                string query = @"SELECT CONCAT(f_name, ' ', l_name) AS EmployeeName
                         FROM tbl_employee";

                comboBox1.Items.Clear(); // Clear existing items before adding new ones

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Use the correct column alias from the query
                                string employeeName = reader["EmployeeName"].ToString();
                                comboBox1.Items.Add(employeeName); // Add each employee name to the ComboBox
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
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
               // string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                // Get the selected doctor name from comboBox2
                string selectedDoctor = comboBox2.SelectedItem?.ToString();
                DateTime selectedDate = aptDate.Value.Date;

                if (string.IsNullOrEmpty(selectedDoctor))
                {
                    MessageBox.Show("Please select a doctor from the list.");
                    return;
                }

                string query = @"
                SELECT TOP 1 a.time_of_appointment 
                FROM tbl_employee e
                INNER JOIN tbl_appointment a
                    ON a.date_of_appointment = @AppointmentDate
                    AND a.appointment_status = 'Booked'
                WHERE a.booked_for_emp_id IN (
                    SELECT emp_id 
                    FROM tbl_employee e
                    WHERE CONCAT(e.f_name, ' ', e.l_name) = @DoctorName
                )
                ORDER BY a.time_of_appointment DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add the selected doctor's name as a parameter
                        cmd.Parameters.AddWithValue("@DoctorName", selectedDoctor);
                        cmd.Parameters.AddWithValue("@AppointmentDate", selectedDate);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Parse the retrieved time and add 15 minutes
                            TimeSpan lastAppointmentTime = (TimeSpan)result;
                            TimeSpan newAppointmentTime = lastAppointmentTime.Add(new TimeSpan(0, 15, 0));

                            // Assign the calculated time to the TextBox
                            string time = newAppointmentTime.ToString(@"hh\:mm");
                            aptTime.Text = time;
                        }
                        else
                        {
                            string dutyQuery = @"
                            SELECT start_duty 
                            FROM tbl_emp_working_hours ewh
                            INNER JOIN tbl_employee e
                                ON e.emp_id = ewh.emp_id
                            WHERE CONCAT(e.f_name, ' ', e.l_name) = @DoctorName";

                            using (SqlCommand dutyCmd = new SqlCommand(dutyQuery, connection))
                            {
                                // Add the selected doctor's name as a parameter
                                dutyCmd.Parameters.AddWithValue("@DoctorName", selectedDoctor);

                                object dutyResult = dutyCmd.ExecuteScalar();

                                if (dutyResult != null)
                                {
                                    TimeSpan startDutyTime = (TimeSpan)dutyResult;

                                    // Assign the start duty time to the TextBox
                                    string dutyTime = startDutyTime.ToString(@"hh\:mm");
                                    aptTime.Text = dutyTime;
                                }
                            }
                        }
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
                string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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
            LoadControl(new addAppointmentController(username, password));
        }

        private void label5_Click(object sender, EventArgs e)
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
            LoadControl(new viewPatient(username, password));
        }

        private void viewAppointmentButton_Click(object sender, EventArgs e)
        {
            LoadControl(new viewAppointment(username, password));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoadControl(new PatientUserControl(username, password));
        }
    }
}