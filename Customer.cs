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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        private void btnChart_Click(object sender, EventArgs e)
        {
            ucC_Chart3.Visible = true;
            ucC_Chart3.BringToFront();
            uccBuy2.Visible = false;
            ucC_Policies2.Visible = false;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uccBuy2.Visible = true;
            uccBuy2.BringToFront();
            ucC_Chart3.Visible = false;
            ucC_Policies2.Visible = false;
        }
        private void btnViewUser_Click(object sender, EventArgs e)
        {
            ucC_Policies2.Visible = true;
            ucC_Policies2.BringToFront();
            ucC_Chart3.Visible = false;
            uccBuy2.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Login am = new Login();
            am.Show();
            this.Hide();
        }
        private void Customer_Load(object sender, EventArgs e)
        {

        }
        private void Customer_Load_1(object sender, EventArgs e)
        {
            ucC_Chart3.Visible = false;
            ucC_Policies2.Visible = false;
            uccBuy2.Visible = false;
        }
        private void ucP_Validation1_Load(object sender, EventArgs e)
        {

        }
    }
}
