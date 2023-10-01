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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            showcategory();
            Countcat();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void showcategory()
        {
            Con.Open();
            string Query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CategoryDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HEN3U3S\MSSQLSERVER2022;Initial Catalog=stock;Integrated Security=True;Pooling=False");
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CategoryTbl values(@Name)", Con);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Category Saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showcategory();
                    Countcat();

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


        private void Countcat()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from categoryTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            catnumberlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from CategoryTbl  WHERE  CatName=@Name", Con);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier Deleted!!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showcategory();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CategoryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CategoryDGV.Rows[e.RowIndex];

                // Assuming the columns in your DataGridView match the order of your database table
                nametxt.Text = row.Cells["CatName"].Value.ToString();

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE CategoryTbl SET  CatName=@Name WHERE CatName=@Name", Con);
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Supplier Edited!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showcategory();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void catnumberlbl_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}
