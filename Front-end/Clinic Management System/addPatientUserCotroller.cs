﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Clinic_Management_System
{
    public partial class addPatientUserCotroller : UserControl
    {
        private string username;
        private string password;
        private string connectionString;
        public addPatientUserCotroller(string username,string password,string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
        }

        private void addPatientUserCotroller_Load(object sender, EventArgs e)
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

        
        private void addPatientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateDataGridView();
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

        private void addButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(pfirstNameTB.Text) || string.IsNullOrWhiteSpace(plastNameTB.Text))
                {
                    MessageBox.Show("First name and Last name are required.", "Validation Error");
                    return;
                }

                // Get the date from the DateTimePicker
                DateTime selectedDOB = pDOBTB.Value;

                // Connection and SQL Command
                //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                //string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO tbl_patient (p_f_name, p_l_name, father_name, date_of_birth, street, block, city, country, ph_country_code, phone_number, gender, age, cnic) " +
                                   "VALUES (@FirstName, @LastName, @FatherName, @DOB, @Street, @Block, @City, @Country, @CountryCode, @PhoneNumber, @Gender, @Age, @CNIC)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", pfirstNameTB.Text);
                    cmd.Parameters.AddWithValue("@LastName", plastNameTB.Text);
                    cmd.Parameters.AddWithValue("@FatherName", pfatherNameTB.Text);
                    cmd.Parameters.AddWithValue("@DOB", selectedDOB); // Use DateTimePicker's Value
                    cmd.Parameters.AddWithValue("@Street", pstreetTB.Text);
                    cmd.Parameters.AddWithValue("@Block", pBlockTB.Text);
                    cmd.Parameters.AddWithValue("@City", pCityTB.Text);
                    cmd.Parameters.AddWithValue("@Country", pCountryTB.Text);
                    cmd.Parameters.AddWithValue("@CountryCode", pCountryCodeTB.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", pPhonenumTB.Text);
                    cmd.Parameters.AddWithValue("@Gender", pGender2.Text);
                    cmd.Parameters.AddWithValue("@Age", pAgeTB.Text);
                    cmd.Parameters.AddWithValue("@CNIC", pCNIC.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient added successfully.");

                    PopulateDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }

        }

        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            LoadControl(new updatePatientUserCotroller(username,password,connectionString));
        }

        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       // Clear any existing controls on Form2
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {

        }

        private void pfirstNameTB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void plastNameTB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
          //  string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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
                        label16.Text = " ";
                        string employeeName = result.ToString();
                        label16.Text = "Incharge: " + employeeName;
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
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

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            LoadControl(new addAppointmentController(username, password, connectionString));
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}