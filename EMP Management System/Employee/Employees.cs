using EMP_Management_System.Employee;
using exam_test;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
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

namespace EMP_Management_System
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
           
            updategridd();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            EmployeeAdd employeeAdd = new EmployeeAdd();
            employeeAdd.Show();
            this.Hide();
            employeeAdd.FormClosed += employeeAdd_FormClosed;

        }
        public void updategridd()
        {
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select id,fullname,email,contact,designation,department,branch,empType from employee;";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                EmployeeDataGridView.DataSource = datatable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while Loading the employee to the Table." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
            }

        }

        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            if (e.RowIndex < 0) return; // Ignore header row click

            int employeeId = Convert.ToInt32(EmployeeDataGridView.Rows[e.RowIndex].Cells["EmpID"].Value);

            if (e.ColumnIndex == EmployeeDataGridView.Columns["ViewPic"].Index)
            {
                EmployeeView employeeView = new EmployeeView(employeeId);
                employeeView.Show();
            }
            else if (e.ColumnIndex == EmployeeDataGridView.Columns["EditPic"].Index)
            {
                EmployeeEdit employeeEdit = new EmployeeEdit(employeeId);
                employeeEdit.Show();
                this.Hide();
                employeeEdit.FormClosed += employeeEdit_FormClosed;

            }
            else if (e.ColumnIndex == EmployeeDataGridView.Columns["DeletePic"].Index)
            {
                try
                {
                    employeeManager.DeleteEmployee(employeeId);
                    updategridd();
                    //MessageBox.Show("Employee added successfully.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");

                }
            }
        }

        private void employeeAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            updategridd();
            this.Show();
        }
        private void employeeEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            updategridd();
            this.Show();
        }
    }
}
