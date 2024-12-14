// Updated Revenue User Control with Chart Integration
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Clinic_Management_System
{
    public partial class revenue : UserControl
    {
        private string connectionString;
        private string username;
        private string password;

        public revenue(string username, string password, string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;

            PopulateDoctorsComboBox();
            LoadBillDetails(); // Load total revenue by default
        }

        private void LoadBillDetails(decimal? profitPercent = null, string doctorName = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            e.emp_id AS DoctorID,
                            CONCAT(e.f_name, ' ', e.l_name) AS DoctorName,
                            SUM(b.emp_fee) AS DoctorRevenue,
                            SUM(b.emp_fee) * @ProfitPercent / 100 AS HospitalRevenue
                        FROM tbl_billing b
                        INNER JOIN tbl_appointment a ON b.appointment_id = a.appointment_id
                        INNER JOIN tbl_employee e ON a.booked_for_emp_id = e.emp_id
                        WHERE (@DoctorName IS NULL OR CONCAT(e.f_name, ' ', e.l_name) = @DoctorName)
                        GROUP BY e.emp_id, e.f_name, e.l_name
                    ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProfitPercent", profitPercent ?? 30);
                        command.Parameters.AddWithValue("@DoctorName", doctorName ?? (object)DBNull.Value);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable revenueDetails = new DataTable();
                            adapter.Fill(revenueDetails);
                            revenuegridview.DataSource = revenueDetails;

                            if (revenueDetails.Rows.Count > 0)
                            {
                                decimal totalDoctorRevenue = 0;
                                decimal totalHospitalRevenue = 0;

                                foreach (DataRow row in revenueDetails.Rows)
                                {
                                    totalDoctorRevenue += Convert.ToDecimal(row["DoctorRevenue"]);
                                    totalHospitalRevenue += Convert.ToDecimal(row["HospitalRevenue"]);
                                }

                                textBox2.Text = totalDoctorRevenue.ToString();
                                textBox3.Text = totalHospitalRevenue.ToString();

                                UpdateChart(revenueDetails);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while fetching revenue details: {ex.Message}");
                }
            }
        }

        private void UpdateChart(DataTable revenueDetails)
        {
            chart1.Series.Clear();

            Series doctorRevenueSeries = new Series("Doctor Revenue")
            {
                ChartType = SeriesChartType.Column
            };

            Series hospitalRevenueSeries = new Series("Hospital Revenue")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (DataRow row in revenueDetails.Rows)
            {
                string doctorName = row["DoctorName"].ToString();
                decimal doctorRevenue = Convert.ToDecimal(row["DoctorRevenue"]);
                decimal hospitalRevenue = Convert.ToDecimal(row["HospitalRevenue"]);

                doctorRevenueSeries.Points.AddXY(doctorName, doctorRevenue);
                hospitalRevenueSeries.Points.AddXY(doctorName, hospitalRevenue);
            }

            chart1.Series.Add(doctorRevenueSeries);
            chart1.Series.Add(hospitalRevenueSeries);
        }

        private void revenuegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle DataGridView cell clicks if needed
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Handle text box changes if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal profitPercent))
            {
                string selectedDoctor = comboBox1.SelectedItem?.ToString();
                LoadBillDetails(profitPercent, selectedDoctor);
            }
            else
            {
                MessageBox.Show("Please enter a valid profit percentage.");
            }
        }

        private void PopulateDoctorsComboBox()
        {
            try
            {
                string query = @"SELECT CONCAT(f_name, ' ', l_name) AS DoctorName
                                 FROM tbl_employee
                                 WHERE designation = 'Doctor'";

                comboBox1.Items.Clear();

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
                                comboBox1.Items.Add(doctorName);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDoctor = comboBox1.SelectedItem?.ToString();
            if (decimal.TryParse(textBox1.Text, out decimal profitPercent))
            {
                LoadBillDetails(profitPercent, selectedDoctor);
            }
            else
            {
                LoadBillDetails(null, selectedDoctor);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Handle picture box clicks if needed
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadControl(new doctor_admin(username, password, connectionString));
        }
        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       // Clear any existing controls on Form2
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }

        private void revenue_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadControl(new adminMenu(username, password, connectionString));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new appintmentLog(username, password, connectionString));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadControl(new appointment_admin(username, password, connectionString));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadControl(new admin_patient(username, password, connectionString));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void adminLabel_Click(object sender, EventArgs e)
        {
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
                        adminLabel.Text = " ";
                        string employeeName = result.ToString();
                        adminLabel.Text = "Admin: " + employeeName;
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
    }
}
