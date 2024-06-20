using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace C_Project.AdministratorUC
{
    public partial class UC_ViewUser : UserControl
    {
        private HashSet<string> uniqueItems = new HashSet<string>();
        public UC_ViewUser()
        {
            InitializeComponent();
        }

        private void Enter2_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.Trim();
            if (!string.IsNullOrWhiteSpace(userInput) && !uniqueItems.Contains(userInput))
            {
                uniqueItems.Add(userInput);
                listBox1.Items.Add(userInput);
                textBox1.Clear();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveItemsToFile();
        }

        private void SaveItemsToFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (Policies.txt)|Policies.txt|All files (*.*)|*.*";
                saveFileDialog.InitialDirectory = @"C:\Users\DELL\Documents";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] itemsArray = uniqueItems.ToArray();
                        File.WriteAllLines(saveFileDialog.FileName, itemsArray);
                        MessageBox.Show("Items saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message);
                    }
                }
            }
        }
    }
}
