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
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(1424, 689);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(177, 29);
            label3.TabIndex = 26;
            label3.Text = "Fathers Name";
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
            // 
            // pfirstNameTB
            // 
            this.pfirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfirstNameTB.Location = new System.Drawing.Point(559, 683);
            this.pfirstNameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pfirstNameTB.MaximumSize = new System.Drawing.Size(351, 35);
            this.pfirstNameTB.MinimumSize = new System.Drawing.Size(351, 35);
            this.pfirstNameTB.Name = "pfirstNameTB";
            this.pfirstNameTB.Size = new System.Drawing.Size(351, 27);
            this.pfirstNameTB.TabIndex = 8;
            // 
            // plastNameTB
            // 
            this.plastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plastNameTB.Location = new System.Drawing.Point(1061, 683);
            this.plastNameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plastNameTB.MaximumSize = new System.Drawing.Size(351, 35);
            this.plastNameTB.MinimumSize = new System.Drawing.Size(351, 35);
            this.plastNameTB.Name = "plastNameTB";
            this.plastNameTB.Size = new System.Drawing.Size(351, 27);
            this.plastNameTB.TabIndex = 9;
            // 
            // pfatherNameTB
            // 
            this.pfatherNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfatherNameTB.Location = new System.Drawing.Point(1607, 681);
            this.pfatherNameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pfatherNameTB.MaximumSize = new System.Drawing.Size(351, 35);
            this.pfatherNameTB.MinimumSize = new System.Drawing.Size(351, 35);
            this.pfatherNameTB.Name = "pfatherNameTB";
            this.pfatherNameTB.Size = new System.Drawing.Size(351, 27);
            this.pfatherNameTB.TabIndex = 10;
            this.pfatherNameTB.TextChanged += new System.EventHandler(this.pfatherNameTB_TextChanged);
            // 
            // pstreetTB
            // 
            this.pstreetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pstreetTB.Location = new System.Drawing.Point(1858, 753);
            this.pstreetTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pstreetTB.MaximumSize = new System.Drawing.Size(100, 35);
            this.pstreetTB.MinimumSize = new System.Drawing.Size(100, 35);
            this.pstreetTB.Name = "pstreetTB";
            this.pstreetTB.Size = new System.Drawing.Size(100, 27);
            this.pstreetTB.TabIndex = 12;
            this.pstreetTB.TextChanged += new System.EventHandler(this.pstreetTB_TextChanged);
            // 
            // pBlockTB
            // 
            this.pBlockTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBlockTB.Location = new System.Drawing.Point(1560, 761);
            this.pBlockTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBlockTB.Name = "pBlockTB";
            this.pBlockTB.Size = new System.Drawing.Size(111, 27);
            this.pBlockTB.TabIndex = 13;
            // 
            // pPhonenumTB
            // 
            this.pPhonenumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPhonenumTB.Location = new System.Drawing.Point(1247, 834);
            this.pPhonenumTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pPhonenumTB.MaximumSize = new System.Drawing.Size(249, 35);
            this.pPhonenumTB.MinimumSize = new System.Drawing.Size(249, 35);
            this.pPhonenumTB.Name = "pPhonenumTB";
            this.pPhonenumTB.Size = new System.Drawing.Size(249, 27);
            this.pPhonenumTB.TabIndex = 14;
            // 
            // pCityTB
            // 
            this.pCityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCityTB.Location = new System.Drawing.Point(1247, 756);
            this.pCityTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pCityTB.MaximumSize = new System.Drawing.Size(200, 35);
            this.pCityTB.MinimumSize = new System.Drawing.Size(200, 35);
            this.pCityTB.Name = "pCityTB";
            this.pCityTB.Size = new System.Drawing.Size(200, 27);
            this.pCityTB.TabIndex = 15;
            this.pCityTB.TextChanged += new System.EventHandler(this.pCityTB_TextChanged_1);
            // 
            // pAgeTB
            // 
            this.pAgeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAgeTB.Location = new System.Drawing.Point(682, 755);
            this.pAgeTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pAgeTB.MaximumSize = new System.Drawing.Size(100, 35);
            this.pAgeTB.MinimumSize = new System.Drawing.Size(100, 35);
            this.pAgeTB.Name = "pAgeTB";
            this.pAgeTB.Size = new System.Drawing.Size(100, 27);
            this.pAgeTB.TabIndex = 17;
            this.pAgeTB.TextChanged += new System.EventHandler(this.pAgeTB_TextChanged);
            // 
            // pCountryTB
            // 
            this.pCountryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCountryTB.Location = new System.Drawing.Point(940, 755);
            this.pCountryTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pCountryTB.MaximumSize = new System.Drawing.Size(200, 35);
            this.pCountryTB.MinimumSize = new System.Drawing.Size(200, 35);
            this.pCountryTB.Name = "pCountryTB";
            this.pCountryTB.Size = new System.Drawing.Size(200, 27);
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
            this.addPatientGridView.Location = new System.Drawing.Point(423, 202);
            this.addPatientGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPatientGridView.Name = "addPatientGridView";
            this.addPatientGridView.RowHeadersWidth = 51;
            this.addPatientGridView.RowTemplate.Height = 24;
            this.addPatientGridView.Size = new System.Drawing.Size(1535, 450);
            this.addPatientGridView.TabIndex = 20;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Maroon;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateButton.Location = new System.Drawing.Point(1799, 810);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(159, 65);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 129);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.N.Location = new System.Drawing.Point(419, 689);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(141, 29);
            this.N.TabIndex = 24;
            this.N.Text = "First Name";
            this.N.Click += new System.EventHandler(this.N_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(916, 687);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1528, 837);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1476, 761);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Block";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(832, 757);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(617, 761);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Age";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(419, 825);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "CNIC";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(419, 764);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "DOB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(1184, 761);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 29);
            this.label11.TabIndex = 34;
            this.label11.Text = "City";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(757, 830);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 29);
            this.label12.TabIndex = 35;
            this.label12.Text = "Country code";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(1041, 830);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 29);
            this.label13.TabIndex = 36;
            this.label13.Text = "Phone Number";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pCNIC
            // 
            this.pCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCNIC.Location = new System.Drawing.Point(495, 829);
            this.pCNIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pCNIC.MaximumSize = new System.Drawing.Size(249, 35);
            this.pCNIC.MaxLength = 13;
            this.pCNIC.MinimumSize = new System.Drawing.Size(249, 35);
            this.pCNIC.Name = "pCNIC";
            this.pCNIC.Size = new System.Drawing.Size(249, 27);
            this.pCNIC.TabIndex = 37;
            // 
            // pDOBTB
            // 
            this.pDOBTB.CustomFormat = "MM/dd/yyyy";
            this.pDOBTB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pDOBTB.Location = new System.Drawing.Point(493, 759);
            this.pDOBTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDOBTB.MaximumSize = new System.Drawing.Size(100, 35);
            this.pDOBTB.MinimumSize = new System.Drawing.Size(100, 35);
            this.pDOBTB.Name = "pDOBTB";
            this.pDOBTB.Size = new System.Drawing.Size(100, 35);
            this.pDOBTB.TabIndex = 38;
            this.pDOBTB.ValueChanged += new System.EventHandler(this.pDOBTB_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1043, 859);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "(without \'-\')";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(1698, 757);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 29);
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
            this.pGender2.Location = new System.Drawing.Point(1634, 838);
            this.pGender2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pGender2.Name = "pGender2";
            this.pGender2.Size = new System.Drawing.Size(121, 28);
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
            this.pCountryCodeTB.Location = new System.Drawing.Point(930, 829);
            this.pCountryCodeTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pCountryCodeTB.MaximumSize = new System.Drawing.Size(70, 0);
            this.pCountryCodeTB.MinimumSize = new System.Drawing.Size(70, 0);
            this.pCountryCodeTB.Name = "pCountryCodeTB";
            this.pCountryCodeTB.Size = new System.Drawing.Size(70, 28);
            this.pCountryCodeTB.TabIndex = 44;
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
            this.patientIdTextBox.Location = new System.Drawing.Point(510, 908);
            this.patientIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.patientIdTextBox.MaximumSize = new System.Drawing.Size(100, 35);
            this.patientIdTextBox.MinimumSize = new System.Drawing.Size(70, 35);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(70, 27);
            this.patientIdTextBox.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(421, 854);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 16);
            this.label15.TabIndex = 48;
            this.label15.Text = "(without \'-\')";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(474, 914);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 29);
            this.label16.TabIndex = 49;
            this.label16.Text = "ID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(423, 897);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // updatePatientUserCotroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2000, 1100);
            this.MinimumSize = new System.Drawing.Size(2000, 1100);
            this.Name = "updatePatientUserCotroller";
            this.Size = new System.Drawing.Size(2000, 1100);
            this.Load += new System.EventHandler(this.updatePatientUserCotroller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}
