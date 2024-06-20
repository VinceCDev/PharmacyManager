namespace C_Project.PharmacistUC
{
    partial class UCP_Validation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCP_Validation));
            label15 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            lb1 = new ListBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(15, 32);
            label15.Name = "label15";
            label15.Size = new Size(158, 36);
            label15.TabIndex = 25;
            label15.Text = "Validation";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(179, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(420, 98);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 39;
            label3.Text = "Check";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 213);
            label1.Name = "label1";
            label1.Size = new Size(224, 33);
            label1.TabIndex = 40;
            label1.Text = "Medicine Name";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(420, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(322, 29);
            comboBox1.TabIndex = 41;
            // 
            // lb1
            // 
            lb1.BackColor = SystemColors.Info;
            lb1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1.FormattingEnabled = true;
            lb1.ItemHeight = 17;
            lb1.Location = new Point(15, 260);
            lb1.Name = "lb1";
            lb1.Size = new Size(1045, 327);
            lb1.TabIndex = 53;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Location = new Point(15, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 14);
            panel1.TabIndex = 54;
            // 
            // UCP_Validation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lb1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label15);
            Name = "UCP_Validation";
            Size = new Size(1078, 696);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private ComboBox comboBox1;
        private ListBox lb1;
        private Panel panel1;
    }
}
