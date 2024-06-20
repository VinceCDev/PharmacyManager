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
    public partial class UCC_Chart : UserControl
    {
        private HashSet<string> medicines = new HashSet<string>();
        private Dictionary<string, Queue<string>> medicineTypes = new Dictionary<string, Queue<string>>();
        private Dictionary<string, string> typeDefinition = new Dictionary<string, string>();
        public UCC_Chart()
        {
            InitializeComponent();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GenerateHierarchy();
            DisplayInListBox();
        }

        private void GenerateHierarchy()
        {
            AddMedicine("Medicine A", "Tablet", "Tablets are solid forms of medicine.");
            AddMedicine("Medicine A", "Capsule", "Capsules contain medication in a gelatinous container.");
            AddMedicine("Medicine A", "Syrup", "Syrups are liquid medications.");

            AddMedicine("Paracetamol", "Tablet", "Paracetamol tablets are used to treat pain and fever.");
            AddMedicine("Ibuprofen", "Tablet", "Ibuprofen tablets are nonsteroidal anti-inflammatory drugs (NSAIDs) used for pain relief.");
            AddMedicine("Amoxicillin", "Capsule", "Amoxicillin capsules are antibiotics used to treat bacterial infections.");
            AddMedicine("Cough Syrup", "Syrup", "Cough syrups are used to relieve coughing and cold symptoms.");
        }

        private void AddMedicine(string medicine, string type, string definition)
        {
            medicines.Add(medicine);

            if (!medicineTypes.ContainsKey(medicine))
            {
                medicineTypes[medicine] = new Queue<string>();
            }

            medicineTypes[medicine].Enqueue(type);
            typeDefinition[type] = definition;
        }

        private void DisplayInListBox()
        {
            listBox1.Items.Clear();

            foreach (string medicine in medicines)
            {
                listBox1.Items.Add(medicine);

                if (medicineTypes.ContainsKey(medicine))
                {
                    foreach (string type in medicineTypes[medicine])
                    {
                        listBox1.Items.Add($"  - {type}");
                        if (typeDefinition.ContainsKey(type))
                        {
                            listBox1.Items.Add($"    Definition: {typeDefinition[type]}");
                        }
                    }
                }
            }
        }
    }
}
