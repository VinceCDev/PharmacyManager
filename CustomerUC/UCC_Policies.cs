using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project.CustomerUC
{
    public partial class UCC_Policies : UserControl
    {
        private Stack<string> policyStack = new Stack<string>();
        public UCC_Policies()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadPoliciesFromFile();
        }

        private void ReloadPoliciesFromFile()
        {
            listBox1.Items.Clear();
            policyStack.Clear();

            try
            {
                string filePath = "C:\\Users\\DELL\\Documents\\Policies.txt";
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    policyStack.Push(line);
                }

                DisplayStackInListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading policies: " + ex.Message);
            }
        }

        private void DisplayStackInListBox()
        {
            foreach (string item in policyStack)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
