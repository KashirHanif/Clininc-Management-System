﻿using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    partial class appointment_admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointment_admin));
            this.addPatientGridView = new System.Windows.Forms.DataGridView();
            this.addAptButton = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // addPatientGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addPatientGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.addPatientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.addPatientGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.addPatientGridView.Location = new System.Drawing.Point(423, 219);
            this.addPatientGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPatientGridView.Name = "addPatientGridView";
            this.addPatientGridView.RowHeadersWidth = 51;
            this.addPatientGridView.RowTemplate.Height = 24;
            this.addPatientGridView.Size = new System.Drawing.Size(1535, 433);
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
            this.aptDate.ValueChanged += new System.EventHandler(this.aptDate_ValueChanged);
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
            this.BookedBy.Location = new System.Drawing.Point(1553, 687);
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
            this.comboBox1.Location = new System.Drawing.Point(1704, 688);
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
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1375, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 38);
            this.label5.TabIndex = 67;
            this.label5.Text = "Incharge: Admin";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(-12, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(2279, 97);
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(48, 833);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 78);
            this.button2.TabIndex = 78;
            this.button2.Text = "Appointment Log";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Black;
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.Location = new System.Drawing.Point(1776, 12);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(67, 62);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 68;
            this.profilePicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 1233);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(101, 48);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 123);
            this.pictureBox4.TabIndex = 72;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(95, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 37);
            this.label6.TabIndex = 73;
            this.label6.Text = "mediAid";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(48, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 55);
            this.button1.TabIndex = 74;
            this.button1.Text = "Doctor ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(48, 703);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 78);
            this.button3.TabIndex = 75;
            this.button3.Text = "Revenue";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(48, 558);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 84);
            this.button4.TabIndex = 76;
            this.button4.Text = "Add Appointment ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(48, 436);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 55);
            this.button5.TabIndex = 77;
            this.button5.Text = "Patient";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(65, 935);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 38);
            this.button6.TabIndex = 79;
            this.button6.Text = "back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // appointment_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.N);
            this.Controls.Add(this.addAptButton);
            this.Controls.Add(this.addPatientGridView);
            this.Controls.Add(this.pictureBox5);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2000, 1100);
            this.MinimumSize = new System.Drawing.Size(2000, 1100);
            this.Name = "appointment_admin";
            this.Size = new System.Drawing.Size(2000, 1100);
            this.Load += new System.EventHandler(this.appointment_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.DataGridView addPatientGridView;
        private System.Windows.Forms.Button addAptButton;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        // Array of gender options
        string[] genderOptions = { "Male", "Female", "Others" };
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
        private PictureBox pictureBox5;
        private Button button2;
        private PictureBox profilePicture;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label6;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
