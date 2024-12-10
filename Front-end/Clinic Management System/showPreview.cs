using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public showPreview(string username, string password, string connectionString)
        {
            InitializeComponent();
            button2.Click += button2_Click;
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
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


    }
}
