using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic_Management_System
{
    public partial class presciption : UserControl
    {
        private string username;
        private string password;
        private string connectionString;

        public presciption(string username, string password, string connectionString)
        {
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
            InitializeComponent();
            LoadPrescriptionData();  // Load data when the control is initialized
            this.comboBox1.DropDown += comboBox1_DropDown;
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
        }

        private void LoadPrescriptionData()
        {
            // Create a SQL query to fetch data from the view
            string query = "SELECT prescription_id, patient_name, doctor_name, date_of_appointment, " +
                           "follow_up_date, followUpDoctorName, bill_id, emp_fee FROM vw_prescription_details";

            try
            {
                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a DataAdapter to fill a DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Open the connection and fill the DataTable
                    connection.Open();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Customize column headers
                    dataGridView1.Columns["prescription_id"].HeaderText = "Prescription ID";
                    dataGridView1.Columns["patient_name"].HeaderText = "Patient Name";
                    dataGridView1.Columns["doctor_name"].HeaderText = "Doctor Name";
                    dataGridView1.Columns["date_of_appointment"].HeaderText = "Appointment Date";
                    dataGridView1.Columns["follow_up_date"].HeaderText = "Follow-Up Date";
                    dataGridView1.Columns["followUpDoctorName"].HeaderText = "Follow-Up Doctor";
                    dataGridView1.Columns["bill_id"].HeaderText = "Bill ID";
                    dataGridView1.Columns["emp_fee"].HeaderText = "Doctor Fee";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
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
                         )"
                ;

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
                                string doctorName = reader["DoctorName"].ToString();
                                comboBox1.Items.Add(doctorName); // Add each doctor name to the ComboBox
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


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string patientName = textBox1.Text.Trim();

            // If the text box is empty, show a message
            if (string.IsNullOrEmpty(patientName))
            {
                MessageBox.Show("Please enter a patient name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create a SQL query to fetch data from the view with a WHERE clause for patient name
                string query = "SELECT prescription_id, patient_name, doctor_name, date_of_appointment, " +
                               "follow_up_date, followUpDoctorName, bill_id, emp_fee FROM vw_prescription_details " +
                               "WHERE patient_name LIKE @PatientName";

                try
                {
                    // Create a connection to the database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Create a DataAdapter to fill a DataTable
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                        // Add the parameter for the patient name
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@PatientName", "%" + patientName + "%");

                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();

                        // Open the connection and fill the DataTable
                        connection.Open();
                        dataAdapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;

                        // Customize column headers
                        dataGridView1.Columns["prescription_id"].HeaderText = "Prescription ID";
                        dataGridView1.Columns["patient_name"].HeaderText = "Patient Name";
                        dataGridView1.Columns["doctor_name"].HeaderText = "Doctor Name";
                        dataGridView1.Columns["date_of_appointment"].HeaderText = "Appointment Date";
                        dataGridView1.Columns["follow_up_date"].HeaderText = "Follow-Up Date";
                        dataGridView1.Columns["followUpDoctorName"].HeaderText = "Follow-Up Doctor";
                        dataGridView1.Columns["bill_id"].HeaderText = "Bill ID";
                        dataGridView1.Columns["emp_fee"].HeaderText = "Doctor Fee";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string doctorName = comboBox1.Text.Trim();

            // If the text box is empty, show a message
            if (string.IsNullOrEmpty(doctorName))
            {
                MessageBox.Show("Please enter a patient name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create a SQL query to fetch data from the view with a WHERE clause for patient name
                string query = "SELECT prescription_id, patient_name, doctor_name, date_of_appointment, " +
                               "follow_up_date, followUpDoctorName, bill_id, emp_fee FROM vw_prescription_details " +
                               "WHERE doctor_name LIKE @doctorName";

                try
                {
                    // Create a connection to the database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Create a DataAdapter to fill a DataTable
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                        // Add the parameter for the patient name
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@doctorName", "%" + doctorName + "%");

                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();

                        // Open the connection and fill the DataTable
                        connection.Open();
                        dataAdapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;

                        // Customize column headers
                        dataGridView1.Columns["prescription_id"].HeaderText = "Prescription ID";
                        dataGridView1.Columns["patient_name"].HeaderText = "Patient Name";
                        dataGridView1.Columns["doctor_name"].HeaderText = "Doctor Name";
                        dataGridView1.Columns["date_of_appointment"].HeaderText = "Appointment Date";
                        dataGridView1.Columns["follow_up_date"].HeaderText = "Follow-Up Date";
                        dataGridView1.Columns["followUpDoctorName"].HeaderText = "Follow-Up Doctor";
                        dataGridView1.Columns["bill_id"].HeaderText = "Bill ID";
                        dataGridView1.Columns["emp_fee"].HeaderText = "Doctor Fee";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            // Ensure the click is not on the header row or an invalid row
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Extract the prescription_id and bill_id
                string prescription_Id = selectedRow.Cells["prescription_id"].Value?.ToString();
                string prescriptionIdString = selectedRow.Cells["prescription_id"].Value?.ToString();
                if (int.TryParse(prescriptionIdString, out int prescriptionId))
                {
                    LoadControl(new prescriptionDetails(connectionString, prescriptionId,username,password));
                }



            }

        }
        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();        // Clear any existing controls on the form
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new doctor(username, password, connectionString));
        }
    }
}