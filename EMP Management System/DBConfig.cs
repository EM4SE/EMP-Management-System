using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace exam_test
{
    public class DBConfig
    {
        public static MySqlConnection connectDB()
        {
            string con_string = "server=127.0.0.1;port = 3307;uid = root;pwd=root;database=employeemanagement";
            MySqlConnection con = new MySqlConnection(con_string);
            return con;


        }
    }
}
