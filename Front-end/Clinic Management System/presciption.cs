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

    public partial class presciption : UserControl
    {
        private string username;
        private string password;
        private string connectionString;
        public presciption(string username, string password, string connectionString)
        {
            this.username = username;
            this.password = password;
            this.connectionString = connectionString;
            InitializeComponent();
        }
    }
}
