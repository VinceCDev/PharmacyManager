namespace C_Project.PharmacistUC
{
    partial class UCP_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCP_Dashboard));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            btnReload = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(169, 36);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnReload);
            panel1.Location = new Point(15, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 544);
            panel1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(851, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(44, 21);
            panel4.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Location = new Point(851, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(44, 21);
            panel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(901, 141);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 37;
            label3.Text = "Valid";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(901, 77);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 36;
            label2.Text = "Expired";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Location = new Point(474, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 466);
            panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Snow;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(379, 466);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.ScrollBar;
            btnReload.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReload.Location = new Point(829, 455);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(195, 51);
            btnReload.TabIndex = 3;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // UCP_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "UCP_Dashboard";
            Size = new Size(1078, 696);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnReset;
        private Button btnReload;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Panel panel3;
    }
}
