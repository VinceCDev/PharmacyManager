namespace C_Project
{
    partial class Customer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            panel1 = new Panel();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            btnViewUser = new Button();
            btnAddUser = new Button();
            btnChart = new Button();
            label1 = new Label();
            panel2 = new Panel();
            ucC_Chart2 = new CustomerUC.UCC_Chart();
            ucC_Policies1 = new CustomerUC.UCC_Policies();
            ucC_Chart1 = new CustomerUC.UCC_Chart();
            uccBuy1 = new CustomerUC.UCCBuy();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            ucC_Policies2 = new CustomerUC.UCC_Policies();
            ucC_Chart3 = new CustomerUC.UCC_Chart();
            uccBuy2 = new CustomerUC.UCCBuy();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnViewUser);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnChart);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 720);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(33, 473);
            button5.Name = "button5";
            button5.Size = new Size(213, 45);
            button5.TabIndex = 5;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnViewUser
            // 
            btnViewUser.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewUser.Location = new Point(33, 411);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(213, 45);
            btnViewUser.TabIndex = 3;
            btnViewUser.Text = "Policies";
            btnViewUser.UseVisualStyleBackColor = true;
            btnViewUser.Click += btnViewUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.Location = new Point(33, 349);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(213, 45);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Buy Medicine";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnChart
            // 
            btnChart.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChart.Location = new Point(33, 283);
            btnChart.Name = "btnChart";
            btnChart.Size = new Size(213, 45);
            btnChart.TabIndex = 1;
            btnChart.Text = "Types";
            btnChart.UseVisualStyleBackColor = true;
            btnChart.Click += btnChart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(61, 194);
            label1.Name = "label1";
            label1.Size = new Size(150, 36);
            label1.TabIndex = 1;
            label1.Text = "Customer";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(ucC_Chart2);
            panel2.Controls.Add(ucC_Policies1);
            panel2.Controls.Add(ucC_Chart1);
            panel2.Controls.Add(uccBuy1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(675, 293);
            panel2.Name = "panel2";
            panel2.Size = new Size(1096, 720);
            panel2.TabIndex = 5;
            // 
            // ucC_Chart2
            // 
            ucC_Chart2.BackgroundImage = (Image)resources.GetObject("ucC_Chart2.BackgroundImage");
            ucC_Chart2.Location = new Point(96, 108);
            ucC_Chart2.Name = "ucC_Chart2";
            ucC_Chart2.Size = new Size(1078, 696);
            ucC_Chart2.TabIndex = 6;
            // 
            // ucC_Policies1
            // 
            ucC_Policies1.BackgroundImage = (Image)resources.GetObject("ucC_Policies1.BackgroundImage");
            ucC_Policies1.Location = new Point(158, 67);
            ucC_Policies1.Name = "ucC_Policies1";
            ucC_Policies1.Size = new Size(1090, 720);
            ucC_Policies1.TabIndex = 6;
            // 
            // ucC_Chart1
            // 
            ucC_Chart1.BackgroundImage = (Image)resources.GetObject("ucC_Chart1.BackgroundImage");
            ucC_Chart1.Location = new Point(169, 141);
            ucC_Chart1.Name = "ucC_Chart1";
            ucC_Chart1.Size = new Size(1090, 720);
            ucC_Chart1.TabIndex = 5;
            // 
            // uccBuy1
            // 
            uccBuy1.BackgroundImage = (Image)resources.GetObject("uccBuy1.BackgroundImage");
            uccBuy1.Location = new Point(315, 12);
            uccBuy1.Name = "uccBuy1";
            uccBuy1.Size = new Size(1090, 720);
            uccBuy1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(292, 330);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(583, 346);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cooper Black", 40F, FontStyle.Italic);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(292, 36);
            label3.Name = "label3";
            label3.Size = new Size(583, 248);
            label3.TabIndex = 2;
            label3.Text = "          Welcome\r\n              to the\r\nPharmarcy Manager\r\n         Customers";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(ucC_Policies2);
            panel3.Controls.Add(ucC_Chart3);
            panel3.Controls.Add(uccBuy2);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(275, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1104, 720);
            panel3.TabIndex = 6;
            // 
            // ucC_Policies2
            // 
            ucC_Policies2.BackgroundImage = (Image)resources.GetObject("ucC_Policies2.BackgroundImage");
            ucC_Policies2.Location = new Point(0, 0);
            ucC_Policies2.Name = "ucC_Policies2";
            ucC_Policies2.Size = new Size(1101, 720);
            ucC_Policies2.TabIndex = 9;
            // 
            // ucC_Chart3
            // 
            ucC_Chart3.BackgroundImage = (Image)resources.GetObject("ucC_Chart3.BackgroundImage");
            ucC_Chart3.Location = new Point(0, 0);
            ucC_Chart3.Name = "ucC_Chart3";
            ucC_Chart3.Size = new Size(1101, 720);
            ucC_Chart3.TabIndex = 8;
            // 
            // uccBuy2
            // 
            uccBuy2.BackgroundImage = (Image)resources.GetObject("uccBuy2.BackgroundImage");
            uccBuy2.Location = new Point(0, 0);
            uccBuy2.Name = "uccBuy2";
            uccBuy2.Size = new Size(1101, 720);
            uccBuy2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(310, 329);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(583, 346);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 40F, FontStyle.Italic);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(310, 66);
            label2.Name = "label2";
            label2.Size = new Size(583, 248);
            label2.TabIndex = 2;
            label2.Text = "          Welcome\r\n              to the\r\nPharmarcy Manager\r\n        Customers";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 720);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += Customer_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private PictureBox pictureBox1;
        private Button btnViewUser;
        private Button btnAddUser;
        private Button btnChart;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
        private CustomerUC.UCCBuy uccBuy1;
        private CustomerUC.UCC_Policies ucC_Policies1;
        private CustomerUC.UCC_Chart ucC_Chart1;
        private CustomerUC.UCC_Chart ucC_Chart2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label2;
        private CustomerUC.UCC_Chart ucC_Chart3;
        private CustomerUC.UCCBuy uccBuy2;
        private CustomerUC.UCC_Policies ucC_Policies2;
    }
}