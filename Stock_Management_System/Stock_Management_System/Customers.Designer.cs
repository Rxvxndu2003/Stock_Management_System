namespace Stock_Management_System
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnedit = new System.Windows.Forms.Button();
            comboBoxgen = new System.Windows.Forms.ComboBox();
            label11 = new System.Windows.Forms.Label();
            phonetxt = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            homebtn = new System.Windows.Forms.Button();
            clearbtn = new System.Windows.Forms.Button();
            deletebtn = new System.Windows.Forms.Button();
            addbtn = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            nametxt = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            CustomerDGV = new System.Windows.Forms.DataGridView();
            addresstxt = new System.Windows.Forms.RichTextBox();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.OrangeRed;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1350, 40);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1313, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(35, 34);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(3, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 21);
            label2.TabIndex = 3;
            label2.Text = "© 4GBx Solutions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(568, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(253, 25);
            label1.TabIndex = 0;
            label1.Text = "Stock Management System";
            // 
            // btnedit
            // 
            btnedit.BackColor = System.Drawing.Color.OrangeRed;
            btnedit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnedit.ForeColor = System.Drawing.Color.White;
            btnedit.Location = new System.Drawing.Point(266, 660);
            btnedit.Name = "btnedit";
            btnedit.Size = new System.Drawing.Size(110, 45);
            btnedit.TabIndex = 52;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // comboBoxgen
            // 
            comboBoxgen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxgen.FormattingEnabled = true;
            comboBoxgen.Items.AddRange(new object[] { "Male", "Female", "Non Prefer" });
            comboBoxgen.Location = new System.Drawing.Point(213, 256);
            comboBoxgen.Name = "comboBoxgen";
            comboBoxgen.Size = new System.Drawing.Size(259, 29);
            comboBoxgen.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.OrangeRed;
            label11.Location = new System.Drawing.Point(34, 256);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(88, 25);
            label11.TabIndex = 50;
            label11.Text = "Gender :";
            // 
            // phonetxt
            // 
            phonetxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            phonetxt.Location = new System.Drawing.Point(212, 318);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new System.Drawing.Size(260, 29);
            phonetxt.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.OrangeRed;
            label8.Location = new System.Drawing.Point(34, 318);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(79, 25);
            label8.TabIndex = 44;
            label8.Text = "Phone :";
            // 
            // homebtn
            // 
            homebtn.BackColor = System.Drawing.Color.OrangeRed;
            homebtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            homebtn.ForeColor = System.Drawing.Color.White;
            homebtn.Location = new System.Drawing.Point(130, 660);
            homebtn.Name = "homebtn";
            homebtn.Size = new System.Drawing.Size(110, 45);
            homebtn.TabIndex = 43;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = System.Drawing.Color.OrangeRed;
            clearbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            clearbtn.ForeColor = System.Drawing.Color.White;
            clearbtn.Location = new System.Drawing.Point(332, 582);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new System.Drawing.Size(110, 45);
            clearbtn.TabIndex = 42;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = System.Drawing.Color.OrangeRed;
            deletebtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deletebtn.ForeColor = System.Drawing.Color.White;
            deletebtn.Location = new System.Drawing.Point(198, 582);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new System.Drawing.Size(110, 45);
            deletebtn.TabIndex = 41;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = System.Drawing.Color.OrangeRed;
            addbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            addbtn.ForeColor = System.Drawing.Color.White;
            addbtn.Location = new System.Drawing.Point(66, 582);
            addbtn.Name = "addbtn";
            addbtn.Size = new System.Drawing.Size(110, 45);
            addbtn.TabIndex = 40;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.OrangeRed;
            label5.Location = new System.Drawing.Point(34, 379);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(93, 25);
            label5.TabIndex = 34;
            label5.Text = "Address :";
            // 
            // nametxt
            // 
            nametxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nametxt.Location = new System.Drawing.Point(212, 194);
            nametxt.Name = "nametxt";
            nametxt.Size = new System.Drawing.Size(260, 29);
            nametxt.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.OrangeRed;
            label4.Location = new System.Drawing.Point(34, 194);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(165, 25);
            label4.TabIndex = 32;
            label4.Text = "Customer Name :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(96, 90);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Navy;
            label3.Location = new System.Drawing.Point(108, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(364, 37);
            label3.TabIndex = 30;
            label3.Text = "Stock Management System";
            // 
            // CustomerDGV
            // 
            CustomerDGV.AllowUserToOrderColumns = true;
            CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDGV.Location = new System.Drawing.Point(496, 117);
            CustomerDGV.Name = "CustomerDGV";
            CustomerDGV.RowTemplate.Height = 25;
            CustomerDGV.Size = new System.Drawing.Size(840, 639);
            CustomerDGV.TabIndex = 29;
            CustomerDGV.CellContentClick += CustomerDGV_CellContentClick;
            // 
            // addresstxt
            // 
            addresstxt.Location = new System.Drawing.Point(212, 384);
            addresstxt.Name = "addresstxt";
            addresstxt.Size = new System.Drawing.Size(260, 133);
            addresstxt.TabIndex = 53;
            addresstxt.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Navy;
            label6.Location = new System.Drawing.Point(826, 63);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(237, 37);
            label6.TabIndex = 54;
            label6.Text = "Customer Details";
            // 
            // Customers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1348, 780);
            Controls.Add(label6);
            Controls.Add(addresstxt);
            Controls.Add(btnedit);
            Controls.Add(comboBoxgen);
            Controls.Add(label11);
            Controls.Add(phonetxt);
            Controls.Add(label8);
            Controls.Add(homebtn);
            Controls.Add(clearbtn);
            Controls.Add(deletebtn);
            Controls.Add(addbtn);
            Controls.Add(label5);
            Controls.Add(nametxt);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(CustomerDGV);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Customers";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Customers";
            Load += Customers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.ComboBox comboBoxgen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CustomerDGV;
        private System.Windows.Forms.RichTextBox addresstxt;
        private System.Windows.Forms.Label label6;
    }
}