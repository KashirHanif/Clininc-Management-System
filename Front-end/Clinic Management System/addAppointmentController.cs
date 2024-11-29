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
    public partial class addAppointmentController : UserControl
    {
        public addAppointmentController()
        {
            InitializeComponent();
            this.addPatientGridView.CellClick += new DataGridViewCellEventHandler(this.addPatientGridView_CellContentClick);

        }

        private void addAppointmentController_Load(object sender, EventArgs e)
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
        }


        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            LoadControl(new updatePatientUserCotroller());
        }

        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       // Clear any existing controls on Form2
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new addPatientUserCotroller());
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
              string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
              string query = @"SELECT CONCAT(f_name, ' ', l_name) 
                  FROM tbl_employee
                  WHERE designation = 'Doctor' 
                  AND emp_id IN (
                      SELECT emp_id 
                      FROM tbl_emp_working_hours 
                      WHERE emp_status = 'Available'
                  )";

                    comboBox2.Items.Clear(); // Clear existing items

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string doctorName = reader.GetString(0);
                            comboBox2.Items.Add(doctorName);
                        }
                        reader.Close();
                    }

                    comboBox2.Refresh(); // Force UI refresh
                }

            }
        }
    
