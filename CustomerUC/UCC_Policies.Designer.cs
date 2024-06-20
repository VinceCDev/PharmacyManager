namespace C_Project.CustomerUC
{
    partial class UCC_Policies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCC_Policies));
            label15 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnReload = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
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
            label15.Size = new Size(323, 36);
            label15.TabIndex = 25;
            label15.Text = "Policies for Customers";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Location = new Point(15, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 14);
            panel1.TabIndex = 59;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(344, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.ScrollBar;
            btnReload.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReload.Location = new Point(428, 599);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(229, 50);
            btnReload.TabIndex = 62;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 549);
            label1.Name = "label1";
            label1.Size = new Size(858, 19);
            label1.TabIndex = 63;
            label1.Text = "**Note: These are created by the administrator and can be altered by others. It ensures to secure the users.**";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.OldLace;
            listBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(79, 153);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(914, 382);
            listBox1.TabIndex = 60;
            // 
            // UCC_Policies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(btnReload);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label15);
            Name = "UCC_Policies";
            Size = new Size(1078, 696);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnReload;
        private Label label1;
        private ListBox listBox1;
    }
}
