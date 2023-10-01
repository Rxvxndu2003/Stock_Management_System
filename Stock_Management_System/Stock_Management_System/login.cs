using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == "Admin" && passtxt.Text == "admin123")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username Password Incorrect!!8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            usernametxt.Text = "";
            passtxt.Text = "";
        }
    }
}
