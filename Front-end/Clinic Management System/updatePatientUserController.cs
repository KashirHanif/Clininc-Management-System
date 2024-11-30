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
    public partial class updatePatientUserCotroller : UserControl
    {
        private string username;
        private string password;
        public updatePatientUserCotroller(string username, string password)
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
            PopulateDataGridView();


            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = addPatientGridView.Rows[e.RowIndex];

                // Populate textboxes with data from the selected row
                pfirstNameTB.Text = selectedRow.Cells["p_f_name"].Value?.ToString() ?? string.Empty;
                plastNameTB.Text = selectedRow.Cells["p_l_name"].Value?.ToString() ?? string.Empty;
                pfatherNameTB.Text = selectedRow.Cells["father_name"].Value?.ToString() ?? string.Empty;
                pDOBTB.Text = selectedRow.Cells["date_of_birth"].Value?.ToString() ?? string.Empty;
                pstreetTB.Text = selectedRow.Cells["street"].Value?.ToString() ?? string.Empty;
                pBlockTB.Text = selectedRow.Cells["block"].Value?.ToString() ?? string.Empty;
                pCityTB.Text = selectedRow.Cells["city"].Value?.ToString() ?? string.Empty;
                pCountryTB.Text = selectedRow.Cells["country"].Value?.ToString() ?? string.Empty;
                pCountryCodeTB.Text = selectedRow.Cells["ph_country_code"].Value?.ToString() ?? string.Empty;
                pPhonenumTB.Text = selectedRow.Cells["phone_number"].Value?.ToString() ?? string.Empty;
                pGender2.Text = selectedRow.Cells["gender"].Value?.ToString() ?? string.Empty;
                pAgeTB.Text = selectedRow.Cells["age"].Value?.ToString() ?? string.Empty;
                pCNIC.Text = selectedRow.Cells["CNIC"].Value?.ToString() ?? string.Empty;
                patientIdTextBox.Text = selectedRow.Cells["patient_id"].Value?.ToString() ?? string.Empty;
            }


        }
        private void PopulateDataGridView()
        {
            try
            {
                string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                //string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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
                // Validate inputs
                if (string.IsNullOrWhiteSpace(pfirstNameTB.Text) || string.IsNullOrWhiteSpace(plastNameTB.Text))
                {
                    MessageBox.Show("First name and Last name are required.", "Validation Error");
                    return;
                }

                // Validate that a record is selected (e.g., using a hidden `patient_id` TextBox)
                if (string.IsNullOrWhiteSpace(patientIdTextBox.Text))
                {
                    MessageBox.Show("Please select a record to update.", "Validation Error");
                    return;
                }

                // Get the date from the DateTimePicker
                DateTime selectedDOB = pDOBTB.Value;

                // Connection and SQL Command
                string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                //string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE tbl_patient " +
                                   "SET p_f_name = @FirstName, p_l_name = @LastName, father_name = @FatherName, date_of_birth = @DOB, street = @Street, block = @Block, city = @City, country = @Country, " +
                                   "ph_country_code = @CountryCode, phone_number = @PhoneNumber, gender = @Gender, age = @Age, cnic = @CNIC " +
                                   "WHERE patient_id = @PatientID";

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
                    cmd.Parameters.AddWithValue("@PatientID", patientIdTextBox.Text); // Unique identifier for the record

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient record updated successfully.");
                        PopulateDataGridView(); // Refresh DataGridView with updated data
                    }
                    else
                    {
                        MessageBox.Show("No record found to update. Please check the Patient ID.", "Update Failed");
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
            string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
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
       

        

    }
}