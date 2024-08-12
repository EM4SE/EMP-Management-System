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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EMP_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public Home(string username)
        {
            InitializeComponent();
            loadUserData(username);
            loadEmployeeCount();
            loadDesigCount();
            loadUserCount();
        }

        private void loadUserData(string username)
        {
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select * from users where username = @uname";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@uname", username);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string name = rdr["name"].ToString();
                    string uname = "@" + rdr["username"].ToString();
                                      labelName.Text = name;
                    labelusername.Text = uname;


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred ." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
            }
        }

        private void loadEmployeeCount()
        {
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select Count(id) AS ecount from employee";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string ecount = rdr["ecount"].ToString();
                  
                    labelempCount.Text = ecount;



                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred ." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
            }
        }

        private void loadDesigCount()
        {
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select Count(id) AS dcount from designations";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string dcount = rdr["dcount"].ToString();

                    labeDesigCount.Text = dcount;



                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred ." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
            }
        }

        private void loadUserCount()
        {
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select Count(username) AS ucount from users";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string ucount = rdr["ucount"].ToString();

                    labelUserCount.Text = ucount;



                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred ." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
            }
        }
    }
}
