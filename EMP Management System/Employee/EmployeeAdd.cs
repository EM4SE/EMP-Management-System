using exam_test;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EMP_Management_System
{
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
            loadComboItem();
        }

        

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var EmpData = new EmployeeFormData
            {
       

                FullName = string.IsNullOrWhiteSpace(txtFullName.Text) ? "" : char.ToUpper(txtFullName.Text[0]) + txtFullName.Text.Substring(1),
                EmailAddress = string.IsNullOrWhiteSpace(txtEmail.Text) ? " " : txtEmail.Text,
                ContactNumber = string.IsNullOrWhiteSpace(txtContact.Text) ? " " : txtContact.Text,
                ResidentAddress = string.IsNullOrWhiteSpace(txtAddress.Text) ? " " : txtAddress.Text,
                Gender = comGender.SelectedIndex != -1 ? comGender.SelectedItem.ToString() : " ",
                DateOfBirth = pickDateOfBirth.Value == pickDateOfBirth.MinDate ? DateTime.Now : pickDateOfBirth.Value,
                Designation = comDesignation.SelectedIndex != -1 ? comDesignation.SelectedItem.ToString() : " ",
                Department = comDepartment.SelectedIndex != -1 ? comDepartment.SelectedItem.ToString() : " ",
                Branch = comBranch.SelectedIndex != -1 ? comBranch.SelectedItem.ToString() : " ",
                DateOfJoining = pickDateOfJoin.Value == pickDateOfJoin.MinDate ? DateTime.Now : pickDateOfJoin.Value,
                EmploymentType = comEmpType.SelectedIndex != -1 ? comEmpType.SelectedItem.ToString() : " "

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

        private void loadComboItem()
        {
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select name from designations";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comDesignation.Items.Add(rdr["name"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while Deleting the employee to the database." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
            }
        }

        private void clearTextboxed()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtAddress.Clear(); 
            comGender.SelectedIndex = -1;
            string dateTimeString = "10-Aug-2024 14:30:00";
            pickDateOfBirth.Value = DateTime.Parse(dateTimeString);
            comDesignation.SelectedIndex = -1;  
            comDepartment.SelectedIndex = -1;
            comBranch.SelectedIndex = -1;
            pickDateOfJoin.Value = DateTime.Parse(dateTimeString);
            comEmpType.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
           

        }
    }
}
