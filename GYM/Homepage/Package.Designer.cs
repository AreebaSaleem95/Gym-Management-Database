namespace Homepage
{
    partial class Package
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Package));
            this.label_decription = new System.Windows.Forms.Label();
            this.textBox_decription = new System.Windows.Forms.TextBox();
            this.label_error_descrip = new System.Windows.Forms.Label();
            this.label_error_duration = new System.Windows.Forms.Label();
            this.label_duration = new System.Windows.Forms.Label();
            this.label_error_price = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_search_package = new System.Windows.Forms.Button();
            this.comboBox_duration = new System.Windows.Forms.ComboBox();
            this.label_error_category = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_decription
            // 
            this.label_decription.AutoSize = true;
            this.label_decription.BackColor = System.Drawing.Color.Transparent;
            this.label_decription.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_decription.ForeColor = System.Drawing.Color.White;
            this.label_decription.Location = new System.Drawing.Point(29, 55);
            this.label_decription.Name = "label_decription";
            this.label_decription.Size = new System.Drawing.Size(146, 35);
            this.label_decription.TabIndex = 63;
            this.label_decription.Text = "Description";
            // 
            // textBox_decription
            // 
            this.textBox_decription.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_decription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_decription.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_decription.Location = new System.Drawing.Point(192, 58);
            this.textBox_decription.Name = "textBox_decription";
            this.textBox_decription.Size = new System.Drawing.Size(499, 32);
            this.textBox_decription.TabIndex = 1;
            this.textBox_decription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_decription.Leave += new System.EventHandler(this.textBox_decription_Leave);
            // 
            // label_error_descrip
            // 
            this.label_error_descrip.AutoSize = true;
            this.label_error_descrip.BackColor = System.Drawing.Color.White;
            this.label_error_descrip.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_error_descrip.ForeColor = System.Drawing.Color.Red;
            this.label_error_descrip.Location = new System.Drawing.Point(666, 60);
            this.label_error_descrip.Name = "label_error_descrip";
            this.label_error_descrip.Size = new System.Drawing.Size(25, 29);
            this.label_error_descrip.TabIndex = 65;
            this.label_error_descrip.Text = "*";
            this.label_error_descrip.Visible = false;
            // 
            // label_error_duration
            // 
            this.label_error_duration.AutoSize = true;
            this.label_error_duration.BackColor = System.Drawing.Color.Transparent;
            this.label_error_duration.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_error_duration.ForeColor = System.Drawing.Color.Red;
            this.label_error_duration.Location = new System.Drawing.Point(697, 136);
            this.label_error_duration.Name = "label_error_duration";
            this.label_error_duration.Size = new System.Drawing.Size(25, 29);
            this.label_error_duration.TabIndex = 68;
            this.label_error_duration.Text = "*";
            this.label_error_duration.Visible = false;
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.BackColor = System.Drawing.Color.Transparent;
            this.label_duration.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duration.ForeColor = System.Drawing.Color.White;
            this.label_duration.Location = new System.Drawing.Point(29, 132);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(115, 35);
            this.label_duration.TabIndex = 66;
            this.label_duration.Text = "Duration";
            // 
            // label_error_price
            // 
            this.label_error_price.AutoSize = true;
            this.label_error_price.BackColor = System.Drawing.Color.White;
            this.label_error_price.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_error_price.ForeColor = System.Drawing.Color.Red;
            this.label_error_price.Location = new System.Drawing.Point(666, 209);
            this.label_error_price.Name = "label_error_price";
            this.label_error_price.Size = new System.Drawing.Size(25, 29);
            this.label_error_price.TabIndex = 71;
            this.label_error_price.Text = "*";
            this.label_error_price.Visible = false;
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_price.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price.Location = new System.Drawing.Point(192, 207);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(499, 32);
            this.textBox_price.TabIndex = 3;
            this.textBox_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_price.TextChanged += new System.EventHandler(this.textBox_price_TextChanged);
            this.textBox_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_price_KeyDown);
            this.textBox_price.Leave += new System.EventHandler(this.textBox_price_Leave);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.Transparent;
            this.label_price.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.Color.White;
            this.label_price.Location = new System.Drawing.Point(29, 204);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(71, 35);
            this.label_price.TabIndex = 69;
            this.label_price.Text = "Price";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(510, 390);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(184, 54);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            this.button_save.Enter += new System.EventHandler(this.button_save_Enter);
            this.button_save.Leave += new System.EventHandler(this.button_save_Leave);
            this.button_save.MouseEnter += new System.EventHandler(this.button_save_MouseEnter);
            this.button_save.MouseLeave += new System.EventHandler(this.button_save_MouseLeave);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_reset.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.White;
            this.button_reset.Location = new System.Drawing.Point(305, 390);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(184, 54);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            this.button_reset.Enter += new System.EventHandler(this.button_reset_Enter);
            this.button_reset.Leave += new System.EventHandler(this.button_reset_Leave);
            this.button_reset.MouseEnter += new System.EventHandler(this.button_reset_MouseEnter);
            this.button_reset.MouseLeave += new System.EventHandler(this.button_reset_MouseLeave);
            // 
            // button_search_package
            // 
            this.button_search_package.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_search_package.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_search_package.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search_package.ForeColor = System.Drawing.Color.White;
            this.button_search_package.Location = new System.Drawing.Point(99, 390);
            this.button_search_package.Name = "button_search_package";
            this.button_search_package.Size = new System.Drawing.Size(184, 54);
            this.button_search_package.TabIndex = 7;
            this.button_search_package.Text = "Search";
            this.button_search_package.UseVisualStyleBackColor = false;
            this.button_search_package.Click += new System.EventHandler(this.button_search_package_Click);
            this.button_search_package.Enter += new System.EventHandler(this.button_search_package_Enter);
            this.button_search_package.Leave += new System.EventHandler(this.button_search_package_Leave);
            this.button_search_package.MouseEnter += new System.EventHandler(this.button_search_package_MouseEnter);
            this.button_search_package.MouseLeave += new System.EventHandler(this.button_search_package_MouseLeave);
            // 
            // comboBox_duration
            // 
            this.comboBox_duration.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_duration.FormattingEnabled = true;
            this.comboBox_duration.Items.AddRange(new object[] {
            "1Month",
            "2Month",
            "3Month",
            "4Month",
            "5Month",
            "6Month",
            "7Month",
            "8Month",
            "9Month",
            "10Month",
            "11Month",
            "12Month"});
            this.comboBox_duration.Location = new System.Drawing.Point(192, 132);
            this.comboBox_duration.Name = "comboBox_duration";
            this.comboBox_duration.Size = new System.Drawing.Size(499, 32);
            this.comboBox_duration.TabIndex = 2;
            this.comboBox_duration.Text = "                                   Select Duration";
            this.comboBox_duration.Enter += new System.EventHandler(this.comboBox_duration_Enter);
            this.comboBox_duration.Leave += new System.EventHandler(this.comboBox_duration_Leave);
            // 
            // label_error_category
            // 
            this.label_error_category.AutoSize = true;
            this.label_error_category.BackColor = System.Drawing.Color.Transparent;
            this.label_error_category.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_error_category.ForeColor = System.Drawing.Color.Red;
            this.label_error_category.Location = new System.Drawing.Point(697, 284);
            this.label_error_category.Name = "label_error_category";
            this.label_error_category.Size = new System.Drawing.Size(25, 29);
            this.label_error_category.TabIndex = 74;
            this.label_error_category.Text = "*";
            this.label_error_category.Visible = false;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.BackColor = System.Drawing.Color.Transparent;
            this.label_category.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.ForeColor = System.Drawing.Color.White;
            this.label_category.Location = new System.Drawing.Point(29, 275);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(117, 35);
            this.label_category.TabIndex = 73;
            this.label_category.Text = "Category";
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Items.AddRange(new object[] {
            "Student",
            "Non Student"});
            this.comboBox_category.Location = new System.Drawing.Point(192, 281);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(499, 32);
            this.comboBox_category.TabIndex = 4;
            this.comboBox_category.Text = "                                   Select Category";
            this.comboBox_category.Enter += new System.EventHandler(this.comboBox_category_Enter);
            this.comboBox_category.Leave += new System.EventHandler(this.comboBox_category_Leave);
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homepage.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 520);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.label_error_category);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.comboBox_duration);
            this.Controls.Add(this.button_search_package);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_error_price);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_error_duration);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.label_error_descrip);
            this.Controls.Add(this.textBox_decription);
            this.Controls.Add(this.label_decription);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Package";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_decription;
        public System.Windows.Forms.TextBox textBox_decription;
        private System.Windows.Forms.Label label_error_descrip;
        private System.Windows.Forms.Label label_error_duration;
        private System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.Label label_error_price;
        public System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_search_package;
        private System.Windows.Forms.ComboBox comboBox_duration;
        private System.Windows.Forms.Label label_error_category;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ComboBox comboBox_category;
    }
}