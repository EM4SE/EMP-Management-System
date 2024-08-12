using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EMP_Management_System
{
    public partial class Profile : UserControl
    {
        string Username;
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(string name ,string username)
        {
            Username = username;
            InitializeComponent();
            lblFullName.Text =  name;
            lblUsername.Text = "@" + username;

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login login = new Login(Username);
            login.Show();
        }
    }
}
