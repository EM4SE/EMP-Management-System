using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_Management_System
{
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }

        

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var EmpData = new EmployeeFormData
            {
                FullName = txtFullName.Text,
                EmailAddress = txtEmail.Text,
                ContactNumber = txtContact.Text,
                ResidentAddress = txtAddress.Text,
                Gender = comGender.SelectedItem.ToString(),
                DateOfBirth = DateTime.Parse(pickDateOfBirth.Text),
                Designation = comDesignation.SelectedItem.ToString(),
                Department = comDepartment.SelectedItem.ToString(),
                Branch = comBranch.SelectedItem.ToString(),
                DateOfJoining = DateTime.Parse(pickDateOfJoin.Text),
                EmploymentType = comEmpType.SelectedItem.ToString()
            };

            EmployeeManager employeeManager = new EmployeeManager();

            try
            {
                employeeManager.AddEmployee(EmpData);
                clearTextboxed();
                           //MessageBox.Show("Employee added successfully.");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                
            }


        }

        private void clearTextboxed()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtAddress.Clear(); 
            comGender.SelectedIndex = -1;
            pickDateOfBirth.Value = DateTime.MinValue;
            comDesignation.SelectedIndex = -1;  
            comDepartment.SelectedIndex = -1;
            comBranch.SelectedIndex = -1;
            pickDateOfJoin.Value = DateTime.MinValue;
            comEmpType.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
           

        }
    }
}
