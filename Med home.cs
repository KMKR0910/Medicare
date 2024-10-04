using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Diploma_Final_Project_1
{
    public partial class Med_home : Form
    {
        public Med_home()
        {
            InitializeComponent();
        }

        private void Med_home_Load(object sender, EventArgs e)
        {

        }
        private void LoadFinance()
        {
            //Create an instance of Form2
            Med_Finance  form2 = new Med_Finance();

            // Remove borders and make the form a child control
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;

            // Add the form to the GroupBox
            groupBox9.Controls.Clear();  // Optionally clear previous controls
            groupBox9.Controls.Add(form2);

            // Show the form inside the GroupBox
            form2.Show();
        }
        private void LoadAppoinment()
        {
            //Create an instance of Form2
            Doctor_Appointment form2 = new Doctor_Appointment();

            // Remove borders and make the form a child control
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;

            // Add the form to the GroupBox
            groupBox11.Controls.Clear();  // Optionally clear previous controls
            groupBox11.Controls.Add(form2);

            // Show the form inside the GroupBox
            form2.Show();
        }

        private void btn_userProfile_Click(object sender, EventArgs e)
        {
            string postion = "Medical Centre Assistant";
            string cs = "Data Source=ASUS; Initial Catalog = Diploma Final Project DB1; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "select [User ID] from tbl_Internal_User WHERE [Postion]=@postion";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@postion", postion);

            var userId = com.ExecuteScalar()?.ToString();  // Fetch the first column of the first row

            if (userId != null)
            {
                Employee_User_Profile profileForm = new Employee_User_Profile(userId);
                profileForm.Show();
            }
            else
            {
                MessageBox.Show("No user found with the specified position.");
            }
        }

        private void btn_appoinments_Click(object sender, EventArgs e)
        {
            Med_Appointments home = new Med_Appointments();
            home.Show();
        }

        private void btn_patients_Click(object sender, EventArgs e)
        {
            Med_Patient_Details home = new Med_Patient_Details();
            home.Show();
        }

        private void btn_finance_Click(object sender, EventArgs e)
        {
            LoadFinance();
        }

        private void btn_appoinments_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
