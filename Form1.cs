using C_Project.AdministratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Login : Form
    {
        private US_AddUsers addUserControl;
        public Login()
        {
            InitializeComponent();
            addUserControl = new US_AddUsers();// Assign the UserControl instance
        }
        public void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        public void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType;

            if (username == "Allen" && password == "pass")
            {
                OpenAdministratorForm(); // Open admin form for specific user
                this.Hide();
                return;
            }

            if (addUserControl.Login(username, password, out userType))
            {
                switch (userType)
                {
                    case "Administrator":
                        OpenAdministratorForm();
                        break;
                    case "Customer":
                        OpenCustomerForm();
                        break;
                    case "Pharmacist":
                        OpenPharmacistForm();
                        break;
                    default:
                        MessageBox.Show("Invalid user type.");
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void OpenAdministratorForm()
        {
            btnLogOut adminForm = new btnLogOut();
            adminForm.Show();
        }
        private void OpenCustomerForm()
        {
            Customer customerForm = new Customer();
            customerForm.Show();
        }
        private void OpenPharmacistForm()
        {
            Pharmacist pharmacistForm = new Pharmacist();
            pharmacistForm.Show();
        }
    }
}
