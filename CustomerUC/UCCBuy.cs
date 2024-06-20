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
    public partial class UCCBuy : UserControl
    {
        private Queue<string> medicineQueue = new Queue<string>();

        public UCCBuy()
        {
            InitializeComponent();
            LoadDataFromFile();
        }
        private void LoadDataFromFile()
        {
            listBox1.Items.Clear();

            try
            {
                string filePath = "C:\\Users\\DELL\\Documents\\Medicine.txt";
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(" -- ");

                    if (parts.Length == 7)
                    {
                        DateTime expirationDate;

                        if (DateTime.TryParse(parts[6], out expirationDate))
                        {
                            if (expirationDate.Date >= DateTime.Today)
                            {
                                listBox1.Items.Add(line);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedMedicine = listBox1.SelectedItem.ToString();
                medicineQueue.Enqueue(selectedMedicine);
                listBox1.Items.Add(selectedMedicine);
                MessageBox.Show("Medicine added to the buy list: " + selectedMedicine);
            }
            else
            {
                MessageBox.Show("Please select a medicine to buy.");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedMedicine = listBox1.SelectedItem.ToString();
                medicineQueue = new Queue<string>(medicineQueue.Where(m => m != selectedMedicine));
                listBox1.Items.Remove(selectedMedicine);
                MessageBox.Show("Medicine is buy" + selectedMedicine);
            }
            else
            {
                MessageBox.Show("Please select a medicine to buy.");
            }
        }
    }
}
