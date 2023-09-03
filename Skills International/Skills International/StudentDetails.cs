using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_International
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet3.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.studentDataSet3.Registration);
            // TODO: This line of code loads data into the 'studentDataSet2.Registration' table. You can move, or remove it, as needed.
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home newhome = new Home();
           newhome.Show();
        }
    }
}
