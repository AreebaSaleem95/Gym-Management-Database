namespace Homepage
{
    partial class MemberFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberFee));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_gymno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_package = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_total_amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_amount_paid = new System.Windows.Forms.TextBox();
            this.dateTimePicker_paid_date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button_submit_fees = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_member = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_father_name = new System.Windows.Forms.TextBox();
            this.textBox_remaining_dues = new System.Windows.Forms.TextBox();
            this.textBox_served_by = new System.Windows.Forms.TextBox();
            this.label_errorgymno = new System.Windows.Forms.Label();
            this.label_error_amount_paid = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter GymNo";
            // 
            // textBox_gymno
            // 
            this.textBox_gymno.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_gymno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_gymno.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_gymno.Location = new System.Drawing.Point(251, 45);
            this.textBox_gymno.MaxLength = 9;
            this.textBox_gymno.Name = "textBox_gymno";
            this.textBox_gymno.Size = new System.Drawing.Size(829, 32);
            this.textBox_gymno.TabIndex = 0;
            this.textBox_gymno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_gymno.TextChanged += new System.EventHandler(this.textBox_gymno_TextChanged);
            this.textBox_gymno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_gymno_KeyDown);
            this.textBox_gymno.Leave += new System.EventHandler(this.textBox_gymno_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "Billing Date";
            // 
            // textBox_package
            // 
            this.textBox_package.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_package.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_package.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_package.ForeColor = System.Drawing.Color.Black;
            this.textBox_package.Location = new System.Drawing.Point(251, 248);
            this.textBox_package.Name = "textBox_package";
            this.textBox_package.ReadOnly = true;
            this.textBox_package.Size = new System.Drawing.Size(829, 35);
            this.textBox_package.TabIndex = 29;
            this.textBox_package.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(571, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 35);
            this.label6.TabIndex = 32;
            this.label6.Text = "Total Amount";
            // 
            // textBox_total_amount
            // 
            this.textBox_total_amount.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_total_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_total_amount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total_amount.ForeColor = System.Drawing.Color.Black;
            this.textBox_total_amount.Location = new System.Drawing.Point(748, 428);
            this.textBox_total_amount.Name = "textBox_total_amount";
            this.textBox_total_amount.ReadOnly = true;
            this.textBox_total_amount.Size = new System.Drawing.Size(332, 35);
            this.textBox_total_amount.TabIndex = 33;
            this.textBox_total_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 35);
            this.label7.TabIndex = 34;
            this.label7.Text = "Amount Paid";
            // 
            // textBox_amount_paid
            // 
            this.textBox_amount_paid.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_amount_paid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_amount_paid.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_amount_paid.Location = new System.Drawing.Point(251, 515);
            this.textBox_amount_paid.MaxLength = 9;
            this.textBox_amount_paid.Name = "textBox_amount_paid";
            this.textBox_amount_paid.Size = new System.Drawing.Size(310, 32);
            this.textBox_amount_paid.TabIndex = 2;
            this.textBox_amount_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_amount_paid.TextChanged += new System.EventHandler(this.textBox_amount_paid_TextChanged);
            this.textBox_amount_paid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_amount_paid_KeyDown);
            this.textBox_amount_paid.Leave += new System.EventHandler(this.textBox_amount_paid_Leave);
            // 
            // dateTimePicker_paid_date
            // 
            this.dateTimePicker_paid_date.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_paid_date.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_paid_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_paid_date.Location = new System.Drawing.Point(251, 338);
            this.dateTimePicker_paid_date.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_paid_date.Name = "dateTimePicker_paid_date";
            this.dateTimePicker_paid_date.Size = new System.Drawing.Size(310, 32);
            this.dateTimePicker_paid_date.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(571, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 35);
            this.label9.TabIndex = 1;
            this.label9.Text = "Served By";
            // 
            // button_submit_fees
            // 
            this.button_submit_fees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_submit_fees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_submit_fees.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_fees.ForeColor = System.Drawing.Color.White;
            this.button_submit_fees.Location = new System.Drawing.Point(896, 595);
            this.button_submit_fees.Name = "button_submit_fees";
            this.button_submit_fees.Size = new System.Drawing.Size(184, 68);
            this.button_submit_fees.TabIndex = 4;
            this.button_submit_fees.Text = "Save";
            this.button_submit_fees.UseVisualStyleBackColor = false;
            this.button_submit_fees.Click += new System.EventHandler(this.button_submit_fees_Click);
            this.button_submit_fees.Enter += new System.EventHandler(this.button_submit_fees_Enter);
            this.button_submit_fees.Leave += new System.EventHandler(this.button_submit_fees_Leave);
            this.button_submit_fees.MouseEnter += new System.EventHandler(this.button_submit_fees_MouseEnter);
            this.button_submit_fees.MouseLeave += new System.EventHandler(this.button_submit_fees_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 35);
            this.label4.TabIndex = 28;
            this.label4.Text = "Package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 35);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name";
            // 
            // textBox_member
            // 
            this.textBox_member.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_member.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_member.ForeColor = System.Drawing.Color.Black;
            this.textBox_member.Location = new System.Drawing.Point(251, 161);
            this.textBox_member.Name = "textBox_member";
            this.textBox_member.ReadOnly = true;
            this.textBox_member.Size = new System.Drawing.Size(310, 35);
            this.textBox_member.TabIndex = 36;
            this.textBox_member.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(569, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 70);
            this.label5.TabIndex = 37;
            this.label5.Text = "Remaining\r\nDues";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(569, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 35);
            this.label10.TabIndex = 39;
            this.label10.Text = "Father name";
            // 
            // textBox_father_name
            // 
            this.textBox_father_name.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_father_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_father_name.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_father_name.ForeColor = System.Drawing.Color.Black;
            this.textBox_father_name.Location = new System.Drawing.Point(748, 161);
            this.textBox_father_name.Name = "textBox_father_name";
            this.textBox_father_name.ReadOnly = true;
            this.textBox_father_name.Size = new System.Drawing.Size(332, 35);
            this.textBox_father_name.TabIndex = 40;
            this.textBox_father_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_remaining_dues
            // 
            this.textBox_remaining_dues.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_remaining_dues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_remaining_dues.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_remaining_dues.ForeColor = System.Drawing.Color.Black;
            this.textBox_remaining_dues.Location = new System.Drawing.Point(748, 335);
            this.textBox_remaining_dues.Name = "textBox_remaining_dues";
            this.textBox_remaining_dues.ReadOnly = true;
            this.textBox_remaining_dues.Size = new System.Drawing.Size(332, 35);
            this.textBox_remaining_dues.TabIndex = 41;
            this.textBox_remaining_dues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_served_by
            // 
            this.textBox_served_by.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_served_by.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_served_by.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_served_by.Location = new System.Drawing.Point(748, 514);
            this.textBox_served_by.MaxLength = 9;
            this.textBox_served_by.Name = "textBox_served_by";
            this.textBox_served_by.Size = new System.Drawing.Size(332, 32);
            this.textBox_served_by.TabIndex = 3;
            this.textBox_served_by.Text = "ADMIN";
            this.textBox_served_by.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_errorgymno
            // 
            this.label_errorgymno.AutoSize = true;
            this.label_errorgymno.BackColor = System.Drawing.Color.White;
            this.label_errorgymno.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_errorgymno.ForeColor = System.Drawing.Color.Red;
            this.label_errorgymno.Location = new System.Drawing.Point(1055, 47);
            this.label_errorgymno.Name = "label_errorgymno";
            this.label_errorgymno.Size = new System.Drawing.Size(25, 29);
            this.label_errorgymno.TabIndex = 43;
            this.label_errorgymno.Text = "*";
            this.label_errorgymno.Visible = false;
            // 
            // label_error_amount_paid
            // 
            this.label_error_amount_paid.AutoSize = true;
            this.label_error_amount_paid.BackColor = System.Drawing.Color.White;
            this.label_error_amount_paid.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_error_amount_paid.ForeColor = System.Drawing.Color.Red;
            this.label_error_amount_paid.Location = new System.Drawing.Point(536, 517);
            this.label_error_amount_paid.Name = "label_error_amount_paid";
            this.label_error_amount_paid.Size = new System.Drawing.Size(25, 29);
            this.label_error_amount_paid.TabIndex = 44;
            this.label_error_amount_paid.Text = "*";
            this.label_error_amount_paid.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(48, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 35);
            this.label8.TabIndex = 46;
            this.label8.Text = "Package Price";
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_price.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price.ForeColor = System.Drawing.Color.Black;
            this.textBox_price.Location = new System.Drawing.Point(251, 426);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(310, 35);
            this.textBox_price.TabIndex = 47;
            this.textBox_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MemberFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homepage.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 708);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_error_amount_paid);
            this.Controls.Add(this.label_errorgymno);
            this.Controls.Add(this.textBox_served_by);
            this.Controls.Add(this.textBox_remaining_dues);
            this.Controls.Add(this.textBox_father_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_member);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_submit_fees);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker_paid_date);
            this.Controls.Add(this.textBox_amount_paid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_total_amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_package);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_gymno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEE";
            this.Activated += new System.EventHandler(this.MemberFee_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_gymno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_package;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_total_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_amount_paid;
        public System.Windows.Forms.DateTimePicker dateTimePicker_paid_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_submit_fees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_member;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_father_name;
        private System.Windows.Forms.TextBox textBox_remaining_dues;
        private System.Windows.Forms.TextBox textBox_served_by;
        private System.Windows.Forms.Label label_errorgymno;
        private System.Windows.Forms.Label label_error_amount_paid;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_price;
    }
}