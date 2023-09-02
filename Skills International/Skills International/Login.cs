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

namespace Skills_International
{
    public partial class Login : Form
    {

        SqlConnection conn = new SqlConnection();
        public Login()
        {
            conn.ConnectionString= @"Data Source = LAPTOP - AHHL9HD4; Initial Catalog = Student; Integrated Security = True; Pooling = False";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to exit", "exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if(dialog == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpw.Clear();
        }

        private void txtpw_Enter(object sender, EventArgs e)
        {
            txtpw.Text = "";
            txtpw.UseSystemPasswordChar=true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true) 
            {
                txtpw.UseSystemPasswordChar = false;
            }
            else
            {
                txtpw.UseSystemPasswordChar=true;
            }
        }
    }
}
