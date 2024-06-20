using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C_Project.AdministratorUC
{
    public partial class US_AddUsers : UserControl
    {
        private const string FilePath = "C:\\Users\\DELL\\Documents\\AdminData.txt";
        struct User
        {
            public string FullName;
            public DateTime DateOfBirth;
            public string MobileNumber;
            public string EmailAddress;
            public string Username;
            public string Password;
            public string UserType;
        }

        private Queue<User> userQueue = new Queue<User>();
        private List<User> userArray = new List<User>(); 

        public US_AddUsers()
        {
            InitializeComponent();
            InitializeUserTypes();
            LoadUserDataFromFile();
        }

        private void InitializeUserTypes()
        {
            comboBox1.Items.Add("Administrator");
            comboBox1.Items.Add("Customer");
            comboBox1.Items.Add("Pharmacist");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                UserType = comboBox1.SelectedItem?.ToString() ?? "Default", 
                FullName = textBox1.Text,
                MobileNumber = textBox2.Text,
                DateOfBirth = dateTimePicker1.Value,
                EmailAddress = textBox3.Text,
                Username = textBox5.Text,
                Password = textBox4.Text
                
            };

            userArray.Add(newUser);

            DisplayUsers();
            SaveUserDataToFile();
        }

        private void DisplayUsers()
        {
            dataGridView1.Rows.Clear();

            foreach (var user in userArray)
            {
                dataGridView1.Rows.Add(
                    user.UserType,
                    user.FullName,
                    user.MobileNumber,
                    user.DateOfBirth.ToShortDateString(),
                    user.EmailAddress,
                    user.Username,
                    user.Password
                );
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                selectedIndex = e.RowIndex;

                comboBox1.SelectedItem = selectedRow.Cells[0].Value.ToString();
                textBox1.Text = selectedRow.Cells[1].Value.ToString();
                textBox2.Text = selectedRow.Cells[2].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(selectedRow.Cells[3].Value.ToString());
                textBox3.Text = selectedRow.Cells[4].Value.ToString();
                textBox5.Text = selectedRow.Cells[5].Value.ToString();
                textBox4.Text = selectedRow.Cells[6].Value.ToString();

            }
        }

        private int selectedIndex = -1;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIndex != -1 && selectedIndex < userArray.Count)
            {
                User selectedUser = userArray[selectedIndex];

                selectedUser.UserType = comboBox1.SelectedItem?.ToString() ?? "Default";
                selectedUser.FullName = textBox1.Text;
                selectedUser.MobileNumber = textBox2.Text;
                selectedUser.DateOfBirth = dateTimePicker1.Value;
                selectedUser.EmailAddress = textBox3.Text;
                selectedUser.Username = textBox5.Text;
                selectedUser.Password = textBox4.Text;

                UpdateDataGridViewRow(selectedIndex, selectedUser);

                SaveUserDataToFile();
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void UpdateDataGridViewRow(int rowIndex, User user)
        {
            dataGridView1.Rows[rowIndex].Cells[0].Value = user.UserType;
            dataGridView1.Rows[rowIndex].Cells[1].Value = user.FullName;
            dataGridView1.Rows[rowIndex].Cells[2].Value = user.MobileNumber;
            dataGridView1.Rows[rowIndex].Cells[3].Value = user.DateOfBirth.ToShortDateString();
            dataGridView1.Rows[rowIndex].Cells[4].Value = user.EmailAddress;
            dataGridView1.Rows[rowIndex].Cells[5].Value = user.Username;
            dataGridView1.Rows[rowIndex].Cells[6].Value = user.Password;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIndex != -1 && selectedIndex < dataGridView1.Rows.Count - 1)
            {
                userArray.RemoveAt(selectedIndex);
                selectedIndex = -1;

                DisplayUsers();
                SaveUserDataToFile();
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        public Dictionary<string, int> CountUserRoles()
        {
            HashSet<string> userRoles = new HashSet<string>();

            foreach (var user in userArray)
            {
                userRoles.Add(user.UserType);
            }

            Dictionary<string, int> roleCounts = new Dictionary<string, int>();
            foreach (string role in userRoles)
            {
                int count = userArray.Count(user => user.UserType == role);
                roleCounts.Add(role, count);
            }

            return roleCounts;
        }

        public void SaveUserDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (var user in userArray)
                {
                    writer.WriteLine($"{user.UserType} -- {user.FullName} -- {user.MobileNumber} -- {user.DateOfBirth} -- {user.EmailAddress} -- {user.Username} -- {user.Password}");
                }
            }
        }

        public void LoadUserDataFromFile()
        {
            if (File.Exists(FilePath))
            {
                userArray.Clear();

                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] userData = line.Split(new string[] { " -- " }, StringSplitOptions.None);

                        if (userData.Length >= 7) 
                        {
                            User newUser = new User
                            {
                                UserType = userData[0],
                                FullName = userData[1],
                                MobileNumber = userData[2],
                                DateOfBirth = DateTime.Parse(userData[3]),
                                EmailAddress = userData[4],
                                Username = userData[5],
                                Password = userData[6]
                            };

                            userArray.Add(newUser);
                        }
                        else
                        {
                            Console.WriteLine("Incomplete user data in file");
                        }
                    }
                }
                DisplayUsers();
            }
        }

        public bool Login(string username, string password, out string userType)
        {
            userType = "";

            var user = userArray.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (!user.Equals(default(User))) 
            {
                userType = user.UserType;
                Console.WriteLine("Login successful. User type: " + userType);
                return true;
            }
            else
            {
                Console.WriteLine("Login failed. User not found or invalid credentials.");
                return false;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

