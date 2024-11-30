using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;


namespace Clinic_Management_System
{
    public partial class viewAppointment : UserControl
    {
        // Connection string to your database
        string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
        // string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
        private string username;
        private string password;
        public viewAppointment(string username,string password)
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            this.username = username;
            this.password = password;
        }

        // Populate the DataGridView with patient data
        private void PopulateDataGridView()
        {
            try
            {
                string query = "SELECT patient_id, p_f_name, p_l_name, father_name, date_of_birth, city, country, phone_number, gender, age FROM tbl_patient";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    patientGridView.DataSource = dataTable;

                    // Set user-friendly column names
                    patientGridView.Columns["patient_id"].HeaderText = "Patient ID";
                    patientGridView.Columns["p_f_name"].HeaderText = "First Name";
                    patientGridView.Columns["p_l_name"].HeaderText = "Last Name";
                    patientGridView.Columns["father_name"].HeaderText = "Father's Name";
                    patientGridView.Columns["date_of_birth"].HeaderText = "Date of Birth";
                    patientGridView.Columns["city"].HeaderText = "City";
                    patientGridView.Columns["country"].HeaderText = "Country";
                    patientGridView.Columns["phone_number"].HeaderText = "Phone Number";
                    patientGridView.Columns["gender"].HeaderText = "Gender";
                    patientGridView.Columns["age"].HeaderText = "Age";

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
            LoadControl(new addPatientUserCotroller(username,password));
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

            try
            {
                // Get the selected filter option from comboBox1
                string selectedFilter = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedFilter))
                {
                    MessageBox.Show("Please select a filter option.");
                    return;
                }
                if (selectedFilter == "Search by Name")
                {
                    if (!textBox1.Parent.Visible)
                    {
                        textBox1.Parent.Visible = true;
                    }

                    button2.Visible = true;


                }

                // Base query
                string query = "SELECT patient_id, p_f_name, p_l_name, father_name, date_of_birth, city, country, phone_number, gender, age FROM tbl_patient";

                // Modify query based on the selected filter
                if (selectedFilter == "Last Week")
                {
                    query += @"
                WHERE patient_id IN (
                    SELECT patient_id FROM tbl_appointment
                    WHERE date_of_appointment >= DATEADD(DAY, -7, GETDATE())
                      AND date_of_appointment <= GETDATE()
                )";
                }
                else if (selectedFilter == "Last Month")
                {
                    query += @"
                WHERE patient_id IN (
                    SELECT patient_id FROM tbl_appointment
                    WHERE date_of_appointment >= DATEADD(MONTH, -1, GETDATE())
                      AND date_of_appointment <= GETDATE()
                )";
                }

                // Execute the query and populate the DataGridView
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    patientGridView.DataSource = dataTable;

                    // Set user-friendly column names if needed
                    patientGridView.Columns["patient_id"].HeaderText = "Patient ID";
                    patientGridView.Columns["p_f_name"].HeaderText = "First Name";
                    patientGridView.Columns["p_l_name"].HeaderText = "Last Name";
                    patientGridView.Columns["father_name"].HeaderText = "Father's Name";
                    patientGridView.Columns["date_of_birth"].HeaderText = "Date of Birth";
                    patientGridView.Columns["city"].HeaderText = "City";
                    patientGridView.Columns["country"].HeaderText = "Country";
                    patientGridView.Columns["phone_number"].HeaderText = "Phone Number";
                    patientGridView.Columns["gender"].HeaderText = "Gender";
                    patientGridView.Columns["age"].HeaderText = "Age";

                    patientGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

                // Construct the query to concatenate first and last names and search
                string query = @"
                    SELECT patient_id, p_f_name, p_l_name, father_name, date_of_birth, city, country, phone_number, gender, age 
                    FROM tbl_patient
                    WHERE CONCAT(p_f_name, ' ', p_l_name) = @SearchText";

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

                    // Set user-friendly column names if needed
                    patientGridView.Columns["patient_id"].HeaderText = "Patient ID";
                    patientGridView.Columns["p_f_name"].HeaderText = "First Name";
                    patientGridView.Columns["p_l_name"].HeaderText = "Last Name";
                    patientGridView.Columns["father_name"].HeaderText = "Father's Name";
                    patientGridView.Columns["date_of_birth"].HeaderText = "Date of Birth";
                    patientGridView.Columns["city"].HeaderText = "City";
                    patientGridView.Columns["country"].HeaderText = "Country";
                    patientGridView.Columns["phone_number"].HeaderText = "Phone Number";
                    patientGridView.Columns["gender"].HeaderText = "Gender";
                    patientGridView.Columns["age"].HeaderText = "Age";

                    patientGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}