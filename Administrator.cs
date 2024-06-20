using C_Project.AdministratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class btnLogOut : Form
    {
        public btnLogOut()
        {
            InitializeComponent();
        }
        private void btnExit(object sender, EventArgs e)
        {
            Login am = new Login();
            am.Show();
            this.Hide();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
            uS_AddUsers2.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_Profile1.Visible = false;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uS_AddUsers2.Visible = true;
            uS_AddUsers2.BringToFront();
            uC_Dashboard1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_Profile1.Visible = false;
        }
        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
            uC_Dashboard1.Visible = false;
            uS_AddUsers2.Visible = false;
            uC_Profile1.Visible = false;
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
            uC_Dashboard1.Visible = false;
            uS_AddUsers2.Visible = false;
            uC_ViewUser1.Visible = false;
        }
        private void btnLogOut_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uS_AddUsers2.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_Profile1.Visible = false;
        }
    }

}
