namespace Homepage
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
            this.pictureBox_contact_us = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_contact_us)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_contact_us
            // 
            this.pictureBox_contact_us.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_contact_us.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_contact_us.Image = global::Homepage.Properties.Resources.background;
            this.pictureBox_contact_us.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_contact_us.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_contact_us.Name = "pictureBox_contact_us";
            this.pictureBox_contact_us.Size = new System.Drawing.Size(705, 487);
            this.pictureBox_contact_us.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_contact_us.TabIndex = 0;
            this.pictureBox_contact_us.TabStop = false;
            // 
            // ContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(705, 487);
            this.Controls.Add(this.pictureBox_contact_us);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContactUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactUs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_contact_us)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_contact_us;
    }
}