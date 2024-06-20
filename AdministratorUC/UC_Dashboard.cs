using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C_Project.AdministratorUC
{
    public partial class UC_Dashboard : UserControl
    {
        private US_AddUsers addUserControl;
        public UC_Dashboard()
        {
            InitializeComponent();
            addUserControl = new US_AddUsers();
            DisplayUserRoleCounts();
        }
        private void DisplayUserRoleCounts()
        {
            if (addUserControl != null)
            {
                Dictionary<string, int> roleCounts = addUserControl.CountUserRoles();

                if (roleCounts.ContainsKey("Administrator"))
                {
                    label5.Text = roleCounts["Administrator"].ToString();
                }

                if (roleCounts.ContainsKey("Customer"))
                {
                    label7.Text = roleCounts["Customer"].ToString();
                }

                if (roleCounts.ContainsKey("Pharmacist"))
                {
                    label8.Text = roleCounts["Pharmacist"].ToString();
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
