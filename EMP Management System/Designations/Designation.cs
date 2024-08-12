using EMP_Management_System.Designations;
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
    public partial class Designation : Form
    {
        int DesignationID = 0;
        public Designation()
        {
            InitializeComponent();
            updategridd();
        }

        private void DataGridViewDesignation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex < 0) return; // Ignore header row click

            else
            {
                int DesId = Convert.ToInt32(DataGridViewDesignation.Rows[e.RowIndex].Cells["Designation_ID"].Value);
                string DesName = DataGridViewDesignation.Rows[e.RowIndex].Cells["DesignationName"].Value.ToString();
                string DesDescription = DataGridViewDesignation.Rows[e.RowIndex].Cells["DesignationDescription"].Value.ToString();

                DesignationID = DesId;
                txtName.Text = DesName;
                textDescription.Text = DesDescription;
            }
        }

        public void updategridd()
        {
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select * from designations;";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                DataGridViewDesignation.DataSource = datatable;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var DesignationData = new DesignationData
            {
                Name = string.IsNullOrWhiteSpace(txtName.Text) ? "" : char.ToUpper(txtName.Text[0]) + txtName.Text.Substring(1),
                Description = string.IsNullOrWhiteSpace(textDescription.Text) ? " " : textDescription.Text,
            };
            DesignationManager designationManager = new DesignationManager();

            try
            {
                designationManager.AddDesignation(DesignationData);

                updategridd();
                cleartextboxes();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
        }

        private void cleartextbox()
        {
            txtName.Clear();
            textDescription.Clear();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var DesignationData = new DesignationData
            {
                DesignationID = DesignationID,
                Name = string.IsNullOrWhiteSpace(txtName.Text) ? "" : char.ToUpper(txtName.Text[0]) + txtName.Text.Substring(1),
                Description = string.IsNullOrWhiteSpace(textDescription.Text) ? " " : textDescription.Text,
            };
            DesignationManager designationManager = new DesignationManager();

            try
            {
                designationManager.EditDesignation(DesignationData);

                updategridd();
                cleartextboxes();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var DesignationData = new DesignationData
            {
                DesignationID = DesignationID,
                Name = string.IsNullOrWhiteSpace(txtName.Text) ? "" : char.ToUpper(txtName.Text[0]) + txtName.Text.Substring(1),
                Description = string.IsNullOrWhiteSpace(textDescription.Text) ? " " : textDescription.Text,
            };
            DesignationManager designationManager = new DesignationManager();

            try
            {
                designationManager.DeleteDesignation(DesignationData);
                updategridd();
                cleartextboxes();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
        }

        private void cleartextboxes()
        {
            txtName.Clear();
            textDescription.Clear();
        }
    }




    
}
