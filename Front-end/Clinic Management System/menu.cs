using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Clinic_Management_System
{
    public partial class menu : UserControl
    {
        private string username;
        private string password;
        private string connectionString;
        public menu(string username,string password,string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
        }

        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();       // Clear any existing controls on Form2
            control.Dock = DockStyle.Fill; // Make the UserControl fill the entire form
            this.Controls.Add(control);
        }
        private void btnPatient_Click(object sender, EventArgs e)
        {
            LoadControl(new PatientUserControl(username,password,connectionString));
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

       

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            LoadControl(new doctor(username, password, connectionString));
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create a new instance of Form1 (login form)
            Form1 form1 = new Form1();

            // Set the form to open in maximized mode
            form1.WindowState = FormWindowState.Maximized;

            // Show the form
            form1.Show();

            // Optionally, dispose of the current form if you don't need it anymore
            this.Dispose();
        }

    }
}
