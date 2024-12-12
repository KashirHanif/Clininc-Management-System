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

            // Set default selection in ComboBox and populate both charts
            comboBox1.SelectedIndex = 0; // Default to "Past week"
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
                // Get the current system date
                DateTime endDate = DateTime.Now;

                // Determine the start date based on dropdown selection
                string duration = comboBox1.SelectedItem?.ToString();
                DateTime startDate;

                if (duration == "Past week")
                {
                    startDate = endDate.AddDays(-7);
                }
                else if (duration == "Past month")
                {
                    startDate = endDate.AddMonths(-1);
                }
                else
                {
                    MessageBox.Show("Invalid duration selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Load data for both charts
                LoadPatientChartData(startDate, endDate);
                LoadDoctorAppointmentsChartData(startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                            PopulateDoctorChart(dt);
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
            if (chart1 == null)
            {
                MessageBox.Show("Chart1 control is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chart1.Series.Clear();

            Series series = new Series("Patient Count")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
                IsValueShownAsLabel = true
            };

            // Fill missing dates in the range with zero count
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

        private void PopulateDoctorChart(DataTable data)
        {
            if (chart2 == null)
            {
                MessageBox.Show("Chart2 control is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
    }
}
