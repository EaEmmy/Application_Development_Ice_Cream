namespace FinalProject
{
    partial class ContactUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUs));
            this.informationGroupBox = new System.Windows.Forms.GroupBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactUsLabel = new System.Windows.Forms.Label();
            this.informationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationGroupBox
            // 
            resources.ApplyResources(this.informationGroupBox, "informationGroupBox");
            this.informationGroupBox.Controls.Add(this.hoursLabel);
            this.informationGroupBox.Controls.Add(this.emailLabel);
            this.informationGroupBox.Controls.Add(this.phoneNumberLabel);
            this.informationGroupBox.Controls.Add(this.addressLabel);
            this.informationGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.informationGroupBox.Name = "informationGroupBox";
            this.informationGroupBox.TabStop = false;
            // 
            // hoursLabel
            // 
            resources.ApplyResources(this.hoursLabel, "hoursLabel");
            this.hoursLabel.Name = "hoursLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // phoneNumberLabel
            // 
            resources.ApplyResources(this.phoneNumberLabel, "phoneNumberLabel");
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addressLabel.Name = "addressLabel";
            // 
            // contactUsLabel
            // 
            resources.ApplyResources(this.contactUsLabel, "contactUsLabel");
            this.contactUsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.contactUsLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.contactUsLabel.ForeColor = System.Drawing.Color.White;
            this.contactUsLabel.Name = "contactUsLabel";
            // 
            // ContactUs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.informationGroupBox);
            this.Controls.Add(this.contactUsLabel);
            this.Name = "ContactUs";
            this.informationGroupBox.ResumeLayout(false);
            this.informationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox informationGroupBox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactUsLabel;
    }
}