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
    public partial class revenue : UserControl
        
    {
        private string connectionString;
        private string username;
        private string password;
        public revenue(string username,string password,string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;

            LoadBillDetails();
        }
        private void LoadBillDetails(decimal? profitPercent = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SqlCommand to execute the stored procedure
                    using (SqlCommand command = new SqlCommand("sp_CalculateBillDetails", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add ProfitPercent parameter if provided, otherwise use the backend default
                        if (profitPercent.HasValue)
                        {
                            command.Parameters.AddWithValue("@ProfitPercent", profitPercent.Value);
                        }

                        // Execute the procedure and populate the DataGridView
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable billDetails = new DataTable();
                            adapter.Fill(billDetails);
                            revenuegridview.DataSource = billDetails;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while fetching bill details: {ex.Message}");
                }
            }
        }

        private void revenuegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal profitPercent))
            {
                LoadBillDetails(profitPercent);
            }
            else
            {
                MessageBox.Show("Please enter a valid profit percentage.");
            }
        }
    }
}
