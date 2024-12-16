using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    partial class addTreatment
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addTreatment));
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.viewPatientButton = new System.Windows.Forms.Button();
            this.cancelAppointmentButton = new System.Windows.Forms.Button();
            this.viewAppointmentButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.addPatientGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addPatientBtn = new System.Windows.Forms.Button();
            this.treatmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.treatmentptname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genBill = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Black;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(450, 683);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 29);
            label3.TabIndex = 26;
            label3.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(1187, 736);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(186, 29);
            label2.TabIndex = 85;
            label2.Text = "Follow up date";
            // 
            // updatePatientButton
            // 
            this.updatePatientButton.BackColor = System.Drawing.Color.Maroon;
            this.updatePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatePatientButton.Location = new System.Drawing.Point(75, 325);
            this.updatePatientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(241, 69);
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
            this.viewPatientButton.Location = new System.Drawing.Point(75, 422);
            this.viewPatientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewPatientButton.Name = "viewPatientButton";
            this.viewPatientButton.Size = new System.Drawing.Size(241, 73);
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
            this.cancelAppointmentButton.Location = new System.Drawing.Point(75, 615);
            this.cancelAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelAppointmentButton.Name = "cancelAppointmentButton";
            this.cancelAppointmentButton.Size = new System.Drawing.Size(241, 71);
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
            this.viewAppointmentButton.Location = new System.Drawing.Point(75, 706);
            this.viewAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewAppointmentButton.Name = "viewAppointmentButton";
            this.viewAppointmentButton.Size = new System.Drawing.Size(241, 75);
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
            this.addAppointmentButton.Location = new System.Drawing.Point(75, 521);
            this.addAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(241, 70);
            this.addAppointmentButton.TabIndex = 7;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.addPatientGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.addPatientGridView.Location = new System.Drawing.Point(601, 233);
            this.addPatientGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPatientGridView.Name = "addPatientGridView";
            this.addPatientGridView.RowHeadersWidth = 51;
            this.addPatientGridView.RowTemplate.Height = 24;
            this.addPatientGridView.Size = new System.Drawing.Size(1091, 418);
            this.addPatientGridView.TabIndex = 20;
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
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(450, 736);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "Treatment Type";
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.BackColor = System.Drawing.Color.Maroon;
            this.addPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPatientBtn.Location = new System.Drawing.Point(75, 233);
            this.addPatientBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Size = new System.Drawing.Size(241, 76);
            this.addPatientBtn.TabIndex = 45;
            this.addPatientBtn.Text = "Add Patient";
            this.addPatientBtn.UseVisualStyleBackColor = false;
            this.addPatientBtn.Click += new System.EventHandler(this.addPatientBtn_Click);
            // 
            // treatmentTypeComboBox
            // 
            this.treatmentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.treatmentTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentTypeComboBox.FormattingEnabled = true;
            this.treatmentTypeComboBox.Items.AddRange(new object[] {
            "consultation",
            "consultation & treatment"});
            this.treatmentTypeComboBox.Location = new System.Drawing.Point(654, 736);
            this.treatmentTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treatmentTypeComboBox.MaximumSize = new System.Drawing.Size(300, 0);
            this.treatmentTypeComboBox.MinimumSize = new System.Drawing.Size(300, 0);
            this.treatmentTypeComboBox.Name = "treatmentTypeComboBox";
            this.treatmentTypeComboBox.Size = new System.Drawing.Size(300, 28);
            this.treatmentTypeComboBox.TabIndex = 54;
            // 
            // treatmentptname
            // 
            this.treatmentptname.Enabled = false;
            this.treatmentptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentptname.Location = new System.Drawing.Point(1071, 686);
            this.treatmentptname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treatmentptname.Name = "treatmentptname";
            this.treatmentptname.Size = new System.Drawing.Size(79, 27);
            this.treatmentptname.TabIndex = 61;
            this.treatmentptname.TextChanged += new System.EventHandler(this.treatmentptname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(859, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Appointmnet  id";
            // 
            // genBill
            // 
            this.genBill.BackColor = System.Drawing.Color.Maroon;
            this.genBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genBill.Location = new System.Drawing.Point(1636, 788);
            this.genBill.Margin = new System.Windows.Forms.Padding(4);
            this.genBill.Name = "genBill";
            this.genBill.Size = new System.Drawing.Size(229, 61);
            this.genBill.TabIndex = 66;
            this.genBill.Text = "show preview";
            this.genBill.UseVisualStyleBackColor = false;
            this.genBill.Click += new System.EventHandler(this.genBill_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(1553, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 38);
            this.label5.TabIndex = 67;
            this.label5.Text = "Incharge: receptionist";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(75, 804);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 69);
            this.button2.TabIndex = 78;
            this.button2.Text = "Add prescribtion";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1330, 788);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 61);
            this.button1.TabIndex = 79;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1637, 682);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 27);
            this.textBox2.TabIndex = 81;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(1330, 682);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 27);
            this.textBox4.TabIndex = 83;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1379, 741);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 27);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(601, 811);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 24);
            this.comboBox1.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1187, 682);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 87;
            this.label4.Text = "doctor fee";
            this.label4.Click += new System.EventHandler(this.label4_Click_2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1478, 682);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 29);
            this.label9.TabIndex = 90;
            this.label9.Text = "Booked by";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(449, 804);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 29);
            this.label6.TabIndex = 91;
            this.label6.Text = "booked for ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(546, 687);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 22);
            this.textBox1.TabIndex = 92;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Black;
            this.checkBox1.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(1018, 739);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 26);
            this.checkBox1.TabIndex = 93;
            this.checkBox1.Text = "follow up";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(120, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 37);
            this.label7.TabIndex = 97;
            this.label7.Text = "mediAid";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 123);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(377, 1233);
            this.pictureBox5.TabIndex = 95;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(158, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(2200, 160);
            this.pictureBox6.TabIndex = 98;
            this.pictureBox6.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Black;
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.Location = new System.Drawing.Point(1462, 49);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(67, 62);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 99;
            this.profilePicture.TabStop = false;
            // 
            // addTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treatmentptname);
            this.Controls.Add(this.treatmentTypeComboBox);
            this.Controls.Add(this.addPatientBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(label3);
            this.Controls.Add(this.addPatientGridView);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.viewAppointmentButton);
            this.Controls.Add(this.cancelAppointmentButton);
            this.Controls.Add(this.viewPatientButton);
            this.Controls.Add(this.updatePatientButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2200, 1100);
            this.MinimumSize = new System.Drawing.Size(2200, 1100);
            this.Name = "addTreatment";
            this.Size = new System.Drawing.Size(2200, 1100);
            this.Load += new System.EventHandler(this.addTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPatientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        // Array of gender options
        string[] genderOptions = { "Male", "Female", "Others" };
        private System.Windows.Forms.Button addPatientBtn;
        private ComboBox treatmentTypeComboBox;
        private TextBox treatmentptname;
        private Label label1;
        private Button genBill;
        private Label label5;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label9;
        private Label label6;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox profilePicture;
    }
}
