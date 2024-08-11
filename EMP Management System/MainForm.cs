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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void FillControls(Form form)
        {
            pnlMain.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            pnlMain.Controls.Add(form);
            form.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FillControls(new Employees());
        }

        private void btnDesignation_Click(object sender, EventArgs e)
        {
            FillControls(new Designation());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FillControls(new Users());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FillControls(new Settings());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FillControls(new Home());
        }
    }
}
