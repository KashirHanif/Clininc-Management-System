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
using static System.Net.Mime.MediaTypeNames;

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
            string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
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
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password; // Replace with hashed password

                        // Execute the query and check if any rows match
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // If a match is found, direct to the new UserControl
                        if (count == 1)
                        {
                            LoadControl(new menu());
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }
        }
        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       // Clear any existing controls on Form2
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }
    }
    }
