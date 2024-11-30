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

namespace Clinic_Management_System
{
    public partial class cancelAppointment : UserControl
    {
        private string username;
        private string password;
        public cancelAppointment(string username, string password)
        {
            InitializeComponent();
            this.addPatientGridView.CellClick += new DataGridViewCellEventHandler(this.addPatientGridView_CellContentClick);

            this.username = username;
            this.password = password;
        }

        private void updatePatientUserCotroller_Load(object sender, EventArgs e)
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
            try
            {
                // Ensure the click is not on the header row
                if (e.RowIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = addPatientGridView.Rows[e.RowIndex];

                    // Populate textboxes with data from the selected row
                    pfirstNameTB.Text = selectedRow.Cells["PatientName"].Value?.ToString() ?? string.Empty; // Full name of the patient
                    plastNameTB.Text = selectedRow.Cells["BookedByEmployee"].Value?.ToString() ?? string.Empty; // Booked by
                    pDOBTB.Text = selectedRow.Cells["AppointmentDate"].Value?.ToString() ?? string.Empty; // Date of appointment
                    if (DateTime.TryParse(selectedRow.Cells["AppointmentTime"].Value?.ToString(), out DateTime time))
                    {
                        dateTimePicker1.Value = time; // Set the valid time
                    }
                    else
                    {
                        MessageBox.Show("Invalid appointment time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    pfatherNameTB.Text = selectedRow.Cells["BookedForEmployee"].Value?.ToString() ?? string.Empty; // Doctor
                    patientIdTextBox.Text = selectedRow.Cells["AppointmentID"].Value?.ToString() ?? string.Empty; // Appointment ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateDataGridView()
        {
            //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
            string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
            try
            {
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
                    addPatientGridView.DataSource = dataTable;

                    // Set user-friendly column names
                    addPatientGridView.Columns["AppointmentID"].HeaderText = "Appointment ID";
                    addPatientGridView.Columns["AppointmentDate"].HeaderText = "Appointment Date";
                    addPatientGridView.Columns["AppointmentTime"].HeaderText = "Appointment Time";
                    addPatientGridView.Columns["PatientName"].HeaderText = "Patient Name";
                    addPatientGridView.Columns["BookedByEmployee"].HeaderText = "Booked By Employee";
                    addPatientGridView.Columns["BookedForEmployee"].HeaderText = "Booked For Employee";

                    // Auto-resize columns for better visibility
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
                // Validate inputs
                if (string.IsNullOrWhiteSpace(pfirstNameTB.Text) || string.IsNullOrWhiteSpace(plastNameTB.Text))
                {
                    MessageBox.Show("Patient name and 'Booked By' fields are required.", "Validation Error");
                    return;
                }

                if (string.IsNullOrWhiteSpace(patientIdTextBox.Text))
                {
                    MessageBox.Show("Please select an appointment to update.", "Validation Error");
                    return;
                }

                // Get input values
                string patientFullName = pfirstNameTB.Text;
                string bookedBy = plastNameTB.Text;
                string appointmentDate = pDOBTB.Text;
                string appointmentTime = dateTimePicker1.Value.ToString("HH:mm:ss");
                string doctor = pfatherNameTB.Text;
                int appointmentId = int.Parse(patientIdTextBox.Text); // Assuming this is numeric and non-null

                // Update query to set the appointment status to "Cancelled"
                string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                UPDATE tbl_appointment
                SET appointment_status = @Status
                WHERE appointment_id = @AppointmentID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Status", "Cancelled"); // Setting appointment status
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment status updated to 'Cancelled' successfully.");
                        PopulateDataGridView(); // Refresh DataGridView with updated data
                    }
                    else
                    {
                        MessageBox.Show("No record found to update. Please check the Appointment ID.", "Update Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }


        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            LoadControl(new updatePatientUserCotroller(username, password));
        }

        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       // Clear any existing controls on Form2
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new addPatientUserCotroller(username, password));
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

        private void label17_Click(object sender, EventArgs e)
        {
          // string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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
                        label17.Text = "Incharge: " + employeeName;
                    }
                    else
                    {
                        label17.Text = "Incharge: Not Found";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching employee name: " + ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoadControl(new PatientUserControl(username, password));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void addPatientGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}