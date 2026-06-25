namespace Homepage
{
    partial class SearchPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPackage));
            this.label_clear = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_searchpackage = new System.Windows.Forms.TextBox();
            this.label_searchpackage = new System.Windows.Forms.Label();
            this.dataGridView_package = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_total_packages = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_package)).BeginInit();
            this.SuspendLayout();
            // 
            // label_clear
            // 
            this.label_clear.AutoSize = true;
            this.label_clear.BackColor = System.Drawing.Color.Transparent;
            this.label_clear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clear.ForeColor = System.Drawing.Color.White;
            this.label_clear.Location = new System.Drawing.Point(886, 156);
            this.label_clear.Name = "label_clear";
            this.label_clear.Size = new System.Drawing.Size(50, 24);
            this.label_clear.TabIndex = 25;
            this.label_clear.Text = "clear\r\n";
            this.label_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_clear.Visible = false;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.White;
            this.button_clear.BackgroundImage = global::Homepage.Properties.Resources.black_cross;
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(875, 86);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(67, 67);
            this.button_clear.TabIndex = 4;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            this.button_clear.Enter += new System.EventHandler(this.button_clear_Enter);
            this.button_clear.Leave += new System.EventHandler(this.button_clear_Leave);
            this.button_clear.MouseEnter += new System.EventHandler(this.button_clear_MouseEnter);
            this.button_clear.MouseLeave += new System.EventHandler(this.button_clear_MouseLeave);
            // 
            // textBox_searchpackage
            // 
            this.textBox_searchpackage.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_searchpackage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_searchpackage.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchpackage.Location = new System.Drawing.Point(194, 47);
            this.textBox_searchpackage.Name = "textBox_searchpackage";
            this.textBox_searchpackage.Size = new System.Drawing.Size(656, 32);
            this.textBox_searchpackage.TabIndex = 0;
            this.textBox_searchpackage.Text = "By Description";
            this.textBox_searchpackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_searchpackage.TextChanged += new System.EventHandler(this.textBox_searchpackage_TextChanged);
            this.textBox_searchpackage.Enter += new System.EventHandler(this.textBox_searchpackage_Enter);
            this.textBox_searchpackage.Leave += new System.EventHandler(this.textBox_searchpackage_Leave);
            // 
            // label_searchpackage
            // 
            this.label_searchpackage.AutoSize = true;
            this.label_searchpackage.BackColor = System.Drawing.Color.Transparent;
            this.label_searchpackage.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_searchpackage.ForeColor = System.Drawing.Color.White;
            this.label_searchpackage.Location = new System.Drawing.Point(12, 47);
            this.label_searchpackage.Name = "label_searchpackage";
            this.label_searchpackage.Size = new System.Drawing.Size(180, 35);
            this.label_searchpackage.TabIndex = 26;
            this.label_searchpackage.Text = "By Description";
            // 
            // dataGridView_package
            // 
            this.dataGridView_package.AllowUserToAddRows = false;
            this.dataGridView_package.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_package.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_package.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.category,
            this.duration});
            this.dataGridView_package.Location = new System.Drawing.Point(12, 215);
            this.dataGridView_package.Name = "dataGridView_package";
            this.dataGridView_package.RowTemplate.Height = 28;
            this.dataGridView_package.Size = new System.Drawing.Size(956, 366);
            this.dataGridView_package.TabIndex = 27;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "PackageName";
            this.name.HeaderText = "Description";
            this.name.Name = "name";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "kategory";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // duration
            // 
            this.duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duration.DataPropertyName = "Duration";
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(758, 614);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(184, 45);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_min
            // 
            this.textBox_min.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_min.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_min.Location = new System.Drawing.Point(194, 103);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(255, 32);
            this.textBox_min.TabIndex = 1;
            this.textBox_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_min.TextChanged += new System.EventHandler(this.textBox_min_TextChanged);
            // 
            // textBox_max
            // 
            this.textBox_max.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_max.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_max.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_max.Location = new System.Drawing.Point(609, 103);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(241, 32);
            this.textBox_max.TabIndex = 2;
            this.textBox_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_max.TextChanged += new System.EventHandler(this.textBox_max_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 35);
            this.label1.TabIndex = 31;
            this.label1.Text = "By Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(469, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 32;
            this.label2.Text = "between";
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Items.AddRange(new object[] {
            "Student",
            "Non Student"});
            this.comboBox_category.Location = new System.Drawing.Point(194, 159);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(656, 32);
            this.comboBox_category.TabIndex = 3;
            this.comboBox_category.TextChanged += new System.EventHandler(this.comboBox_category_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 35);
            this.label3.TabIndex = 34;
            this.label3.Text = "By Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 35);
            this.label4.TabIndex = 35;
            this.label4.Text = "Total Packages";
            // 
            // textBox_total_packages
            // 
            this.textBox_total_packages.BackColor = System.Drawing.Color.Gray;
            this.textBox_total_packages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_total_packages.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total_packages.Location = new System.Drawing.Point(194, 622);
            this.textBox_total_packages.Name = "textBox_total_packages";
            this.textBox_total_packages.ReadOnly = true;
            this.textBox_total_packages.Size = new System.Drawing.Size(521, 35);
            this.textBox_total_packages.TabIndex = 36;
            this.textBox_total_packages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 671);
            this.Controls.Add(this.textBox_total_packages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView_package);
            this.Controls.Add(this.label_searchpackage);
            this.Controls.Add(this.label_clear);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_searchpackage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package Record";
            this.Activated += new System.EventHandler(this.SearchPackage_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_package)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_clear;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_searchpackage;
        private System.Windows.Forms.Label label_searchpackage;
        private System.Windows.Forms.DataGridView dataGridView_package;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_total_packages;
    }
}