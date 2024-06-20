namespace C_Project.PharmacistUC
{
    partial class UCP_AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCP_AddMedicine));
            label15 = new Label();
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            MedicineID = new DataGridViewTextBoxColumn();
            MedicineName = new DataGridViewTextBoxColumn();
            MedicineNumber = new DataGridViewTextBoxColumn();
            MedicineQuantity = new DataGridViewTextBoxColumn();
            MedicinePricePerUnit = new DataGridViewTextBoxColumn();
            MedicineManufacturingDate = new DataGridViewTextBoxColumn();
            MedicineExpirationDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(15, 32);
            label15.Name = "label15";
            label15.Size = new Size(228, 36);
            label15.TabIndex = 23;
            label15.Text = "Add Medicines";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(249, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ScrollBar;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(15, 122);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 30);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ScrollBar;
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(15, 188);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(195, 34);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ScrollBar;
            btnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(15, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(195, 32);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(262, 127);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 25);
            textBox1.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(513, 127);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(148, 25);
            textBox4.TabIndex = 29;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(262, 197);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 25);
            textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(262, 265);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 25);
            textBox3.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(782, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(513, 265);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(284, 27);
            dateTimePicker2.TabIndex = 33;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(513, 197);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(148, 25);
            textBox5.TabIndex = 34;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 102);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 35;
            label1.Text = "Medicine ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 173);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 36;
            label2.Text = "Medicine Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(261, 241);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 37;
            label3.Text = "Medicine Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(513, 102);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 38;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(513, 173);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 39;
            label5.Text = "Price Per Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(513, 241);
            label6.Name = "label6";
            label6.Size = new Size(172, 21);
            label6.TabIndex = 40;
            label6.Text = "Manufacturing Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(782, 102);
            label7.Name = "label7";
            label7.Size = new Size(136, 21);
            label7.TabIndex = 41;
            label7.Text = "Expriration Date";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Location = new Point(15, 320);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 47);
            panel1.TabIndex = 42;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MedicineID, MedicineName, MedicineNumber, MedicineQuantity, MedicinePricePerUnit, MedicineManufacturingDate, MedicineExpirationDate });
            dataGridView1.Location = new Point(15, 390);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1033, 286);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // MedicineID
            // 
            MedicineID.HeaderText = "ID";
            MedicineID.Name = "MedicineID";
            // 
            // MedicineName
            // 
            MedicineName.HeaderText = "Name";
            MedicineName.Name = "MedicineName";
            MedicineName.Width = 150;
            // 
            // MedicineNumber
            // 
            MedicineNumber.HeaderText = "Number";
            MedicineNumber.Name = "MedicineNumber";
            // 
            // MedicineQuantity
            // 
            MedicineQuantity.HeaderText = "Quantity";
            MedicineQuantity.Name = "MedicineQuantity";
            // 
            // MedicinePricePerUnit
            // 
            MedicinePricePerUnit.HeaderText = "Price Per Unit";
            MedicinePricePerUnit.Name = "MedicinePricePerUnit";
            MedicinePricePerUnit.Width = 150;
            // 
            // MedicineManufacturingDate
            // 
            MedicineManufacturingDate.HeaderText = "Manufacturing Date";
            MedicineManufacturingDate.Name = "MedicineManufacturingDate";
            MedicineManufacturingDate.Width = 200;
            // 
            // MedicineExpirationDate
            // 
            MedicineExpirationDate.HeaderText = "Expiration Date";
            MedicineExpirationDate.Name = "MedicineExpirationDate";
            MedicineExpirationDate.Width = 190;
            // 
            // UCP_AddMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(label15);
            Name = "UCP_AddMedicine";
            Size = new Size(1078, 696);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private PictureBox pictureBox1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MedicineID;
        private DataGridViewTextBoxColumn MedicineName;
        private DataGridViewTextBoxColumn MedicineNumber;
        private DataGridViewTextBoxColumn MedicineQuantity;
        private DataGridViewTextBoxColumn MedicinePricePerUnit;
        private DataGridViewTextBoxColumn MedicineManufacturingDate;
        private DataGridViewTextBoxColumn MedicineExpirationDate;
    }
}
