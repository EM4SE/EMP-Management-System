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

namespace EMP_Management_System.Employee
{
    public partial class EmployeeEdit : Form
    {
        int employeeID;
        public EmployeeEdit()
        {
            InitializeComponent();
            loadComboItem();
        }

        public EmployeeEdit(int empID)
        {
            employeeID = empID;
            InitializeComponent();
            loadComboItem();
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select * from employee where id = @empID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@empID", empID);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                try
                {
                    if (rdr.Read())
                    {
                        txtFullName.Text = rdr.GetString("fullname");
                        txtEmail.Text = rdr.GetString("email");
                        txtContact.Text = rdr.GetInt32("contact").ToString();
                        txtAddress.Text = rdr.GetString("address");
                        comGender.Text = rdr.GetString("gender");
                        pickDateOfBirth.Value = DateTime.Parse(rdr.GetDateTime("dob").ToString());
                        comDesignation.Text = rdr.GetString("designation");
                        comDepartment.Text = rdr.GetString("department");
                        comBranch.Text = rdr.GetString("branch");
                        pickDateOfJoin.Value = DateTime.Parse(rdr.GetDateTime("dateOfJoin").ToString());
                        comEmpType.Text = rdr.GetString("empType");

                    }
                    else
                    {
                        MessageBox.Show("No data Found !!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 

            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while adding the employee to the database." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            var EmpData = new EmployeeFormData
            {
                EmployeeID = employeeID,
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
                employeeManager.EditEmployee(EmpData);

                this.Close();


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
    }

}
