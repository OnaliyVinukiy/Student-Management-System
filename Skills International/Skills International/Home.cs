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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

       

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Profile profilenew = new Profile();
            profilenew.Show();
        }

        private void btnStuDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDetails newstudetails = new StudentDetails();
            newstudetails.Show();

        }

        private void btnStudentReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            regis newregis = new regis();
            newregis.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard newdashboard = new Dashboard();
            newdashboard.Show();
        }
    }
}
