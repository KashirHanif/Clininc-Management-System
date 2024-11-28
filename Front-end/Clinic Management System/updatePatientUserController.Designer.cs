using System.Windows.Forms;

namespace Clinic_Management_System
{
    partial class updatePatientUserCotroller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatePatientUserCotroller));
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.viewPatientButton = new System.Windows.Forms.Button();
            this.cancelAppointmentButton = new System.Windows.Forms.Button();
            this.viewAppointmentButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.pfirstNameTB = new System.Windows.Forms.TextBox();
            this.plastNameTB = new System.Windows.Forms.TextBox();
            this.pfatherNameTB = new System.Windows.Forms.TextBox();
            this.pstreetTB = new System.Windows.Forms.TextBox();
            this.pBlockTB = new System.Windows.Forms.TextBox();
            this.pPhonenumTB = new System.Windows.Forms.TextBox();
            this.pCityTB = new System.Windows.Forms.TextBox();
            this.pAgeTB = new System.Windows.Forms.TextBox();
            this.pCountryTB = new System.Windows.Forms.TextBox();
            this.addPatientGridView = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.N = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pCNIC = new System.Windows.Forms.TextBox();
            this.pDOBTB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pGender2 = new System.Windows.Forms.ComboBox();
            this.pCountryCodeTB = new System.Windows.Forms.ComboBox();
            this.addPatientBtn = new System.Windows.Forms.Button();
            this.patientIdTextBox = new System.Windows.Forms.MaskedTextBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(1093, 561);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(141, 24);
            label3.TabIndex = 26;
            label3.Text = "Fathers Name";
            // 
            // updatePatientButton
            // 
            this.updatePatientButton.BackColor = System.Drawing.Color.Maroon;
            this.updatePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatePatientButton.Location = new System.Drawing.Point(56, 250);
            this.updatePatientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(218, 68);
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
            this.viewPatientButton.Location = new System.Drawing.Point(56, 344);
            this.viewPatientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewPatientButton.Name = "viewPatientButton";
            this.viewPatientButton.Size = new System.Drawing.Size(218, 68);
            this.viewPatientButton.TabIndex = 2;
            this.viewPatientButton.Text = "View Patient";
            this.viewPatientButton.UseVisualStyleBackColor = false;
            // 
            // cancelAppointmentButton
            // 
            this.cancelAppointmentButton.BackColor = System.Drawing.Color.Maroon;
            this.cancelAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAppointmentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelAppointmentButton.Location = new System.Drawing.Point(56, 536);
            this.cancelAppointmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelAppointmentButton.Name = "cancelAppointmentButton";
            this.cancelAppointmentButton.Size = new System.Drawing.Size(218, 71);
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
            this.viewAppointmentButton.Location = new System.Drawing.Point(56, 636);
            this.viewAppointmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewAppointmentButton.Name = "viewAppointmentButton";
            this.viewAppointmentButton.Size = new System.Drawing.Size(218, 76);
            this.viewAppointmentButton.TabIndex = 4;
            this.viewAppointmentButton.Text = "View Appointment";
            this.viewAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Navy;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(56, 743);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 27);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.BackColor = System.Drawing.Color.Maroon;
            this.addAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAppointmentButton.Location = new System.Drawing.Point(56, 440);
            this.addAppointmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(218, 67);
            this.addAppointmentButton.TabIndex = 7;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // pfirstNameTB
            // 
            this.pfirstNameTB.Location = new System.Drawing.Point(419, 553);
            this.pfirstNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pfirstNameTB.MaximumSize = new System.Drawing.Size(264, 35);
            this.pfirstNameTB.MinimumSize = new System.Drawing.Size(264, 35);
            this.pfirstNameTB.Name = "pfirstNameTB";
            this.pfirstNameTB.Size = new System.Drawing.Size(264, 35);
            this.pfirstNameTB.TabIndex = 8;
            // 
            // plastNameTB
            // 
            this.plastNameTB.Location = new System.Drawing.Point(812, 561);
            this.plastNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plastNameTB.MaximumSize = new System.Drawing.Size(264, 35);
            this.plastNameTB.MinimumSize = new System.Drawing.Size(264, 35);
            this.plastNameTB.Name = "plastNameTB";
            this.plastNameTB.Size = new System.Drawing.Size(264, 20);
            this.plastNameTB.TabIndex = 9;
            // 
            // pfatherNameTB
            // 
            this.pfatherNameTB.Location = new System.Drawing.Point(1230, 557);
            this.pfatherNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pfatherNameTB.MaximumSize = new System.Drawing.Size(264, 35);
            this.pfatherNameTB.MinimumSize = new System.Drawing.Size(264, 35);
            this.pfatherNameTB.Name = "pfatherNameTB";
            this.pfatherNameTB.Size = new System.Drawing.Size(264, 20);
            this.pfatherNameTB.TabIndex = 10;
            this.pfatherNameTB.TextChanged += new System.EventHandler(this.pfatherNameTB_TextChanged);
            // 
            // pstreetTB
            // 
            this.pstreetTB.Location = new System.Drawing.Point(1240, 631);
            this.pstreetTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pstreetTB.MaximumSize = new System.Drawing.Size(76, 35);
            this.pstreetTB.MinimumSize = new System.Drawing.Size(76, 35);
            this.pstreetTB.Name = "pstreetTB";
            this.pstreetTB.Size = new System.Drawing.Size(76, 20);
            this.pstreetTB.TabIndex = 12;
            this.pstreetTB.TextChanged += new System.EventHandler(this.pstreetTB_TextChanged);
            // 
            // pBlockTB
            // 
            this.pBlockTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBlockTB.Location = new System.Drawing.Point(1377, 596);
            this.pBlockTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBlockTB.Name = "pBlockTB";
            this.pBlockTB.Size = new System.Drawing.Size(84, 26);
            this.pBlockTB.TabIndex = 13;
            // 
            // pPhonenumTB
            // 
            this.pPhonenumTB.Location = new System.Drawing.Point(936, 631);
            this.pPhonenumTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pPhonenumTB.MaximumSize = new System.Drawing.Size(188, 35);
            this.pPhonenumTB.MinimumSize = new System.Drawing.Size(188, 35);
            this.pPhonenumTB.Name = "pPhonenumTB";
            this.pPhonenumTB.Size = new System.Drawing.Size(188, 20);
            this.pPhonenumTB.TabIndex = 14;
            // 
            // pCityTB
            // 
            this.pCityTB.Location = new System.Drawing.Point(962, 593);
            this.pCityTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCityTB.MaximumSize = new System.Drawing.Size(151, 35);
            this.pCityTB.MinimumSize = new System.Drawing.Size(151, 35);
            this.pCityTB.Name = "pCityTB";
            this.pCityTB.Size = new System.Drawing.Size(151, 20);
            this.pCityTB.TabIndex = 15;
            // 
            // pAgeTB
            // 
            this.pAgeTB.Location = new System.Drawing.Point(578, 592);
            this.pAgeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pAgeTB.MaximumSize = new System.Drawing.Size(76, 35);
            this.pAgeTB.MinimumSize = new System.Drawing.Size(76, 35);
            this.pAgeTB.Name = "pAgeTB";
            this.pAgeTB.Size = new System.Drawing.Size(76, 20);
            this.pAgeTB.TabIndex = 17;
            this.pAgeTB.TextChanged += new System.EventHandler(this.pAgeTB_TextChanged);
            // 
            // pCountryTB
            // 
            this.pCountryTB.Location = new System.Drawing.Point(745, 596);
            this.pCountryTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCountryTB.MaximumSize = new System.Drawing.Size(151, 35);
            this.pCountryTB.MinimumSize = new System.Drawing.Size(151, 35);
            this.pCountryTB.Name = "pCountryTB";
            this.pCountryTB.Size = new System.Drawing.Size(151, 20);
            this.pCountryTB.TabIndex = 19;
            // 
            // addPatientGridView
            // 
            this.addPatientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPatientGridView.Location = new System.Drawing.Point(317, 164);
            this.addPatientGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPatientGridView.Name = "addPatientGridView";
            this.addPatientGridView.RowHeadersWidth = 51;
            this.addPatientGridView.RowTemplate.Height = 24;
            this.addPatientGridView.Size = new System.Drawing.Size(1120, 366);
            this.addPatientGridView.TabIndex = 20;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Maroon;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateButton.Location = new System.Drawing.Point(1240, 96);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(119, 53);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 105);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.N.Location = new System.Drawing.Point(314, 560);
            this.N.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(111, 24);
            this.N.TabIndex = 24;
            this.N.Text = "First Name";
            this.N.Click += new System.EventHandler(this.N_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(702, 561);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1126, 598);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1314, 598);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Block";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(664, 596);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(529, 596);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(711, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(278, 600);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "CNIC";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(319, 630);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "DOB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(915, 600);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(566, 636);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 24);
            this.label12.TabIndex = 35;
            this.label12.Text = "Country code";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(790, 631);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 24);
            this.label13.TabIndex = 36;
            this.label13.Text = "Phone Number";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pCNIC
            // 
            this.pCNIC.Location = new System.Drawing.Point(339, 592);
            this.pCNIC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCNIC.MaximumSize = new System.Drawing.Size(188, 35);
            this.pCNIC.MinimumSize = new System.Drawing.Size(188, 35);
            this.pCNIC.Name = "pCNIC";
            this.pCNIC.Size = new System.Drawing.Size(188, 35);
            this.pCNIC.TabIndex = 37;
            // 
            // pDOBTB
            // 
            this.pDOBTB.CustomFormat = "MM/dd/yyyy";
            this.pDOBTB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pDOBTB.Location = new System.Drawing.Point(376, 635);
            this.pDOBTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pDOBTB.Name = "pDOBTB";
            this.pDOBTB.Size = new System.Drawing.Size(151, 20);
            this.pDOBTB.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 655);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "(without \'-\')";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(1127, 636);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "Street Num";
            // 
            // pGender2
            // 
            this.pGender2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pGender2.FormattingEnabled = true;
            this.pGender2.Items.AddRange(new object[] {
            "male",
            "female",
            "other"});
            this.pGender2.Location = new System.Drawing.Point(1206, 599);
            this.pGender2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pGender2.Name = "pGender2";
            this.pGender2.Size = new System.Drawing.Size(92, 21);
            this.pGender2.TabIndex = 43;
            // 
            // pCountryCodeTB
            // 
            this.pCountryCodeTB.FormattingEnabled = true;
            this.pCountryCodeTB.Items.AddRange(new object[] {
            "+1",
            "+44",
            "+91",
            "+86",
            "+81",
            "+49",
            "+33",
            "+7",
            "+39",
            "+34",
            "+61",
            "+55",
            "+27",
            "+82",
            "+31",
            "+90",
            "+964",
            "+971",
            "+92",
            "+880"});
            this.pCountryCodeTB.Location = new System.Drawing.Point(695, 640);
            this.pCountryCodeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCountryCodeTB.Name = "pCountryCodeTB";
            this.pCountryCodeTB.Size = new System.Drawing.Size(92, 21);
            this.pCountryCodeTB.TabIndex = 44;
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.BackColor = System.Drawing.Color.Maroon;
            this.addPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPatientBtn.Location = new System.Drawing.Point(56, 164);
            this.addPatientBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Size = new System.Drawing.Size(218, 59);
            this.addPatientBtn.TabIndex = 45;
            this.addPatientBtn.Text = "Add Patient";
            this.addPatientBtn.UseVisualStyleBackColor = false;
            this.addPatientBtn.Click += new System.EventHandler(this.addPatientBtn_Click);
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Enabled = false;
            this.patientIdTextBox.Location = new System.Drawing.Point(376, 667);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(107, 20);
            this.patientIdTextBox.TabIndex = 47;
            // 
            // updatePatientUserCotroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.patientIdTextBox);
            this.Controls.Add(this.addPatientBtn);
            this.Controls.Add(this.pCountryCodeTB);
            this.Controls.Add(this.pGender2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pDOBTB);
            this.Controls.Add(this.pCNIC);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.N);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addPatientGridView);
            this.Controls.Add(this.pCountryTB);
            this.Controls.Add(this.pAgeTB);
            this.Controls.Add(this.pCityTB);
            this.Controls.Add(this.pPhonenumTB);
            this.Controls.Add(this.pBlockTB);
            this.Controls.Add(this.pstreetTB);
            this.Controls.Add(this.pfatherNameTB);
            this.Controls.Add(this.plastNameTB);
            this.Controls.Add(this.pfirstNameTB);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.viewAppointmentButton);
            this.Controls.Add(this.cancelAppointmentButton);
            this.Controls.Add(this.viewPatientButton);
            this.Controls.Add(this.updatePatientButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1500, 894);
            this.MinimumSize = new System.Drawing.Size(1500, 894);
            this.Name = "updatePatientUserCotroller";
            this.Size = new System.Drawing.Size(1500, 894);
            this.Load += new System.EventHandler(this.updatePatientUserCotroller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox pfirstNameTB;
        private System.Windows.Forms.TextBox plastNameTB;
        private System.Windows.Forms.TextBox pfatherNameTB;
        private System.Windows.Forms.TextBox pstreetTB;
        private System.Windows.Forms.TextBox pBlockTB;
        private System.Windows.Forms.TextBox pPhonenumTB;
        private System.Windows.Forms.TextBox pCityTB;
        private System.Windows.Forms.TextBox pAgeTB;
        private System.Windows.Forms.TextBox pCountryTB;
        private System.Windows.Forms.DataGridView addPatientGridView;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox pCNIC;
        private System.Windows.Forms.DateTimePicker pDOBTB;
        // Array of gender options
        string[] genderOptions = { "Male", "Female", "Others" };
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox pGender2;
        private System.Windows.Forms.ComboBox pCountryCodeTB;
        private System.Windows.Forms.Button addPatientBtn;
        private MaskedTextBox patientIdTextBox;
    }
}
