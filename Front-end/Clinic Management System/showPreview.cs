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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Clinic_Management_System
{
    public partial class showPreview : UserControl

    {
        private string username;
        private string password;
        private string connectionString;
        private int billId;
        public showPreview(string username, string password, string connectionString, int billId)
        {
            InitializeComponent();
            button2.Click += button2_Click;
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
            this.billId = billId;

            textBox1.Text = billId.ToString();
            this.Load += showPreview_Load;

        }
        private void showPreview_Load(object sender, EventArgs e)
        {
            FetchBillDetails();

        }

        private void FetchBillDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_get_prescription_summary", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pass billId as a parameter
                        cmd.Parameters.AddWithValue("@bill_id", billId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate textboxes with data from the reader
                                textBox6.Text = reader["patient_name"].ToString(); // Patient Name
                                textBox9.Text = reader["doctor_name"].ToString();  // Doctor Name
                                textBox5.Text = reader["doctor_fee"].ToString();   // Doctor Fee
                            }
                            else
                            {
                                MessageBox.Show("No data found for the provided Bill ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching bill details: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new Printable(username, password, connectionString));
        }

        private void LoadControl(object control)
        {
            // Your logic to handle the control
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadControl(new Printable(username, password, connectionString));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}