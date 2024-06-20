using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Project
{
    public class Profile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public string Status { get; set; }
        public string Position { get; set; }
        public string Citizenship { get; set; }
        public string Description { get; set; }

        public Image ProfileImage { get; set; }
    }
    public partial class AddProfileForm : Form
    {
        public event Action<Profile> SaveProfile;
        public AddProfileForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Name = Name.Text;
            int age;
            if (int.TryParse(Age.Text, out age))
            {
                profile.Age = age;
            }
            profile.Address = Address.Text;
            profile.Sex = Sex.Text;
            profile.Status = Status.Text;
            profile.Position = Position.Text;
            profile.Citizenship = Citizenship.Text;
            profile.Description = Description.Text;
            profile.ProfileImage = pictureBox1.Image;

            SaveProfile?.Invoke(profile);
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Name.Text = "";
            Age.Text = "";
            Address.Text = "";
            Sex.Text = "";
            Status.Text = "";
            Position.Text = "";
            Citizenship.Text = "";
            Description.Text = "";
            pictureBox1.Image = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}
