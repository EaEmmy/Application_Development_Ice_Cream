namespace FinalProject
{
    partial class Calendar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.outputLabel = new System.Windows.Forms.Label();
            this.EstimatedPickUpTime = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.Label();
            this.pickUpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            resources.ApplyResources(this.outputLabel, "outputLabel");
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Name = "outputLabel";
            // 
            // EstimatedPickUpTime
            // 
            resources.ApplyResources(this.EstimatedPickUpTime, "EstimatedPickUpTime");
            this.EstimatedPickUpTime.Name = "EstimatedPickUpTime";
            // 
            // orderDate
            // 
            resources.ApplyResources(this.orderDate, "orderDate");
            this.orderDate.Name = "orderDate";
            // 
            // pickUpDateTimePicker
            // 
            resources.ApplyResources(this.pickUpDateTimePicker, "pickUpDateTimePicker");
            this.pickUpDateTimePicker.Name = "pickUpDateTimePicker";
            this.pickUpDateTimePicker.ValueChanged += new System.EventHandler(this.pickUpDateTimePicker_ValueChanged);
            // 
            // calendarLabel
            // 
            resources.ApplyResources(this.calendarLabel, "calendarLabel");
            this.calendarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.calendarLabel.ForeColor = System.Drawing.Color.White;
            this.calendarLabel.Name = "calendarLabel";
            // 
            // Calendar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.EstimatedPickUpTime);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.pickUpDateTimePicker);
            this.Name = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label EstimatedPickUpTime;
        private System.Windows.Forms.Label orderDate;
        private System.Windows.Forms.DateTimePicker pickUpDateTimePicker;
        private System.Windows.Forms.Label calendarLabel;
    }
}