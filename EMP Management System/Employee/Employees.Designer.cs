namespace EMP_Management_System
{
    partial class Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmploymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEmpAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.textSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ViewPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeletePic = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management";
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDataGridView.ColumnHeadersHeight = 35;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.name,
            this.email,
            this.ContactNumber,
            this.Designation,
            this.Department,
            this.Branch,
            this.EmploymentType,
            this.ViewPic,
            this.EditPic,
            this.DeletePic});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmployeeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView.Location = new System.Drawing.Point(0, 86);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeeDataGridView.RowHeadersVisible = false;
            this.EmployeeDataGridView.RowTemplate.Height = 30;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(1155, 634);
            this.EmployeeDataGridView.TabIndex = 1;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.EmployeeDataGridView.ThemeStyle.ReadOnly = true;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellContentClick);
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "id";
            this.EmpID.FillWeight = 68.61771F;
            this.EmpID.HeaderText = "Emp ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "fullname";
            this.name.FillWeight = 68.61771F;
            this.name.HeaderText = "Full Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 68.61771F;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "contact";
            this.ContactNumber.FillWeight = 68.61771F;
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "designation";
            this.Designation.FillWeight = 68.61771F;
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "department";
            this.Department.FillWeight = 68.61771F;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Branch
            // 
            this.Branch.DataPropertyName = "branch";
            this.Branch.FillWeight = 68.61771F;
            this.Branch.HeaderText = "Branch";
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            // 
            // EmploymentType
            // 
            this.EmploymentType.DataPropertyName = "empType";
            this.EmploymentType.FillWeight = 68.61771F;
            this.EmploymentType.HeaderText = "Employment Type";
            this.EmploymentType.Name = "EmploymentType";
            this.EmploymentType.ReadOnly = true;
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.AutoRoundedCorners = true;
            this.btnEmpAdd.BorderRadius = 21;
            this.btnEmpAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmpAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmpAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmpAdd.ForeColor = System.Drawing.Color.White;
            this.btnEmpAdd.Location = new System.Drawing.Point(963, 19);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(180, 45);
            this.btnEmpAdd.TabIndex = 2;
            this.btnEmpAdd.Text = "Add Employee";
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::EMP_Management_System.Properties.Resources.file;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::EMP_Management_System.Properties.Resources.pencil;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::EMP_Management_System.Properties.Resources.delete;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 5;
            // 
            // textSearch
            // 
            this.textSearch.Animated = true;
            this.textSearch.AutoRoundedCorners = true;
            this.textSearch.BorderColor = System.Drawing.Color.Blue;
            this.textSearch.BorderRadius = 21;
            this.textSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSearch.DefaultText = "";
            this.textSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSearch.IconLeft = global::EMP_Management_System.Properties.Resources._9135995;
            this.textSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.textSearch.Location = new System.Drawing.Point(621, 19);
            this.textSearch.Name = "textSearch";
            this.textSearch.PasswordChar = '\0';
            this.textSearch.PlaceholderText = "Search Here....";
            this.textSearch.SelectedText = "";
            this.textSearch.Size = new System.Drawing.Size(318, 45);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // ViewPic
            // 
            this.ViewPic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ViewPic.HeaderText = "";
            this.ViewPic.Image = global::EMP_Management_System.Properties.Resources.file__1_;
            this.ViewPic.Name = "ViewPic";
            this.ViewPic.ReadOnly = true;
            this.ViewPic.Width = 5;
            // 
            // EditPic
            // 
            this.EditPic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditPic.HeaderText = "";
            this.EditPic.Image = global::EMP_Management_System.Properties.Resources.pencil__1_;
            this.EditPic.Name = "EditPic";
            this.EditPic.ReadOnly = true;
            this.EditPic.Width = 5;
            // 
            // DeletePic
            // 
            this.DeletePic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeletePic.HeaderText = "";
            this.DeletePic.Image = global::EMP_Management_System.Properties.Resources.delete__1_;
            this.DeletePic.Name = "DeletePic";
            this.DeletePic.ReadOnly = true;
            this.DeletePic.Width = 5;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 720);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnEmpAdd);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Guna.UI2.WinForms.Guna2Button btnEmpAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmploymentType;
        private System.Windows.Forms.DataGridViewImageColumn ViewPic;
        private System.Windows.Forms.DataGridViewImageColumn EditPic;
        private System.Windows.Forms.DataGridViewImageColumn DeletePic;
        private Guna.UI2.WinForms.Guna2TextBox textSearch;
    }
}