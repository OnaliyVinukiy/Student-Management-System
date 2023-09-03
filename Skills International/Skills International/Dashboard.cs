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
    public partial class Dashboard : Form
    {
        private string connectionString = "Data Source=LAPTOP-AHHL9HD4;Initial Catalog=Student;Integrated Security=True;";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateDashboard();
        }

        private void UpdateDashboard()
        {
            try
            {
                // Establish a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                  
                    int totalStudents= GetTotalStudents(connection);
                    lblstu.Text = totalStudents.ToString();

                  
                    int maleStudents = GetMaleStudents(connection);
                    lblmale.Text =  maleStudents.ToString();


                    int femaleStudents = GetFemaleStudents(connection);
                    lblfemale.Text = femaleStudents.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating the dashboard: " + ex.Message);
            }
        }
        private int GetTotalStudents(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM Registration";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                    return Convert.ToInt32(result);
                else
                    return 0; // or any other default value you prefer
            }
        }

        private int GetMaleStudents(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM Registration WHERE gender='male'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                    return Convert.ToInt32(result);
                else
                    return 0; // or any other default value you prefer
            }
        }

        private int GetFemaleStudents(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM Registration WHERE gender='female'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                    return Convert.ToInt32(result);
                else
                    return 0; // or any other default value you prefer
            }
        }
    }
}
