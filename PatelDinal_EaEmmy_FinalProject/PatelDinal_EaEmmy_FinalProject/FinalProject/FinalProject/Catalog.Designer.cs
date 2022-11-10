namespace FinalProject
{
    partial class Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.catalogLabel = new System.Windows.Forms.Label();
            this.catalogPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.catalogPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // previousButton
            // 
            resources.ApplyResources(this.previousButton, "previousButton");
            this.previousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.previousButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.previousButton.Name = "previousButton";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            resources.ApplyResources(this.nextButton, "nextButton");
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nextButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.nextButton.Name = "nextButton";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // catalogLabel
            // 
            resources.ApplyResources(this.catalogLabel, "catalogLabel");
            this.catalogLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.catalogLabel.ForeColor = System.Drawing.Color.White;
            this.catalogLabel.Name = "catalogLabel";
            // 
            // catalogPictureBox
            // 
            resources.ApplyResources(this.catalogPictureBox, "catalogPictureBox");
            this.catalogPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catalogPictureBox.Name = "catalogPictureBox";
            this.catalogPictureBox.TabStop = false;
            this.catalogPictureBox.Click += new System.EventHandler(this.catalogPictureBox_Click);
            // 
            // Catalog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.catalogLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.catalogPictureBox);
            this.Name = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.catalogPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox catalogPictureBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label catalogLabel;
    }
}