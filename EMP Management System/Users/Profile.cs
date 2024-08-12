using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_Management_System
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(string name ,string username)
        {
            InitializeComponent();
            lblFullName.Text = name;
            lblUsername.Text = username;
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
