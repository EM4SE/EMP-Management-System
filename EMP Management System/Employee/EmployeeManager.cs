using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using exam_test;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;

namespace EMP_Management_System
{
    public class EmployeeManager
    {
       
        public void AddEmployee(EmployeeFormData empData)
        {
            ValidateFormData(empData);

            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string query = @"INSERT INTO employee 
                    (fullname, email, contact, address, gender, dob, 
                     designation, department, branch, dateOfJoin, empType) 
                    VALUES (@FullName, @Email, @ContactNumber, @ResidentAddress, @Gender, @DateOfBirth, 
                            @Designation, @Department, @Branch, @DateOfJoining, @EmploymentType)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", empData.FullName);
                cmd.Parameters.AddWithValue("@Email", empData.EmailAddress);
                cmd.Parameters.AddWithValue("@ContactNumber", 0 + empData.ContactNumber);
                cmd.Parameters.AddWithValue("@ResidentAddress", empData.ResidentAddress);
                cmd.Parameters.AddWithValue("@Gender", empData.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", empData.DateOfBirth);
                cmd.Parameters.AddWithValue("@Designation", empData.Designation);
                cmd.Parameters.AddWithValue("@Department", empData.Department);
                cmd.Parameters.AddWithValue("@Branch", empData.Branch);
                cmd.Parameters.AddWithValue("@DateOfJoining", empData.DateOfJoining);
                cmd.Parameters.AddWithValue("@EmploymentType", empData.EmploymentType);

                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data entered success fully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while adding the employee to the database." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
            }
        }

        public void DeleteEmployee(int empId)
        {
            if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection con = DBConfig.connectDB();
                    string query = @"DELETE FROM employee WHERE id = @EmployeeId";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@EmployeeId", empId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Deleted success fully");
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

        public void ValidateFormData(EmployeeFormData empData)
        {
            if (string.IsNullOrWhiteSpace(empData.FullName))
            {
                throw new ArgumentException("Full Name is required.");  
            }
                

            if (!IsValidEmail(empData.EmailAddress))
            {
                throw new ArgumentException("Invalid Email Address.");
            }
               

            if (!IsValidPhoneNumber(empData.ContactNumber) || empData.ContactNumber.Length > 10)
            {
                throw new ArgumentException("Invalid Contact Number.");
            }


            if (string.IsNullOrWhiteSpace(empData.ResidentAddress))
            {
                throw new ArgumentException("Resident Address is required.");
            }


            if (string.IsNullOrWhiteSpace(empData.Gender))
            {
                throw new ArgumentException("Gender is required.");
            }


            if (empData.DateOfBirth >= DateTime.Now.AddYears(-18))
            {
                throw new ArgumentException("Employee must be at least 18 years old.");
            }


            if (string.IsNullOrWhiteSpace(empData.Designation))
            {
                throw new ArgumentException("Designation is required.");
            }



            if (string.IsNullOrWhiteSpace(empData.Department))
            {
                throw new ArgumentException("Department is required.");
            }


            if (string.IsNullOrWhiteSpace(empData.Branch))
            {
                throw new ArgumentException("Branch is required.");
            }


            if (empData.DateOfJoining > DateTime.Now)
            {
                throw new ArgumentException("Date of Joining cannot be in the future.");
            }


            if (string.IsNullOrWhiteSpace(empData.EmploymentType))
            {
                throw new ArgumentException("Employment Type is required.");
            }

        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$");
        }

        public void EditEmployee(EmployeeFormData empData)
        {
            ValidateFormData(empData);

            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string query = @"UPDATE employee SET fullname = @FullName , email = @Email, contact = @ContactNumber,
                     address = @ResidentAddress,gender =  @Gender, dob = @DateOfBirth, 
                     designation = @Designation, department = @Department , branch = @Branch ,
                     dateOfJoin = @DateOfJoining , empType = @EmploymentType  WHERE id = @EmpID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", empData.FullName);
                cmd.Parameters.AddWithValue("@Email", empData.EmailAddress);
                cmd.Parameters.AddWithValue("@ContactNumber",empData.ContactNumber);
                cmd.Parameters.AddWithValue("@ResidentAddress", empData.ResidentAddress);
                cmd.Parameters.AddWithValue("@Gender", empData.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", empData.DateOfBirth);
                cmd.Parameters.AddWithValue("@Designation", empData.Designation);
                cmd.Parameters.AddWithValue("@Department", empData.Department);
                cmd.Parameters.AddWithValue("@Branch", empData.Branch);
                cmd.Parameters.AddWithValue("@DateOfJoining", empData.DateOfJoining);
                cmd.Parameters.AddWithValue("@EmploymentType", empData.EmploymentType);
                cmd.Parameters.AddWithValue("@EmpID", empData.EmployeeID);


                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Edited success fully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while adding the employee to the database." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
            }
        }
    }
}

public class EmployeeFormData
{
    public int EmployeeID { get; set; } 
    public string FullName { get; set; }
    public string EmailAddress { get; set; } 
    public string ContactNumber { get; set; } 
    public string ResidentAddress { get; set; }
    public string Gender { get; set; } 
    public DateTime DateOfBirth { get; set; }
    public string Designation { get; set; } 
    public string Department { get; set; }
    public string Branch { get; set; } 
    public DateTime DateOfJoining { get; set; } 
    public string EmploymentType { get; set; }
}


