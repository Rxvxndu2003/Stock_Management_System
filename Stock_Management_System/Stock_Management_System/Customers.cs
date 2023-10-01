using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            showcustomer();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showcustomer()
        {
            Con.Open();
            string Query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HEN3U3S\MSSQLSERVER2022;Initial Catalog=stock;Integrated Security=True;Pooling=False");
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || comboBoxgen.SelectedItem == "" || phonetxt.Text == "" || addresstxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl values(@Name,@Gender,@Phone,@Address)", Con);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBoxgen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Phone", phonetxt.Text);
                    cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer Saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showcustomer();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            nametxt.Text = "";
            comboBoxgen.Text = "";
            phonetxt.Text = "";
            addresstxt.Text = "";
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CustomerDGV.Rows[e.RowIndex];

                // Assuming the columns in your DataGridView match the order of your database table
                nametxt.Text = row.Cells["Name"].Value.ToString();
                comboBoxgen.SelectedItem = comboBoxgen.FindString(row.Cells["Gender"].Value.ToString());
                phonetxt.Text = row.Cells["Phone"].Value.ToString();
                addresstxt.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || comboBoxgen.SelectedItem == "" || phonetxt.Text == "" || addresstxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl SET Gender=@Gender,Phone=@Phone,Address=@Address WHERE Name=@Name", Con);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBoxgen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Phone", phonetxt.Text);
                    cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer Edited!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showcustomer();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || comboBoxgen.SelectedItem == "" || phonetxt.Text == "" || addresstxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from CustomerTbl  WHERE  Name=@Name", Con);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBoxgen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Phone", phonetxt.Text);
                    cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer Deleted!!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showcustomer();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
