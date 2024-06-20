using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_Project.PharmacistUC
{
    public partial class UCP_Dashboard : UserControl
    {
        public UCP_Dashboard()
        {
            InitializeComponent();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UCP_AddMedicine addMedicineUserControl = new UCP_AddMedicine();
            var counts = addMedicineUserControl.CountExpiredAndValidMedicines();
            DrawChart(counts.expired, counts.valid);
        }

        private void DrawChart(int expiredCount, int validCount)
        {
            panel2.Controls.Clear();

            int panelWidth = panel2.ClientSize.Width;
            int panelHeight = panel2.ClientSize.Height;

            int totalMedicines = expiredCount + validCount;
            int barWidth = (panelWidth - 60) / 2;
            try
            {
                int expiredBarWidth = panelWidth * expiredCount / totalMedicines;
                int validBarWidth = panelWidth - expiredBarWidth;

                DrawBar(barWidth, panelHeight, Color.Red, 20, expiredCount, totalMedicines, "Expired");
                DrawBar(barWidth, panelHeight, Color.Green, 40 + barWidth, validCount, totalMedicines, "Valid");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No medicines found to draw the chart.");
                Console.WriteLine(ex.Message);
            }
        }

        private void DrawBar(int width, int height, Color color, int xPosition, int count, int total, string label)
        {
            using (var graphics = panel2.CreateGraphics())
            {
                int barHeight = (int)((double)count / total * height);

                graphics.FillRectangle(new SolidBrush(color), xPosition, height - barHeight, width, barHeight);

                Font font = new Font(FontFamily.GenericSansSerif, 8);
                string countText = count.ToString();
                SizeF textSize = graphics.MeasureString(countText, font);
                float textX = xPosition + (width - textSize.Width) / 2;
                float textY = height - barHeight - textSize.Height;

                graphics.DrawString(countText, font, Brushes.Black, textX, textY);

                Font labelFont = new Font(FontFamily.GenericSansSerif, 10);
                SizeF labelSize = graphics.MeasureString(label, labelFont);
                float labelX = xPosition + (width - labelSize.Width) / 2;
                float labelY = height + 5;

                graphics.DrawString(label, labelFont, Brushes.Black, labelX, labelY);

                Pen axisPen = new Pen(Color.Black, 2);
                graphics.DrawLine(axisPen, 10, height, panel2.ClientSize.Width - 10, height);
                graphics.DrawLine(axisPen, 10, height, 10, 0);

                int scaleWidth = (panel2.ClientSize.Width - 40) / 3;
                float scaleX = 10 + scaleWidth;
                for (int i = 1; i <= 2; i++)
                {
                    graphics.DrawLine(axisPen, scaleX, height - 5, scaleX, height + 5);
                    scaleX += scaleWidth;
                }

                int scaleHeight = height / 5; 
                float scaleY = height - scaleHeight;
                for (int i = 1; i <= 4; i++)
                {
                    graphics.DrawLine(axisPen, 5, scaleY, 15, scaleY); 
                    scaleY -= scaleHeight;
                }
            }
        }
    }
}
