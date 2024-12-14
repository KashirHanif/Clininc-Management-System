using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class appintmentLog : UserControl
    {
        private string username;
        private string password;
        private string connectionString;
        public appintmentLog(string username,string password,string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
            LoadAppointmentLogs();

        }

        private void LoadAppointmentLogs()
        {
            // SQL query to fetch data
            string query = @"
        SELECT 
            appointment_id, patient_name, doctor_name, booked_by,
            action_type, column_updated, previous_value, new_value, log_date
        FROM tbl_appointment_log";

            // Create a connection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a DataAdapter to execute the query
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Create a DataTable to hold the results
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the query
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Optionally, set column names in DataGridView for better clarity
                    dataGridView1.Columns["appointment_id"].HeaderText = "Appointment ID";
                    dataGridView1.Columns["patient_name"].HeaderText = "Patient Name";
                    dataGridView1.Columns["doctor_name"].HeaderText = "Doctor Name";
                    dataGridView1.Columns["booked_by"].HeaderText = "Booked By";
                    dataGridView1.Columns["action_type"].HeaderText = "Action Type";
                    dataGridView1.Columns["column_updated"].HeaderText = "Column Updated";
                    dataGridView1.Columns["previous_value"].HeaderText = "Previous Value";
                    dataGridView1.Columns["new_value"].HeaderText = "New Value";
                    dataGridView1.Columns["log_date"].HeaderText = "Log Date";
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the connection or query execution
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value.Date; // Use .Date to remove the time part

            // Call the method to load appointment logs with the selected date filter
            LoadAppointmentLogs(selectedDate);
        }

        private void LoadAppointmentLogs(DateTime selectedDate)
        {
            // SQL query to fetch data with a filter for the selected date
            string query = @"
                SELECT 
                    appointment_id, patient_name, doctor_name, booked_by, 
                    action_type, column_updated, previous_value, new_value, log_date
                FROM tbl_appointment_log
                WHERE CAST(log_date AS DATE) = @selectedDate"; // Filter by the date part of log_date

            // Create a connection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a DataAdapter to execute the query
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Add the parameter for the selected date
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@selectedDate", selectedDate);

                    // Create a DataTable to hold the results
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the query
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Optionally, set column names in DataGridView for better clarity
                    dataGridView1.Columns["appointment_id"].HeaderText = "Appointment ID";
                    dataGridView1.Columns["patient_name"].HeaderText = "Patient Name";
                    dataGridView1.Columns["doctor_name"].HeaderText = "Doctor Name";
                    dataGridView1.Columns["booked_by"].HeaderText = "Booked By";
                    dataGridView1.Columns["action_type"].HeaderText = "Action Type";
                    dataGridView1.Columns["column_updated"].HeaderText = "Column Updated";
                    dataGridView1.Columns["previous_value"].HeaderText = "Previous Value";
                    dataGridView1.Columns["new_value"].HeaderText = "New Value";
                    dataGridView1.Columns["log_date"].HeaderText = "Log Date";
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the connection or query execution
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }



    private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new appintmentLog(username, password, connectionString));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadControl(new revenue(username, password, connectionString));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadControl(new appointment_admin(username, password, connectionString));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadControl(new admin_patient(username, password, connectionString));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadControl(new doctor_admin(username, password, connectionString));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LoadControl(new adminMenu(username, password, connectionString));
        }
        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
        }

        private void adminLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
