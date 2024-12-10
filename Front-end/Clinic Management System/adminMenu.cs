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
        private string username;
        private string password;
        private string connectionString;

        public adminMenu(string username, string password, string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;

            // Load data into the chart when the control is initialized
            LoadChartData();
        }

        private void LoadChartData()
        {
            try
            {
                // Establish the SQL connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Create a SQL command to call the stored procedure
                    SqlCommand cmd = new SqlCommand("CountPatientsByDay", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Execute the stored procedure and fill the data table
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the data to the chart
                    PopulateChart(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateChart(DataTable data)
        {
            // Clear existing chart data
            chart1.Series.Clear();

            // Create a new series for the chart
            Series series = new Series("Patient Count");
            series.ChartType = SeriesChartType.Column; // Column chart style
            series.Color = Color.Blue;
            series.IsValueShownAsLabel = true;

            // Add data points to the series
            foreach (DataRow row in data.Rows)
            {
                string dayOfWeek = row["DayOfWeek"].ToString(); // Day of the week
                int patientCount = Convert.ToInt32(row["PatientCount"]); // Patient count
                series.Points.AddXY(dayOfWeek, patientCount);
            }

            // Add the series to the chart
            chart1.Series.Add(series);

            // Customize chart appearance
            chart1.ChartAreas[0].AxisX.Title = "Day of the Week";
            chart1.ChartAreas[0].AxisY.Title = "Patient Count";
            chart1.Titles.Clear();
            chart1.Titles.Add("Patient Count Per Day (Last Month)");
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Handle click events for pictureBox2 if required
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
            // Custom drawing logic for the header panel (if required)
        }
    }
}
