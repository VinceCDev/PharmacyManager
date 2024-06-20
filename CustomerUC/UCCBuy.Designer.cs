namespace C_Project.CustomerUC
{
    partial class UCCBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCBuy));
            label15 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            listBox1 = new ListBox();
            btnBuy = new Button();
            btnOK = new Button();
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
            label15.Size = new Size(207, 36);
            label15.TabIndex = 26;
            label15.Text = "Buy Medicine";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(228, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Location = new Point(15, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 14);
            panel1.TabIndex = 60;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.OldLace;
            listBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(82, 157);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(914, 403);
            listBox1.TabIndex = 61;
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(262, 605);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(270, 44);
            btnBuy.TabIndex = 62;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(558, 605);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(270, 44);
            btnOK.TabIndex = 63;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // UCCBuy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btnOK);
            Controls.Add(btnBuy);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label15);
            Name = "UCCBuy";
            Size = new Size(1078, 696);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ListBox listBox1;
        private Button btnBuy;
        private Button btnOK;
    }
}
