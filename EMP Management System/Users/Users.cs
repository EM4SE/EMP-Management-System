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
using System.Web.UI;
using System.Windows.Forms;

namespace EMP_Management_System
{
    public partial class Users : Form
    {

        public Users()
        {
            InitializeComponent();
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string sql = "Select * from users";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    String name = rdr["name"].ToString();
                    String uname = rdr["username"].ToString();
                    Profile pro = new Profile(name,uname);
                    pro.Dock = DockStyle.Top;
                    flowMain.Controls.Add(pro);
                }
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("An error occurred while Deleting the employee to the database." + ex.Message);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("An unexpected error occurred while processing your request." + ex.Message);
            }


        }
    }
}
