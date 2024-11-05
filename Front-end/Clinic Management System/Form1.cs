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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Get the username and password from the TextBoxes
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                // SQL query to check for matching username and password in the login_table
                string query = "SELECT COUNT(1) FROM login_table WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Execute the query and check if any rows match
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // If a match is found, direct to the new UserControl
                    if (count == 1)
                    {
                        MessageBox.Show("Login successful!");

                        // Code to navigate to the new UserControl
                        // Example: mainPanel.Controls.Clear();
                        // mainPanel.Controls.Add(new NewUserControl());
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password.");
                    }
                }
            }
            }
    }
}
