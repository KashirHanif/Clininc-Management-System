using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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
            // Code to cancel appointment functionality
            MessageBox.Show("Cancel Appointment functionality goes here");
        }

        // Event handler to handle View Appointments
        private void viewAppointmentsButton_Click(object sender, EventArgs e)
        {
            // Code to view appointments
            MessageBox.Show("View Appointments functionality goes here");
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
           // string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
            try
            {
                // Get the selected filter option from comboBox1
                string selectedFilter = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedFilter))
                {
                    MessageBox.Show("Please select a filter option.");
                    return;
                }

                // Base query
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
            FROM tbl_appointment a";

                // Modify query based on the selected filter
                if (selectedFilter == "Upcoming Week")
                {
                    query += @"
                WHERE a.date_of_appointment >= GETDATE()
                  AND a.date_of_appointment < DATEADD(DAY, 7, GETDATE())";
                }
                else if (selectedFilter == "Upcoming Month")
                {
                    query += @"
                WHERE a.date_of_appointment >= GETDATE()
                  AND a.date_of_appointment < DATEADD(MONTH, 1, GETDATE())";
                }
                else if (selectedFilter == "Cancelled")
                {
                    query += @"
                WHERE a.appointment_status = 'Cancelled'";
                }

                // Execute the query and populate the DataGridView
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

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
    }
}