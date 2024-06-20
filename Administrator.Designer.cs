namespace C_Project
{
    partial class btnLogOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnLogOut));
            panel1 = new Panel();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            btnProfile = new Button();
            btnViewUser = new Button();
            btnAddUser = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            panel2 = new Panel();
            uS_AddUsers2 = new AdministratorUC.US_AddUsers();
            uC_Profile1 = new AdministratorUC.UC_Profile();
            uC_Dashboard1 = new AdministratorUC.UC_Dashboard();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            uC_ViewUser1 = new AdministratorUC.UC_ViewUser();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnViewUser);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 720);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(33, 537);
            button5.Name = "button5";
            button5.Size = new Size(213, 45);
            button5.TabIndex = 5;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnExit;
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
            btnProfile.Location = new Point(33, 473);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(213, 45);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
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
            btnAddUser.Text = "Add User";
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
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 194);
            label1.Name = "label1";
            label1.Size = new Size(213, 36);
            label1.TabIndex = 1;
            label1.Text = "Administrator";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(uS_AddUsers2);
            panel2.Controls.Add(uC_Profile1);
            panel2.Controls.Add(uC_Dashboard1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(275, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1096, 720);
            panel2.TabIndex = 1;
            // 
            // uS_AddUsers2
            // 
            uS_AddUsers2.BackgroundImage = (Image)resources.GetObject("uS_AddUsers2.BackgroundImage");
            uS_AddUsers2.Dock = DockStyle.Fill;
            uS_AddUsers2.Location = new Point(0, 0);
            uS_AddUsers2.Margin = new Padding(3, 2, 3, 2);
            uS_AddUsers2.Name = "uS_AddUsers2";
            uS_AddUsers2.Size = new Size(1096, 720);
            uS_AddUsers2.TabIndex = 5;
            // 
            // uC_Profile1
            // 
            uC_Profile1.BackColor = Color.White;
            uC_Profile1.BackgroundImage = (Image)resources.GetObject("uC_Profile1.BackgroundImage");
            uC_Profile1.Dock = DockStyle.Fill;
            uC_Profile1.Location = new Point(0, 0);
            uC_Profile1.Margin = new Padding(3, 2, 3, 2);
            uC_Profile1.Name = "uC_Profile1";
            uC_Profile1.Size = new Size(1096, 720);
            uC_Profile1.TabIndex = 4;
            // 
            // uC_Dashboard1
            // 
            uC_Dashboard1.AutoSize = true;
            uC_Dashboard1.BackColor = Color.White;
            uC_Dashboard1.BackgroundImage = (Image)resources.GetObject("uC_Dashboard1.BackgroundImage");
            uC_Dashboard1.Dock = DockStyle.Fill;
            uC_Dashboard1.Location = new Point(0, 0);
            uC_Dashboard1.Margin = new Padding(3, 2, 3, 2);
            uC_Dashboard1.Name = "uC_Dashboard1";
            uC_Dashboard1.Size = new Size(1096, 720);
            uC_Dashboard1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(293, 330);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(583, 346);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cooper Black", 40F, FontStyle.Italic);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(293, 35);
            label3.Name = "label3";
            label3.Size = new Size(583, 248);
            label3.TabIndex = 1;
            label3.Text = "          Welcome\r\n              to the\r\nPharmarcy Manager\r\n      Administrator";
            // 
            // uC_ViewUser1
            // 
            uC_ViewUser1.BackgroundImage = (Image)resources.GetObject("uC_ViewUser1.BackgroundImage");
            uC_ViewUser1.Dock = DockStyle.Fill;
            uC_ViewUser1.Location = new Point(0, 0);
            uC_ViewUser1.Margin = new Padding(3, 2, 3, 2);
            uC_ViewUser1.Name = "uC_ViewUser1";
            uC_ViewUser1.Size = new Size(1371, 720);
            uC_ViewUser1.TabIndex = 2;
            // 
            // btnLogOut
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1371, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(uC_ViewUser1);
            Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(8, 7, 8, 7);
            Name = "btnLogOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrator";
            Load += btnLogOut_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button5;
        private Button btnProfile;
        private Button btnViewUser;
        private Button btnAddUser;
        private Button btnDashboard;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private AdministratorUC.US_AddUsers uS_AddUsers1;
        private AdministratorUC.UC_Dashboard uC_Dashboard1;
        private AdministratorUC.UC_Profile uC_Profile1;
        private AdministratorUC.US_AddUsers uS_AddUsers2;
        private AdministratorUC.UC_ViewUser uC_ViewUser1;
    }
}