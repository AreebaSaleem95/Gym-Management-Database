namespace Homepage
{
    partial class SearchMemberFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMemberFee));
            this.textBox_gymno = new System.Windows.Forms.TextBox();
            this.dateTimePicker_second = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_first = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_fee = new System.Windows.Forms.DataGridView();
            this.memberid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingdues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_searchmember = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_net_income = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_pending_fee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fee)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_gymno
            // 
            this.textBox_gymno.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_gymno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_gymno.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_gymno.Location = new System.Drawing.Point(185, 36);
            this.textBox_gymno.MaxLength = 9;
            this.textBox_gymno.Name = "textBox_gymno";
            this.textBox_gymno.Size = new System.Drawing.Size(624, 32);
            this.textBox_gymno.TabIndex = 0;
            this.textBox_gymno.Text = "Enter Gym no";
            this.textBox_gymno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_gymno.TextChanged += new System.EventHandler(this.textBox_gymno_TextChanged);
            this.textBox_gymno.Enter += new System.EventHandler(this.textBox_gymno_Enter);
            this.textBox_gymno.Leave += new System.EventHandler(this.textBox_gymno_Leave);
            // 
            // dateTimePicker_second
            // 
            this.dateTimePicker_second.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_second.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_second.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_second.Location = new System.Drawing.Point(185, 242);
            this.dateTimePicker_second.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_second.Name = "dateTimePicker_second";
            this.dateTimePicker_second.Size = new System.Drawing.Size(624, 32);
            this.dateTimePicker_second.TabIndex = 2;
            this.dateTimePicker_second.ValueChanged += new System.EventHandler(this.dateTimePicker_second_ValueChanged);
            // 
            // dateTimePicker_first
            // 
            this.dateTimePicker_first.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_first.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_first.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_first.Location = new System.Drawing.Point(185, 154);
            this.dateTimePicker_first.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_first.Name = "dateTimePicker_first";
            this.dateTimePicker_first.Size = new System.Drawing.Size(624, 32);
            this.dateTimePicker_first.TabIndex = 1;
            this.dateTimePicker_first.ValueChanged += new System.EventHandler(this.dateTimePicker_first_ValueChanged);
            // 
            // dataGridView_fee
            // 
            this.dataGridView_fee.AllowUserToAddRows = false;
            this.dataGridView_fee.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_fee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberid,
            this.datePaid,
            this.amountPaid,
            this.remainingdues,
            this.package,
            this.duration,
            this.servedBy,
            this.feeid});
            this.dataGridView_fee.Location = new System.Drawing.Point(33, 414);
            this.dataGridView_fee.Name = "dataGridView_fee";
            this.dataGridView_fee.RowTemplate.Height = 28;
            this.dataGridView_fee.Size = new System.Drawing.Size(1065, 386);
            this.dataGridView_fee.TabIndex = 36;
            this.dataGridView_fee.TabStop = false;
            // 
            // memberid
            // 
            this.memberid.DataPropertyName = "MemberID";
            this.memberid.HeaderText = "Gym No";
            this.memberid.Name = "memberid";
            this.memberid.Width = 50;
            // 
            // datePaid
            // 
            this.datePaid.DataPropertyName = "Date_fee_paid";
            this.datePaid.HeaderText = "Date Paid";
            this.datePaid.Name = "datePaid";
            this.datePaid.Width = 70;
            // 
            // amountPaid
            // 
            this.amountPaid.DataPropertyName = "Amount_paid";
            this.amountPaid.HeaderText = "Amount Paid";
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.Width = 80;
            // 
            // remainingdues
            // 
            this.remainingdues.DataPropertyName = "Remaining_dues";
            this.remainingdues.HeaderText = "Remaining Dues";
            this.remainingdues.Name = "remainingdues";
            // 
            // package
            // 
            this.package.DataPropertyName = "PackageName";
            this.package.HeaderText = "Package";
            this.package.Name = "package";
            this.package.Width = 130;
            // 
            // duration
            // 
            this.duration.DataPropertyName = "Duration";
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            this.duration.Width = 80;
            // 
            // servedBy
            // 
            this.servedBy.DataPropertyName = "Served_by";
            this.servedBy.HeaderText = "Served By";
            this.servedBy.Name = "servedBy";
            this.servedBy.Width = 80;
            // 
            // feeid
            // 
            this.feeid.DataPropertyName = "FeeID";
            this.feeid.HeaderText = "Invoice No";
            this.feeid.Name = "feeid";
            // 
            // label_searchmember
            // 
            this.label_searchmember.AutoSize = true;
            this.label_searchmember.BackColor = System.Drawing.Color.Transparent;
            this.label_searchmember.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_searchmember.ForeColor = System.Drawing.Color.White;
            this.label_searchmember.Location = new System.Drawing.Point(27, 33);
            this.label_searchmember.Name = "label_searchmember";
            this.label_searchmember.Size = new System.Drawing.Size(141, 35);
            this.label_searchmember.TabIndex = 2;
            this.label_searchmember.Text = "By Gym No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 37;
            this.label1.Text = "By Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(912, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 35);
            this.label3.TabIndex = 38;
            this.label3.Text = "Net Income";
            // 
            // textBox_net_income
            // 
            this.textBox_net_income.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_net_income.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_net_income.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_net_income.Location = new System.Drawing.Point(875, 151);
            this.textBox_net_income.Name = "textBox_net_income";
            this.textBox_net_income.Size = new System.Drawing.Size(223, 35);
            this.textBox_net_income.TabIndex = 39;
            this.textBox_net_income.TabStop = false;
            this.textBox_net_income.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(881, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 35);
            this.label4.TabIndex = 40;
            this.label4.Text = "Net Pending Fee\'s";
            // 
            // textBox_pending_fee
            // 
            this.textBox_pending_fee.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_pending_fee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_pending_fee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pending_fee.Location = new System.Drawing.Point(875, 277);
            this.textBox_pending_fee.Name = "textBox_pending_fee";
            this.textBox_pending_fee.Size = new System.Drawing.Size(223, 35);
            this.textBox_pending_fee.TabIndex = 41;
            this.textBox_pending_fee.TabStop = false;
            this.textBox_pending_fee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(179, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 35);
            this.label5.TabIndex = 43;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(179, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 35);
            this.label6.TabIndex = 44;
            this.label6.Text = "Till";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(33, 355);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(292, 53);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Delete Fee Record";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            this.button_update.Enter += new System.EventHandler(this.button_update_Enter);
            this.button_update.Leave += new System.EventHandler(this.button_update_Leave);
            this.button_update.MouseEnter += new System.EventHandler(this.button_update_MouseEnter);
            this.button_update.MouseLeave += new System.EventHandler(this.button_update_MouseLeave);
            // 
            // SearchMemberFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1120, 855);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_pending_fee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_net_income);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_fee);
            this.Controls.Add(this.dateTimePicker_first);
            this.Controls.Add(this.dateTimePicker_second);
            this.Controls.Add(this.textBox_gymno);
            this.Controls.Add(this.label_searchmember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchMemberFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fee Record";
            this.Activated += new System.EventHandler(this.SearchMemberFee_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_gymno;
        private System.Windows.Forms.DateTimePicker dateTimePicker_second;
        private System.Windows.Forms.DateTimePicker dateTimePicker_first;
        private System.Windows.Forms.DataGridView dataGridView_fee;
        private System.Windows.Forms.Label label_searchmember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_net_income;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_pending_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberid;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingdues;
        private System.Windows.Forms.DataGridViewTextBoxColumn package;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn servedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_update;
    }
}