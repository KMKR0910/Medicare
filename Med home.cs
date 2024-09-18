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
    public partial class Med_home : Form
    {
        public Med_home()
        {
            InitializeComponent();
        }

        private void Med_home_Load(object sender, EventArgs e)
        {

        }

        private void btn_userProfile_Click(object sender, EventArgs e)
        {// Employee_User_Profile home = new Employee_User_Profile();
          //  home.Show();
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
    }
}
