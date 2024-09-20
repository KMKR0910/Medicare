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
    public partial class Doctor_Home : Form
    {
        public Doctor_Home()
        {
            InitializeComponent();
        }

        private void Doctor_Home_Load(object sender, EventArgs e)
        {

        }

       
        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_appoinments_Click(object sender, EventArgs e)
        {
            Doctor_Appointment home = new Doctor_Appointment();
            home.Show();
        }

        private void btn_patients_Click(object sender, EventArgs e)
        {
            Patient_Details_Doctor home = new Patient_Details_Doctor();
            home.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            Doctor_Employee_User_Profile home = new Doctor_Employee_User_Profile();
            home.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_userProfile_Click(object sender, EventArgs e)
        {

            string postion = "Doctor";
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_prescription_Click(object sender, EventArgs e)
        {

        }

        private void btn_finance_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
