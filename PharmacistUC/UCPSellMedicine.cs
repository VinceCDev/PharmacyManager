using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C_Project.PharmacistUC
{
    public partial class UCPSellMedicine : UserControl
    {
        private Stack<string> medicineStack = new Stack<string>();
        private LinkedList<string> cartItemsLinkedList = new LinkedList<string>();

        public UCPSellMedicine()
        {
            InitializeComponent();
        }
        private List<string> PerformSearch(string searchTerm)
        {
            List<string> foundMedicines = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines("C:\\Users\\DELL\\Documents\\Medicine.txt");

                foreach (string line in lines)
                {
                    string[] medicineData = line.Split(" -- ");

                    string medicineInfoFromFile = string.Join(" -- ", medicineData);

                    if (medicineInfoFromFile.ToLower().Contains(searchTerm.ToLower()))
                    {
                        foundMedicines.Add(medicineInfoFromFile);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return foundMedicines;
        }

        private void DisplayCartItems()
        {
            lb1.Items.Clear();

            foreach (var item in cartItemsLinkedList)
            {
                lb1.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedMedicine = listBox1.SelectedItem.ToString();

                string units = textBox5.Text;
                string totalPrice = textBox6.Text;

                if (!string.IsNullOrEmpty(units) && !string.IsNullOrEmpty(totalPrice))
                {
                    string newItem = $"{selectedMedicine} -- {units} -- {totalPrice}";

                    cartItemsLinkedList.AddLast(newItem);

                    DisplayCartItems();
                }
                else
                {
                    MessageBox.Show("Please enter units and total price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No item selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CalculateAndUpdateTotalPrice()
        {
            try
            {
                int enteredNumber = int.Parse(textBox5.Text);
                double pricePerItem = double.Parse(textBox4.Text);
                double totalPrice = CalculateTotalPrice(enteredNumber, pricePerItem);

                textBox6.Text = totalPrice.ToString();
            }
            catch (FormatException)
            {

            }
        }

        private double CalculateTotalPrice(int enteredNumber, double pricePerItem)
        {
            double totalPrice = enteredNumber * pricePerItem;
            return totalPrice;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex != -1)
            {
                int selectedIndex = lb1.SelectedIndex;

                cartItemsLinkedList.Remove(lb1.SelectedItem.ToString());

                DisplayCartItems();
            }
            else
            {
                MessageBox.Show("No item selected to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PurchaseandPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "C:\\Users\\DELL\\Documents\\CartItem.txt";

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in cartItemsLinkedList)
                    {
                        writer.WriteLine(item);
                    }
                }

                MessageBox.Show("Items saved to text file successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text;

            List<string> searchResults = PerformSearch(searchTerm); 
            listBox1.Items.Clear();
            listBox1.Items.AddRange(searchResults.ToArray());
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedMedicine = listBox1.SelectedItem.ToString();

                string[] medicineInfo = selectedMedicine.Split(" -- "); 

                if (medicineInfo.Length == 7)
                {
                    textBox3.Text = medicineInfo[0].Trim();
                    textBox2.Text = medicineInfo[1].Trim();
                    textBox4.Text = medicineInfo[2].Trim();

                    string expirationDate = medicineInfo[6].Trim();

                    if (DateTime.TryParseExact(expirationDate, "dd/MM/yyyy h:mm:ss tt",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedExpirationDate))
                    {
                        if (parsedExpirationDate < DateTime.Now)
                        {
                            MessageBox.Show("The selected medicine has expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearTextBoxesAndDatePicker();
                        }
                        else
                        {
                            dateTimePicker1.Value = parsedExpirationDate;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid expiration date format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected item format does not match expected structure.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No item selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxesAndDatePicker()
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateTotalPrice();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateTotalPrice();
        }
    }
}
