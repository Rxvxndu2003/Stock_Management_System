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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
            showsupplier();
        }
        private void showsupplier()
        {
            Con.Open();
            string Query = "select * from SupplierTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SupplierDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HEN3U3S\MSSQLSERVER2022;Initial Catalog=stock;Integrated Security=True;Pooling=False");
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || phonetxt.Text == "" || addresstxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SupplierTbl values(@Name,@Phone,@Address)", Con);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@Phone", phonetxt.Text);
                    cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier Saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showsupplier();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || phonetxt.Text == "" || addresstxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE SupplierTbl SET Phone=@Phone,Address=@Address WHERE SupName=@Name", Con);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@Phone", phonetxt.Text);
                    cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier Edited!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showsupplier();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SupplierDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = SupplierDGV.Rows[e.RowIndex];

                // Assuming the columns in your DataGridView match the order of your database table
                nametxt.Text = row.Cells["SupName"].Value.ToString();
                phonetxt.Text = row.Cells["Phone"].Value.ToString();
                addresstxt.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || phonetxt.Text == "" || addresstxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from SupplierTbl  WHERE  SupName=@Name", Con);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@Phone", phonetxt.Text);
                    cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier Deleted!!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showsupplier();

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
            phonetxt.Text = "";
            addresstxt.Text = "";
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
