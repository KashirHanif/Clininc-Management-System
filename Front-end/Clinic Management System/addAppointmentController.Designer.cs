using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    partial class addAppointmentController
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAppointmentController));
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.viewPatientButton = new System.Windows.Forms.Button();
            this.cancelAppointmentButton = new System.Windows.Forms.Button();
            this.viewAppointmentButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.addPatientGridView = new System.Windows.Forms.DataGridView();
            this.addAptButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.N = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addPatientBtn = new System.Windows.Forms.Button();
            this.patientIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aptDate = new System.Windows.Forms.DateTimePicker();
            this.aptTime = new System.Windows.Forms.DateTimePicker();
            this.BookedBy = new System.Windows.Forms.Label();
            this.AptTypeComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.aptPhonenum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aptSearch = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchPatient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(419, 689);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 29);
            label3.TabIndex = 26;
            label3.Text = "Doctor";
            // 
            // updatePatientButton
            // 
            this.updatePatientButton.BackColor = System.Drawing.Color.Maroon;
            this.updatePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatePatientButton.Location = new System.Drawing.Point(75, 308);
            this.updatePatientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(291, 84);
            this.updatePatientButton.TabIndex = 1;
            this.updatePatientButton.Text = "Update Patient";
            this.updatePatientButton.UseVisualStyleBackColor = false;
            this.updatePatientButton.Click += new System.EventHandler(this.updatePatientButton_Click);
            // 
            // viewPatientButton
            // 
            this.viewPatientButton.BackColor = System.Drawing.Color.Maroon;
            this.viewPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPatientButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewPatientButton.Location = new System.Drawing.Point(75, 428);
            this.viewPatientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewPatientButton.Name = "viewPatientButton";
            this.viewPatientButton.Size = new System.Drawing.Size(291, 84);
            this.viewPatientButton.TabIndex = 2;
            this.viewPatientButton.Text = "View Patient";
            this.viewPatientButton.UseVisualStyleBackColor = false;
            this.viewPatientButton.Click += new System.EventHandler(this.viewPatientButton_Click);
            // 
            // cancelAppointmentButton
            // 
            this.cancelAppointmentButton.BackColor = System.Drawing.Color.Maroon;
            this.cancelAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAppointmentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelAppointmentButton.Location = new System.Drawing.Point(75, 660);
            this.cancelAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelAppointmentButton.Name = "cancelAppointmentButton";
            this.cancelAppointmentButton.Size = new System.Drawing.Size(291, 87);
            this.cancelAppointmentButton.TabIndex = 3;
            this.cancelAppointmentButton.Text = "Cancel Appointment";
            this.cancelAppointmentButton.UseVisualStyleBackColor = false;
            this.cancelAppointmentButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // viewAppointmentButton
            // 
            this.viewAppointmentButton.BackColor = System.Drawing.Color.Maroon;
            this.viewAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAppointmentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewAppointmentButton.Location = new System.Drawing.Point(75, 783);
            this.viewAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewAppointmentButton.Name = "viewAppointmentButton";
            this.viewAppointmentButton.Size = new System.Drawing.Size(291, 94);
            this.viewAppointmentButton.TabIndex = 4;
            this.viewAppointmentButton.Text = "View Appointment";
            this.viewAppointmentButton.UseVisualStyleBackColor = false;
            this.viewAppointmentButton.Click += new System.EventHandler(this.viewAppointmentButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Navy;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(75, 914);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 33);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.BackColor = System.Drawing.Color.Maroon;
            this.addAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAppointmentButton.Location = new System.Drawing.Point(75, 549);
            this.addAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(291, 82);
            this.addAppointmentButton.TabIndex = 7;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // addPatientGridView
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addPatientGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.addPatientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.addPatientGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.addPatientGridView.Location = new System.Drawing.Point(423, 202);
            this.addPatientGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPatientGridView.Name = "addPatientGridView";
            this.addPatientGridView.RowHeadersWidth = 51;
            this.addPatientGridView.RowTemplate.Height = 24;
            this.addPatientGridView.Size = new System.Drawing.Size(1535, 450);
            this.addPatientGridView.TabIndex = 20;
            // 
            // addAptButton
            // 
            this.addAptButton.BackColor = System.Drawing.Color.Maroon;
            this.addAptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAptButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAptButton.Location = new System.Drawing.Point(1799, 770);
            this.addAptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAptButton.Name = "addAptButton";
            this.addAptButton.Size = new System.Drawing.Size(159, 82);
            this.addAptButton.TabIndex = 21;
            this.addAptButton.Text = "Book";
            this.addAptButton.UseVisualStyleBackColor = false;
            this.addAptButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 129);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.N.Location = new System.Drawing.Point(1145, 687);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(71, 29);
            this.N.TabIndex = 24;
            this.N.Text = "date ";
            this.N.Click += new System.EventHandler(this.N_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(824, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(948, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(419, 756);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "Appointment Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(853, 756);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 29);
            this.label11.TabIndex = 34;
            this.label11.Text = "Status";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.BackColor = System.Drawing.Color.Maroon;
            this.addPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPatientBtn.Location = new System.Drawing.Point(75, 202);
            this.addPatientBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Size = new System.Drawing.Size(291, 80);
            this.addPatientBtn.TabIndex = 45;
            this.addPatientBtn.Text = "Add Patient";
            this.addPatientBtn.UseVisualStyleBackColor = false;
            this.addPatientBtn.Click += new System.EventHandler(this.addPatientBtn_Click);
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Enabled = false;
            this.patientIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdTextBox.Location = new System.Drawing.Point(605, 825);
            this.patientIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientIdTextBox.MaximumSize = new System.Drawing.Size(100, 35);
            this.patientIdTextBox.MinimumSize = new System.Drawing.Size(71, 35);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(71, 27);
            this.patientIdTextBox.TabIndex = 47;
            this.patientIdTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.patientIdTextBox_MaskInputRejected);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(475, 830);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 29);
            this.label16.TabIndex = 49;
            this.label16.Text = "patient ID";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(424, 810);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // aptDate
            // 
            this.aptDate.CustomFormat = "MM/dd/yyyy";
            this.aptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.aptDate.Location = new System.Drawing.Point(1221, 682);
            this.aptDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aptDate.MaximumSize = new System.Drawing.Size(200, 40);
            this.aptDate.MinimumSize = new System.Drawing.Size(200, 40);
            this.aptDate.Name = "aptDate";
            this.aptDate.Size = new System.Drawing.Size(200, 40);
            this.aptDate.TabIndex = 51;
            // 
            // aptTime
            // 
            this.aptTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.aptTime.Location = new System.Drawing.Point(903, 683);
            this.aptTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aptTime.MaximumSize = new System.Drawing.Size(151, 35);
            this.aptTime.MinimumSize = new System.Drawing.Size(151, 35);
            this.aptTime.Name = "aptTime";
            this.aptTime.Size = new System.Drawing.Size(151, 35);
            this.aptTime.TabIndex = 52;
            // 
            // BookedBy
            // 
            this.BookedBy.AutoSize = true;
            this.BookedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookedBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BookedBy.Location = new System.Drawing.Point(1523, 687);
            this.BookedBy.Name = "BookedBy";
            this.BookedBy.Size = new System.Drawing.Size(137, 29);
            this.BookedBy.TabIndex = 53;
            this.BookedBy.Text = "Booked by";
            // 
            // AptTypeComboBox
            // 
            this.AptTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AptTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AptTypeComboBox.FormattingEnabled = true;
            this.AptTypeComboBox.Items.AddRange(new object[] {
            "Online",
            "Walk In"});
            this.AptTypeComboBox.Location = new System.Drawing.Point(665, 754);
            this.AptTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AptTypeComboBox.Name = "AptTypeComboBox";
            this.AptTypeComboBox.Size = new System.Drawing.Size(121, 28);
            this.AptTypeComboBox.TabIndex = 54;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Attended",
            "Booked"});
            this.statusComboBox.Location = new System.Drawing.Point(953, 754);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 28);
            this.statusComboBox.TabIndex = 58;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1675, 686);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.MaximumSize = new System.Drawing.Size(249, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(249, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 28);
            this.comboBox1.TabIndex = 59;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(515, 689);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.MaximumSize = new System.Drawing.Size(249, 0);
            this.comboBox2.MinimumSize = new System.Drawing.Size(249, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(249, 28);
            this.comboBox2.TabIndex = 60;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // aptPhonenum
            // 
            this.aptPhonenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptPhonenum.Location = new System.Drawing.Point(1357, 754);
            this.aptPhonenum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aptPhonenum.Name = "aptPhonenum";
            this.aptPhonenum.Size = new System.Drawing.Size(241, 27);
            this.aptPhonenum.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1164, 754);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Phone Number";
            // 
            // aptSearch
            // 
            this.aptSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptSearch.Location = new System.Drawing.Point(803, 832);
            this.aptSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aptSearch.Name = "aptSearch";
            this.aptSearch.Size = new System.Drawing.Size(368, 27);
            this.aptSearch.TabIndex = 63;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(729, 810);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 54);
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 809);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "enter phone number";
            // 
            // searchPatient
            // 
            this.searchPatient.BackColor = System.Drawing.Color.Maroon;
            this.searchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchPatient.Location = new System.Drawing.Point(1187, 817);
            this.searchPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchPatient.Name = "searchPatient";
            this.searchPatient.Size = new System.Drawing.Size(100, 42);
            this.searchPatient.TabIndex = 66;
            this.searchPatient.Text = "Search";
            this.searchPatient.UseVisualStyleBackColor = false;
            this.searchPatient.Click += new System.EventHandler(this.searchPatient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1551, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 38);
            this.label5.TabIndex = 67;
            this.label5.Text = "Incharge: receptionist";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1500, 71);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 50);
            this.pictureBox4.TabIndex = 68;
            this.pictureBox4.TabStop = false;
            // 
            // addAppointmentController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchPatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.aptSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aptPhonenum);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.AptTypeComboBox);
            this.Controls.Add(this.BookedBy);
            this.Controls.Add(this.aptTime);
            this.Controls.Add(this.aptDate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.patientIdTextBox);
            this.Controls.Add(this.addPatientBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.N);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addAptButton);
            this.Controls.Add(this.addPatientGridView);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.viewAppointmentButton);
            this.Controls.Add(this.cancelAppointmentButton);
            this.Controls.Add(this.viewPatientButton);
            this.Controls.Add(this.updatePatientButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2000, 1100);
            this.MinimumSize = new System.Drawing.Size(2000, 1100);
            this.Name = "addAppointmentController";
            this.Size = new System.Drawing.Size(2000, 1100);
            this.Load += new System.EventHandler(this.addAppointmentController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button updatePatientButton;
        private System.Windows.Forms.Button viewPatientButton;
        private System.Windows.Forms.Button cancelAppointmentButton;
        private System.Windows.Forms.Button viewAppointmentButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.DataGridView addPatientGridView;
        private System.Windows.Forms.Button addAptButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        // Array of gender options
        string[] genderOptions = { "Male", "Female", "Others" };
        private System.Windows.Forms.Button addPatientBtn;
        private MaskedTextBox patientIdTextBox;
        private Label label16;
        private PictureBox pictureBox2;
        private DateTimePicker aptDate;
        private DateTimePicker aptTime;
        private Label BookedBy;
        private ComboBox AptTypeComboBox;
        private ComboBox statusComboBox;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox aptPhonenum;
        private Label label1;
        private TextBox aptSearch;
        private PictureBox pictureBox3;
        private Label label4;
        private Button searchPatient;
        private Label label5;
        private PictureBox pictureBox4;
    }
}
