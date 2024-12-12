namespace Clinic_Management_System
{
    partial class prescriptionDetails
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
            this.prescriptiondetailgridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptiondetailgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // prescriptiondetailgridview
            // 
            this.prescriptiondetailgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptiondetailgridview.Location = new System.Drawing.Point(257, 62);
            this.prescriptiondetailgridview.Name = "prescriptiondetailgridview";
            this.prescriptiondetailgridview.Size = new System.Drawing.Size(577, 321);
            this.prescriptiondetailgridview.TabIndex = 0;
           
            // 
            // prescriptionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prescriptiondetailgridview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1500, 894);
            this.MinimumSize = new System.Drawing.Size(1500, 894);
            this.Name = "prescriptionDetails";
            this.Size = new System.Drawing.Size(1500, 894);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptiondetailgridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView prescriptiondetailgridview;
    }
}
