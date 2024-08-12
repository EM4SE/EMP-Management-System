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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();
            lblError.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Here you would typically check the credentials against a database
                try
                {
                    string username = textUsername.Text;
                    string Password = textPassword.Text;

                    MySqlConnection con = DBConfig.connectDB();
                    string sql = "Select * from users where username = @name";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@name", username);
                    con.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string passwordDB = rdr.GetString("password");
                        if (Password == passwordDB)
                        {
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            lblError.Text = "Invalid Password !!";
                        }

                    }
                    else
                    {
                        lblError.Text = "Invalid Username !!";
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

        private bool ValidateInput()
        {
            // Validate Username
            if (string.IsNullOrWhiteSpace(textUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(textPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                                             

            return true;
        }
    }
}
