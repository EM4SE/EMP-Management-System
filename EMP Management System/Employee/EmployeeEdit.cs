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
        }

        public EmployeeEdit(int empID)
        {
            employeeID = empID;
            InitializeComponent();
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
                throw new Exception("An error occurred while adding the employee to the database." + ex.Message);
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
                employeeManager.EditEmployee(EmpData);

                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }


        }
    }
}
