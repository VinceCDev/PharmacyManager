using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_Project.PharmacistUC
{
    public partial class UCP_AddMedicine : UserControl
    {
        private const string FilePath = "C:\\Users\\DELL\\Documents\\Medicine.txt";

        struct Medicine
        {
            public int MedicineID;
            public string MedicineName;
            public int MedicineNumber;
            public decimal PricePerUnit;
            public int Quantity;
            public DateTime ManufacturingDate;
            public DateTime ExpirationDate;
        }

        private Stack<Medicine> medicineStack = new Stack<Medicine>();
        private LinkedList<Medicine> medicineLinkedList = new LinkedList<Medicine>();
        private HashSet<Medicine> medicineHashSet = new HashSet<Medicine>();

        public UCP_AddMedicine()
        {
            InitializeComponent();
            LoadMedicineDataFromFile();
        }
       
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Medicine newMedicine = new Medicine
            {
                MedicineID = int.Parse(textBox1.Text),
                MedicineName = textBox2.Text,
                MedicineNumber = int.Parse(textBox3.Text),
                PricePerUnit = decimal.Parse(textBox5.Text),
                Quantity = int.Parse(textBox4.Text),
                ManufacturingDate = dateTimePicker2.Value,
                ExpirationDate = dateTimePicker1.Value
            };

            medicineStack.Push(newMedicine);
            medicineLinkedList.AddLast(newMedicine);

            DisplayMedicines();
            SaveMedicineDataToFile();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }

        private void DisplayMedicines()
        {
            dataGridView1.Rows.Clear();

            foreach (var medicine in medicineLinkedList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1,
                    medicine.MedicineID,
                    medicine.MedicineName,
                    medicine.MedicineNumber,
                    medicine.Quantity,
                    medicine.PricePerUnit.ToString("C"),
                    medicine.ManufacturingDate.ToString("dd/MM/yyyy hh:mm:ss tt"),
                    medicine.ExpirationDate.ToString("dd/MM/yyyy hh:mm:ss tt")
                );

                dataGridView1.Rows.Add(row);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < medicineLinkedList.Count)
                {
                    LinkedListNode<Medicine> selectedNode = medicineLinkedList.First;
                    for (int i = 0; i < selectedIndex; i++)
                    {
                        selectedNode = selectedNode.Next;
                    }

                    if (selectedNode != null)
                    {
                        medicineLinkedList.Remove(selectedNode);
                        dataGridView1.Rows.RemoveAt(selectedIndex);
                        SaveMedicineDataToFile();
                        return;
                    }
                }
            }

            MessageBox.Show("Please select a valid medicine to delete.");
        }

        public void LoadMedicineDataFromFile()
        {
            if (File.Exists(FilePath))
            {
                medicineLinkedList.Clear();

                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] medicineData = line.Split(" -- ");

                        if (medicineData.Length == 7)
                        {
                            Medicine newMedicine = new Medicine();

                            if (int.TryParse(medicineData[0], out int medicineID) &&
                                int.TryParse(medicineData[2], out int medicineNumber) &&
                                decimal.TryParse(medicineData[4], out decimal pricePerUnit) &&
                                int.TryParse(medicineData[3], out int quantity) &&
                                DateTime.TryParse(medicineData[5], out DateTime manufacturingDate) &&
                                DateTime.TryParse(medicineData[6], out DateTime expirationDate))
                            {
                                newMedicine.MedicineID = medicineID;
                                newMedicine.MedicineName = medicineData[1];
                                newMedicine.MedicineNumber = medicineNumber;
                                newMedicine.Quantity = quantity;
                                newMedicine.PricePerUnit = pricePerUnit;
                                newMedicine.ManufacturingDate = manufacturingDate;
                                newMedicine.ExpirationDate = expirationDate;

                                medicineLinkedList.AddLast(newMedicine);
                            }
                            else
                            {
                                Console.WriteLine("Invalid or incomplete data in file: " + line);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incomplete data in file: " + line);
                        }
                    }
                }
                DisplayMedicines();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < dataGridView1.Rows.Count - 1)
                {
                    int selectedMedicineID = int.Parse(dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString());

                    LinkedListNode<Medicine> current = medicineLinkedList.First;
                    while (current != null && current.Value.MedicineID != selectedMedicineID)
                    {
                        current = current.Next;
                    }

                    if (current != null)
                    {
                        // Get the updated values from the textboxes and date pickers
                        if (int.TryParse(textBox1.Text, out int medicineID) &&
                            decimal.TryParse(textBox5.Text, out decimal pricePerUnit) &&
                            int.TryParse(textBox4.Text, out int quantity))
                        {
                            Medicine updatedMedicine = new Medicine
                            {
                                MedicineID = medicineID,
                                MedicineName = textBox2.Text,
                                MedicineNumber = int.Parse(textBox3.Text),
                                PricePerUnit = pricePerUnit,
                                Quantity = quantity,
                                ManufacturingDate = dateTimePicker2.Value,
                                ExpirationDate = dateTimePicker1.Value
                            };

                            current.Value = updatedMedicine;

                            UpdateDataGridViewRow(selectedIndex, updatedMedicine);

                            SaveMedicineDataToFile();

                            MessageBox.Show("Medicine details updated successfully!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid values for updating the medicine.");
                        }
                    }
                }
            }
            MessageBox.Show("Please select a valid medicine to update.");
        }

        private void UpdateDataGridViewRow(int rowIndex, Medicine medicine)
        {
            dataGridView1.Rows[rowIndex].Cells[0].Value = medicine.MedicineID;
            dataGridView1.Rows[rowIndex].Cells[1].Value = medicine.MedicineName;
            dataGridView1.Rows[rowIndex].Cells[2].Value = medicine.MedicineNumber;
            dataGridView1.Rows[rowIndex].Cells[3].Value = medicine.Quantity;
            dataGridView1.Rows[rowIndex].Cells[4].Value = medicine.PricePerUnit.ToString("C");
            dataGridView1.Rows[rowIndex].Cells[5].Value = medicine.ManufacturingDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            dataGridView1.Rows[rowIndex].Cells[6].Value = medicine.ExpirationDate.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        public void SaveMedicineDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (var medicine in medicineLinkedList)
                {
                    string medicineData = $"{medicine.MedicineID} -- {medicine.MedicineName} -- {medicine.MedicineNumber} -- {medicine.PricePerUnit} -- {medicine.Quantity} -- {medicine.ManufacturingDate} -- {medicine.ExpirationDate}";
                    writer.WriteLine(medicineData);
                }
            }
        }

        public (int expired, int valid) CountExpiredAndValidMedicines()
        {
            int expiredCount = 0;
            int validCount = 0;

            foreach (var medicine in medicineLinkedList)
            {
                if (medicine.ExpirationDate < DateTime.Today)
                {
                    expiredCount++;
                }
                else
                {
                    validCount++;
                }
            }

            return (expiredCount, validCount);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = selectedRow.Cells[0].Value.ToString();
                textBox2.Text = selectedRow.Cells[1].Value.ToString();
                textBox3.Text = selectedRow.Cells[2].Value.ToString();
                textBox5.Text = selectedRow.Cells[4].Value.ToString(); 
                textBox4.Text = selectedRow.Cells[3].Value.ToString(); 

                dateTimePicker2.Value = DateTime.Parse(selectedRow.Cells[5].Value.ToString()); 
                dateTimePicker1.Value = DateTime.Parse(selectedRow.Cells[6].Value.ToString()); 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
