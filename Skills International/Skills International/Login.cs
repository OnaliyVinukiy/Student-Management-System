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
            conn.ConnectionString = "Data Source=LAPTOP-AHHL9HD4;Initial Catalog=Student;Integrated Security=True;";
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

      

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpw.UseSystemPasswordChar = true; // Show password character
            }
            else
            {
                txtpw.UseSystemPasswordChar = false; // Show actual characters
            }
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpw.Clear();
            txtuser.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to exit", "exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string user = txtuser.Text;
            string pw = txtpw.Text;
            string query = "SELECT * FROM login WHERE username = '" + user + "' AND password = '" + pw + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader sqlData = cmd.ExecuteReader();
            if (sqlData.HasRows)
            {
                this.Hide();
                regis registrationnew = new regis();
                registrationnew.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void txtpw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
