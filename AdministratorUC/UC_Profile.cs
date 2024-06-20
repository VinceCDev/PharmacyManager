using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static C_Project.AddProfileForm;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Project.AdministratorUC
{
    public partial class UC_Profile : UserControl
    {
        private Queue<Profile> profilesQueue = new Queue<Profile>();

        public UC_Profile()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddProfileForm addProfileForm = new AddProfileForm();
            addProfileForm.SaveProfile += AddProfileForm_SaveProfile;
            addProfileForm.ShowDialog();
        }

        private void AddProfileForm_SaveProfile(Profile profile)
        {
            profilesQueue.Enqueue(profile);
            DisplayProfileDetails(profile);
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (profilesQueue.Count > 0)
            {
                Profile profile = profilesQueue.Peek();
                DisplayProfileDetails(profile);
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("No profiles available to view!");
            }
        }

        private void DisplayProfileDetails(Profile profile)
        {
            pictureBox2.Image = profile.ProfileImage;

            lbUsername.Text = $"{profile.Name}";

            panel1.Controls.Clear();

            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);


            label2.Text = $"{profile.Name}";
            panel1.Controls.Add(label2);


            label3.Text = $"{profile.Age}";
            panel1.Controls.Add(label3);

            label4.Text = $"{profile.Address}";
            panel1.Controls.Add(label4);

            label8.Text = $"{profile.Sex}";
            panel1.Controls.Add(label8);

            label15.Text = $"{profile.Status}";
            panel1.Controls.Add(label15);

            label16.Text = $"{profile.Position}";
            panel1.Controls.Add(label16);

            label17.Text = $"{profile.Citizenship}";
            panel1.Controls.Add(label17);


            label18.Text = $"{profile.Description}";
            panel1.Controls.Add(label18);

            pictureBox1.Image = profile.ProfileImage;

            panel1.Controls.Add(pictureBox1);

            panel1.Controls.Add(button1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private Profile currentProfile; 


        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
