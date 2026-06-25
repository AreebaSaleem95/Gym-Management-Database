namespace Homepage
{
    partial class FrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.button_members = new System.Windows.Forms.Button();
            this.button_contact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_members
            // 
            this.button_members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_members.FlatAppearance.BorderSize = 0;
            this.button_members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_members.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_members.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_members.Location = new System.Drawing.Point(293, 55);
            this.button_members.Name = "button_members";
            this.button_members.Size = new System.Drawing.Size(335, 234);
            this.button_members.TabIndex = 1;
            this.button_members.Text = "Members";
            this.button_members.UseVisualStyleBackColor = false;
            this.button_members.Click += new System.EventHandler(this.button_members_Click);
            this.button_members.MouseEnter += new System.EventHandler(this.button_members_MouseEnter);
            this.button_members.MouseLeave += new System.EventHandler(this.button_members_MouseLeave);
            // 
            // button_contact
            // 
            this.button_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_contact.FlatAppearance.BorderSize = 0;
            this.button_contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contact.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_contact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_contact.Location = new System.Drawing.Point(293, 372);
            this.button_contact.Name = "button_contact";
            this.button_contact.Size = new System.Drawing.Size(335, 234);
            this.button_contact.TabIndex = 4;
            this.button_contact.Text = "Contact Us";
            this.button_contact.UseVisualStyleBackColor = false;
            this.button_contact.Click += new System.EventHandler(this.button_contact_Click);
            this.button_contact.MouseEnter += new System.EventHandler(this.button_contact_MouseEnter);
            this.button_contact.MouseLeave += new System.EventHandler(this.button_contact_MouseLeave);
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homepage.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 679);
            this.Controls.Add(this.button_contact);
            this.Controls.Add(this.button_members);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrontPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_members;
        private System.Windows.Forms.Button button_contact;
    }
}