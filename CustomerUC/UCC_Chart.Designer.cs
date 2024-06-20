namespace C_Project.CustomerUC
{
    partial class UCC_Chart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCC_Chart));
            label15 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            listBox1 = new ListBox();
            label1 = new Label();
            btnReload = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(15, 32);
            label15.Name = "label15";
            label15.Size = new Size(284, 36);
            label15.TabIndex = 26;
            label15.Text = "Types of Medicines";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(874, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Location = new Point(15, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 14);
            panel1.TabIndex = 58;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.OldLace;
            listBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(78, 222);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(914, 382);
            listBox1.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(468, 162);
            label1.Name = "label1";
            label1.Size = new Size(161, 36);
            label1.TabIndex = 60;
            label1.Text = "Medicines";
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.ScrollBar;
            btnReload.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReload.Location = new Point(417, 627);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(229, 50);
            btnReload.TabIndex = 63;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(302, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // UCC_Chart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(pictureBox2);
            Controls.Add(btnReload);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label15);
            Name = "UCC_Chart";
            Size = new Size(1078, 696);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ListBox listBox1;
        private Label label1;
        private Button btnReload;
        private PictureBox pictureBox2;
    }
}
