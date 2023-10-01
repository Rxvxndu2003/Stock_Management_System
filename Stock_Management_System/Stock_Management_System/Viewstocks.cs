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
    public partial class Viewstocks : Form
    {
        public Viewstocks()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HEN3U3S\MSSQLSERVER2022;Initial Catalog=stock;Integrated Security=True;Pooling=False");
        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from  StockTb where Scode='" + scodetxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                scodelbl.Text = dr["Scode"].ToString();
                pidlbl.Text = dr["Pid"].ToString();
                namelbl.Text = dr["Name"].ToString();
                quantitylbl.Text = dr["Quantity"].ToString();
                pricelbl.Text = dr["Price"].ToString();
                suplbl.Text = dr["Supplier"].ToString();
                dtlbl.Text = dr["Date/Time"].ToString();
                catlbl.Text = dr["Category"].ToString();
                scodelbl.Visible = true;
                pidlbl.Visible = true;
                namelbl.Visible = true;
                quantitylbl.Visible = true;
                pricelbl.Visible = true;
                suplbl.Visible = true;
                dtlbl.Visible = true;
                catlbl.Visible = true;
            }
            Con.Close();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            scodelbl.Visible = false;
            pidlbl.Visible = false;
            namelbl.Visible = false;
            quantitylbl.Visible = false;
            pricelbl.Visible = false;
            suplbl.Visible = false;
            dtlbl.Visible = false;
            catlbl.Visible = false;
            scodetxt.Clear();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=======STOCK SUMMARY=======", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Red, new Point(170));
            e.Graphics.DrawString("Stock Code:  " + scodelbl.Text + "\tProduct Id:  " + pidlbl.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Blue, new Point(50, 100));
            e.Graphics.DrawString("Item Name:  " + namelbl.Text + "\tQuantity:  " + quantitylbl.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Blue, new Point(50, 200));
            e.Graphics.DrawString("Price:  " + pricelbl.Text + "\tSupplier:  " + suplbl.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Blue, new Point(50, 300));
            e.Graphics.DrawString("Date/Time:  " + dtlbl.Text + "\tCategory:  " + catlbl.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Blue, new Point(50, 400));
            e.Graphics.DrawString("=======4GBx SOLUTIONS=======", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Red, new Point(170, 500));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scodetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
