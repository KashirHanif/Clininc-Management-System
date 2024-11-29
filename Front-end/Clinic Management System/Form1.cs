using System;
using System.Data;
using System.Data.SqlClient;
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
            //string connectionString = "Data Source=KASHIR-LAPTOP\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
            string connectionString = "Data Source=MALEAHAS-ELITEB\\SQLEXPRESS;Initial Catalog=clinic_management_db;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Get the username and password from the TextBoxes
                    string username = usernameTextBox.Text;
                    string password = passwordTextBox.Text;

                    // SQL query to retrieve designation based on username and password
                    string query = @"
                                SELECT e.designation 
                                FROM login_table l
                                JOIN tbl_employee e ON l.emp_id = e.emp_id
                                WHERE l.username = @username AND l.password = @password";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Use parameters to prevent SQL injection
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

                        // Execute the query and get the designation
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string designation = result.ToString();

                            // Redirect based on designation
                            if (designation == "Doctor")
                            {
                                LoadControl(new doctorMenu());
                            }
                            else if (designation == "Receptionist")
                            {
                                LoadControl(new menu());
                            }
                            else if (designation == "Admin")
                            {
                                LoadControl(new adminMenu());
                            }
                            else
                            {
                                MessageBox.Show("Invalid designation detected. Please contact the administrator.");
                            }
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
            } // End of 'using' for SqlConnection
        }

        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();        // Clear any existing controls on the form
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }

        // Define Form1_Load method to resolve CS1061 error
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization code (if required)
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
    }
}