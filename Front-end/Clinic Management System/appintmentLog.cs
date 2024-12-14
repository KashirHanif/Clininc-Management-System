using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class appintmentLog : UserControl
    {
        private string username;
        private string password;
        private string connectionString;
        public appintmentLog(string username,string password,string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new appintmentLog(username, password, connectionString));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadControl(new revenue(username, password, connectionString));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadControl(new appointment_admin(username, password, connectionString));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadControl(new admin_patient(username, password, connectionString));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadControl(new doctor_admin(username, password, connectionString));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LoadControl(new adminMenu(username, password, connectionString));
        }
        private void LoadControl(UserControl control)
        {
            this.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
        }
    }
}
