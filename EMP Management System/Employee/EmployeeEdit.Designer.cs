namespace EMP_Management_System.Employee
{
    partial class EmployeeEdit
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.comEmpType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pickDateOfJoin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.comBranch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comDesignation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pickDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BorderRadius = 21;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(699, 524);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 45);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Cancel";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.AutoRoundedCorners = true;
            this.btnEditEmployee.BorderRadius = 21;
            this.btnEditEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEditEmployee.Location = new System.Drawing.Point(523, 524);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(150, 45);
            this.btnEditEmployee.TabIndex = 12;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // comEmpType
            // 
            this.comEmpType.BackColor = System.Drawing.Color.Transparent;
            this.comEmpType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.comEmpType.BorderRadius = 7;
            this.comEmpType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comEmpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comEmpType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comEmpType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comEmpType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comEmpType.ForeColor = System.Drawing.Color.Black;
            this.comEmpType.ItemHeight = 30;
            this.comEmpType.Items.AddRange(new object[] {
            "Full-Time Employment",
            "Part-Time Employment",
            "Contract Employment",
            "Temporary Employment",
            "Internship",
            "Casual Employment",
            "Seasonal Employment",
            "Volunteer"});
            this.comEmpType.Location = new System.Drawing.Point(523, 432);
            this.comEmpType.Name = "comEmpType";
            this.comEmpType.Size = new System.Drawing.Size(326, 36);
            this.comEmpType.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label14.Location = new System.Drawing.Point(520, 411);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 18);
            this.label14.TabIndex = 65;
            this.label14.Text = "Employment Type";
            // 
            // pickDateOfJoin
            // 
            this.pickDateOfJoin.Animated = true;
            this.pickDateOfJoin.BackColor = System.Drawing.Color.Transparent;
            this.pickDateOfJoin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.pickDateOfJoin.BorderRadius = 7;
            this.pickDateOfJoin.BorderThickness = 1;
            this.pickDateOfJoin.Checked = true;
            this.pickDateOfJoin.CheckedState.FillColor = System.Drawing.Color.White;
            this.pickDateOfJoin.FillColor = System.Drawing.Color.White;
            this.pickDateOfJoin.FocusedColor = System.Drawing.Color.White;
            this.pickDateOfJoin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pickDateOfJoin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pickDateOfJoin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.pickDateOfJoin.Location = new System.Drawing.Point(523, 362);
            this.pickDateOfJoin.MaxDate = new System.DateTime(2024, 8, 11, 0, 0, 0, 0);
            this.pickDateOfJoin.MinDate = new System.DateTime(1948, 1, 1, 0, 0, 0, 0);
            this.pickDateOfJoin.Name = "pickDateOfJoin";
            this.pickDateOfJoin.Size = new System.Drawing.Size(326, 36);
            this.pickDateOfJoin.TabIndex = 10;
            this.pickDateOfJoin.Value = new System.DateTime(2024, 8, 11, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label13.Location = new System.Drawing.Point(520, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 18);
            this.label13.TabIndex = 63;
            this.label13.Text = "Date of Joining";
            // 
            // comBranch
            // 
            this.comBranch.BackColor = System.Drawing.Color.Transparent;
            this.comBranch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.comBranch.BorderRadius = 7;
            this.comBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBranch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comBranch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comBranch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comBranch.ForeColor = System.Drawing.Color.Black;
            this.comBranch.ItemHeight = 30;
            this.comBranch.Items.AddRange(new object[] {
            "Headquarters",
            "Regional Office",
            "Manufacturing Plant",
            "Sales Office",
            "Research and Development (R&D) Center",
            "Distribution Center",
            "Retail Branch",
            "Customer Support Center",
            "Warehouse"});
            this.comBranch.Location = new System.Drawing.Point(523, 292);
            this.comBranch.Name = "comBranch";
            this.comBranch.Size = new System.Drawing.Size(326, 36);
            this.comBranch.TabIndex = 9;
            // 
            // comDepartment
            // 
            this.comDepartment.BackColor = System.Drawing.Color.Transparent;
            this.comDepartment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.comDepartment.BorderRadius = 7;
            this.comDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comDepartment.ForeColor = System.Drawing.Color.Black;
            this.comDepartment.ItemHeight = 30;
            this.comDepartment.Items.AddRange(new object[] {
            "Human Resources (HR)",
            "Finance and Accounting",
            "Marketing",
            "Sales",
            "Information Technology (IT)",
            "Research and Development (R&D)",
            "Operations",
            "Customer Service",
            "Legal",
            "Procurement",
            "Administration"});
            this.comDepartment.Location = new System.Drawing.Point(523, 222);
            this.comDepartment.Name = "comDepartment";
            this.comDepartment.Size = new System.Drawing.Size(326, 36);
            this.comDepartment.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label12.Location = new System.Drawing.Point(520, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 18);
            this.label12.TabIndex = 60;
            this.label12.Text = "Branch";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label11.Location = new System.Drawing.Point(520, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 59;
            this.label11.Text = "Department";
            // 
            // comDesignation
            // 
            this.comDesignation.BackColor = System.Drawing.Color.Transparent;
            this.comDesignation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.comDesignation.BorderRadius = 7;
            this.comDesignation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDesignation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comDesignation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comDesignation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comDesignation.ForeColor = System.Drawing.Color.Black;
            this.comDesignation.ItemHeight = 30;
            this.comDesignation.Location = new System.Drawing.Point(523, 152);
            this.comDesignation.Name = "comDesignation";
            this.comDesignation.Size = new System.Drawing.Size(326, 36);
            this.comDesignation.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label10.Location = new System.Drawing.Point(520, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 57;
            this.label10.Text = "Designation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label9.Location = new System.Drawing.Point(519, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 24);
            this.label9.TabIndex = 56;
            this.label9.Text = "Employment Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label6.Location = new System.Drawing.Point(374, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 37);
            this.label6.TabIndex = 55;
            this.label6.Text = "Edit Employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(152, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Personal Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label8.Location = new System.Drawing.Point(156, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 53;
            this.label8.Text = "Gender";
            // 
            // txtAddress
            // 
            this.txtAddress.Animated = true;
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.txtAddress.BorderRadius = 7;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(156, 362);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAddress.PlaceholderText = "Enter Resident Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(326, 105);
            this.txtAddress.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label7.Location = new System.Drawing.Point(156, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Resident Address";
            // 
            // comGender
            // 
            this.comGender.BackColor = System.Drawing.Color.Transparent;
            this.comGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.comGender.BorderRadius = 7;
            this.comGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comGender.ForeColor = System.Drawing.Color.Black;
            this.comGender.ItemHeight = 30;
            this.comGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comGender.Location = new System.Drawing.Point(156, 502);
            this.comGender.Name = "comGender";
            this.comGender.Size = new System.Drawing.Size(326, 36);
            this.comGender.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.Animated = true;
            this.txtContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.txtContact.BorderRadius = 7;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.Location = new System.Drawing.Point(156, 292);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtContact.PlaceholderText = "Enter Contact Number ";
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(326, 36);
            this.txtContact.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label5.Location = new System.Drawing.Point(156, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label4.Location = new System.Drawing.Point(156, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.txtEmail.BorderRadius = 7;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(156, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.PlaceholderText = "Enter Email Address";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(326, 36);
            this.txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label3.Location = new System.Drawing.Point(156, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Date Of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label2.Location = new System.Drawing.Point(153, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Full Name";
            // 
            // pickDateOfBirth
            // 
            this.pickDateOfBirth.Animated = true;
            this.pickDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.pickDateOfBirth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.pickDateOfBirth.BorderRadius = 7;
            this.pickDateOfBirth.BorderThickness = 1;
            this.pickDateOfBirth.Checked = true;
            this.pickDateOfBirth.CheckedState.FillColor = System.Drawing.Color.White;
            this.pickDateOfBirth.FillColor = System.Drawing.Color.White;
            this.pickDateOfBirth.FocusedColor = System.Drawing.Color.White;
            this.pickDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pickDateOfBirth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pickDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.pickDateOfBirth.Location = new System.Drawing.Point(156, 572);
            this.pickDateOfBirth.MaxDate = new System.DateTime(2024, 8, 11, 0, 0, 0, 0);
            this.pickDateOfBirth.MinDate = new System.DateTime(1948, 1, 1, 0, 0, 0, 0);
            this.pickDateOfBirth.Name = "pickDateOfBirth";
            this.pickDateOfBirth.Size = new System.Drawing.Size(326, 36);
            this.pickDateOfBirth.TabIndex = 6;
            this.pickDateOfBirth.Value = new System.DateTime(2024, 8, 11, 0, 0, 0, 0);
            // 
            // txtFullName
            // 
            this.txtFullName.Animated = true;
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.txtFullName.BorderRadius = 7;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(156, 152);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFullName.PlaceholderText = "Enter Full Name";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(326, 36);
            this.txtFullName.TabIndex = 0;
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.comEmpType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pickDateOfJoin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comBranch);
            this.Controls.Add(this.comDepartment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comDesignation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comGender);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickDateOfBirth);
            this.Controls.Add(this.txtFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnEditEmployee;
        private Guna.UI2.WinForms.Guna2ComboBox comEmpType;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DateTimePicker pickDateOfJoin;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox comBranch;
        private Guna.UI2.WinForms.Guna2ComboBox comDepartment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox comDesignation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox comGender;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker pickDateOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
    }
}