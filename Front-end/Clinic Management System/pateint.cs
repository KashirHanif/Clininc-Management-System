using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class PatientUserControl : UserControl
    {
        // Connection string to your database
        //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
        string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";

        private string username;
        private string password;
        public PatientUserControl(string username,string password)
        {
            InitializeComponent();
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
    }
}
