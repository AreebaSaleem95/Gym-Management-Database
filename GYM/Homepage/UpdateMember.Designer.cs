namespace Homepage
{
    partial class UpdateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMember));
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_errorpackage = new System.Windows.Forms.Label();
            this.label_errorcategory = new System.Windows.Forms.Label();
            this.label_errorname = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.dateTimePicker_dateofjoining = new System.Windows.Forms.DateTimePicker();
            this.label_dateofjoining = new System.Windows.Forms.Label();
            this.comboBox_selecttrainer = new System.Windows.Forms.ComboBox();
            this.label_trainer = new System.Windows.Forms.Label();
            this.textBox_admissionfee = new System.Windows.Forms.TextBox();
            this.label_admissionfee = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.textBox_gymno = new System.Windows.Forms.TextBox();
            this.label_gymno = new System.Windows.Forms.Label();
            this.comboBox_package = new System.Windows.Forms.ComboBox();
            this.label_package = new System.Windows.Forms.Label();
            this.textBox_purpose = new System.Windows.Forms.TextBox();
            this.label_purpose = new System.Windows.Forms.Label();
            this.textBox_height_in = new System.Windows.Forms.TextBox();
            this.textBox_height_ft = new System.Windows.Forms.TextBox();
            this.label_height = new System.Windows.Forms.Label();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.label_weight = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.label_contact = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_fathername = new System.Windows.Forms.TextBox();
            this.label_fathername = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Items.AddRange(new object[] {
            "Student",
            "Non Student"});
            this.comboBox_category.Location = new System.Drawing.Point(787, 73);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(424, 32);
            this.comboBox_category.TabIndex = 1;
            this.comboBox_category.Text = "                             Select Category";
            this.comboBox_category.Enter += new System.EventHandler(this.comboBox_category_Enter);
            this.comboBox_category.Leave += new System.EventHandler(this.comboBox_category_Leave);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(787, 536);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(424, 32);
            this.comboBox_gender.TabIndex = 14;
            this.comboBox_gender.Text = "                             Select Gender";
            this.comboBox_gender.Enter += new System.EventHandler(this.comboBox_gender_Enter);
            this.comboBox_gender.Leave += new System.EventHandler(this.comboBox_gender_Leave);
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.BackColor = System.Drawing.Color.Transparent;
            this.label_gender.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.ForeColor = System.Drawing.Color.White;
            this.label_gender.Location = new System.Drawing.Point(621, 533);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(101, 35);
            this.label_gender.TabIndex = 52;
            this.label_gender.Text = "Gender";
            // 
            // label_errorpackage
            // 
            this.label_errorpackage.AutoSize = true;
            this.label_errorpackage.BackColor = System.Drawing.Color.Transparent;
            this.label_errorpackage.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_errorpackage.ForeColor = System.Drawing.Color.Red;
            this.label_errorpackage.Location = new System.Drawing.Point(732, 391);
            this.label_errorpackage.Name = "label_errorpackage";
            this.label_errorpackage.Size = new System.Drawing.Size(25, 29);
            this.label_errorpackage.TabIndex = 61;
            this.label_errorpackage.Text = "*";
            this.label_errorpackage.Visible = false;
            // 
            // label_errorcategory
            // 
            this.label_errorcategory.AutoSize = true;
            this.label_errorcategory.BackColor = System.Drawing.Color.Transparent;
            this.label_errorcategory.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_errorcategory.ForeColor = System.Drawing.Color.Red;
            this.label_errorcategory.Location = new System.Drawing.Point(737, 76);
            this.label_errorcategory.Name = "label_errorcategory";
            this.label_errorcategory.Size = new System.Drawing.Size(25, 29);
            this.label_errorcategory.TabIndex = 60;
            this.label_errorcategory.Text = "*";
            this.label_errorcategory.Visible = false;
            // 
            // label_errorname
            // 
            this.label_errorname.AutoSize = true;
            this.label_errorname.BackColor = System.Drawing.Color.White;
            this.label_errorname.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_errorname.ForeColor = System.Drawing.Color.Red;
            this.label_errorname.Location = new System.Drawing.Point(511, 146);
            this.label_errorname.Name = "label_errorname";
            this.label_errorname.Size = new System.Drawing.Size(25, 29);
            this.label_errorname.TabIndex = 59;
            this.label_errorname.Text = "*";
            this.label_errorname.Visible = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(995, 629);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(184, 68);
            this.button_update.TabIndex = 15;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            this.button_update.Enter += new System.EventHandler(this.button_update_Enter);
            this.button_update.Leave += new System.EventHandler(this.button_update_Leave);
            this.button_update.MouseEnter += new System.EventHandler(this.button_update_MouseEnter);
            this.button_update.MouseLeave += new System.EventHandler(this.button_update_MouseLeave);
            // 
            // dateTimePicker_dateofjoining
            // 
            this.dateTimePicker_dateofjoining.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_dateofjoining.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_dateofjoining.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateofjoining.Location = new System.Drawing.Point(215, 533);
            this.dateTimePicker_dateofjoining.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_dateofjoining.Name = "dateTimePicker_dateofjoining";
            this.dateTimePicker_dateofjoining.Size = new System.Drawing.Size(325, 32);
            this.dateTimePicker_dateofjoining.TabIndex = 13;
            // 
            // label_dateofjoining
            // 
            this.label_dateofjoining.AutoSize = true;
            this.label_dateofjoining.BackColor = System.Drawing.Color.Transparent;
            this.label_dateofjoining.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateofjoining.ForeColor = System.Drawing.Color.White;
            this.label_dateofjoining.Location = new System.Drawing.Point(26, 530);
            this.label_dateofjoining.Name = "label_dateofjoining";
            this.label_dateofjoining.Size = new System.Drawing.Size(183, 35);
            this.label_dateofjoining.TabIndex = 57;
            this.label_dateofjoining.Text = "Date of Joining";
            // 
            // comboBox_selecttrainer
            // 
            this.comboBox_selecttrainer.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selecttrainer.FormattingEnabled = true;
            this.comboBox_selecttrainer.Items.AddRange(new object[] {
            "Public-Trainer",
            "Personal-Trainer Cbum",
            "Personal-Trainer Arnold",
            "Personal-Trainer Noel Dyzel"});
            this.comboBox_selecttrainer.Location = new System.Drawing.Point(787, 461);
            this.comboBox_selecttrainer.Name = "comboBox_selecttrainer";
            this.comboBox_selecttrainer.Size = new System.Drawing.Size(424, 32);
            this.comboBox_selecttrainer.TabIndex = 12;
            this.comboBox_selecttrainer.Text = "                             Select Trainer";
            this.comboBox_selecttrainer.Enter += new System.EventHandler(this.comboBox_selecttrainer_Enter);
            this.comboBox_selecttrainer.Leave += new System.EventHandler(this.comboBox_selecttrainer_Leave);
            // 
            // label_trainer
            // 
            this.label_trainer.AutoSize = true;
            this.label_trainer.BackColor = System.Drawing.Color.Transparent;
            this.label_trainer.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trainer.ForeColor = System.Drawing.Color.White;
            this.label_trainer.Location = new System.Drawing.Point(621, 452);
            this.label_trainer.Name = "label_trainer";
            this.label_trainer.Size = new System.Drawing.Size(94, 35);
            this.label_trainer.TabIndex = 55;
            this.label_trainer.Text = "Trainer";
            // 
            // textBox_admissionfee
            // 
            this.textBox_admissionfee.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_admissionfee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_admissionfee.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_admissionfee.Location = new System.Drawing.Point(215, 458);
            this.textBox_admissionfee.Name = "textBox_admissionfee";
            this.textBox_admissionfee.Size = new System.Drawing.Size(325, 32);
            this.textBox_admissionfee.TabIndex = 11;
            this.textBox_admissionfee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_admissionfee.TextChanged += new System.EventHandler(this.textBox_admissionfee_TextChanged);
            this.textBox_admissionfee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_admissionfee_KeyDown);
            // 
            // label_admissionfee
            // 
            this.label_admissionfee.AutoSize = true;
            this.label_admissionfee.BackColor = System.Drawing.Color.Transparent;
            this.label_admissionfee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admissionfee.ForeColor = System.Drawing.Color.White;
            this.label_admissionfee.Location = new System.Drawing.Point(30, 456);
            this.label_admissionfee.Name = "label_admissionfee";
            this.label_admissionfee.Size = new System.Drawing.Size(179, 35);
            this.label_admissionfee.TabIndex = 53;
            this.label_admissionfee.Text = "Admission Fee";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.BackColor = System.Drawing.Color.Transparent;
            this.label_category.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.ForeColor = System.Drawing.Color.White;
            this.label_category.Location = new System.Drawing.Point(620, 66);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(117, 35);
            this.label_category.TabIndex = 50;
            this.label_category.Text = "Category";
            // 
            // textBox_gymno
            // 
            this.textBox_gymno.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_gymno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_gymno.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_gymno.Location = new System.Drawing.Point(215, 69);
            this.textBox_gymno.Name = "textBox_gymno";
            this.textBox_gymno.ReadOnly = true;
            this.textBox_gymno.Size = new System.Drawing.Size(323, 32);
            this.textBox_gymno.TabIndex = 29;
            this.textBox_gymno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_gymno.TextChanged += new System.EventHandler(this.textBox_gymno_TextChanged);
            this.textBox_gymno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_gymno_KeyDown);
            // 
            // label_gymno
            // 
            this.label_gymno.AutoSize = true;
            this.label_gymno.BackColor = System.Drawing.Color.Transparent;
            this.label_gymno.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gymno.ForeColor = System.Drawing.Color.White;
            this.label_gymno.Location = new System.Drawing.Point(26, 66);
            this.label_gymno.Name = "label_gymno";
            this.label_gymno.Size = new System.Drawing.Size(104, 35);
            this.label_gymno.TabIndex = 48;
            this.label_gymno.Text = "Gym no";
            // 
            // comboBox_package
            // 
            this.comboBox_package.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_package.FormattingEnabled = true;
            this.comboBox_package.Location = new System.Drawing.Point(787, 385);
            this.comboBox_package.Name = "comboBox_package";
            this.comboBox_package.Size = new System.Drawing.Size(424, 32);
            this.comboBox_package.TabIndex = 10;
            this.comboBox_package.Text = "                             Select Package";
            this.comboBox_package.Leave += new System.EventHandler(this.comboBox_package_Leave);
            // 
            // label_package
            // 
            this.label_package.AutoSize = true;
            this.label_package.BackColor = System.Drawing.Color.Transparent;
            this.label_package.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_package.ForeColor = System.Drawing.Color.White;
            this.label_package.Location = new System.Drawing.Point(620, 380);
            this.label_package.Name = "label_package";
            this.label_package.Size = new System.Drawing.Size(106, 35);
            this.label_package.TabIndex = 45;
            this.label_package.Text = "Package";
            // 
            // textBox_purpose
            // 
            this.textBox_purpose.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_purpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_purpose.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_purpose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_purpose.Location = new System.Drawing.Point(215, 385);
            this.textBox_purpose.Name = "textBox_purpose";
            this.textBox_purpose.Size = new System.Drawing.Size(325, 32);
            this.textBox_purpose.TabIndex = 9;
            this.textBox_purpose.Text = "bulk | cut | fitness";
            this.textBox_purpose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_purpose.Enter += new System.EventHandler(this.textBox_purpose_Enter);
            this.textBox_purpose.Leave += new System.EventHandler(this.textBox_purpose_Leave);
            // 
            // label_purpose
            // 
            this.label_purpose.AutoSize = true;
            this.label_purpose.BackColor = System.Drawing.Color.Transparent;
            this.label_purpose.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_purpose.ForeColor = System.Drawing.Color.White;
            this.label_purpose.Location = new System.Drawing.Point(26, 385);
            this.label_purpose.Name = "label_purpose";
            this.label_purpose.Size = new System.Drawing.Size(109, 35);
            this.label_purpose.TabIndex = 41;
            this.label_purpose.Text = "Purpose";
            // 
            // textBox_height_in
            // 
            this.textBox_height_in.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_height_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_height_in.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_height_in.Location = new System.Drawing.Point(1015, 306);
            this.textBox_height_in.Name = "textBox_height_in";
            this.textBox_height_in.Size = new System.Drawing.Size(196, 32);
            this.textBox_height_in.TabIndex = 8;
            this.textBox_height_in.Text = "in";
            this.textBox_height_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_height_in.TextChanged += new System.EventHandler(this.textBox_height_in_TextChanged);
            this.textBox_height_in.Enter += new System.EventHandler(this.textBox_height_in_Enter);
            this.textBox_height_in.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_height_in_KeyDown);
            this.textBox_height_in.Leave += new System.EventHandler(this.textBox_height_in_Leave);
            // 
            // textBox_height_ft
            // 
            this.textBox_height_ft.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_height_ft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_height_ft.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_height_ft.Location = new System.Drawing.Point(787, 306);
            this.textBox_height_ft.Name = "textBox_height_ft";
            this.textBox_height_ft.Size = new System.Drawing.Size(196, 32);
            this.textBox_height_ft.TabIndex = 7;
            this.textBox_height_ft.Text = "ft";
            this.textBox_height_ft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_height_ft.TextChanged += new System.EventHandler(this.textBox_height_ft_TextChanged);
            this.textBox_height_ft.Enter += new System.EventHandler(this.textBox_height_ft_Enter);
            this.textBox_height_ft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_height_ft_KeyDown);
            this.textBox_height_ft.Leave += new System.EventHandler(this.textBox_height_ft_Leave);
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.BackColor = System.Drawing.Color.Transparent;
            this.label_height.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_height.ForeColor = System.Drawing.Color.White;
            this.label_height.Location = new System.Drawing.Point(620, 306);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(89, 35);
            this.label_height.TabIndex = 38;
            this.label_height.Text = "Height";
            // 
            // textBox_weight
            // 
            this.textBox_weight.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_weight.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_weight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_weight.Location = new System.Drawing.Point(215, 306);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(323, 32);
            this.textBox_weight.TabIndex = 6;
            this.textBox_weight.Text = "kg";
            this.textBox_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_weight.Enter += new System.EventHandler(this.textBox_weight_Enter);
            this.textBox_weight.Leave += new System.EventHandler(this.textBox_weight_Leave);
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.BackColor = System.Drawing.Color.Transparent;
            this.label_weight.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_weight.ForeColor = System.Drawing.Color.White;
            this.label_weight.Location = new System.Drawing.Point(26, 306);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(96, 35);
            this.label_weight.TabIndex = 36;
            this.label_weight.Text = "Weight";
            // 
            // textBox_address
            // 
            this.textBox_address.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_address.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(787, 224);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(424, 32);
            this.textBox_address.TabIndex = 5;
            this.textBox_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.BackColor = System.Drawing.Color.Transparent;
            this.label_address.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.ForeColor = System.Drawing.Color.White;
            this.label_address.Location = new System.Drawing.Point(620, 224);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(107, 35);
            this.label_address.TabIndex = 33;
            this.label_address.Text = "Address";
            // 
            // textBox_contact
            // 
            this.textBox_contact.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_contact.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contact.Location = new System.Drawing.Point(215, 224);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(323, 32);
            this.textBox_contact.TabIndex = 4;
            this.textBox_contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_contact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_contact_KeyDown);
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.BackColor = System.Drawing.Color.Transparent;
            this.label_contact.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.ForeColor = System.Drawing.Color.White;
            this.label_contact.Location = new System.Drawing.Point(26, 224);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(117, 35);
            this.label_contact.TabIndex = 27;
            this.label_contact.Text = "Contact#";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(215, 143);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(323, 32);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_name.Leave += new System.EventHandler(this.textBox_name_Leave);
            // 
            // textBox_fathername
            // 
            this.textBox_fathername.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_fathername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_fathername.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fathername.Location = new System.Drawing.Point(787, 146);
            this.textBox_fathername.Name = "textBox_fathername";
            this.textBox_fathername.Size = new System.Drawing.Size(424, 32);
            this.textBox_fathername.TabIndex = 3;
            this.textBox_fathername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_fathername
            // 
            this.label_fathername.AutoSize = true;
            this.label_fathername.BackColor = System.Drawing.Color.Transparent;
            this.label_fathername.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fathername.ForeColor = System.Drawing.Color.White;
            this.label_fathername.Location = new System.Drawing.Point(620, 144);
            this.label_fathername.Name = "label_fathername";
            this.label_fathername.Size = new System.Drawing.Size(161, 35);
            this.label_fathername.TabIndex = 28;
            this.label_fathername.Text = "Father Name";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(26, 141);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(82, 35);
            this.label_name.TabIndex = 26;
            this.label_name.Text = "Name";
            // 
            // UpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Homepage.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 737);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_errorpackage);
            this.Controls.Add(this.label_errorcategory);
            this.Controls.Add(this.label_errorname);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dateTimePicker_dateofjoining);
            this.Controls.Add(this.label_dateofjoining);
            this.Controls.Add(this.comboBox_selecttrainer);
            this.Controls.Add(this.label_trainer);
            this.Controls.Add(this.textBox_admissionfee);
            this.Controls.Add(this.label_admissionfee);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.textBox_gymno);
            this.Controls.Add(this.label_gymno);
            this.Controls.Add(this.comboBox_package);
            this.Controls.Add(this.label_package);
            this.Controls.Add(this.textBox_purpose);
            this.Controls.Add(this.label_purpose);
            this.Controls.Add(this.textBox_height_in);
            this.Controls.Add(this.textBox_height_ft);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_fathername);
            this.Controls.Add(this.label_fathername);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateMember";
            this.Activated += new System.EventHandler(this.UpdateMember_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBox_category;
        public System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_errorpackage;
        private System.Windows.Forms.Label label_errorcategory;
        private System.Windows.Forms.Label label_errorname;
        private System.Windows.Forms.Button button_update;
        public System.Windows.Forms.DateTimePicker dateTimePicker_dateofjoining;
        private System.Windows.Forms.Label label_dateofjoining;
        private System.Windows.Forms.ComboBox comboBox_selecttrainer;
        private System.Windows.Forms.Label label_trainer;
        public System.Windows.Forms.TextBox textBox_admissionfee;
        private System.Windows.Forms.Label label_admissionfee;
        private System.Windows.Forms.Label label_category;
        public System.Windows.Forms.TextBox textBox_gymno;
        private System.Windows.Forms.Label label_gymno;
        public System.Windows.Forms.ComboBox comboBox_package;
        private System.Windows.Forms.Label label_package;
        public System.Windows.Forms.TextBox textBox_purpose;
        private System.Windows.Forms.Label label_purpose;
        public System.Windows.Forms.TextBox textBox_height_in;
        public System.Windows.Forms.TextBox textBox_height_ft;
        private System.Windows.Forms.Label label_height;
        public System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Label label_weight;
        public System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_address;
        public System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.Label label_contact;
        public System.Windows.Forms.TextBox textBox_name;
        public System.Windows.Forms.TextBox textBox_fathername;
        private System.Windows.Forms.Label label_fathername;
        private System.Windows.Forms.Label label_name;
    }
}