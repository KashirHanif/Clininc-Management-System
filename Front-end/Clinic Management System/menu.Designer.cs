namespace Clinic_Management_System
{
    partial class menu
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
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPatient.Location = new System.Drawing.Point(249, 200);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(292, 72);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "PATIENT";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDoctors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDoctors.Location = new System.Drawing.Point(249, 302);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(292, 77);
            this.btnDoctors.TabIndex = 1;
            this.btnDoctors.Text = "DOCTORS";
            this.btnDoctors.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnInventory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInventory.Location = new System.Drawing.Point(249, 405);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(292, 68);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReports.Location = new System.Drawing.Point(249, 498);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(292, 74);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "REPORTS ";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnDoctors);
            this.Controls.Add(this.btnPatient);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "menu";
            this.Size = new System.Drawing.Size(802, 647);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label label1;
    }
}
