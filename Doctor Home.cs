using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button2_Click(object sender, EventArgs e)
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
    }
}
