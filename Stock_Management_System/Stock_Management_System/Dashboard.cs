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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Countcat();
            Countsup();
            Countcus();
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
        private void Countsup()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from SupplierTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            supnumberlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Countcus()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CustomerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cusnumberlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HEN3U3S\MSSQLSERVER2022;Initial Catalog=stock;Integrated Security=True;Pooling=False");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
