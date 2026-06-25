namespace Homepage
{
    partial class SearchMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMember));
            this.textBox_searchmember_name = new System.Windows.Forms.TextBox();
            this.label_clear = new System.Windows.Forms.Label();
            this.dataGridView_members = new System.Windows.Forms.DataGridView();
            this.memberid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_ress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofjoining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightFT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_searchmember = new System.Windows.Forms.Label();
            this.textBox_searchmember_gymno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_members)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_searchmember_name
            // 
            this.textBox_searchmember_name.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_searchmember_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_searchmember_name.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchmember_name.Location = new System.Drawing.Point(1057, 40);
            this.textBox_searchmember_name.Name = "textBox_searchmember_name";
            this.textBox_searchmember_name.Size = new System.Drawing.Size(622, 32);
            this.textBox_searchmember_name.TabIndex = 2;
            this.textBox_searchmember_name.Text = "Enter Name";
            this.textBox_searchmember_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_searchmember_name.TextChanged += new System.EventHandler(this.textBox_searchmember_TextChanged);
            this.textBox_searchmember_name.Enter += new System.EventHandler(this.textBox_searchmember_Enter);
            this.textBox_searchmember_name.Leave += new System.EventHandler(this.textBox_searchmember_Leave);
            // 
            // label_clear
            // 
            this.label_clear.AutoSize = true;
            this.label_clear.BackColor = System.Drawing.Color.Transparent;
            this.label_clear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clear.ForeColor = System.Drawing.Color.White;
            this.label_clear.Location = new System.Drawing.Point(1751, 30);
            this.label_clear.Name = "label_clear";
            this.label_clear.Size = new System.Drawing.Size(64, 48);
            this.label_clear.TabIndex = 22;
            this.label_clear.Text = "clear\r\nsearch";
            this.label_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_clear.Visible = false;
            // 
            // dataGridView_members
            // 
            this.dataGridView_members.AllowUserToAddRows = false;
            this.dataGridView_members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_members.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_members.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberid,
            this.membername,
            this.fathername,
            this.contactno,
            this.add_ress,
            this.dateofjoining,
            this.gender,
            this.admissionfee,
            this.category,
            this.purpose,
            this.weigh,
            this.heightFT,
            this.heightIN,
            this.package});
            this.dataGridView_members.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_members.Location = new System.Drawing.Point(12, 97);
            this.dataGridView_members.Name = "dataGridView_members";
            this.dataGridView_members.RowTemplate.Height = 28;
            this.dataGridView_members.Size = new System.Drawing.Size(1803, 511);
            this.dataGridView_members.TabIndex = 5;
            // 
            // memberid
            // 
            this.memberid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.memberid.DataPropertyName = "MemberID";
            this.memberid.HeaderText = "Gym No";
            this.memberid.Name = "memberid";
            this.memberid.Width = 50;
            // 
            // membername
            // 
            this.membername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.membername.DataPropertyName = "MemberName";
            this.membername.HeaderText = "Name";
            this.membername.Name = "membername";
            // 
            // fathername
            // 
            this.fathername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fathername.DataPropertyName = "FatherName";
            this.fathername.HeaderText = "FatherName";
            this.fathername.Name = "fathername";
            // 
            // contactno
            // 
            this.contactno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactno.DataPropertyName = "Contactno";
            this.contactno.HeaderText = "Contact No";
            this.contactno.Name = "contactno";
            // 
            // add_ress
            // 
            this.add_ress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.add_ress.DataPropertyName = "Add_ress";
            this.add_ress.HeaderText = "Address";
            this.add_ress.Name = "add_ress";
            // 
            // dateofjoining
            // 
            this.dateofjoining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateofjoining.DataPropertyName = "DateOfJoining";
            this.dateofjoining.HeaderText = "Date Of Joining";
            this.dateofjoining.Name = "dateofjoining";
            this.dateofjoining.Width = 80;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gender.DataPropertyName = "Gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.Width = 60;
            // 
            // admissionfee
            // 
            this.admissionfee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admissionfee.DataPropertyName = "Admissionfee";
            this.admissionfee.HeaderText = "Admissionfee";
            this.admissionfee.Name = "admissionfee";
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.category.DataPropertyName = "Category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // purpose
            // 
            this.purpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.purpose.DataPropertyName = "Purpose";
            this.purpose.HeaderText = "Purpose";
            this.purpose.Name = "purpose";
            this.purpose.Width = 60;
            // 
            // weigh
            // 
            this.weigh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.weigh.DataPropertyName = "Weigh";
            this.weigh.HeaderText = "Weight";
            this.weigh.Name = "weigh";
            this.weigh.Width = 50;
            // 
            // heightFT
            // 
            this.heightFT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.heightFT.DataPropertyName = "HeightFT";
            this.heightFT.HeaderText = "Height FT";
            this.heightFT.Name = "heightFT";
            this.heightFT.Width = 60;
            // 
            // heightIN
            // 
            this.heightIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.heightIN.DataPropertyName = "HeightIN";
            this.heightIN.HeaderText = "Height IN";
            this.heightIN.Name = "heightIN";
            this.heightIN.Width = 60;
            // 
            // package
            // 
            this.package.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.package.DataPropertyName = "PackageName";
            this.package.HeaderText = "Package Type";
            this.package.Name = "package";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(1622, 614);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(184, 61);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            this.button_delete.Enter += new System.EventHandler(this.button_delete_Enter);
            this.button_delete.Leave += new System.EventHandler(this.button_delete_Leave);
            this.button_delete.MouseEnter += new System.EventHandler(this.button_delete_MouseEnter);
            this.button_delete.MouseLeave += new System.EventHandler(this.button_delete_MouseLeave);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(1413, 614);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(184, 61);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            this.button_update.Enter += new System.EventHandler(this.button_update_Enter);
            this.button_update.Leave += new System.EventHandler(this.button_update_Leave);
            this.button_update.MouseEnter += new System.EventHandler(this.button_update_MouseEnter);
            this.button_update.MouseLeave += new System.EventHandler(this.button_update_MouseLeave);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.White;
            this.button_clear.BackgroundImage = global::Homepage.Properties.Resources.black_cross;
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(1703, 28);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(47, 50);
            this.button_clear.TabIndex = 5;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            this.button_clear.MouseEnter += new System.EventHandler(this.button_clear_MouseEnter);
            this.button_clear.MouseLeave += new System.EventHandler(this.button_clear_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(919, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 35);
            this.label1.TabIndex = 24;
            this.label1.Text = "By Name";
            // 
            // label_searchmember
            // 
            this.label_searchmember.AutoSize = true;
            this.label_searchmember.BackColor = System.Drawing.Color.Transparent;
            this.label_searchmember.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_searchmember.ForeColor = System.Drawing.Color.White;
            this.label_searchmember.Location = new System.Drawing.Point(58, 37);
            this.label_searchmember.Name = "label_searchmember";
            this.label_searchmember.Size = new System.Drawing.Size(141, 35);
            this.label_searchmember.TabIndex = 0;
            this.label_searchmember.Text = "By Gym No";
            // 
            // textBox_searchmember_gymno
            // 
            this.textBox_searchmember_gymno.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_searchmember_gymno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_searchmember_gymno.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchmember_gymno.Location = new System.Drawing.Point(223, 40);
            this.textBox_searchmember_gymno.Name = "textBox_searchmember_gymno";
            this.textBox_searchmember_gymno.Size = new System.Drawing.Size(674, 32);
            this.textBox_searchmember_gymno.TabIndex = 0;
            this.textBox_searchmember_gymno.Text = "Enter Gym no";
            this.textBox_searchmember_gymno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_searchmember_gymno.TextChanged += new System.EventHandler(this.textBox_searchmember_gymno_TextChanged);
            this.textBox_searchmember_gymno.Enter += new System.EventHandler(this.textBox_searchmember_gymno_Enter);
            this.textBox_searchmember_gymno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_searchmember_gymno_KeyDown);
            this.textBox_searchmember_gymno.Leave += new System.EventHandler(this.textBox_searchmember_gymno_Leave);
            // 
            // SearchMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_searchmember_gymno);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView_members);
            this.Controls.Add(this.label_clear);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_searchmember);
            this.Controls.Add(this.textBox_searchmember_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members Record";
            this.Activated += new System.EventHandler(this.SearchMember_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_members)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_searchmember_name;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_clear;
        private System.Windows.Forms.DataGridView dataGridView_members;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberid;
        private System.Windows.Forms.DataGridViewTextBoxColumn membername;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_ress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofjoining;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn weigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightFT;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn package;
        private System.Windows.Forms.Label label_searchmember;
        private System.Windows.Forms.TextBox textBox_searchmember_gymno;
    }
}