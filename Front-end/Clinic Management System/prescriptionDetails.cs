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
    public partial class prescriptionDetails : UserControl

    {
        private string connectionString;
        private int prescriptionId;
        public prescriptionDetails(string connectionString,int prescriptionId)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.prescriptionId = prescriptionId;
            PopulatePrescriptionGridView();
        }

        private void PopulatePrescriptionGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT pi.prescription_id, pi.prescription_item_id, i.item_name, pi.item_type" +
                        " FROM tbl_prescription_item pi" +
                        " JOIN tbl_item i ON pi.item_id = i.item_id" +
                        " WHERE pi.prescription_id = @prescription_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@prescription_id", prescriptionId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            prescriptiondetailgridview.DataSource = dataTable;

                            prescriptiondetailgridview.Columns["prescription_id"].HeaderText = "Prescription ID";
                            prescriptiondetailgridview.Columns["item_name"].HeaderText = "Item Name";
                            prescriptiondetailgridview.Columns["item_type"].HeaderText = "Item Type";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching prescription details: " + ex.Message);
            }
        }
    }
}
