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

namespace EMP_Management_System
{
    public partial class Settings : Form
    {
        string UName;
        public Settings()
        {
            InitializeComponent();
        }

        public Settings(string username)
        {
            InitializeComponent();
            UName = username;


            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select * from users where username = @uname";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@uname", UName);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string name = rdr["name"].ToString();
                    string uname = "@" + rdr["username"].ToString();
                    string password = rdr["password"].ToString();

                    labelName.Text = name;
                    textName.Text = name;
                    labelUName.Text = uname;
                    textUsername.Text = rdr["username"].ToString();
                    textPassword.Text = password;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUname_Click(object sender, EventArgs e)
        {
         

            try
            {
                if (string.IsNullOrWhiteSpace(textUsername.Text))
                {
                    throw new ArgumentException("Please enter a new username.");
                }
                if (textUsername.Text.Length < 4)
                {
                    throw new ArgumentException("New username must be at least 4 characters long.");

                }
                MySqlConnection con = DBConfig.connectDB();
                string query = @"UPDATE users 
                SET username = @Name WHERE username = @UName";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UName", UName);
                cmd.Parameters.AddWithValue("@Name", textUsername.Text);
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Username Edited success fully");
                this.Refresh();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 547 || ex.Number == 2601)
                {
                    MessageBox.Show("Error: Designation Name Already in Used");
                }
                else
                {
                    MessageBox.Show("An error occurred while Editing the the database." + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (string.IsNullOrWhiteSpace(textPassword.Text))
                {
                    throw new ArgumentException("Please enter a new password.", "Validation Error");

                }
                if (textPassword.Text.Length < 8)
                {
                    throw new ArgumentException("New password must be at least 8 characters long.");

                }

                MySqlConnection con = DBConfig.connectDB();
                string query = @"UPDATE users 
                SET password = @Password WHERE username = @UName";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UName", UName);
                cmd.Parameters.AddWithValue("@password", textPassword.Text);
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Edited success fully");
                this.Refresh();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 547 || ex.Number == 2601)
                {
                    MessageBox.Show("Error: Designation Name Already in Used");
                }
                else
                {
                    MessageBox.Show("An error occurred while Editing the the database." + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (string.IsNullOrWhiteSpace(textName.Text))
                {
                    throw new ArgumentException("Please enter a new username.");
                }
                if (textName.Text.Length < 4)
                {
                    throw new ArgumentException("New username must be at least 4 characters long.");

                }


                MySqlConnection con = DBConfig.connectDB();
                string query = @"UPDATE users 
                SET name = @Name WHERE username = @UName";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UName", UName);
                cmd.Parameters.AddWithValue("@Name", textName.Text);
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Name Edited success fully");
                this.Refresh();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 547 || ex.Number == 2601)
                {
                    MessageBox.Show("Error: Designation Name Already in Used");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
