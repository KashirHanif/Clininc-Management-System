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
    public partial class addTreatment : UserControl
    {
        private string username;
        private string password;
        public addTreatment(string username, string password)
        {
            InitializeComponent();
            this.addPatientGridView.CellClick += new DataGridViewCellEventHandler(this.addPatientGridView_CellContentClick);




            this.username = username;
            this.password = password;
        }

        private void addTreatment_Load(object sender, EventArgs e)
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
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = addPatientGridView.Rows[e.RowIndex];

                // Retrieve values from the selected row
                string patientName = selectedRow.Cells["PatientName"].Value?.ToString();
                string doctorName = selectedRow.Cells["BookedForEmployee"].Value?.ToString()?.Trim();
                


                // Set the retrieved values in the appropriate controls
                if (!string.IsNullOrEmpty(patientName))
                {
                    treatmentptname.Text = patientName;
                }
                else
                {
                    treatmentptname.Text = string.Empty;
                    MessageBox.Show("Patient Name is not available for the selected row.");
                }

                if (!string.IsNullOrEmpty(doctorName))
                {
                    textBox1.Text = doctorName;
                }
                else
                {
                    textBox1.Text = string.Empty;
                    MessageBox.Show("Booked For Employee is not available for the selected row.");
                }

            }
            else
            {
                MessageBox.Show("Please select a valid row.");
            }
        }

        private void PopulateDataGridView()
        {
            string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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

        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call the method to fetch and display the next appointment time

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

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void aptSearch_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";

            string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";

            try
            {
                // Retrieve the selected employee name, patient name, and treatment type
                string employeeName = textBox1.Text.Trim();
                string patientName = treatmentptname.Text.Trim();
                string treatmentType = treatmentTypeComboBox.Text.Trim();

                if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(patientName) || string.IsNullOrEmpty(treatmentType))
                {
                    MessageBox.Show("Please ensure all fields are filled before proceeding.");
                    return;
                }

                int employeeId, patientId;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get emp_id
                    string employeeQuery = "SELECT emp_id FROM tbl_employee WHERE CONCAT(f_name, ' ', l_name) = @EmployeeName";
                    using (SqlCommand cmd = new SqlCommand(employeeQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeName", employeeName);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            employeeId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Employee not found.");
                            return;
                        }
                    }

                    // Query to get patient_id
                    string patientQuery = "SELECT patient_id FROM tbl_patient WHERE CONCAT(p_f_name, ' ', p_l_name) = @PatientName";
                    using (SqlCommand cmd = new SqlCommand(patientQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientName", patientName);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            patientId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Patient not found.");
                            return;
                        }
                    }

                    // Insert data into tbl_treatment
                    string insertQuery = @"
                INSERT INTO tbl_treatment (emp_id, patient_id, treatment_type) 
                VALUES (@EmployeeId, @PatientId, @TreatmentType)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                        cmd.Parameters.AddWithValue("@PatientId", patientId);
                        cmd.Parameters.AddWithValue("@TreatmentType", treatmentType);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Treatment record added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add treatment record.");
                        }
                    }
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

        private void genBill_Click(object sender, EventArgs e)
        {
            LoadControl(new generateBill(username, password));
        }
    }
}