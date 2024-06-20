namespace C_Project
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            panel1 = new Panel();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            btnProfile = new Button();
            btnAddUser = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            ucpSellMedicine1 = new PharmacistUC.UCPSellMedicine();
            ucP_AddMedicine1 = new PharmacistUC.UCP_AddMedicine();
            ucP_Dashboard1 = new PharmacistUC.UCP_Dashboard();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 720);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(33, 491);
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
            // btnProfile
            // 
            btnProfile.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(33, 419);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(213, 45);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Sell Medicine";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.Location = new Point(33, 349);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(213, 45);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Add Medicine";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(33, 283);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(213, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 194);
            label1.Name = "label1";
            label1.Size = new Size(180, 36);
            label1.TabIndex = 1;
            label1.Text = " Pharmacist";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cooper Black", 40F, FontStyle.Italic);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(586, 57);
            label3.Name = "label3";
            label3.Size = new Size(583, 248);
            label3.TabIndex = 2;
            label3.Text = "          Welcome\r\n              to the\r\nPharmarcy Manager\r\n        Pharmacist";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(586, 326);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(583, 346);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(ucpSellMedicine1);
            panel2.Controls.Add(ucP_AddMedicine1);
            panel2.Controls.Add(ucP_Dashboard1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1371, 720);
            panel2.TabIndex = 4;
            // 
            // ucpSellMedicine1
            // 
            ucpSellMedicine1.BackgroundImage = (Image)resources.GetObject("ucpSellMedicine1.BackgroundImage");
            ucpSellMedicine1.Location = new Point(281, 0);
            ucpSellMedicine1.Name = "ucpSellMedicine1";
            ucpSellMedicine1.Size = new Size(1090, 720);
            ucpSellMedicine1.TabIndex = 6;
            // 
            // ucP_AddMedicine1
            // 
            ucP_AddMedicine1.BackColor = Color.LightGreen;
            ucP_AddMedicine1.BackgroundImage = (Image)resources.GetObject("ucP_AddMedicine1.BackgroundImage");
            ucP_AddMedicine1.Location = new Point(281, 0);
            ucP_AddMedicine1.Name = "ucP_AddMedicine1";
            ucP_AddMedicine1.Size = new Size(1090, 720);
            ucP_AddMedicine1.TabIndex = 5;
            ucP_AddMedicine1.Load += ucP_AddMedicine1_Load;
            // 
            // ucP_Dashboard1
            // 
            ucP_Dashboard1.BackgroundImage = (Image)resources.GetObject("ucP_Dashboard1.BackgroundImage");
            ucP_Dashboard1.Location = new Point(281, 0);
            ucP_Dashboard1.Name = "ucP_Dashboard1";
            ucP_Dashboard1.Size = new Size(1090, 720);
            ucP_Dashboard1.TabIndex = 4;
            // 
            // Pharmacist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1371, 720);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pharmacist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmacist";
            Load += Pharmacist_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private PictureBox pictureBox1;
        private Button btnProfile;
        private Button btnAddUser;
        private Button btnDashboard;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PharmacistUC.UCP_Dashboard ucP_Dashboard1;
        private PharmacistUC.UCPSellMedicine ucpSellMedicine1;
        private PharmacistUC.UCP_AddMedicine ucP_AddMedicine1;
    }
}