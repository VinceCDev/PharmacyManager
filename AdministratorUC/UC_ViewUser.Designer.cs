namespace C_Project.AdministratorUC
{
    partial class UC_ViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ViewUser));
            label1 = new Label();
            Save = new Button();
            UserType = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            MobileNumber = new DataGridViewTextBoxColumn();
            EmailAddress = new DataGridViewTextBoxColumn();
            UN = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            Enter2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(122, 36);
            label1.TabIndex = 1;
            label1.Text = "Policies";
            // 
            // Save
            // 
            Save.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save.Location = new Point(558, 598);
            Save.Name = "Save";
            Save.Size = new Size(270, 44);
            Save.TabIndex = 3;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // UserType
            // 
            UserType.Name = "UserType";
            // 
            // DOB
            // 
            DOB.Name = "DOB";
            // 
            // MobileNumber
            // 
            MobileNumber.Name = "MobileNumber";
            // 
            // EmailAddress
            // 
            EmailAddress.Name = "EmailAddress";
            // 
            // UN
            // 
            UN.Name = "UN";
            // 
            // Password
            // 
            Password.Name = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Location = new Point(22, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 10);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(440, 58);
            label2.Name = "label2";
            label2.Size = new Size(207, 36);
            label2.TabIndex = 7;
            label2.Text = "List of Policies";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.OldLace;
            listBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(154, 197);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(775, 277);
            listBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(488, 148);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 11;
            label3.Text = "Policies";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(150, 497);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(775, 61);
            textBox1.TabIndex = 14;
            // 
            // Enter2
            // 
            Enter2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter2.Location = new Point(250, 598);
            Enter2.Name = "Enter2";
            Enter2.Size = new Size(270, 44);
            Enter2.TabIndex = 16;
            Enter2.Text = "Enter";
            Enter2.UseVisualStyleBackColor = true;
            Enter2.Click += Enter2_Click;
            // 
            // UC_ViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(Enter2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(Save);
            Controls.Add(label1);
            Name = "UC_ViewUser";
            Size = new Size(1078, 696);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Save;
        private Panel panel1;
        private Label label2;
        private DataGridViewTextBoxColumn UserType;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn MobileNumber;
        private DataGridViewTextBoxColumn EmailAddress;
        private DataGridViewTextBoxColumn UN;
        private DataGridViewTextBoxColumn Password;
        private ListBox listBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button Enter2;
        private TextBox textBox3;
    }
}
