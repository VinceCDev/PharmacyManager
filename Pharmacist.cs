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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ucP_AddMedicine1.Visible = true;
            ucP_AddMedicine1.BringToFront();
            ucP_Dashboard1.Visible = false;
            ucpSellMedicine1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ucP_Dashboard1.Visible = false;
            ucP_AddMedicine1.Visible = false;
            ucpSellMedicine1.Visible = false;
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            ucpSellMedicine1.Visible = true;
            ucpSellMedicine1.BringToFront();
            ucP_Dashboard1.Visible = false;
            ucP_AddMedicine1.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Login am = new Login();
            am.Show();
            this.Hide();
        }
        private void Pharmacist_Load(object sender, EventArgs e)
        {
            ucP_Dashboard1.Visible = false;
            ucP_AddMedicine1.Visible = false;
            ucpSellMedicine1.Visible = false;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ucP_Dashboard1.Visible = true;
            ucP_Dashboard1.BringToFront();
            ucP_AddMedicine1.Visible = false;
            ucpSellMedicine1.Visible = false;
        }
        private void ucP_Dashboard1_Load(object sender, EventArgs e)
        {

        }
        private void ucP_Validation1_Load(object sender, EventArgs e)
        {

        }
        private void ucP_AddMedicine1_Load(object sender, EventArgs e)
        {

        }
    }
}
