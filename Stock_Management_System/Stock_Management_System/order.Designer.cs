namespace Stock_Management_System
{
    partial class order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order));
            label1 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            comboBoxpro = new System.Windows.Forms.ComboBox();
            label11 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            printbtn = new System.Windows.Forms.Button();
            billbtn = new System.Windows.Forms.Button();
            cancelbtn = new System.Windows.Forms.Button();
            orderbtn = new System.Windows.Forms.Button();
            quantitytxt = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            amounttxt = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            OrdersDGV = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            comboBoxcus = new System.Windows.Forms.ComboBox();
            comboBoxuser = new System.Windows.Forms.ComboBox();
            panel2 = new System.Windows.Forms.Panel();
            BillDGV = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            proNametxt = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            pricetxt = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            totallbl = new System.Windows.Forms.Label();
            clearbtn = new System.Windows.Forms.Button();
            ordertxt = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrdersDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(571, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(253, 25);
            label1.TabIndex = 0;
            label1.Text = "Stock Management System";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.Color.Navy;
            label12.Location = new System.Drawing.Point(809, 58);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(214, 37);
            label12.TabIndex = 81;
            label12.Text = "Manage Orders";
            // 
            // comboBoxpro
            // 
            comboBoxpro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxpro.FormattingEnabled = true;
            comboBoxpro.Location = new System.Drawing.Point(194, 486);
            comboBoxpro.Name = "comboBoxpro";
            comboBoxpro.Size = new System.Drawing.Size(259, 29);
            comboBoxpro.TabIndex = 79;
            comboBoxpro.SelectionChangeCommitted += comboBoxpro_SelectionChangeCommitted;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.OrangeRed;
            label11.Location = new System.Drawing.Point(18, 486);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(102, 25);
            label11.TabIndex = 78;
            label11.Text = "Products :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.OrangeRed;
            label8.Location = new System.Drawing.Point(24, 256);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(62, 25);
            label8.TabIndex = 72;
            label8.Text = "User :";
            // 
            // printbtn
            // 
            printbtn.BackColor = System.Drawing.Color.OrangeRed;
            printbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            printbtn.ForeColor = System.Drawing.Color.White;
            printbtn.Location = new System.Drawing.Point(786, 684);
            printbtn.Name = "printbtn";
            printbtn.Size = new System.Drawing.Size(110, 45);
            printbtn.TabIndex = 71;
            printbtn.Text = "Print";
            printbtn.UseVisualStyleBackColor = false;
            // 
            // billbtn
            // 
            billbtn.BackColor = System.Drawing.Color.OrangeRed;
            billbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            billbtn.ForeColor = System.Drawing.Color.White;
            billbtn.Location = new System.Drawing.Point(108, 697);
            billbtn.Name = "billbtn";
            billbtn.Size = new System.Drawing.Size(141, 45);
            billbtn.TabIndex = 70;
            billbtn.Text = "Add To Bill";
            billbtn.UseVisualStyleBackColor = false;
            billbtn.Click += billbtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.BackColor = System.Drawing.Color.OrangeRed;
            cancelbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cancelbtn.ForeColor = System.Drawing.Color.White;
            cancelbtn.Location = new System.Drawing.Point(302, 410);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new System.Drawing.Size(110, 45);
            cancelbtn.TabIndex = 69;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = false;
            // 
            // orderbtn
            // 
            orderbtn.BackColor = System.Drawing.Color.OrangeRed;
            orderbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            orderbtn.ForeColor = System.Drawing.Color.White;
            orderbtn.Location = new System.Drawing.Point(140, 410);
            orderbtn.Name = "orderbtn";
            orderbtn.Size = new System.Drawing.Size(110, 45);
            orderbtn.TabIndex = 68;
            orderbtn.Text = "Order";
            orderbtn.UseVisualStyleBackColor = false;
            orderbtn.Click += orderbtn_Click;
            // 
            // quantitytxt
            // 
            quantitytxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            quantitytxt.Location = new System.Drawing.Point(194, 654);
            quantitytxt.Name = "quantitytxt";
            quantitytxt.Size = new System.Drawing.Size(260, 29);
            quantitytxt.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.OrangeRed;
            label6.Location = new System.Drawing.Point(21, 658);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 25);
            label6.TabIndex = 64;
            label6.Text = "Quantity :";
            // 
            // amounttxt
            // 
            amounttxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            amounttxt.Location = new System.Drawing.Point(191, 313);
            amounttxt.Name = "amounttxt";
            amounttxt.Size = new System.Drawing.Size(260, 29);
            amounttxt.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.OrangeRed;
            label5.Location = new System.Drawing.Point(24, 313);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(95, 25);
            label5.TabIndex = 62;
            label5.Text = "Amount :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.OrangeRed;
            label4.Location = new System.Drawing.Point(24, 202);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 25);
            label4.TabIndex = 60;
            label4.Text = "Customer :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(3, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(96, 90);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1298, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(35, 34);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePicker1.Location = new System.Drawing.Point(192, 368);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(260, 29);
            dateTimePicker1.TabIndex = 67;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.OrangeRed;
            label7.Location = new System.Drawing.Point(24, 368);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(124, 25);
            label7.TabIndex = 66;
            label7.Text = "Date / Time :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Navy;
            label3.Location = new System.Drawing.Point(105, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(364, 37);
            label3.TabIndex = 58;
            label3.Text = "Stock Management System";
            // 
            // OrdersDGV
            // 
            OrdersDGV.AllowUserToOrderColumns = true;
            OrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDGV.Location = new System.Drawing.Point(487, 116);
            OrdersDGV.Name = "OrdersDGV";
            OrdersDGV.RowTemplate.Height = 25;
            OrdersDGV.Size = new System.Drawing.Size(840, 268);
            OrdersDGV.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.OrangeRed;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1341, 40);
            panel1.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(14, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 21);
            label2.TabIndex = 3;
            label2.Text = "© 4GBx Solutions";
            // 
            // comboBoxcus
            // 
            comboBoxcus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxcus.FormattingEnabled = true;
            comboBoxcus.Location = new System.Drawing.Point(193, 202);
            comboBoxcus.Name = "comboBoxcus";
            comboBoxcus.Size = new System.Drawing.Size(259, 29);
            comboBoxcus.TabIndex = 82;
            // 
            // comboBoxuser
            // 
            comboBoxuser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxuser.FormattingEnabled = true;
            comboBoxuser.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxuser.Location = new System.Drawing.Point(191, 256);
            comboBoxuser.Name = "comboBoxuser";
            comboBoxuser.Size = new System.Drawing.Size(259, 29);
            comboBoxuser.TabIndex = 83;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.OrangeRed;
            panel2.Location = new System.Drawing.Point(487, 390);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(840, 5);
            panel2.TabIndex = 84;
            // 
            // BillDGV
            // 
            BillDGV.AllowUserToOrderColumns = true;
            BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, PRODUCT, PRICE, QUANTITY, TOTAL });
            BillDGV.Location = new System.Drawing.Point(634, 401);
            BillDGV.Name = "BillDGV";
            BillDGV.RowTemplate.Height = 25;
            BillDGV.Size = new System.Drawing.Size(546, 229);
            BillDGV.TabIndex = 85;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // PRODUCT
            // 
            PRODUCT.HeaderText = "PRODUCT";
            PRODUCT.Name = "PRODUCT";
            // 
            // PRICE
            // 
            PRICE.HeaderText = "PRICE";
            PRICE.Name = "PRICE";
            // 
            // QUANTITY
            // 
            QUANTITY.HeaderText = "QUANTITY";
            QUANTITY.Name = "QUANTITY";
            // 
            // TOTAL
            // 
            TOTAL.HeaderText = "TOTAL";
            TOTAL.Name = "TOTAL";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.OrangeRed;
            button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(934, 684);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(110, 45);
            button1.TabIndex = 86;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // proNametxt
            // 
            proNametxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            proNametxt.Location = new System.Drawing.Point(194, 542);
            proNametxt.Name = "proNametxt";
            proNametxt.Size = new System.Drawing.Size(260, 29);
            proNametxt.TabIndex = 88;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.OrangeRed;
            label9.Location = new System.Drawing.Point(18, 542);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(151, 25);
            label9.TabIndex = 87;
            label9.Text = "Product Name :";
            // 
            // pricetxt
            // 
            pricetxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pricetxt.Location = new System.Drawing.Point(193, 597);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new System.Drawing.Size(260, 29);
            pricetxt.TabIndex = 90;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.OrangeRed;
            label10.Location = new System.Drawing.Point(20, 601);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(66, 25);
            label10.TabIndex = 89;
            label10.Text = "Price :";
            // 
            // totallbl
            // 
            totallbl.AutoSize = true;
            totallbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            totallbl.ForeColor = System.Drawing.Color.Navy;
            totallbl.Location = new System.Drawing.Point(878, 642);
            totallbl.Name = "totallbl";
            totallbl.Size = new System.Drawing.Size(61, 30);
            totallbl.TabIndex = 91;
            totallbl.Text = "Total";
            // 
            // clearbtn
            // 
            clearbtn.BackColor = System.Drawing.Color.OrangeRed;
            clearbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            clearbtn.ForeColor = System.Drawing.Color.White;
            clearbtn.Location = new System.Drawing.Point(302, 697);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new System.Drawing.Size(110, 45);
            clearbtn.TabIndex = 92;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // ordertxt
            // 
            ordertxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ordertxt.Location = new System.Drawing.Point(192, 155);
            ordertxt.Name = "ordertxt";
            ordertxt.Size = new System.Drawing.Size(260, 29);
            ordertxt.TabIndex = 94;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label13.ForeColor = System.Drawing.Color.OrangeRed;
            label13.Location = new System.Drawing.Point(25, 155);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(99, 25);
            label13.TabIndex = 93;
            label13.Text = "Order ID :";
            // 
            // order
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1332, 754);
            Controls.Add(ordertxt);
            Controls.Add(label13);
            Controls.Add(clearbtn);
            Controls.Add(totallbl);
            Controls.Add(pricetxt);
            Controls.Add(label10);
            Controls.Add(proNametxt);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(BillDGV);
            Controls.Add(panel2);
            Controls.Add(comboBoxuser);
            Controls.Add(comboBoxcus);
            Controls.Add(label12);
            Controls.Add(comboBoxpro);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(printbtn);
            Controls.Add(billbtn);
            Controls.Add(cancelbtn);
            Controls.Add(orderbtn);
            Controls.Add(quantitytxt);
            Controls.Add(label6);
            Controls.Add(amounttxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(OrdersDGV);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "order";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "order";
            Load += order_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrdersDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxpro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button billbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button orderbtn;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OrdersDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxcus;
        private System.Windows.Forms.ComboBox comboBoxuser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView BillDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox proNametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.TextBox ordertxt;
        private System.Windows.Forms.Label label13;
    }
}