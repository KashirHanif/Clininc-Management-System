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

            // Load data into the chart when the control is initialized
            LoadChartData();
        }

        private void LoadChartData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("CountPatientsByDay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Debugging log for data
                            foreach (DataRow row in dt.Rows)
                            {
                                Console.WriteLine($"Day: {row["DayOfWeek"]}, Count: {row["PatientCount"]}");
                            }

                            PopulateChart(dt);
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

        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();        // Clear any existing controls on the form
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }

        private void PopulateChart(DataTable data)
        {
            if (chart1 == null)
            {
                MessageBox.Show("Chart control is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear existing chart data
            chart1.Series.Clear();

            // Create a new series for the chart
            Series series = new Series("Patient Count")
            {
                ChartType = SeriesChartType.Column, // Column chart style
                Color = Color.Blue,
                IsValueShownAsLabel = true
            };

            // Add data points to the series
            foreach (DataRow row in data.Rows)
            {
                if (row["DayOfWeek"] != DBNull.Value && row["PatientCount"] != DBNull.Value)
                {
                    string dayOfWeek = row["DayOfWeek"].ToString();
                    int patientCount = Convert.ToInt32(row["PatientCount"]);
                    series.Points.AddXY(dayOfWeek, patientCount);
                }
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
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Change the background and text color when the mouse enters the button
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                button.ForeColor = System.Drawing.Color.Yellow;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Revert the background and text color when the mouse leaves the button
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoadControl(new Form1());
        }
    }
}
