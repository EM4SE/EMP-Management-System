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
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
        }


        public EmployeeView(int employeeID)
        {
            
            InitializeComponent();
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select * from employee where id = @empID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@empID", employeeID);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                try
                {
                    if (rdr.Read())
                    {
                        lblEmpTitle.Text = rdr.GetString("fullname");
                        lblEmpSub.Text = rdr.GetString("designation");
                        labelEmpId.Text = rdr.GetInt32("id").ToString();
                        labelFullname.Text = rdr.GetString("fullname");
                        labelEmail.Text = rdr.GetString("email");
                        labelContact.Text = rdr.GetInt32("contact").ToString();
                        labelAddress.Text = rdr.GetString("address");
                        labelGender.Text = rdr.GetString("gender");
                        labelDOB.Text = rdr.GetDateTime("dob").ToString();
                        labelDesignation.Text = rdr.GetString("designation");
                        labelDepartment.Text = rdr.GetString("department");
                        labelBranch.Text = rdr.GetString("branch");
                        labelJoinDate.Text = rdr.GetDateTime("dateOfJoin").ToString();
                        labelType.Text = rdr.GetString("empType");
                        labelStatus.Text = rdr.GetString("empStatus");
                        labelNum.Text = rdr.GetInt32("bankAccount").ToString();


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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
