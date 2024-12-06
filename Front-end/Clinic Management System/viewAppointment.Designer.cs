using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    partial class viewAppointment
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button updatePatientButton;
        private System.Windows.Forms.Button viewPatientButton;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button cancelAppointmentButton;
        private System.Windows.Forms.Button viewAppointmentsButton;
        private System.Windows.Forms.DataGridView patientGridView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewAppointment));
            this.addPatientButton = new System.Windows.Forms.Button();
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.viewPatientButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.cancelAppointmentButton = new System.Windows.Forms.Button();
            this.viewAppointmentsButton = new System.Windows.Forms.Button();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.mediAidLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.findByDoctor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediAidLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // addPatientButton
            // 
            this.addPatientButton.BackColor = System.Drawing.Color.Maroon;
            this.addPatientButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPatientButton.Location = new System.Drawing.Point(50, 250);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(255, 65);
            this.addPatientButton.TabIndex = 0;
            this.addPatientButton.Text = "Add Patient";
            this.addPatientButton.UseVisualStyleBackColor = false;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // updatePatientButton
            // 
            this.updatePatientButton.BackColor = System.Drawing.Color.Maroon;
            this.updatePatientButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatePatientButton.Location = new System.Drawing.Point(50, 321);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(255, 65);
            this.updatePatientButton.TabIndex = 1;
            this.updatePatientButton.Text = "Update Patient";
            this.updatePatientButton.UseVisualStyleBackColor = false;
            this.updatePatientButton.Click += new System.EventHandler(this.updatePatientButton_Click);
            // 
            // viewPatientButton
            // 
            this.viewPatientButton.BackColor = System.Drawing.Color.Maroon;
            this.viewPatientButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPatientButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewPatientButton.Location = new System.Drawing.Point(50, 392);
            this.viewPatientButton.Name = "viewPatientButton";
            this.viewPatientButton.Size = new System.Drawing.Size(255, 65);
            this.viewPatientButton.TabIndex = 2;
            this.viewPatientButton.Text = "View Patients";
            this.viewPatientButton.UseVisualStyleBackColor = false;
            this.viewPatientButton.Click += new System.EventHandler(this.viewPatientButton_Click);
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.BackColor = System.Drawing.Color.Maroon;
            this.addAppointmentButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAppointmentButton.Location = new System.Drawing.Point(50, 463);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(255, 68);
            this.addAppointmentButton.TabIndex = 3;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // cancelAppointmentButton
            // 
            this.cancelAppointmentButton.BackColor = System.Drawing.Color.Maroon;
            this.cancelAppointmentButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAppointmentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelAppointmentButton.Location = new System.Drawing.Point(50, 537);
            this.cancelAppointmentButton.Name = "cancelAppointmentButton";
            this.cancelAppointmentButton.Size = new System.Drawing.Size(255, 64);
            this.cancelAppointmentButton.TabIndex = 4;
            this.cancelAppointmentButton.Text = "Cancel Appointment";
            this.cancelAppointmentButton.UseVisualStyleBackColor = false;
            this.cancelAppointmentButton.Click += new System.EventHandler(this.cancelAppointmentButton_Click);
            // 
            // viewAppointmentsButton
            // 
            this.viewAppointmentsButton.BackColor = System.Drawing.Color.Maroon;
            this.viewAppointmentsButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAppointmentsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewAppointmentsButton.Location = new System.Drawing.Point(50, 607);
            this.viewAppointmentsButton.Name = "viewAppointmentsButton";
            this.viewAppointmentsButton.Size = new System.Drawing.Size(255, 60);
            this.viewAppointmentsButton.TabIndex = 5;
            this.viewAppointmentsButton.Text = "View Appointments";
            this.viewAppointmentsButton.UseVisualStyleBackColor = false;
            this.viewAppointmentsButton.Click += new System.EventHandler(this.viewAppointmentsButton_Click);
            // 
            // patientGridView
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.patientGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.patientGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.patientGridView.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.patientGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.patientGridView.Location = new System.Drawing.Point(395, 266);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.patientGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.patientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientGridView.Size = new System.Drawing.Size(1089, 478);
            this.patientGridView.TabIndex = 8;
            this.patientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientGridView_CellContentClick);
            // 
            // mediAidLogo
            // 
            this.mediAidLogo.Image = ((System.Drawing.Image)(resources.GetObject("mediAidLogo.Image")));
            this.mediAidLogo.Location = new System.Drawing.Point(50, 53);
            this.mediAidLogo.Name = "mediAidLogo";
            this.mediAidLogo.Size = new System.Drawing.Size(553, 133);
            this.mediAidLogo.TabIndex = 9;
            this.mediAidLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(50, 743);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All ",
            "Upcoming Week",
            "Upcoming Month",
            "Cancelled"});
            this.comboBox1.Location = new System.Drawing.Point(1234, 211);
            this.comboBox1.MaximumSize = new System.Drawing.Size(250, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(250, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1174, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 48);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1230, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter Appointments";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1174, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 23);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1306, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Search by Name";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1123, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 47);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(50, 673);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 64);
            this.button3.TabIndex = 79;
            this.button3.Text = "Add treatment";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // findByDoctor
            // 
            this.findByDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.findByDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findByDoctor.FormattingEnabled = true;
            this.findByDoctor.Location = new System.Drawing.Point(902, 211);
            this.findByDoctor.MaximumSize = new System.Drawing.Size(250, 0);
            this.findByDoctor.MinimumSize = new System.Drawing.Size(250, 0);
            this.findByDoctor.Name = "findByDoctor";
            this.findByDoctor.Size = new System.Drawing.Size(250, 28);
            this.findByDoctor.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(898, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 81;
            this.label2.Text = "Filter by Doctor";
            // 
            // viewAppointment
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findByDoctor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mediAidLogo);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.updatePatientButton);
            this.Controls.Add(this.viewPatientButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.cancelAppointmentButton);
            this.Controls.Add(this.viewAppointmentsButton);
            this.Controls.Add(this.patientGridView);
            this.MaximumSize = new System.Drawing.Size(2000, 1100);
            this.MinimumSize = new System.Drawing.Size(2000, 1000);
            this.Name = "viewAppointment";
            this.Size = new System.Drawing.Size(2000, 1000);
            this.Load += new System.EventHandler(this.PatientUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediAidLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox mediAidLogo;
        private Button button1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button3;
        private ComboBox findByDoctor;
        private Label label2;
    }
}