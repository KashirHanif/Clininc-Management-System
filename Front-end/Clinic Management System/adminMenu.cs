using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Clinic_Management_System
{
    public partial class adminMenu : UserControl
    {
        private readonly string username;
        private readonly string password;
        private readonly string connectionString;

        public adminMenu(string username, string password, string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;

            // Set default selection in ComboBox and DateTimePicker
            comboBox1.SelectedIndex = 0; // Default to "Past week"
            dateTimePicker1.MaxDate = DateTime.Now; // Prevent selection of future dates
            dateTimePicker1.Value = DateTime.Now; // Default to current date
            FetchDataAndPlotCharts();
        }

        private void FetchDataButton_Click(object sender, EventArgs e)
        {
            FetchDataAndPlotCharts();
        }

        private void FetchDataAndPlotCharts()
        {
            try
            {
                // Get the selected date from the DateTimePicker
                DateTime selectedDate = dateTimePicker1.Value;

                // Determine the start and end date based on ComboBox selection
                string duration = comboBox1.SelectedItem?.ToString();
                DateTime startDate;
                DateTime endDate = selectedDate;

                if (duration == "Past week")
                {
                    startDate = selectedDate.AddDays(-7);
                }
                else if (duration == "Past month")
                {
                    startDate = selectedDate.AddMonths(-1);
                }
                else
                {
                    MessageBox.Show("Invalid duration selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Load data for all charts
                LoadPatientChartData(startDate, endDate);
                LoadDoctorAppointmentsChartData(startDate, endDate);
                LoadDoctorRevenueChartData(startDate, endDate);

                // Load data for the hospital revenue chart (Chart 4)
                LoadHospitalRevenueChart(selectedDate, duration == "Past week" ? "weekly" : "monthly");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadHospitalRevenueChart(DateTime selectedDate, string duration)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_calculate_hospital_revenue", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pass parameters to the stored procedure
                        cmd.Parameters.AddWithValue("@StartDate", selectedDate);
                        cmd.Parameters.AddWithValue("@Duration", duration);
                        cmd.Parameters.AddWithValue("@profitpercent", 30.00m); // Default profit percent

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No data available for the selected range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            PopulateHospitalRevenueChart(dt, selectedDate, duration);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateHospitalRevenueChart(DataTable data, DateTime selectedDate, string duration)
        {
            chart4.Series.Clear();

            // Create a series for hospital revenue
            Series series = new Series("Hospital Revenue")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 2,
                IsValueShownAsLabel = true
            };

            foreach (DataRow row in data.Rows)
            {
                DateTime revenueDate = Convert.ToDateTime(row["RevenueDate"]);
                decimal revenueAmount = Convert.ToDecimal(row["RevenueAmount"]);

                // Add points to the series
                series.Points.AddXY(revenueDate.ToString("yyyy-MM-dd"), revenueAmount);
            }

            chart4.Series.Add(series);
            chart4.ChartAreas[0].AxisX.Title = "Date";
            chart4.ChartAreas[0].AxisY.Title = "Revenue (in PKR)";
            chart4.ChartAreas[0].AxisY.LabelStyle.Format = "N2"; // Format axis labels as currency

            // Set chart title dynamically
            chart4.Titles.Clear();
            chart4.Titles.Add($"Hospital Revenue ({duration}) From {selectedDate:yyyy-MM-dd}");
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FetchDataAndPlotCharts(); // Automatically updates the charts
        }

        private void LoadPatientChartData(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("CountPatientsByDateRange", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            PopulatePatientChart(dt, startDate, endDate);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctorAppointmentsChartData(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("CountAppointmentsByDoctor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            PopulateDoctorAppointmentsChart(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctorRevenueChartData(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("CalculateDoctorRevenue", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            PopulateRevenueChart(dt);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulatePatientChart(DataTable data, DateTime startDate, DateTime endDate)
        {
            chart1.Series.Clear();

            Series series = new Series("Patient Count")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
                IsValueShownAsLabel = true
            };

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                string dateStr = date.ToString("yyyy-MM-dd");
                DataRow[] rows = data.Select($"AppointmentDate = '{dateStr}'");

                int patientCount = rows.Length > 0 ? Convert.ToInt32(rows[0]["PatientCount"]) : 0;
                series.Points.AddXY(dateStr, patientCount);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisY.Title = "Patient Count";
            chart1.Titles.Clear();
            chart1.Titles.Add($"Patient Count From {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}");
        }

        private void PopulateDoctorAppointmentsChart(DataTable data)
        {
            chart2.Series.Clear();

            Series series = new Series("Appointment Count")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Green,
                IsValueShownAsLabel = true
            };

            foreach (DataRow row in data.Rows)
            {
                string doctorName = row["DoctorName"].ToString();
                int appointmentCount = Convert.ToInt32(row["AppointmentCount"]);
                series.Points.AddXY(doctorName, appointmentCount);
            }

            chart2.Series.Add(series);
            chart2.ChartAreas[0].AxisX.Title = "Doctor";
            chart2.ChartAreas[0].AxisY.Title = "Appointment Count";
            chart2.Titles.Clear();
            chart2.Titles.Add("Appointments Per Doctor");
        }

        private void PopulateRevenueChart(DataTable data)
        {
            chart3.Series.Clear();

            Series series = new Series("Doctor Revenue")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            if (data.Rows.Count == 0)
            {
                // Add a placeholder entry if there is no revenue data
                series.Points.AddXY("No Revenue", 1); // Placeholder point
                chart3.Series.Add(series);
                chart3.Titles.Clear();
                chart3.Titles.Add("Revenue Generated Per Doctor (No Data Available)");
                chart3.Series[0].Points[0].Color = Color.Gray; // Optional: Color the placeholder differently
                return;
            }

            foreach (DataRow row in data.Rows)
            {
                string doctorName = row["DoctorName"].ToString();
                decimal revenue = Convert.ToDecimal(row["TotalRevenue"]);
                series.Points.AddXY(doctorName, revenue);
            }

            chart3.Series.Add(series);
            chart3.Titles.Clear();
            chart3.Titles.Add("Revenue Generated Per Doctor");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadControl(new doctor_admin(username, password, connectionString));
        }
        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       
            control.Dock = DockStyle.Fill; 
            this.Controls.Add(control);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadControl(new admin_patient(username, password, connectionString));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadControl(new appointment_admin(username, password, connectionString));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadControl(new revenue(username, password, connectionString));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new appintmentLog(username, password, connectionString));
        }
    }
}