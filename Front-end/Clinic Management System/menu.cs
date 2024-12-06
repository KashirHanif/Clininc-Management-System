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

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadControl(new inventory(username, password, connectionString));
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            LoadControl(new addInventory(username, password, connectionString));
        }
    }
}
