using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stock_Management_System
{
    public partial class Stocks : Form
    {

        public Stocks()
        {
            InitializeComponent();
            showstocks();
            Getcategory();
            Getsupplier();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {

        }

        private void showstocks()
        {
            Con.Open();
            string Query = "select * from StockTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HEN3U3S\MSSQLSERVER2022;Initial Catalog=stock;Integrated Security=True;Pooling=False");
        private void Getcategory()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from CategoryTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(Rdr);
            comboBoxcat.ValueMember = "CatName";
            comboBoxcat.DisplayMember = "CatName";
            comboBoxcat.DataSource = dt;
            Con.Close();
        }

        private void Getsupplier()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from SupplierTbl", Con);
            SqlDataReader Spr;
            Spr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SupName", typeof(string));
            dt.Load(Spr);
            comboBoxsup.ValueMember = "SupName";
            comboBoxsup.DisplayMember = "SupName";
            comboBoxsup.DataSource = dt;
            Con.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (codetxt.Text == "" || idtxt.Text == "" || nametxt.Text == "" || quantitytxt.Text == "" || pricetxt.Text == "" || comboBoxsup.SelectedItem == "" || comboBoxcat.SelectedItem == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StockTb values(@Scode,@Pid,@Name,@Quantity,@Price,@Supplier,@Date,@Category)", Con);
                    cmd.Parameters.AddWithValue("@Scode", codetxt.Text);
                    cmd.Parameters.AddWithValue("@Pid", idtxt.Text);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@Quantity", quantitytxt.Text);
                    cmd.Parameters.AddWithValue("@Price", pricetxt.Text);
                    cmd.Parameters.AddWithValue("@Supplier", comboBoxsup.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Category", comboBoxcat.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showstocks();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

            codetxt.Text = "";
            idtxt.Text = "";
            nametxt.Text = "";
            quantitytxt.Text = "";
            pricetxt.Text = "";
            comboBoxsup.Text = "";
            comboBoxcat.Text = "";

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (codetxt.Text == "" || idtxt.Text == "" || nametxt.Text == "" || quantitytxt.Text == "" || pricetxt.Text == "" || comboBoxsup.SelectedIndex == -1 || comboBoxcat.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from StockTb  WHERE Scode=@Scode", Con);
                    cmd.Parameters.AddWithValue("@Scode", codetxt.Text);
                    cmd.Parameters.AddWithValue("@Pid", idtxt.Text);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@Quantity", quantitytxt.Text);
                    cmd.Parameters.AddWithValue("@Price", pricetxt.Text);
                    cmd.Parameters.AddWithValue("@Supplier", comboBoxsup.SelectedItem.ToString()); // Use SelectedItem
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Category", comboBoxcat.SelectedItem.ToString()); // Use SelectedItem
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Deleted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showstocks(); // Refresh the DataGridView
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming the columns in your DataGridView match the order of your database table
                codetxt.Text = row.Cells["Scode"].Value.ToString();
                idtxt.Text = row.Cells["Pid"].Value.ToString();
                nametxt.Text = row.Cells["Name"].Value.ToString();
                quantitytxt.Text = row.Cells["Quantity"].Value.ToString();
                pricetxt.Text = row.Cells["Price"].Value.ToString();

                // Set the selected item in the Supplier and Category ComboBoxes
                comboBoxsup.SelectedIndex = comboBoxsup.FindString(row.Cells["Supplier"].Value.ToString());
                comboBoxcat.SelectedIndex = comboBoxcat.FindString(row.Cells["Category"].Value.ToString());

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnedit_Click(object sender, EventArgs e)
        {
            if (codetxt.Text == "" || idtxt.Text == "" || nametxt.Text == "" || quantitytxt.Text == "" || pricetxt.Text == "" || comboBoxsup.SelectedIndex == -1 || comboBoxcat.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE StockTb SET Pid=@Pid, Name=@Name, Quantity=@Quantity, Price=@Price, Supplier=@Supplier,  Category=@Category WHERE Scode=@Scode", Con);
                    cmd.Parameters.AddWithValue("@Scode", codetxt.Text);
                    cmd.Parameters.AddWithValue("@Pid", idtxt.Text);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@Quantity", quantitytxt.Text);
                    cmd.Parameters.AddWithValue("@Price", pricetxt.Text);
                    cmd.Parameters.AddWithValue("@Supplier", comboBoxsup.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Category", comboBoxcat.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Updated", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showstocks();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
    }
}
