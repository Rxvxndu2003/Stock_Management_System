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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            Getcustomer();
            Getproduct();
            GetProdName();
            showorders();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HEN3U3S\MSSQLSERVER2022;Initial Catalog=stock;Integrated Security=True;Pooling=False");

        private void showorders()
        {
            Con.Open();
            string Query = "select * from OrderTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Getcustomer()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from CustomerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Load(Rdr);
            comboBoxcus.ValueMember = "Name";
            comboBoxcus.DataSource = dt;
            Con.Close();
        }
        private void Getproduct()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from StockTb", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Scode", typeof(string));
            dt.Load(Rdr);
            comboBoxpro.ValueMember = "Scode";
            comboBoxpro.DataSource = dt;
            Con.Close();
        }
        private void GetProdName()
        {
            Con.Open();
            string mysql = "Select *from StockTb where Scode = '" + comboBoxpro.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                proNametxt.Text = dr["Name"].ToString();
                pricetxt.Text = dr["Price"].ToString();
            }
            Con.Close();
        }
        private void orderbtn_Click(object sender, EventArgs e)
        {
            if (ordertxt.Text == "" || comboBoxcus.SelectedItem == "" || comboBoxuser.SelectedItem == "" || amounttxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into OrderTbl values(@OrderNum,@CusName,@UserID,@Date,@Amount)", Con);
                    cmd.Parameters.AddWithValue("@OrderNum", ordertxt.Text);
                    cmd.Parameters.AddWithValue("@CusName", comboBoxcus.Text);
                    cmd.Parameters.AddWithValue("@UserID", comboBoxuser.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Amount", amounttxt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Con.Close();
                    showorders();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void order_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxpro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetProdName();
        }

        int n = 0;
        int gtotal = 0;
        private void billbtn_Click(object sender, EventArgs e)
        {
            if (proNametxt.Text == "" || quantitytxt.Text == "")
            {

                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int total = Convert.ToInt32(quantitytxt.Text) * Convert.ToInt32(pricetxt.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = proNametxt.Text;
                newRow.Cells[2].Value = pricetxt.Text;
                newRow.Cells[3].Value = quantitytxt.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                gtotal = gtotal + total;
                totallbl.Text = "Rs." + gtotal;
                amounttxt.Text = "" + gtotal;
                n++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            comboBoxpro.Text = "";
            proNametxt.Text = "";
            pricetxt.Text = "";
            quantitytxt.Text = "";

        }
    }
}
