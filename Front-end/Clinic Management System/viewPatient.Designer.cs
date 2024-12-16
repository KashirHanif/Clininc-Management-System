using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    partial class viewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewPatient));
            this.addPatientButton = new System.Windows.Forms.Button();
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.viewPatientButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.cancelAppointmentButton = new System.Windows.Forms.Button();
            this.viewAppointmentsButton = new System.Windows.Forms.Button();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // addPatientButton
            // 
            this.addPatientButton.BackColor = System.Drawing.Color.Maroon;
            this.addPatientButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPatientButton.Location = new System.Drawing.Point(50, 243);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(255, 51);
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
            this.updatePatientButton.Location = new System.Drawing.Point(50, 313);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(255, 55);
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
            this.viewPatientButton.Size = new System.Drawing.Size(255, 53);
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
            this.addAppointmentButton.Location = new System.Drawing.Point(50, 469);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(255, 51);
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
            this.cancelAppointmentButton.Location = new System.Drawing.Point(50, 541);
            this.cancelAppointmentButton.Name = "cancelAppointmentButton";
            this.cancelAppointmentButton.Size = new System.Drawing.Size(255, 51);
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
            this.viewAppointmentsButton.Location = new System.Drawing.Point(50, 611);
            this.viewAppointmentsButton.Name = "viewAppointmentsButton";
            this.viewAppointmentsButton.Size = new System.Drawing.Size(255, 57);
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
            this.patientGridView.Location = new System.Drawing.Point(395, 260);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.patientGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.patientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientGridView.Size = new System.Drawing.Size(1089, 484);
            this.patientGridView.TabIndex = 8;
            this.patientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(50, 753);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All ",
            "Last Week",
            "Last Month"});
            this.comboBox1.Location = new System.Drawing.Point(1234, 221);
            this.comboBox1.MaximumSize = new System.Drawing.Size(250, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(250, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 33);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1169, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 53);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1230, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter Patients";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(475, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 28);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(946, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Search By Name ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(50, 690);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 54);
            this.button3.TabIndex = 78;
            this.button3.Text = "Add prescription";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(104, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 81;
            this.label2.Text = "mediAid";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(111, 63);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 123);
            this.pictureBox4.TabIndex = 80;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(341, 1233);
            this.pictureBox3.TabIndex = 79;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(2024, 137);
            this.pictureBox5.TabIndex = 82;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(395, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 49);
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // viewPatient
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.updatePatientButton);
            this.Controls.Add(this.viewPatientButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.cancelAppointmentButton);
            this.Controls.Add(this.viewAppointmentsButton);
            this.Controls.Add(this.patientGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.MaximumSize = new System.Drawing.Size(2000, 1100);
            this.MinimumSize = new System.Drawing.Size(2000, 1000);
            this.Name = "viewPatient";
            this.Size = new System.Drawing.Size(2000, 1000);
            this.Load += new System.EventHandler(this.PatientUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button button1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
    }
}