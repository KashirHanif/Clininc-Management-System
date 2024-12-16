using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic_Management_System
{
    public partial class viewAppointment : UserControl
    {
        private string username;
        private string password;
        private string connectionString;
        // Connection string to your database
        //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
       // string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
        public viewAppointment(string username,string password,string connectionString)
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            

            this.findByDoctor.DropDown += findByDoctor_DropDown;
            this.findByDoctor.SelectedIndexChanged += findByDoctor_SelectedIndexChanged;


            this.username = username;
            this.password = password;
            this.connectionString = connectionString;

        }

        // Populate the DataGridView with patient data
        private void PopulateDataGridView()
        {
            try
            {
                // Query to retrieve appointment details along with patient and employee information
                string query = @"
                    SELECT 
                        a.appointment_id AS AppointmentID,
                        a.date_of_appointment AS AppointmentDate,
                        a.time_of_appointment AS AppointmentTime,
                        (SELECT CONCAT(p.p_f_name, ' ', p.p_l_name) 
                         FROM tbl_patient p 
                         WHERE p.patient_id = a.patient_id) AS PatientName,
                        (SELECT CONCAT(e.f_name, ' ', e.l_name)
                         FROM tbl_employee e 
                         WHERE e.emp_id = a.booked_by_emp_id) AS BookedByEmployee,
                        (SELECT CONCAT(e.f_name, ' ', e.l_name)
                         FROM tbl_employee e 
                         WHERE e.emp_id = a.booked_for_emp_id) AS BookedForEmployee
                    FROM tbl_appointment a;";

                // Using connection and command to fetch data
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the results to the DataGridView
                    patientGridView.DataSource = dataTable;

                    // Set user-friendly column names
                    patientGridView.Columns["AppointmentID"].HeaderText = "Appointment ID";
                    patientGridView.Columns["AppointmentDate"].HeaderText = "Appointment Date";
                    patientGridView.Columns["AppointmentTime"].HeaderText = "Appointment Time";
                    patientGridView.Columns["PatientName"].HeaderText = "Patient Name";
                    patientGridView.Columns["BookedByEmployee"].HeaderText = "Booked By Employee";
                    patientGridView.Columns["BookedForEmployee"].HeaderText = "Booked For Employee";

                    // Auto-resize columns for better visibility
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
            LoadControl(new addPatientUserCotroller(username,password, connectionString));
        }

        // Event handler to handle Update Patient
        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            // Code to open Update Patient form or logic to update patient
            LoadControl(new updatePatientUserCotroller(username,password, connectionString));
        }

        // Event handler to handle View Patient
        private void viewPatientButton_Click(object sender, EventArgs e)
        {
            LoadControl(new viewPatient(username, password, connectionString));
            PopulateDataGridView();
        }

        // Event handler to handle Add Appointment
        // Event handler to handle Add Appointment
        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            // Load the Add Appointment screen
            LoadControl(new addAppointmentController(username,password, connectionString));
        }


        // Event handler to handle Cancel Appointment
        private void cancelAppointmentButton_Click(object sender, EventArgs e)
        {
            LoadControl(new cancelAppointment(username, password, connectionString));
        }

        // Event handler to handle View Appointments
        private void viewAppointmentsButton_Click(object sender, EventArgs e)
        {
            LoadControl(new viewAppointment(username, password, connectionString));
        }

        // Event handler to load the user control
        private void PatientUserControl_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void patientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patientGridView.ScrollBars = ScrollBars.Both;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the selected filter option from comboBox1
                string selectedFilter = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedFilter))
                {
                    MessageBox.Show("Please select a filter option.");
                    return;
                }


                // Establish a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SQL command to call the stored procedure
                    using (SqlCommand cmd = new SqlCommand("sp_GetFilteredAppointments", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add the filter option as a parameter
                        cmd.Parameters.AddWithValue("@FilterOption", selectedFilter);

                        // Execute the query and fetch the results
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Bind the results to the DataGridView
                        patientGridView.DataSource = dataTable;

                        // Set user-friendly column headers
                        patientGridView.Columns["appointment_id"].HeaderText = "Appointment ID";
                        patientGridView.Columns["date_of_appointment"].HeaderText = "Date of Appointment";
                        patientGridView.Columns["time_of_appointment"].HeaderText = "Time of Appointment";
                        patientGridView.Columns["PatientName"].HeaderText = "Patient Name";
                        patientGridView.Columns["BookedByEmployee"].HeaderText = "Booked By Employee";
                        patientGridView.Columns["BookedForEmployee"].HeaderText = "Booked For Employee";

                        // Adjust column widths to fit the content
                        patientGridView.AutoResizeColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void findByDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the selected doctor's name
                string selectedDoctorName = findByDoctor.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedDoctorName))
                {
                    MessageBox.Show("Please select a doctor.");
                    return;
                }

                // Use stored procedure to fetch appointments for the selected doctor
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Set up the SqlCommand for the stored procedure
                    SqlCommand cmd = new SqlCommand("view_appointments_by_doctor", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Add the doctor name parameter
                    cmd.Parameters.AddWithValue("@doctorName", selectedDoctorName);

                    // Execute the procedure and fill a DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    patientGridView.DataSource = dataTable;

                    // Set user-friendly column headers
                    patientGridView.Columns["AppointmentID"].HeaderText = "Appointment ID";
                    patientGridView.Columns["AppointmentDate"].HeaderText = "Appointment Date";
                    patientGridView.Columns["AppointmentTime"].HeaderText = "Appointment Time";
                    patientGridView.Columns["PatientName"].HeaderText = "Patient Name";
                    patientGridView.Columns["BookedByEmployee"].HeaderText = "Booked By Employee";
                    patientGridView.Columns["BookedForEmployee"].HeaderText = "Booked For Employee";

                    // Auto-resize columns for better visibility
                    patientGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the text from the textbox
                string searchText = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Please enter a name to search.");
                    return;
                }

                // Query to search appointments by exact patient name
                string query = @"
            SELECT 
                a.appointment_id,
                a.date_of_appointment,
                a.time_of_appointment,
                (SELECT CONCAT(p.p_f_name, ' ', p.p_l_name) 
                 FROM tbl_patient p 
                 WHERE p.patient_id = a.patient_id) AS PatientName,
                (SELECT CONCAT(e.f_name, ' ', e.l_name)
                 FROM tbl_employee e 
                 WHERE e.emp_id = a.booked_by_emp_id) AS BookedByEmployee,
                (SELECT CONCAT(e.f_name, ' ', e.l_name)
                 FROM tbl_employee e 
                 WHERE e.emp_id = a.booked_for_emp_id) AS BookedForEmployee
            FROM tbl_appointment a
            WHERE (SELECT CONCAT(p.p_f_name, ' ', p.p_l_name) 
                   FROM tbl_patient p 
                   WHERE p.patient_id = a.patient_id) = @SearchText";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Add the parameter for the search text
                    cmd.Parameters.AddWithValue("@SearchText", searchText);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Update the DataGridView with the filtered data
                    patientGridView.DataSource = dataTable;

                    // Set user-friendly column names
                    patientGridView.Columns["appointment_id"].HeaderText = "Appointment ID";
                    patientGridView.Columns["date_of_appointment"].HeaderText = "Date of Appointment";
                    patientGridView.Columns["time_of_appointment"].HeaderText = "Time of Appointment";
                    patientGridView.Columns["PatientName"].HeaderText = "Patient Name";
                    patientGridView.Columns["BookedByEmployee"].HeaderText = "Booked By Employee";
                    patientGridView.Columns["BookedForEmployee"].HeaderText = "Booked For Employee";

                    patientGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadControl(new addTreatment(username, password, connectionString));
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
                        ";

                findByDoctor.Items.Clear(); // Clear existing items before adding new ones

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
                                findByDoctor.Items.Add(doctorName); // Add each doctor name to the ComboBox
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
        private void findByDoctor_DropDown(object sender, EventArgs e)
        {
            PopulateDoctorsComboBox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}