using System.Drawing;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(1068, 560);
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
            this.updatePatientButton.Location = new System.Drawing.Point(56, 276);
            this.updatePatientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(218, 58);
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
            this.viewPatientButton.Location = new System.Drawing.Point(56, 348);
            this.viewPatientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewPatientButton.Name = "viewPatientButton";
            this.viewPatientButton.Size = new System.Drawing.Size(218, 56);
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
            this.cancelAppointmentButton.Location = new System.Drawing.Point(56, 502);
            this.cancelAppointmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelAppointmentButton.Name = "cancelAppointmentButton";
            this.cancelAppointmentButton.Size = new System.Drawing.Size(218, 62);
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
            this.viewAppointmentButton.Location = new System.Drawing.Point(56, 581);
            this.viewAppointmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewAppointmentButton.Name = "viewAppointmentButton";
            this.viewAppointmentButton.Size = new System.Drawing.Size(218, 55);
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
            this.backButton.Location = new System.Drawing.Point(56, 743);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 27);
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
            this.addAppointmentButton.Location = new System.Drawing.Point(56, 424);
            this.addAppointmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(218, 58);
            this.addAppointmentButton.TabIndex = 7;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // pfirstNameTB
            // 
            this.pfirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfirstNameTB.Location = new System.Drawing.Point(419, 555);
            this.pfirstNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pfirstNameTB.MaximumSize = new System.Drawing.Size(264, 35);
            this.pfirstNameTB.MinimumSize = new System.Drawing.Size(264, 35);
            this.pfirstNameTB.Name = "pfirstNameTB";
            this.pfirstNameTB.Size = new System.Drawing.Size(264, 23);
            this.pfirstNameTB.TabIndex = 8;
            // 
            // plastNameTB
            // 
            this.plastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plastNameTB.Location = new System.Drawing.Point(796, 555);
            this.plastNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plastNameTB.MaximumSize = new System.Drawing.Size(264, 35);
            this.plastNameTB.MinimumSize = new System.Drawing.Size(264, 35);
            this.plastNameTB.Name = "plastNameTB";
            this.plastNameTB.Size = new System.Drawing.Size(264, 23);
            this.plastNameTB.TabIndex = 9;
            // 
            // pfatherNameTB
            // 
            this.pfatherNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfatherNameTB.Location = new System.Drawing.Point(1205, 553);
            this.pfatherNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pfatherNameTB.MaximumSize = new System.Drawing.Size(264, 35);
            this.pfatherNameTB.MinimumSize = new System.Drawing.Size(264, 35);
            this.pfatherNameTB.Name = "pfatherNameTB";
            this.pfatherNameTB.Size = new System.Drawing.Size(264, 23);
            this.pfatherNameTB.TabIndex = 10;
            this.pfatherNameTB.TextChanged += new System.EventHandler(this.pfatherNameTB_TextChanged);
            // 
            // pstreetTB
            // 
            this.pstreetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pstreetTB.Location = new System.Drawing.Point(1394, 612);
            this.pstreetTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pstreetTB.MaximumSize = new System.Drawing.Size(76, 35);
            this.pstreetTB.MinimumSize = new System.Drawing.Size(76, 35);
            this.pstreetTB.Name = "pstreetTB";
            this.pstreetTB.Size = new System.Drawing.Size(76, 23);
            this.pstreetTB.TabIndex = 12;
            this.pstreetTB.TextChanged += new System.EventHandler(this.pstreetTB_TextChanged);
            // 
            // pBlockTB
            // 
            this.pBlockTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBlockTB.Location = new System.Drawing.Point(1170, 618);
            this.pBlockTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBlockTB.Name = "pBlockTB";
            this.pBlockTB.Size = new System.Drawing.Size(84, 23);
            this.pBlockTB.TabIndex = 13;
            // 
            // pPhonenumTB
            // 
            this.pPhonenumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPhonenumTB.Location = new System.Drawing.Point(935, 678);
            this.pPhonenumTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pPhonenumTB.MaximumSize = new System.Drawing.Size(188, 35);
            this.pPhonenumTB.MinimumSize = new System.Drawing.Size(188, 35);
            this.pPhonenumTB.Name = "pPhonenumTB";
            this.pPhonenumTB.Size = new System.Drawing.Size(188, 23);
            this.pPhonenumTB.TabIndex = 14;
            // 
            // pCityTB
            // 
            this.pCityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCityTB.Location = new System.Drawing.Point(935, 614);
            this.pCityTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCityTB.MaximumSize = new System.Drawing.Size(151, 35);
            this.pCityTB.MinimumSize = new System.Drawing.Size(151, 35);
            this.pCityTB.Name = "pCityTB";
            this.pCityTB.Size = new System.Drawing.Size(151, 23);
            this.pCityTB.TabIndex = 15;
            this.pCityTB.TextChanged += new System.EventHandler(this.pCityTB_TextChanged_1);
            // 
            // pAgeTB
            // 
            this.pAgeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAgeTB.Location = new System.Drawing.Point(512, 613);
            this.pAgeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pAgeTB.MaximumSize = new System.Drawing.Size(76, 35);
            this.pAgeTB.MinimumSize = new System.Drawing.Size(76, 35);
            this.pAgeTB.Name = "pAgeTB";
            this.pAgeTB.Size = new System.Drawing.Size(76, 23);
            this.pAgeTB.TabIndex = 17;
            this.pAgeTB.TextChanged += new System.EventHandler(this.pAgeTB_TextChanged);
            // 
            // pCountryTB
            // 
            this.pCountryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCountryTB.Location = new System.Drawing.Point(705, 613);
            this.pCountryTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCountryTB.MaximumSize = new System.Drawing.Size(151, 35);
            this.pCountryTB.MinimumSize = new System.Drawing.Size(151, 35);
            this.pCountryTB.Name = "pCountryTB";
            this.pCountryTB.Size = new System.Drawing.Size(151, 23);
            this.pCountryTB.TabIndex = 19;
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
            this.addPatientGridView.Location = new System.Drawing.Point(317, 205);
            this.addPatientGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPatientGridView.Name = "addPatientGridView";
            this.addPatientGridView.RowHeadersWidth = 51;
            this.addPatientGridView.RowTemplate.Height = 24;
            this.addPatientGridView.Size = new System.Drawing.Size(1151, 325);
            this.addPatientGridView.TabIndex = 20;
            this.addPatientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addPatientGridView_CellContentClick_1);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Maroon;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateButton.Location = new System.Drawing.Point(1349, 658);
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
            this.label2.Location = new System.Drawing.Point(687, 558);
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
            this.label4.Location = new System.Drawing.Point(1146, 680);
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
            this.label5.Location = new System.Drawing.Point(1107, 618);
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
            this.label6.Location = new System.Drawing.Point(624, 615);
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
            this.label7.Location = new System.Drawing.Point(463, 618);
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
            this.label9.Location = new System.Drawing.Point(314, 670);
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
            this.label10.Location = new System.Drawing.Point(314, 621);
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
            this.label11.Location = new System.Drawing.Point(888, 618);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "City";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(568, 674);
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
            this.label13.Location = new System.Drawing.Point(781, 674);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 24);
            this.label13.TabIndex = 36;
            this.label13.Text = "Phone Number";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pCNIC
            // 
            this.pCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCNIC.Location = new System.Drawing.Point(371, 674);
            this.pCNIC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCNIC.MaximumSize = new System.Drawing.Size(188, 35);
            this.pCNIC.MaxLength = 13;
            this.pCNIC.MinimumSize = new System.Drawing.Size(188, 35);
            this.pCNIC.Name = "pCNIC";
            this.pCNIC.Size = new System.Drawing.Size(188, 23);
            this.pCNIC.TabIndex = 37;
            // 
            // pDOBTB
            // 
            this.pDOBTB.CustomFormat = "MM/dd/yyyy";
            this.pDOBTB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pDOBTB.Location = new System.Drawing.Point(370, 617);
            this.pDOBTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pDOBTB.MaximumSize = new System.Drawing.Size(76, 35);
            this.pDOBTB.MinimumSize = new System.Drawing.Size(76, 35);
            this.pDOBTB.Name = "pDOBTB";
            this.pDOBTB.Size = new System.Drawing.Size(76, 35);
            this.pDOBTB.TabIndex = 38;
            this.pDOBTB.ValueChanged += new System.EventHandler(this.pDOBTB_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(782, 698);
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
            this.label14.Location = new System.Drawing.Point(1274, 615);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "Street Num";
            // 
            // pGender2
            // 
            this.pGender2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pGender2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGender2.FormattingEnabled = true;
            this.pGender2.Items.AddRange(new object[] {
            "male",
            "female",
            "other"});
            this.pGender2.Location = new System.Drawing.Point(1226, 681);
            this.pGender2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pGender2.Name = "pGender2";
            this.pGender2.Size = new System.Drawing.Size(92, 25);
            this.pGender2.TabIndex = 43;
            // 
            // pCountryCodeTB
            // 
            this.pCountryCodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pCountryCodeTB.Location = new System.Drawing.Point(698, 674);
            this.pCountryCodeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCountryCodeTB.MaximumSize = new System.Drawing.Size(54, 0);
            this.pCountryCodeTB.MinimumSize = new System.Drawing.Size(54, 0);
            this.pCountryCodeTB.Name = "pCountryCodeTB";
            this.pCountryCodeTB.Size = new System.Drawing.Size(54, 25);
            this.pCountryCodeTB.TabIndex = 44;
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.BackColor = System.Drawing.Color.Maroon;
            this.addPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPatientBtn.Location = new System.Drawing.Point(56, 205);
            this.addPatientBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Size = new System.Drawing.Size(218, 54);
            this.addPatientBtn.TabIndex = 45;
            this.addPatientBtn.Text = "Add Patient";
            this.addPatientBtn.UseVisualStyleBackColor = false;
            this.addPatientBtn.Click += new System.EventHandler(this.addPatientBtn_Click);
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Enabled = false;
            this.patientIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdTextBox.Location = new System.Drawing.Point(382, 738);
            this.patientIdTextBox.MaximumSize = new System.Drawing.Size(76, 35);
            this.patientIdTextBox.MinimumSize = new System.Drawing.Size(54, 35);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(54, 23);
            this.patientIdTextBox.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(316, 694);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "(without \'-\')";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(356, 743);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 24);
            this.label16.TabIndex = 49;
            this.label16.Text = "ID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(317, 729);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 40);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(1200, 63);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(297, 31);
            this.label17.TabIndex = 51;
            this.label17.Text = "Incharge: receptionist";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1167, 63);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 41);
            this.pictureBox4.TabIndex = 69;
            this.pictureBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(56, 658);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 53);
            this.button2.TabIndex = 78;
            this.button2.Text = "Add treatment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // updatePatientUserCotroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private Label label15;
        private Label label16;
        private PictureBox pictureBox2;
        private Label label17;
        private PictureBox pictureBox4;
        private Button button2;
    }
}
